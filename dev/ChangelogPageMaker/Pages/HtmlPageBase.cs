using ChangelogPageMaker.Logic;
using System.Runtime.InteropServices;

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

    public string GetMarkdown()
    {
        string markdown =
            $"""
            ---
            Title: {Title}
            Description: {Description}
            ---

            # {Title}

            {Description}

            {GetHtml()}
            """;

        if (RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
        {
            markdown = markdown.Replace("\n", "\r\n");
        }

        return markdown;
    }

    public void SaveMarkdown(string saveAs)
    {
        saveAs = Path.GetFullPath(saveAs);
        File.WriteAllText(saveAs, GetMarkdown());
        Console.WriteLine($"Wrote: {saveAs}");
    }
}
