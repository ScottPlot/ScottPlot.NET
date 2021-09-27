using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SiteBuilder
{
    public class CookbookGenerator
    {
        public readonly string ImagePath;
        public readonly string SourcePath;
        public readonly string CategoryPath;
        public readonly string CookbookPath;
        public readonly string Version;

        public CookbookGenerator(string path, string version = "4.1")
        {
            Version = version;

            path = Path.GetFullPath(path);
            if (!Directory.Exists(path))
                throw new ArgumentException($"not found: {path}");
            CookbookPath = path;

            string imagePath = Path.Combine(path, "images");
            if (!Directory.Exists(imagePath))
                throw new ArgumentException($"not found: {imagePath}");
            ImagePath = imagePath;

            string sourcePath = Path.Combine(path, "source");
            if (!Directory.Exists(sourcePath))
                throw new ArgumentException($"not found: {sourcePath}");
            SourcePath = sourcePath;

            CategoryPath = Path.Combine(path, "category");
            if (!Directory.Exists(CategoryPath))
                Directory.CreateDirectory(CategoryPath);
        }

        public void Generate()
        {
            Recipe[] recipes = Directory
                .GetFiles(SourcePath, "*.cs")
                .Select(x => Recipe.FromFile(x))
                .ToArray();

            string[] categories = recipes
                .Select(x => x.Category)
                .Distinct()
                .OrderBy(x => x)
                .ToArray();

            foreach (string category in categories)
            {
                GenerateCategoryPage(category, recipes);
            }

            GenerateHomePage(categories, recipes);
        }

        private void GenerateHomePage(string[] categories, Recipe[] recipes)
        {
            StringBuilder sb = new();

            sb.AppendLine($"---");
            sb.AppendLine($"Title: ScottPlot {Version} Cookbook");
            sb.AppendLine($"Description: Images created with ScottPlot {Version} shown next to the code used to create them.");
            sb.AppendLine($"---");
            sb.AppendLine();
            sb.AppendLine($"<div class='display-3 mb-3'><a href='/cookbook/{Version}' class='text-dark'>ScottPlot {Version} Cookbook</a></div>");
            sb.AppendLine();

            foreach (string category in categories.Where(x => x.StartsWith("Quickstart")))
            {
                IncludeCategoryThumbnails(category, recipes, sb);
            }

            foreach (string category in categories.Where(x => !x.StartsWith("Plottable") && !x.StartsWith("Quickstart")))
            {
                IncludeCategoryThumbnails(category, recipes, sb);
            }

            foreach (string category in categories.Where(x => x.StartsWith("Plottable")))
            {
                IncludeCategoryThumbnails(category, recipes, sb);
            }

            string mdFilePath = Path.Combine(CookbookPath, "index.md");
            File.WriteAllText(mdFilePath, sb.ToString());
            Console.WriteLine($"Wrote: {mdFilePath}");
        }

        private void IncludeCategoryThumbnails(string category, Recipe[] recipes, StringBuilder sb)
        {
            string categoryUrl = $"category/{Url.Sanitize(category)}";
            sb.AppendLine($"<div class='h3 mt-5'><a href='{categoryUrl}'>{category}</a></div>");

            Recipe[] categoryRecipes = recipes.Where(x => x.Category == category).ToArray();
            foreach (Recipe recipe in categoryRecipes)
            {
                string anchorUrl = $"category/{Url.Sanitize(recipe.Category)}/#{Url.Sanitize(recipe.Title)}";
                string thumbUrl = $"images/{Url.Sanitize(recipe.ID)}_thumb.jpg";
                sb.AppendLine($"<a href='{anchorUrl}'><img src='{thumbUrl}' /></a>");
            }
            sb.AppendLine();
        }

        private void GenerateCategoryPage(string category, Recipe[] recipes)
        {
            StringBuilder sb = new();

            string title = category.Replace("Plottable: ", "");
            sb.AppendLine($"---");
            sb.AppendLine($"Title: {title} - ScottPlot {Version} Cookbook");
            sb.AppendLine($"---");
            sb.AppendLine();
            sb.AppendLine($"<div class='display-3'><a href='/cookbook/{Version}' class='text-dark'>ScottPlot {Version} Cookbook</a></div>");
            sb.AppendLine($"<div class='display-6'>{category}</div>");
            sb.AppendLine();

            foreach (Recipe recipe in recipes.Where(x => x.Category == category))
            {
                sb.AppendLine();
                sb.AppendLine("<div class='m-2'>&nbsp;</div>"); // extra spacing
                sb.AppendLine();
                sb.AppendLine($"## {recipe.Title}");
                sb.AppendLine();
                sb.AppendLine($"{recipe.Description}");
                sb.AppendLine();
                sb.AppendLine($"```cs");
                sb.AppendLine(recipe.Code);
                sb.AppendLine($"```");
                sb.AppendLine();
                string imageUrl = $"../../images/{recipe.ID}.png";
                sb.AppendLine($"<div class='text-center'>");
                sb.AppendLine($"<a href='{imageUrl}'><img src='{imageUrl}' /></a>");
                sb.AppendLine($"</div>");
                sb.AppendLine();
            }

            string folderName = Url.Sanitize(category);
            string folderPath = Path.Combine(CategoryPath, folderName);
            if (!Directory.Exists(folderPath))
                Directory.CreateDirectory(folderPath);

            string mdFilePath = Path.Combine(folderPath, "index.md");
            File.WriteAllText(mdFilePath, sb.ToString());
            Console.WriteLine($"Wrote: {mdFilePath}");
        }
    }
}
