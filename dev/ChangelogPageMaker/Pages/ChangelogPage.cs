using ChangelogPageMaker.Logic;
using System.Text;

namespace ChangelogPageMaker.Pages;

internal class ChangelogPage : HtmlPageBase
{
    public readonly string Changelog;

    public ChangelogPage(string changelog, string[] ids, AvatarCollection avatars)
        : base("ScottPlot Changelog", "Release notes for every version of ScottPlot", ids, avatars)
    {
        Changelog = changelog;
    }

    public override string GetHtml()
    {
        StringBuilder sb = new();

        sb.AppendLine(Markdig.Markdown.ToHtml(Changelog));

        // TODO: don't show empty headings
        foreach (string id in IDs)
        {
            sb.Replace("@" + id, $"<a href='https://github.com/{id}'>@{id}</a>");
        }

        // TODO: something more effecient
        for (int i = 3_000; i > 0; i--)
        {
            sb.Replace($"#{i}", $"<a href='https://github.com/ScottPlot/ScottPlot/issues/{i}'>#ISSUE_{i}</a>");
        }
        sb.Replace($"#ISSUE_", $"#");

        sb.AppendLine("<div class='mt-5 mb-3 text-muted'>");
        sb.AppendLine("Contributors are listed in the same order they appear in the changelog, ");
        sb.AppendLine("with those submitting contributions most recently at the top. ");
        sb.AppendLine("Contributor avatars are downloaded the first time they appear in the changelog. ");
        sb.AppendLine("</div>");

        sb.AppendLine("<div class='mb-5 text-muted'>");
        sb.AppendLine("If you changed your GitHub avatar and wish to update the image on this page, ");
        sb.AppendLine("go to <a href='https://github.com/ScottPlot/ScottPlot.NET/tree/main/static/images/contributors'>");
        sb.AppendLine("https://github.com/ScottPlot/ScottPlot.NET/tree/main/static/images/contributors</a> ");
        sb.AppendLine("and create a pull request which deletes the file with your GitHub username. ");
        sb.AppendLine("Your new avatar will be downloaded the next time the changelog is updated. ");
        sb.AppendLine("</div>");

        return sb.ToString();
    }
}
