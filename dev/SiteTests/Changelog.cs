using System;
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
            string md = DownloadChangelog();

            string[] usernames = GitHubMarkdown.GetUsernames(md);
            Console.WriteLine($"Identified {usernames.Length} mentions");

            md = GitHubMarkdown.LinkUsernames(md, usernames);

            string outputFilePath = Path.GetFullPath(Path.Combine(
                path1: TestContext.CurrentContext.TestDirectory,
                path2: "../../../../../content/changelog/index.md"));
            File.WriteAllText(outputFilePath, md);
            Console.WriteLine($"Wrote: {outputFilePath}");
        }
    }
}