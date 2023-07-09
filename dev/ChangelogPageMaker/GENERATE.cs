using ChangelogPageMaker.Logic;
using ChangelogPageMaker.Pages;

namespace ChangelogPageMaker;

internal class GENERATE
{
    [Test]
    public void Test_Generate_Pages()
    {
        string changelog = ChangelogDownloader.Download();

        // download contributor avatar images
        string[] contributors = IdExtraction.GetIDs(changelog);
        Console.WriteLine($"Changelog has {contributors.Length} contributors");
        AvatarCollection avatars = new(RepoPaths.ContributorImageFolder);
        avatars.DownloadMissingImages(contributors);

        // create contributor page
        ContributorPage conPage = new(contributors, avatars);
        conPage.SaveBootstrappedHtml("test-contributors.html");
        conPage.SaveMarkdown(RepoPaths.ContributorsPageMarkdown);

        // create changelog page
        ChangelogPage chgPage = new(changelog, contributors, avatars);
        chgPage.SaveBootstrappedHtml("test-changelog.html");
        chgPage.SaveMarkdown(RepoPaths.ChangelogPageMarkdown);
    }
}