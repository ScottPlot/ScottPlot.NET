using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SiteBuilder
{
    public static class PageBuilding
    {
        public static string GetAnnotatedChangelogMarkdown(string rawMarkdown)
        {
            string[] chunks = rawMarkdown.Split("\n#");
            for (int i = 0; i < chunks.Length; i++)
            {
                string md = chunks[i];

                string[] usernames = SiteBuilder.GitHubMarkdown.GetUsernames(md);
                string[] uniqueUsernames = usernames.Append("swharden").Distinct().OrderBy(x => x).ToArray();

                md = SiteBuilder.GitHubMarkdown.LinkUsernames(md, uniqueUsernames);

                int[] issueNumbers = SiteBuilder.GitHubMarkdown.GetIssues(md);
                md = SiteBuilder.GitHubMarkdown.LinkIssues(md, issueNumbers);

                if (uniqueUsernames.Length > 1) // will always contain swharden
                {
                    md += "\n\n";
                    md += "<div class='text-center mt-4'>";

                    md += "<div class='fs-4 fw-lighter text-center mx-5 px-5'>";
                    md += "Special thanks to this version's contributors!";
                    md += "</div>";

                    md += GetUserIconDiv(uniqueUsernames);

                    md += "</div>";
                }

                md += "\n\n<hr class='my-3' style='width: 50%; opacity: 0;'>\n\n";

                chunks[i] = md;
            }

            return string.Join("\n#", chunks);
        }

        public static string GetUserIconDiv(string[] usernames)
        {
            StringBuilder sb = new();
            sb.AppendLine("<div class='d-flex justify-content-center flex-wrap'>");
            foreach (string username in usernames)
            {
                sb.AppendLine(GetUserIconDiv(username));
            }
            sb.AppendLine("</div>");
            return sb.ToString();
        }

        public static string GetUserIconDiv(string username)
        {
            StringBuilder sb = new();
            sb.AppendLine($"<div class='bg-light border rounded text-center mx-3 my-2'>");

            sb.AppendLine($"<div>");
            sb.AppendLine($"<a href='https://github.com/{username}'>");

            int px = 125;
            sb.AppendLine($"<img src='https://github.com/{username}.png?size={px}' height='{px}' width='{px}' " +
                          $"class='img-fluid rounded m-1' />");
            sb.AppendLine($"</a>");
            sb.AppendLine($"</div>");

            sb.AppendLine($"<div>");
            sb.AppendLine($"<a href='https://github.com/{username}'>@{username}</a>");
            sb.AppendLine($"</div>");

            sb.AppendLine($"</div>");
            return sb.ToString();
        }

        public static void CreateChangelogMarkdownPage(string changelogMarkdown, string outputFilePath)
        {
            StringBuilder sb = new();
            sb.AppendLine("---");
            sb.AppendLine("Title: ScottPlot Changelog");
            sb.AppendLine("Description: Release log for every version of ScottPlot");
            sb.AppendLine("Source: https://github.com/ScottPlot/ScottPlot/blob/master/dev/changelog.md");
            sb.AppendLine("---");
            sb.AppendLine(changelogMarkdown);

            string outputFolder = Path.GetDirectoryName(outputFilePath);
            if (!string.IsNullOrWhiteSpace(outputFolder) && !Directory.Exists(outputFolder))
                Directory.CreateDirectory(outputFolder);

            File.WriteAllText(outputFilePath, sb.ToString());
        }

        public static void CreateContributorsMarkdownPage(string[] usernames, string outputFilePath)
        {
            StringBuilder sb = new();
            sb.AppendLine("---");
            sb.AppendLine("Title: ScottPlot Contributors");
            sb.AppendLine("Description: GitHub users who contributed to ScottPlot");
            sb.AppendLine("Source: https://github.com/ScottPlot/ScottPlot/blob/master/dev/changelog.md");
            sb.AppendLine("---");

            sb.AppendLine("<div class='display-3 text-center'>ScottPlot Contributors</div>");
            sb.AppendLine("<div class='fs-3 fw-lighter text-center mx-5 px-5'>");
            sb.AppendLine("Special thanks to all the people who contributed to discussions, issues, and pull requests on GitHub!");
            sb.AppendLine("</div>");
            sb.AppendLine("<div class='display-3 my-5 text-center'>💖🚀✨</div>");

            sb.AppendLine(GetUserIconDiv(usernames));

            string outputFolder = Path.GetDirectoryName(outputFilePath);
            if (!Directory.Exists(outputFolder))
                Directory.CreateDirectory(outputFolder);

            File.WriteAllText(outputFilePath, sb.ToString());
        }
    }
}
