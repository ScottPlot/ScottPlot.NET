using System.Text;
using ChangelogPageMaker.Logic;

namespace ChangelogPageMaker.Pages;

internal class ContributorPage : HtmlPageBase
{
    public ContributorPage(Changelog changelog)
        : base("ScottPlot Contributors", "Members of the open-source community who contributed to ScottPlot", changelog)
    {
    }

    public override string GetHtml()
    {
        StringBuilder sb = new();

        sb.AppendLine($"""
            <div class="mt-3 text-center fs-1 fw-semibold">ScottPlot Contributors</div>
            <div class='fs-5 fw-lighter text-center mb-4'>
                Special thanks to the <span class="sparkle-highlight">{Changelog.Contributors.Length}</span> GitHub users 
                who contributed to this project, making ScottPlot better for everyone!
                💖🚀✨
            </div>
            """);

        sb.AppendLine("<div class='avatar-container my-3'>");
        foreach (string id in Changelog.Contributors)
        {
            string githubUrl = $"https://github.com/{id}";
            string imageUrl = Changelog.Avatars.GetImage(id);
            sb.AppendLine($"<a href='{githubUrl}'><img src='{imageUrl}'></a>");
        }
        sb.AppendLine("</div>");

        sb.AppendLine("""
            <div class='mt-5 mb-3 text-muted'>
            <p>This page is automatically generated.</p>
            <p>Contributors are listed in the same order they appear in the changelog</p>
            <p>Most recent contributors are listed at the top</p>
            <p>Contributor avatars are downloaded the first time they appear in the changelog</p>
            <p>To update your GitHub avatar, delete the image 
            <a href='https://github.com/ScottPlot/ScottPlot.NET/tree/main/static/images/contributors'>here</a>
            and it will be re-downloaded the next time the changelog is updated.</p>
            </div>
            """);

        return sb.ToString();
    }
}
