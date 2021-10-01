using System;
using System.Text;
using System.Linq;
using System.Net;
using System.Collections.Generic;
using NUnit.Framework;
using System.IO;

namespace SiteTests
{
    public class Changelog
    {
        public string DownloadChangelog()
        {
            const string url = "https://raw.githubusercontent.com/ScottPlot/ScottPlot/master/dev/changelog.md";
            using WebClient client = new();
            string txt = client.DownloadString(url);
            return txt;
        }

        [Test]
        public void Test_Changelog_Build()
        {
            StringBuilder sb = new();
            sb.AppendLine("---");
            sb.AppendLine("Title: ScottPlot Changelog");
            sb.AppendLine("Description: Release log for every version of ScottPlot");
            sb.AppendLine("---");
            sb.AppendLine(DownloadChangelog());

            string md = sb.ToString();
            string[] usernames = GitHubMarkdown.GetUsernames(md);
            md = GitHubMarkdown.LinkUsernames(md, usernames);
            Console.WriteLine($"Identified {usernames.Length} mentions ({usernames.Distinct().Count()} unique)");

            string outputFolder = Path.GetFullPath(Path.Combine(
                path1: TestContext.CurrentContext.TestDirectory,
                path2: "../../../../../content/changelog"));

            if (!Directory.Exists(outputFolder))
                Directory.CreateDirectory(outputFolder);
            Console.WriteLine($"Created: {outputFolder}");

            string outputFilePath = Path.Combine(outputFolder, "index.md");
            File.WriteAllText(outputFilePath, md);
            Console.WriteLine($"Wrote: {outputFilePath}");
        }
    }
}