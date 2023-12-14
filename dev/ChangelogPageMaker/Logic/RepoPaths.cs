namespace ChangelogPageMaker.Logic;

internal static class RepoPaths
{
    public readonly static string Root = RepoPath();

    public readonly static string ContributorImageFolder = RepoPath("static/images/contributors");

    public readonly static string ContributorsPageMarkdown = RepoPath("content/contributors.md");

    public readonly static string ChangelogPageMarkdown = RepoPath("content/changelog.md");

    private static string RepoPath(string subfolder = "")
    {
        string path = Path.Combine(TestContext.CurrentContext.TestDirectory, "../../../../../");
        path = Path.GetFullPath(path);
        path = Path.Combine(path, subfolder);
        return path;
    }

    [Test]
    public static void Test_Root_HasLicense()
    {
        Console.WriteLine(Root);
        string licenseFilePath = Path.Combine(Root, "LICENSE");
        File.Exists(licenseFilePath).Should().BeTrue();
    }

    [Test]
    public static void Test_MarkdownFiles_Exist()
    {
        File.Exists(ContributorsPageMarkdown).Should().BeTrue();
        File.Exists(ChangelogPageMarkdown).Should().BeTrue();
    }

    [Test]
    public static void Test_StaticContributors_IsNotEmpty()
    {
        Console.WriteLine(ContributorImageFolder);
        Directory.Exists(ContributorImageFolder).Should().BeTrue();
        Directory.GetFiles(ContributorImageFolder, "*.*").Should().NotBeEmpty();
    }
}
