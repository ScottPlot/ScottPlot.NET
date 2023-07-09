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

    public void DownloadMissingImages(string[] ids, int max = 50, bool parallel = false)
    {
        var idsWithoutImages = ids.Where(x => !ImageFilenames.ContainsKey(x.ToLowerInvariant()));
        Console.WriteLine($"Found {idsWithoutImages.Count()} IDs without images");

        var idsToDownload = idsWithoutImages.Take(max);
        Console.WriteLine($"Downloading {idsToDownload.Count()} images...");

        if (parallel)
        {
            Parallel.ForEach(idsToDownload, DownloadMissingImage);
        }
        else
        {
            foreach (string id in idsToDownload)
            {
                DownloadMissingImage(id);
            }
        }
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
        Console.WriteLine($"Downloading: {url}");

        using HttpClient client = new();
        using HttpResponseMessage response = client.GetAsync(url).Result;
        if (response.StatusCode != System.Net.HttpStatusCode.OK)
            throw new InvalidOperationException($"image download failed: {response.StatusCode}");

        using HttpContent content = response.Content;
        byte[] bytes = content.ReadAsByteArrayAsync().Result;

        string basename = id.ToLowerInvariant();
        string extension = GetExtension(bytes);
        string filename = $"{basename}.{extension}";
        string saveAs = Path.Combine(ImageFolder, filename);
        Console.WriteLine($"Saving: {saveAs}");
        File.WriteAllBytes(saveAs, bytes);
    }
}
