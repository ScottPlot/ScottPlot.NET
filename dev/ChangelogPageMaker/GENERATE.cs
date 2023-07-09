using ChangelogPageMaker.Logic;
using ChangelogPageMaker.Pages;

namespace ChangelogPageMaker;

internal class GENERATE
{
    [Test]
    public void Test_Generate_Pages()
    {
        // download changelog
        string changelog = ChangelogDownloader.Download();

        // download contributor avatar images
        string[] contributors = ChangelogParsing.GetGithubIDs(changelog);
        Console.WriteLine($"Changelog has {contributors.Length} contributors");
        AvatarCollection avatars = new(RepoPaths.ContributorImageFolder);
        avatars.DownloadMissingImages(contributors);

        // create contributor page
        ContributorPage contrib = new(contributors, avatars);
        contrib.SaveBootstrappedHtml("test-contributors.html");
        contrib.SaveMarkdown(RepoPaths.ContributorsPageMarkdown);
    }
}