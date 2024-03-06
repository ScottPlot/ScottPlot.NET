using ChangelogPageMaker.Logic;
using System.Text;

namespace ChangelogPageMaker.Pages;

internal class ChangelogPage(Changelog changelog) 
    : HtmlPageBase(
        title: "ScottPlot Changelog",
        description: "Release notes for every version of ScottPlot", 
        changelog)
{
    public override string GetHtml()
    {
        StringBuilder sb = new();

        sb.AppendLine(Changelog.GetHtml());

        sb.AppendLine("<div class='mt-5 mb-3 text-muted'>");
        sb.AppendLine("If you changed your GitHub avatar and wish to update the image on this page, ");
        sb.AppendLine("go to <a href='https://github.com/ScottPlot/ScottPlot.NET/tree/main/static/images/contributors'>");
        sb.AppendLine("https://github.com/ScottPlot/ScottPlot.NET/tree/main/static/images/contributors</a> ");
        sb.AppendLine("and create a pull request which deletes the file with your GitHub username. ");
        sb.AppendLine("Your new avatar will be downloaded the next time the changelog is updated. ");
        sb.AppendLine("</div>");

        return sb.ToString();
    }
}
