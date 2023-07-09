namespace ChangelogPageMaker;

internal class AvatarCollection
{
    public readonly Dictionary<string, string> ImageFilenames = new();
    public readonly string ImageFolder;

    public AvatarCollection(string thumbnailFolder)
    {
        ImageFolder = thumbnailFolder;

        if (!Directory.Exists(thumbnailFolder))
            throw new DirectoryNotFoundException(thumbnailFolder);

        foreach (string file in Directory.GetFiles(thumbnailFolder, "*.*"))
        {
            string id = Path.GetFileNameWithoutExtension(file).ToLowerInvariant();
            ImageFilenames.Add(id, Path.GetFileName(file));
        }
    }

    public string GetImage(string id)
    {
        if (ImageFilenames.TryGetValue(id.ToLower(), out var image))
        {
            return $"https://scottplot.net/images/contributors/{image}";
        }
        else
        {
            return $"https://scottplot.net/images/brand/favicon.png";
        }
    }

    public void DownloadMissingImages(string[] ids, int max = 50)
    {
        var idsWithoutImages = ids.Where(x => !ImageFilenames.ContainsKey(x.ToLowerInvariant()));

        if (!idsWithoutImages.Any())
        {
            Console.WriteLine($"Located saved avatars for all {idsWithoutImages.Count()} contributors.");
            return;
        }

        string missingIDs = string.Join(", ", idsWithoutImages);
        Console.WriteLine($"Found {idsWithoutImages.Count()} IDs without images: {missingIDs}");
        var idsToDownload = idsWithoutImages.Take(max);
        Console.WriteLine($"Downloading {idsToDownload.Count()} images...");

        Parallel.ForEach(idsToDownload, DownloadMissingImage);
    }

    private static string GetExtension(byte[] bytes)
    {
        string magicHex = string.Join(" ", bytes.Take(5).Select(x => x.ToString("x2")));

        if (magicHex.StartsWith("ff d8 ff"))
        {
            return "jpg";
        }

        if (magicHex.StartsWith("89 50 4e 47"))
        {
            return "png";
        }

        throw new InvalidDataException($"unknown magic number: {magicHex}");
    }

    private void DownloadMissingImage(string id)
    {
        int size = 125;
        string url = $"https://github.com/{id}.png?size={size}";

        using HttpClient client = new();
        using HttpResponseMessage response = client.GetAsync(url).Result;
        if (response.StatusCode != System.Net.HttpStatusCode.OK)
        {
            string message = $"image download for '{id}' failed: {response.StatusCode}";
            Console.WriteLine(message);
            throw new InvalidOperationException(message);
        }

        using HttpContent content = response.Content;
        byte[] bytes = content.ReadAsByteArrayAsync().Result;

        string basename = id.ToLowerInvariant();
        string extension = GetExtension(bytes);
        string filename = $"{basename}.{extension}";
        string saveAs = Path.Combine(ImageFolder, filename);
        File.WriteAllBytes(saveAs, bytes);
        Console.WriteLine($"Saved: {saveAs}");
    }
}
