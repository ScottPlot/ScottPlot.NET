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
        public void Test_GetUsernames_Line()
        {
            string inputLine = "* Hide design-time error message component at run time to reduce flicking when resizing (#1073, #1075) _Thanks @Superberti and @bclehmann_";
            string[] usernames = SiteBuilder.GitHubMarkdown.GetUsernamesFromLine(inputLine);
            Assert.AreEqual(2, usernames.Length);
            Assert.AreEqual("Superberti", usernames[0]);
            Assert.AreEqual("bclehmann", usernames[1]);
        }
    }
}