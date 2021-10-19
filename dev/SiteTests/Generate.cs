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
            // get raw changelog contents
            string rawMarkdown = ReadLocalChangelog() ?? DownloadChangelog();

            // make changelog page markdown
            string changelogMarkdownRaw = SiteBuilder.PageBuilding.GetAnnotatedChangelogMarkdown(rawMarkdown);
            string changelogIndexPagePath = Path.Combine(PATH_REPO_ROOT, "content/changelog/index.md");
            SiteBuilder.PageBuilding.CreateChangelogMarkdownPage(changelogMarkdownRaw, changelogIndexPagePath);

            // make contributors page markdown
            string[] contributors = SiteBuilder.GitHubMarkdown.GetUniqueUsernames(rawMarkdown);
            string contributorsIndexPagePath = Path.Combine(PATH_REPO_ROOT, "content/contributors/index.md");
            SiteBuilder.PageBuilding.CreateContributorsMarkdownPage(contributors, contributorsIndexPagePath);

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
    }
}
