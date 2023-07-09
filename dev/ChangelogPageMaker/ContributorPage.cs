using System.Text;

namespace ChangelogPageMaker;

internal class ContributorPage
{
    public static void GenerateHtml(string[] ids, AvatarCollection avatars, string saveAs)
    {
        StringBuilder sb = new();

        sb.AppendLine("""
            <div class='display-3 text-center'>ScottPlot Contributors</div>
            <div class='fs-3 fw-lighter text-center mx-5 px-5'>
                Special thanks to these GitHub members who are 
                recognized for their contributions
                to discussions, issues, and pull requests!
            </div>
            <div class='display-3 my-5 text-center'>💖🚀✨</div>
            """);

        sb.AppendLine("<div class='d-flex justify-content-center flex-wrap'>");
        foreach (string id in ids)
        {
            sb.AppendLine("<div class='bg-light border rounded text-center mx-3 my-2'>");

            sb.AppendLine("<div><img class='img-fluid rounded m-1' " +
                $"src='{avatars.GetImage(id)}' " +
                "height='125' width='125'/></div>");

            sb.AppendLine($"<div><a href='https://github.com/{id}'>@{id}</a></div>");

            sb.AppendLine("</div>");
        }
        sb.AppendLine("</div>");

        string html = HtmlTemplate.Bootstrap
            .Replace("{{ TITLE }}", "Contributors")
            .Replace("{{ BODY }}", sb.ToString());

        File.WriteAllText(saveAs, html);
    }
}
