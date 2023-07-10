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
        conPage.SaveBootstrappedHtml("test-contributors.html");
        conPage.SaveMarkdown(RepoPaths.ContributorsPageMarkdown);

        ChangelogPage chgPage = new(changelog);
        chgPage.SaveBootstrappedHtml("test-changelog.html");
        chgPage.SaveMarkdown(RepoPaths.ChangelogPageMarkdown);
    }

    public static Changelog GetLatestChangelog()
    {
        bool isScottsComputer = Directory.Exists("C:/Users/scott");
        if (isScottsComputer)
        {
            Console.WriteLine("Scott's computer detected: using local changelog file");
            return new Changelog(SampleChangelog.Text, RepoPaths.ContributorImageFolder);
        }

        string url = "https://raw.githubusercontent.com/ScottPlot/ScottPlot/main/CHANGELOG.md";
        Console.WriteLine($"Downloading: {url}");

        using HttpClient client = new();

        Console.WriteLine($"Downloading: {url}");
        using HttpResponseMessage response = client.GetAsync(url).Result;
        if (response.StatusCode != System.Net.HttpStatusCode.OK)
        {
            throw new InvalidOperationException($"HTTP response code: {response.StatusCode}");
        }

        using HttpContent content = response.Content;
        string txt = content.ReadAsStringAsync().Result;

        return new Changelog(txt, RepoPaths.ContributorImageFolder);
    }
}