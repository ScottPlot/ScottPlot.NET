using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
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

        public static Recipe[] FromJson(string jsonFilePath)
        {
            List<Recipe> recipes = new();

            using JsonDocument document = JsonDocument.Parse(File.ReadAllText(jsonFilePath));
            foreach (JsonElement recipeElement in document.RootElement.GetProperty("recipes").EnumerateArray())
            {
                string id = recipeElement.GetProperty("id").GetString() ?? "";
                string category = recipeElement.GetProperty("category").GetString() ?? "";
                string title = recipeElement.GetProperty("title").GetString() ?? "";
                string description = recipeElement.GetProperty("description").GetString() ?? "";
                string code = recipeElement.GetProperty("code").GetString() ?? "";
                recipes.Add(new Recipe(id, title, category, description, code));
            }

            return recipes.ToArray();
        }
    }
}
