namespace ChangelogPageMaker.Logic;

internal class ChangelogTests
{
    Changelog Changelog = new(SampleChangelog.Text);

    [Test]
    public void Test_Changelog_HasSections()
    {
        Changelog.Releases.Should().NotBeEmpty();

        foreach (ChangelogRelease release in Changelog.Releases)
        {
            Console.WriteLine($"{release.Title} ({release.Date}) has {release.Changes.Count} changes");
            release.Changes.Should().NotBeEmpty();
        }
    }
}
