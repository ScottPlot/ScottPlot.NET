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
        public readonly string CategoryPath;
        public readonly string CookbookPath;
        public readonly string Version = "4.1";
        public readonly Recipe[] Recipes;

        public CookbookGenerator(string path)
        {
            path = Path.GetFullPath(path);
            if (!Directory.Exists(path))
                throw new ArgumentException($"not found: {path}");
            CookbookPath = path;

            string imagePath = Path.Combine(path, "images");
            if (!Directory.Exists(imagePath))
                throw new ArgumentException($"not found: {imagePath}");
            ImagePath = imagePath;

            string jsonFilePath = Path.Combine(path, "recipes.json");
            if (!File.Exists(jsonFilePath))
                throw new ArgumentException($"not found: {jsonFilePath}");
            Recipes = Recipe.FromJson(jsonFilePath);

            CategoryPath = Path.Combine(path, "category");
            if (!Directory.Exists(CategoryPath))
                Directory.CreateDirectory(CategoryPath);
        }

        public void Generate()
        {
            string[] categories = Recipes
                .Select(x => x.Category)
                .Distinct()
                .OrderBy(x => x)
                .ToArray();

            foreach (string category in categories)
                GenerateCategoryPage(category);

            GenerateHomePage(categories);
            GenerateSitemap();
        }

        private void GenerateSitemap()
        {
            var sm = new Statix.Sitemap.SitemapBuilder();
            sm.AddScan(CookbookPath, "https://scottplot.net/cookbook/4.1/");

            string sitemapFilePath = Path.Combine(CookbookPath, "sitemap.xml");
            File.WriteAllText(sitemapFilePath, sm.GetXML());
            Console.WriteLine($"Generated cookbook sitemap with {sm.Count} pages: {sitemapFilePath}");
        }

        private void GenerateHomePage(string[] categories)
        {
            StringBuilder sb = new();

            sb.AppendLine($"---");
            sb.AppendLine($"Title: ScottPlot {Version} Cookbook");
            sb.AppendLine($"Description: Images created with ScottPlot {Version} shown next to the code used to create them.");
            sb.AppendLine($"Source: https://github.com/ScottPlot/ScottPlot/tree/master/src/cookbook");
            sb.AppendLine($"---");
            sb.AppendLine();
            sb.AppendLine($"<div class='display-3 mb-3'><a href='/cookbook/{Version}' class='text-dark'>ScottPlot {Version} Cookbook</a></div>");
            sb.AppendLine();

            foreach (string category in categories.Where(x => x.StartsWith("Quickstart")))
            {
                IncludeCategoryThumbnails(category, Recipes, sb);
            }

            foreach (string category in categories.Where(x => !x.StartsWith("Plottable") && !x.StartsWith("Quickstart")))
            {
                IncludeCategoryThumbnails(category, Recipes, sb);
            }

            foreach (string category in categories.Where(x => x.StartsWith("Plottable")))
            {
                IncludeCategoryThumbnails(category, Recipes, sb);
            }

            string mdFilePath = Path.Combine(CookbookPath, "index.md");
            File.WriteAllText(mdFilePath, sb.ToString());
            Console.WriteLine($"Wrote: {mdFilePath}");
        }

        private void IncludeCategoryThumbnails(string category, Recipe[] recipes, StringBuilder sb)
        {
            string categoryUrl = $"category/{Url.Sanitize(category)}";
            sb.AppendLine($"<div class='h3 mt-5'><a href='{categoryUrl}'>{category}</a></div>");

            sb.AppendLine("<div class='row'>");
            Recipe[] categoryRecipes = recipes.Where(x => x.Category == category).ToArray();
            foreach (Recipe recipe in categoryRecipes)
            {
                string anchorUrl = $"category/{Url.Sanitize(recipe.Category)}/#{Url.Sanitize(recipe.Title)}";
                string thumbUrl = $"images/{Url.Sanitize(recipe.ID)}_thumb.jpg";
                string card = @$"
<div class='col-md-4 mb-3'>
    <div class='card'>
        <div class='card-header'>
        <strong><a href='{anchorUrl}'>{recipe.Title}</a></strong>
        </div>
        <div class='card-body'>
            <p class='card-text'>{recipe.Description}</p>
        <div class='text-center'>
            <a href='{anchorUrl}'>
                <img src='{thumbUrl}' class='mw-100' />
            </a>
        </div>
        </div>
    </div>
</div>";
                sb.AppendLine(card);
            }
            sb.AppendLine("</div>");
            sb.AppendLine();
        }

        private void GenerateCategoryPage(string category)
        {
            StringBuilder sb = new();

            string title = category.Replace("Plottable: ", "");
            sb.AppendLine($"---");
            sb.AppendLine($"Title: {title} - ScottPlot {Version} Cookbook");
            sb.AppendLine($"Description: {category} recipes");
            sb.AppendLine($"Source: https://github.com/ScottPlot/ScottPlot/tree/master/src/cookbook");
            sb.AppendLine($"---");
            sb.AppendLine();
            sb.AppendLine($"<div class='display-3'><a href='/cookbook/{Version}' class='text-dark'>ScottPlot {Version} Cookbook</a></div>");
            sb.AppendLine($"<div class='display-6'>{category}</div>");
            sb.AppendLine();

            foreach (Recipe recipe in Recipes.Where(x => x.Category == category))
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
                string imageUrl = $"../../images/{recipe.ID.ToLower()}.png";
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
