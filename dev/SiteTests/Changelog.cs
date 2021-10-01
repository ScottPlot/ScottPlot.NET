using System;
using System.Collections.Generic;
using NUnit.Framework;
using System.IO;

namespace SiteTests
{
    public class Cookbook
    {
        /// <summary>
        /// given a single line of a markdown file
        /// return the line with github usernames linked to their github pages
        /// and also an array of all the usernames seen
        /// </summary>
        private static (string line, string[] usernames) LinkGitHubUsers(string line)
        {
            List<string> usernames = new();
            List<char> nextUsername = new();
            bool inName = false;

            char[] adjacentChars = { ' ', '\n', '\r', '(', ')', '*', '_', ',' };
            string adjacentChars2 = new string(adjacentChars);

            char[] chars = line.ToCharArray();
            for (int i = 0; i < chars.Length; i++)
            {
                char c = chars[i];

                // name starting?
                if (c == '@')
                {
                    if (i == 0 || adjacentChars2.Contains(chars[i - 1]))
                    {
                        inName = true;
                        continue;
                    }
                }

                // not in name
                if (inName == false)
                    continue;

                // name over?
                if (adjacentChars2.Contains(c))
                {
                    usernames.Add(new string(nextUsername.ToArray()));
                    nextUsername.Clear();
                    inName = false;
                    continue;
                }

                // name continuing
                nextUsername.Add(c);
            }

            foreach (string username in usernames)
            {
                line = line.Replace($"@{username}", $"[**@{username}**](https://github.com/{username})");
            }

            return (line, usernames.ToArray());
        }

        [Test]
        public void Test_Changelog_Build()
        {
            string changelogFilePath = Path.Combine(
                path1: TestContext.CurrentContext.TestDirectory,
                path2: "../../../../../ScottPlot/dev/changelog.md");

            Assert.That(File.Exists(changelogFilePath));

            List<string> usernames = new();
            string[] lines = File.ReadAllLines(changelogFilePath);
            for (int i = 0; i < lines.Length; i++)
            {
                (string line, string[] lineUsernames) = LinkGitHubUsers(lines[i]);
                lines[i] = line;
                usernames.AddRange(lineUsernames);
            }

            string outputFilePath = Path.GetFullPath(Path.Combine(
                path1: TestContext.CurrentContext.TestDirectory,
                path2: "../../../../../content/changelog/index.md"));

            string md = string.Join("\n", lines);
            File.WriteAllText(outputFilePath, md);

            Console.WriteLine($"Wrote: {outputFilePath}");
        }
    }
}