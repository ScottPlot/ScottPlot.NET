namespace ChangelogPageMaker;

internal class GENERATE
{
    [Test]
    public void Test_Generate_Pages()
    {
        string changelog = ChangelogDownloader.Download();

        string[] contributors = ChangelogParsing.GetGithubIDs(changelog);
        Console.WriteLine($"Changelog has {contributors.Length} contributors");

        AvatarCollection avatars = new(RepoPaths.ContributorImageFolder);
        avatars.DownloadMissingImages(contributors);

        File.WriteAllText(RepoPaths.ContributorsPageMarkdown, ContributorPage.GetMarkdown(contributors, avatars));
    }
}
