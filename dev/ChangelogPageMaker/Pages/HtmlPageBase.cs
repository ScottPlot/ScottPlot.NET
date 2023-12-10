using ChangelogPageMaker.Logic;

namespace ChangelogPageMaker.Pages;

internal abstract class HtmlPageBase
{
    public readonly string Title;
    public readonly string Description;
    public readonly Changelog Changelog;

    public abstract string GetHtml();

    public HtmlPageBase(string title, string description, Changelog changelog)
    {
        Title = title;
        Description = description;
        Changelog = changelog;
    }

    public string GetBootstrappedHtml(bool pre)
    {
        string html = GetHtml();

        if (pre)
        {
            html = $"<pre>{html}</pre>";
        }

        return $"""
        <!doctype html>
        <html lang="en">
          <head>
            <meta charset="utf-8">
            <meta name="viewport" content="width=device-width, initial-scale=1">
            <title>{Title}</title>
            <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.3.0/dist/css/bootstrap.min.css" rel="stylesheet"
                  integrity="sha384-9ndCyUaIbzAi2FUVXJi0CjmCapSmO7SnpJef0486qhLnuZ2cdeRhO02iuK6FUUVM" crossorigin="anonymous">
          </head>
          <body>
            <div class='container my-5'>
              {html}
            </div>
          </body>
        </html>
        """;
    }

    public void SaveBootstrappedHtml(string saveAs, bool pre = false)
    {
        saveAs = Path.GetFullPath(saveAs);
        File.WriteAllText(saveAs, GetBootstrappedHtml(pre));
        Console.WriteLine($"Wrote: {saveAs}");
    }

    public string GetMarkdown()
    {
        return $"""
            ---
            Title: {Title}
            Description: {Description}
            ---

            # {Title}

            {Description}

            {GetHtml()}
            """;
    }

    public void SaveMarkdown(string saveAs)
    {
        saveAs = Path.GetFullPath(saveAs);
        File.WriteAllText(saveAs, GetMarkdown());
        Console.WriteLine($"Wrote: {saveAs}");
    }
}
