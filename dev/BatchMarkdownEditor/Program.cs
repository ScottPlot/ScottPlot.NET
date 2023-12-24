namespace BatchMarkdownEditor;

public static class Program
{
    public static void Main()
    {
        foreach (string path in Paths.GetMarkdownFilePaths())
        {
            string[] lines = File.ReadAllLines(path);
            var urlLines = lines.Where(x => x.StartsWith("url: ", StringComparison.InvariantCultureIgnoreCase));
            if (urlLines.Any())
            {
                string url = urlLines.Single()[4..];
                if (!url.Contains(".html", StringComparison.InvariantCultureIgnoreCase))
                {
                    continue;
                }

                Console.WriteLine();
                Console.WriteLine(path);
                Console.WriteLine(url);
            }
        }
    }
}
