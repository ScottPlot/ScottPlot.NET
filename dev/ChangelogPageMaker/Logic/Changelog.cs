using System.Linq;
using System.Text;

namespace ChangelogPageMaker.Logic;

internal class ChangelogChange
{
    public string Markdown;
    public string[] Contributors;
    public string Html;

    public ChangelogChange(string markdown)
    {
        Markdown = markdown;
        (Html, Contributors) = GetHtml();
    }

    private (string html, string[] contributors) GetHtml()
    {
        string md = Markdown;

        string[] words = md
            .Replace("(", " ")
            .Replace(")", " ")
            .Replace("_", " ")
            .Replace("!", " ")
            .Replace(".", " ")
            .Replace(":", " ")
            .Replace(",", " ")
            .Split(" ");

        List<int> issues = new();
        List<string> ids = new();

        foreach (string word in words)
        {
            if (word.StartsWith("#"))
            {
                if (int.TryParse(word.Substring(1), out int issue))
                {
                    issues.Add(issue);
                }
            }
            else if (word.StartsWith("@"))
            {
                ids.Add(word.Substring(1));
            }
        }

        foreach (int issue in issues.OrderByDescending(x => x))
        {
            md = md.Replace($"#{issue}", $"[#_ISSUE{issue}](https://github.com/ScottPlot/ScottPlot/issues/{issue})");
        }

        foreach (string id in ids)
        {
            md = md.Replace($"@{id}", $"[@_USER{id}](https://github.com/{id})");
        }

        md = md.Replace("#_ISSUE", "#");
        md = md.Replace("@_USER", "@");

        string html = Markdig.Markdown.ToHtml(md).Replace("<p>", "").Replace("</p>", "");
        string[] contributors = ids.ToArray();
        return (html, contributors);
    }
}

internal class ChangelogRelease
{
    public string Date { get; set; } = string.Empty;
    public string Title { get; set; } = string.Empty;
    public List<ChangelogChange> Changes { get; } = new();

    public string[] Contributors => Changes.SelectMany(x => x.Contributors).Distinct().ToArray();

    public string GetHtml(AvatarCollection avatars)
    {
        StringBuilder sb = new();

        AddTitle(sb);
        AddChangeList(sb);

        if (!string.IsNullOrWhiteSpace(Date))
        {
            sb.AppendLine("<h3 class='text-center fw-light'>Contributors</h3>");
            AddContributorNames(sb);
            AddContributorImages(sb, avatars);
        }

        string[] urls =
        {
            "https://scottplot.net/versions/",
            "https://scottplot.net/changelog/",
            "https://scottplot.net/contributors/",
        };

        foreach(string url in urls)
        {
            sb.Replace(url, $"<a href='{url}'>{url}</a>");
        }

        return sb.ToString();
    }

    private void AddTitle(StringBuilder sb)
    {
        sb.AppendLine($"<h1 class='mb-0'>{Title}</h1>");

        if (string.IsNullOrEmpty(Title))
        {
            // top of the page
            return;
        }

        if (Title.Contains("development", StringComparison.InvariantCultureIgnoreCase))
        {
            sb.AppendLine($"<div><i>Not yet published as a NuGet package...</i></div>");
            return;
        }

        if (Title.Split(" ").Length == 2 && string.IsNullOrWhiteSpace(Date))
        {
            sb.AppendLine($"<div><mark>Warning: NuGet package date is missing</mark></div>");
        }

        sb.AppendLine($"<div><i>NuGet packages published {Date}</i></div>");
    }

    private void AddChangeList(StringBuilder sb)
    {
        sb.AppendLine($"<div class='mt-1'>");
        sb.AppendLine($"<ul>");
        foreach (ChangelogChange change in Changes)
        {
            sb.AppendLine($"<li>{change.Html}</li>");
        }
        sb.AppendLine($"</ul>");
        sb.AppendLine($"</div>");
    }

    private void AddContributorNames(StringBuilder sb)
    {
        sb.AppendLine("<div class='text-center'>");
        sb.AppendLine(string.Join(", ", Contributors.Append("swharden").Select(x => $"<a href='https://github.com/{x}'>{x}</a>")));
        sb.AppendLine("</div>");
    }

    private void AddContributorImages(StringBuilder sb, AvatarCollection avatars)
    {
        sb.AppendLine("<div class='text-center'>");
        foreach (string id in Contributors.Append("swharden"))
        {
            sb.AppendLine($"<a href='https://github.com/{id}'>" +
                $"<img src='{avatars.GetImage(id)}' width=75 height=75 style='border-radius: 50%;' class='m-1'/>" +
                $"</a>");
        }
        sb.AppendLine("</div>");
    }
}

internal class Changelog
{
    public readonly ChangelogRelease[] Releases;
    public string[] Contributors => Releases.SelectMany(x => x.Contributors).Distinct().ToArray();
    public readonly AvatarCollection Avatars;

    public Changelog(string markdown, string avatarImageFolder)
    {
        Releases = GetReleases(markdown);
        Avatars = new(avatarImageFolder);
    }

    private ChangelogRelease[] GetReleases(string markdown)
    {
        List<ChangelogRelease> releases = new();

        string[] lines = markdown.Split("\n");

        ChangelogRelease thisRelease = new();

        foreach (string line in lines)
        {
            // ignore top-level headings
            if (line.StartsWith("# "))
                continue;

            if (line.StartsWith("## "))
            {
                if (thisRelease.Changes.Any())
                {
                    releases.Add(thisRelease);
                    thisRelease = new ChangelogRelease();
                }

                thisRelease.Title = line.Substring(3).Trim();
                continue;
            }

            if (line.StartsWith("_Published"))
            {
                thisRelease.Date = line.Trim().Split(" ").Last().Replace("_", "");
                continue;
            }

            if (line.StartsWith("* "))
            {
                ChangelogChange change = new(line.Substring(2).Trim());
                thisRelease.Changes.Add(change);
            }
        }

        if (thisRelease.Changes.Any())
            releases.Add(thisRelease);

        return releases.ToArray();
    }

    public void DownloadMissingAvatars(int max = 50)
    {
        Avatars.DownloadMissingImages(Contributors, max);
    }

    public string GetHtml()
    {
        StringBuilder sb = new();

        foreach (ChangelogRelease release in Releases)
        {
            sb.AppendLine("<section class='mb-5'>");
            sb.AppendLine(release.GetHtml(Avatars));
            sb.AppendLine("</section>");
        }

        return sb.ToString();
    }

    public override string ToString()
    {
        return $"Changelog with {Releases.Length} releases and {Contributors.Length} contributors";
    }
}
