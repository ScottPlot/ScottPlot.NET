namespace ChangelogPageMaker;

internal class PageGenerationTests
{
    [Test]
    public void Test_Generate_Pages()
    {
        string saveAs = Path.GetFullPath("test-contributors.html");
        ContributorPage.GenerateHtml(SampleChangelog.Contributors, saveAs);
        Console.WriteLine(saveAs);
    }
}
