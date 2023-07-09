using System.Text;
using ChangelogPageMaker.Logic;

namespace ChangelogPageMaker.Pages;

internal class ContributorPage : HtmlPageBase
{
    public ContributorPage(string[] ids, AvatarCollection avatars)
        : base("ScottPlot Contributors", "Members of the open-source community who contributed to ScottPlot", ids, avatars)
    {

    }

    public override string GetHtml()
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
        foreach (string id in IDs)
        {
            string url = $"https://github.com/{id}";
            sb.AppendLine("<div class='bg-light border rounded text-center mx-3 my-2'>");

            sb.AppendLine("<div><a href=''><img class='img-fluid rounded m-1' " +
                $"src='{Avatars.GetImage(id)}' " +
                "height='125' width='125'/></a></div>");

            sb.AppendLine($"<div><a href='{url}'>@{id}</a></div>");

            sb.AppendLine("</div>");
        }
        sb.AppendLine("</div>");

        sb.AppendLine("<div class='my-5 text-muted'>");
        sb.AppendLine("Contributors are listed in the same order they appear in the changelog, ");
        sb.AppendLine("with those submitting contributions most recently at the top. ");
        sb.AppendLine("Contributor avatars are downloaded at the time the changelog was updated. ");
        sb.AppendLine("If you changed your GitHub avatar and wish to update the image on this page, ");
        sb.AppendLine("go to the <a href='https://github.com/ScottPlot/ScottPlot.NET' class='text-muted'>ScottPlot.NET website repository</a>, ");
        sb.AppendLine("navigate to ./static/images/contributors, and create a pull request which ");
        sb.AppendLine("deletes the file with your GitHub username that contains the old avatar. ");
        sb.AppendLine("Your new avatar will be downloaded the next time the changelog is updated. ");
        sb.AppendLine("</div>");

        return sb.ToString();
    }
}
