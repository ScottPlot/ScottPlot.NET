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
        public CookbookGenerator(string cookbookCsprojFilePath)
        {
            if (!cookbookCsprojFilePath.EndsWith(".csproj", StringComparison.InvariantCultureIgnoreCase))
                throw new ArgumentException("not a csproj file path", nameof(cookbookCsprojFilePath));

            if (!File.Exists(cookbookCsprojFilePath))
                throw new ArgumentException($"csproj file not found: {cookbookCsprojFilePath}", nameof(cookbookCsprojFilePath));

            cookbookCsprojFilePath = Path.GetFullPath(cookbookCsprojFilePath);

            Console.WriteLine($"analyzing cookbook: {cookbookCsprojFilePath}");
        }

        public void Generate()
        {
            Console.WriteLine("generating...");
        }
    }
}
