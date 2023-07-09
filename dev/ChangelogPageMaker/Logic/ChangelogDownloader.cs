namespace ChangelogPageMaker.Logic;

public static class ChangelogDownloader
{
    public static string Download(string url = "https://raw.githubusercontent.com/ScottPlot/ScottPlot/main/CHANGELOG.md")
    {
        bool isScottsComputer = Directory.Exists("C:/Users/scott");
        if (isScottsComputer)
        {
            Console.WriteLine("Scott's computer detected: using local changelog file");
            return SampleChangelog.Text;
        }

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

        return txt;
    }
}
