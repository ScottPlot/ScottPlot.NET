namespace ChangelogPageMaker;

internal class GENERATE
{
    [Test]
    public void Test_Generate_Pages()
    {
        AvatarCollection avatars = new(RepoPaths.StaticContributors);
        avatars.DownloadMissingImages(SampleChangelog.Contributors);

        string saveAs = Path.GetFullPath("test-contributors.html");
        ContributorPage.GenerateHtml(SampleChangelog.Contributors, avatars, saveAs);
        Console.WriteLine(saveAs);
    }
}
