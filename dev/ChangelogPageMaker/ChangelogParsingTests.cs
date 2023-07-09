namespace ChangelogPageMaker;

internal class ChangelogParsingTests
{
    [Test]
    public void Test_Sections_AreFound()
    {
        List<string[]> sections = ChangelogParsing.GetSections(SampleChangelog.Text);
        sections.Should().NotBeEmpty();

        foreach (string[] section in sections)
        {
            Console.WriteLine(section[0]);
            Console.WriteLine(section.Last());
            Console.WriteLine("");
        }
    }

    [Test]
    public void Test_SampleData_ContainsAllContributors()
    {
        Console.WriteLine($"Sample data has {SampleChangelog.Contributors.Length} contributors");
        foreach (string author in SampleChangelog.Contributors)
        {
            string githubID = "@" + author;
            Assert.That(SampleChangelog.Text.Contains(githubID));
        }
    }

    [Test]
    public void Test_GithubIDs_AreAllFound()
    {
        string[] ids = ChangelogParsing.GetGithubIDs(SampleChangelog.Text);
        Console.WriteLine($"Parsed data has {ids.Length} contributors");
        foreach (string id in ids)
        {
            Assert.That(SampleChangelog.Contributors, Contains.Item(id));
        }
    }

    [Test]
    public void Test_Contributors_NoDuplicates()
    {
        string[] ids = ChangelogParsing.GetGithubIDs(SampleChangelog.Text);
        HashSet<string> unique = new();

        foreach (string id in ids)
        {
            if (unique.Contains(id))
                Assert.Fail(id);

            unique.Add(id);
        }

        Assert.That(ids.Length, Is.EqualTo(unique.Count));
    }
}
