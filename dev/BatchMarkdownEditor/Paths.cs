namespace BatchMarkdownEditor;

public static class Paths
{
    public static string[] GetMarkdownFilePaths()
    {
        string repoRoot = Path.GetFullPath("../../../../../");

        string licenseFilePath = Path.Combine(repoRoot, "LICENSE");
        if (!File.Exists(licenseFilePath))
            throw new FileNotFoundException();

        string contentFolder = Path.Combine(repoRoot, "content");
        if (!Directory.Exists(contentFolder))
            throw new DirectoryNotFoundException();

        return Directory
            .GetFiles(contentFolder, "*.md", SearchOption.AllDirectories)
            //.Where(x=>!x.Contains("\\cookbook\\4.0\\"))
            //.Where(x => !x.Contains("\\cookbook\\4.1\\"))
            //.Where(x => !x.Contains("\\cookbook\\5.0\\"))
            .ToArray();
    }
}
