using System;
using System.Linq;
using System.Collections.Generic;
using System.IO;

namespace SiteBuilder
{
    public static class GitHubMarkdown
    {
        public static string LinkIssues(string md, int[] numbers)
        {
            foreach (int number in numbers.Distinct().OrderByDescending(x => x))
            {
                md = md.Replace($"#{number}", $"[%ISSUE%{number}](https://github.com/ScottPlot/ScottPlot/issues/{number})");
            }

            md = md.Replace("%ISSUE%", "#");

            return md;
        }

        public static string LinkUsernames(string md, string[] usernames)
        {
            foreach (string username in usernames.Distinct().OrderByDescending(x => x))
            {
                md = md.Replace($"@{username}", $"[**%USERNAME%{username}**](https://github.com/{username})");
            }

            md = md.Replace("%USERNAME%", "@");

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

        public static string[] GetUsernamesFromLine(string line)
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

        public static int[] GetIssues(string md)
        {
            List<int> numbers = new();
            foreach (string line in md.Split())
            {
                numbers.AddRange(GetIssueNumbersFromLine(line));
            }
            return numbers.ToArray();
        }

        private static int[] GetIssueNumbersFromLine(string line)
        {
            List<int> numbers = new();
            List<char> nextNumber = new();
            bool inNumber = false;

            char[] adjacentChars = { ' ', '\n', '\r', '(', ')', '*', '_', ',' };
            string adjacentChars2 = new string(adjacentChars);

            char[] chars = line.ToCharArray();
            for (int i = 0; i < chars.Length; i++)
            {
                char c = chars[i];

                // name starting?
                if (c == '#')
                {
                    if (i == 0 || adjacentChars2.Contains(chars[i - 1]))
                    {
                        inNumber = true;
                        continue;
                    }
                }

                // not in name
                if (inNumber == false)
                    continue;

                // name over?
                if (adjacentChars2.Contains(c))
                {
                    string numberString = new string(nextNumber.ToArray());
                    int number = int.Parse(numberString);
                    numbers.Add(number);
                    nextNumber.Clear();
                    inNumber = false;
                    continue;
                }

                // name continuing
                nextNumber.Add(c);
            }

            return numbers.ToArray();
        }
    }
}