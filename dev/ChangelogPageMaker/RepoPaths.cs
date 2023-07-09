namespace ChangelogPageMaker;

internal static class RepoPaths
{
    public readonly static string Root = RepoPath();

    public readonly static string StaticContributors = RepoPath("static/contributors");

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
    public static void Test_StaticContributors_IsNotEmpty()
    {
        Console.WriteLine(StaticContributors);
        Directory.Exists(StaticContributors).Should().BeTrue();
        Directory.GetFiles(StaticContributors, "*.*").Should().NotBeEmpty();
    }
}
