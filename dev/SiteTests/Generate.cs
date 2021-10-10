using NUnit.Framework;
using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;

namespace SiteTests
{
    internal class Generate
    {
        string PATH_REPO_ROOT = Path.GetFullPath(Path.Combine(TestContext.CurrentContext.TestDirectory, "../../../../../"));

        [Test]
        public void Test_Generate_LocalSite()
        {
            // updated changelog and contributors markdown files
            string rawMarkdown = ReadLocalChangelog() ?? DownloadChangelog();
            string changelogMarkdownRaw = GetAnnotatedChangelogMarkdown(rawMarkdown);
            string changelogIndexPagePath = Path.Combine(PATH_REPO_ROOT, "content/changelog/index.md");
            CreateChangelogMarkdownPage(changelogMarkdownRaw, changelogIndexPagePath);

            string[] contributors = GetAllUsernames(rawMarkdown);
            string contributorsIndexPagePath = Path.Combine(PATH_REPO_ROOT, "content/contributors/index.md");
            CreateContributorsMarkdownPage(contributors, contributorsIndexPagePath);

            // generate updated cookbook pages
            /*
            string cookbookFolder = Path.Combine(
                path1: TestContext.CurrentContext.TestDirectory,
                path2: "../../../../../content/cookbook/4.1/");
            var cbg = new SiteBuilder.CookbookGenerator(cookbookFolder);
            cbg.Generate();
            */

            // generate HTML pages from markdown files
            var ssg = new Statix.Generator(
                contentFolder: Path.Combine(PATH_REPO_ROOT, "content"),
                themeFolder: Path.Combine(PATH_REPO_ROOT, "dev/theme"),
                rootUrl: "http://localhost:8080",
                sourceUrl: "https://github.com/ScottPlot/ScottPlot.NET/blob/main/content");

            ssg.HeaderRequirements.RequireDescription = false;
            ssg.HeaderRequirements.RequireDate = false;
            ssg.Generate();
        }

        private string DownloadChangelog()
        {
            Console.WriteLine("Downloading changelog...");
            const string url = "https://raw.githubusercontent.com/ScottPlot/ScottPlot/master/dev/changelog.md";
            using WebClient client = new();
            string txt = client.DownloadString(url);
            return txt;
        }

        private string ReadLocalChangelog()
        {
            string path = Path.GetFullPath("../../../../../../ScottPlot/dev/changelog.md");
            if (File.Exists(path))
            {
                Console.WriteLine("Reading local changelog...");
                return File.ReadAllText(path);
            }
            else
            {
                return null;
            }
        }

        private string[] GetAllUsernames(string rawMarkdown)
        {
            HashSet<string> uniqueNames = new();

            foreach (string line in rawMarkdown.Split("\n"))
            {
                foreach (string username in GitHubMarkdown.GetUsernames(line))
                {
                    uniqueNames.Add(username);
                }
            }

            return uniqueNames.OrderBy(x => x.ToLower()).ToArray();
        }

        private string GetAnnotatedChangelogMarkdown(string rawMarkdown)
        {
            string[] chunks = rawMarkdown.Split("\n#");
            for (int i = 0; i < chunks.Length; i++)
            {
                string md = chunks[i];

                string[] usernames = GitHubMarkdown.GetUsernames(md);
                string[] uniqueUsernames = usernames.Append("swharden").Distinct().OrderBy(x => x).ToArray();
                md = GitHubMarkdown.LinkUsernames(md, uniqueUsernames);

                int[] issueNumbers = GitHubMarkdown.GetIssues(md);
                md = GitHubMarkdown.LinkIssues(md, issueNumbers);

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

        private string GetUserIconDiv(string[] usernames)
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

        private string GetUserIconDiv(string username)
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

        private void CreateChangelogMarkdownPage(string changelogMarkdown, string outputFilePath)
        {
            StringBuilder sb = new();
            sb.AppendLine("---");
            sb.AppendLine("Title: ScottPlot Changelog");
            sb.AppendLine("Description: Release log for every version of ScottPlot");
            sb.AppendLine("Source: https://github.com/ScottPlot/ScottPlot/blob/master/dev/changelog.md");
            sb.AppendLine("---");
            sb.AppendLine(changelogMarkdown);

            string outputFolder = Path.GetDirectoryName(outputFilePath);
            if (!Directory.Exists(outputFolder))
                Directory.CreateDirectory(outputFolder);

            File.WriteAllText(outputFilePath, sb.ToString());
        }

        private void CreateContributorsMarkdownPage(string[] usernames, string outputFilePath)
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
