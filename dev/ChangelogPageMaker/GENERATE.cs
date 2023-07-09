namespace ChangelogPageMaker;

internal class GENERATE
{
    [Test]
    public void Test_Generate_Pages()
    {
        AvatarCollection avatars = new(RepoPaths.StaticContributors);
        avatars.DownloadMissingImages(SampleChangelog.Contributors);

        // TODO: fetch changelog from github page
        string md = ContributorPage.GetMarkdown(SampleChangelog.Contributors, avatars);

        File.WriteAllText(RepoPaths.ContributorsPageMarkdown, md);
    }
}
