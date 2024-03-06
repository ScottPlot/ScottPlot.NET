using ChangelogPageMaker.Logic;
using ChangelogPageMaker.Pages;

namespace ChangelogPageMaker;

internal class GENERATE
{
    [Test]
    public void Test_Generate_Pages()
    {
        Changelog changelog = GetLatestChangelog();
        Console.WriteLine(changelog);

        changelog.DownloadMissingAvatars();

        ContributorPage conPage = new(changelog);
        conPage.SaveMarkdown(RepoPaths.ContributorsPageMarkdown);

        ChangelogPage chgPage = new(changelog);
        chgPage.SaveMarkdown(RepoPaths.ChangelogPageMarkdown);
    }

    public static Changelog GetLatestChangelog()
    {
        string localChangelogFile = Path.GetFullPath("../../../../../../ScottPlot/CHANGELOG.md");
        string changelogText = string.Empty;
        if (File.Exists(localChangelogFile))
        {
            changelogText = File.ReadAllText(localChangelogFile);
            Console.WriteLine($"Generating changelog from local file: {localChangelogFile}");
        }
        else
        {
            string url = "https://raw.githubusercontent.com/ScottPlot/ScottPlot/main/CHANGELOG.md";
            Console.WriteLine($"Downloading: {url}");

            using HttpClient client = new();

            Console.WriteLine($"Downloading changelog file: {url}");
            using HttpResponseMessage response = client.GetAsync(url).Result;
            if (response.StatusCode != System.Net.HttpStatusCode.OK)
            {
                throw new InvalidOperationException($"HTTP response code: {response.StatusCode}");
            }

            using HttpContent content = response.Content;
            changelogText = content.ReadAsStringAsync().Result;
        }

        return new Changelog(changelogText, RepoPaths.ContributorImageFolder);
    }
}