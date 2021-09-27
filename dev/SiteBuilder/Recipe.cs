using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SiteBuilder
{
    public class Recipe
    {
        public readonly string ID;
        public readonly string Category;
        public readonly string Title;
        public readonly string Description;
        public readonly string Code;

        public Recipe(string id, string title, string category, string description, string code)
        {
            ID = id;
            Category = category; 
            Title = title;
            Description = description;
            Code = code;
        }

        public static Recipe FromFile(string recipeFile)
        {
            string[] lines = File.ReadAllLines(recipeFile);

            string GetHeaderValue(string line, string key)
            {
                string start = $"/// {key}: ";
                if (!line.StartsWith(start))
                    throw new InvalidOperationException("header line not proper format for key: {key}");
                return line[start.Length..].Trim();
            }

            string id = GetHeaderValue(lines[0], "ID");
            string title = GetHeaderValue(lines[1], "TITLE");
            string category = GetHeaderValue(lines[2], "CATEGORY");
            string description = GetHeaderValue(lines[3], "DESCRIPTION");
            string code = string.Join("\n", lines[4..]);

            return new Recipe(id, title, category, description, code);
        }
    }
}
