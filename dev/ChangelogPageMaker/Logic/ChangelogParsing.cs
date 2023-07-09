namespace ChangelogPageMaker.Logic;

internal static class ChangelogParsing
{
    /// <summary>
    /// Given a full changelog, return blocks of markdown (one per section)
    /// </summary>
    public static List<string[]> GetSections(string text)
    {
        string[] lines = text.Split('\n');

        List<string[]> sections = new();

        List<string> sectionLines = new();

        foreach (string line in lines)
        {
            // ignore top-level headings
            if (line.StartsWith("# "))
                continue;

            if (line.Trim().Length == 0)
            {
                if (!sectionLines.Any())
                    continue;

                // end of section
                sections.Add(sectionLines.ToArray());
                sectionLines.Clear();
            }
            else
            {
                sectionLines.Add(line.Trim());
            }
        }

        return sections;
    }

    /// <summary>
    /// Given a line of markdown, return the formatted HTML which links to issue pages and usernames
    /// </summary>
    public static string GetChangeLineHTML(string line)
    {
        if (!line.StartsWith("* "))
            throw new InvalidOperationException("expected a change line to start with '* '");
        string html = line;

        // remove '* '
        html = html[2..];

        return html;
    }
}
