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
    internal class GitHubMarkdownTests
    {
        [Test]
        public void Test_Annotate_Usernames_Line()
        {
            string raw = "* Added 'Open in New Window' option to right-click menu (#958, #969) _Thanks @ademkaya and @bclehmann_";
            string[] usernames = SiteBuilder.GitHubMarkdown.GetUsernamesFromLine(raw);
            Assert.AreEqual(2, usernames.Length);
            Assert.AreEqual("ademkaya", usernames[0]);
            Assert.AreEqual("bclehmann", usernames[1]);

            string annotated = SiteBuilder.GitHubMarkdown.LinkUsernames(raw, usernames);
            Assert.That(annotated.Contains("[**@bclehmann**](https://github.com/bclehmann)"));
            Assert.That(annotated.Contains("[**@ademkaya**](https://github.com/ademkaya)"));
        }

        [Test]
        public void Test_Annotate_Usernames_TextBlock()
        {
            string raw = @"
## ScottPlot 4.1.15
* Hide design-time error message component at run time to reduce flicking when resizing (#1073, #1075) _Thanks @Superberti and @bclehmann_
* Added a modern `Plot.GetBitmap()` overload suitable for the new stateless rendering system (#913 #1063)
* Controls now have `PlottableDragged` and `PlottableDropped` event handlers (#1072) _Thanks @JS-BGResearch_
";
            string[] usernames = SiteBuilder.GitHubMarkdown.GetUsernames(raw);
            Assert.Contains("bclehmann", usernames);
            Assert.Contains("Superberti", usernames);
            Assert.Contains("JS-BGResearch", usernames);

            string annotated = SiteBuilder.GitHubMarkdown.LinkUsernames(raw, usernames);
            Assert.That(annotated.Contains("[**@bclehmann**](https://github.com/bclehmann)"));
            Assert.That(annotated.Contains("[**@Superberti**](https://github.com/Superberti)"));
        }

        [Test]
        public void Test_Changelog_HasNoUnlinkedUsernames()
        {
            string path = Path.GetFullPath("../../../../../../ScottPlot/dev/changelog.md");
            string rawMarkdown = File.ReadAllText(path);
            string changelogMarkdownRaw = SiteBuilder.PageBuilding.GetAnnotatedChangelogMarkdown(rawMarkdown);
            string outFile = Path.GetFullPath("test-changelog.md");
            SiteBuilder.PageBuilding.CreateChangelogMarkdownPage(changelogMarkdownRaw, outFile);
            Console.WriteLine(outFile);
            Assert.That(!changelogMarkdownRaw.Contains(" @"));
        }
    }
}