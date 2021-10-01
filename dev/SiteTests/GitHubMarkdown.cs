using System;
using System.Linq;
using System.Collections.Generic;
using NUnit.Framework;
using System.IO;

namespace SiteTests
{
    public static class GitHubMarkdown
    {
        public static string LinkUsernames(string md, string[] usernames)
        {
            foreach (string username in usernames.Distinct().OrderByDescending(x => x))
            {
                md = md.Replace($"@{username}", $"[**@{username}**](https://github.com/{username})");
            }

            return md;
        }

        public static string[] GetUsernames(string md)
        {
            List<string> usernames = new();
            foreach (string line in md.Split())
            {
                usernames.AddRange(GetUsernamesFromLine(line));
            }
            return usernames.ToArray();
        }

        private static string[] GetUsernamesFromLine(string line)
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

            return usernames.ToArray();
        }
    }
}