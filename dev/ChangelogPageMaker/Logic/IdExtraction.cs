namespace ChangelogPageMaker.Logic;

internal static class IdExtraction
{
    /// <summary>
    /// Given a block of markdown, return the GitHub IDs within it.
    /// GitHub IDs are single words that start with @.
    /// IDs returned do not contain @.
    /// </summary>
    public static string[] GetIDs(string changelog)
    {
        HashSet<string> ids = new();

        string[] flankingText = { ",", "(", ")", ".", ",", "\n", "_" };
        foreach (string flank in flankingText)
        {
            changelog = changelog.Replace(flank, " ");
        }

        foreach (string item in changelog.Split(" "))
        {
            if (item.StartsWith("@"))
            {
                string id = item.Substring(1).Trim();
                ids.Add(id);
            }
        }

        return ids.ToArray();
    }
}
