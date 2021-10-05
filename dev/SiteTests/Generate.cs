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
            // create updated changelog file
            string rawMarkdown = ReadLocalChangelog() ?? DownloadChangelog();
            string changelogMarkdownRaw = GetAnnotatedChangelogMarkdown(rawMarkdown);
            string changelogIndexPagePath = Path.Combine(PATH_REPO_ROOT, "content/changelog/index.md");
            CreateChangelogMarkdownPage(changelogMarkdownRaw, changelogIndexPagePath);

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

        private string GetAnnotatedChangelogMarkdown(string rawMarkdown)
        {
            string[] chunks = rawMarkdown.Split("\n#");
            for (int i = 0; i < chunks.Length; i++)
            {
                string md = chunks[i];

                string[] usernames = GitHubMarkdown.GetUsernames(md);
                md = GitHubMarkdown.LinkUsernames(md, usernames);

                int[] issueNumbers = GitHubMarkdown.GetIssues(md);
                md = GitHubMarkdown.LinkIssues(md, issueNumbers);

                if (usernames.Length > 0)
                {
                    md += "\n\n";
                    md += "<div class='text-center mt-4'>";
                    md += "<div><i>Special thanks to this version's contributors!</i></div>";
                    md += "<div>";
                    foreach (string username in usernames.Append("swharden").Distinct().OrderBy(x => x))
                    {
                        md += $"<div class='d-inline-block mx-3'>";

                        md += $"<a href='https://github.com/{username}'>" +
                            $"<img src='https://github.com/{username}.png?size=100' height='100' width='100' />" +
                            $"</a>";
                        md += $"<br>";
                        md += $"<a href='https://github.com/{username}'>@{username}</a>";

                        md += "</div>";
                    }
                    md += "</div>";
                    md += "</div>";
                }

                md += "\n\n<hr class='my-3' style='width: 50%; opacity: 0;'>\n\n";

                chunks[i] = md;
            }

            return string.Join("\n#", chunks);
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
    }
}
