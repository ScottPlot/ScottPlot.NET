namespace ChangelogPageMaker.Logic;

public static class ChangelogDownloader
{
    public static string Download(string url = "https://raw.githubusercontent.com/ScottPlot/ScottPlot/main/CHANGELOG.md")
    {
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
