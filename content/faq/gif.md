---
Title: Animated GIF Plot - ScottPlot FAQ
Description: How to create an animated GIF from a series of ScottPlot plots
date: 2024-10-18
---

## Animated GIF Plot

Animated GIFs can be created from ScottPlot plots!

![](/images/faq/gif/animated.gif)

This example requires these NuGet packages:
* [`ScottPlot`](https://www.nuget.org/packages/ScottPlot)
* [`Magick.NET-Q16-AnyCPU`](https://www.nuget.org/packages/Magick.NET-Q16-AnyCPU)

```cs
using ImageMagick;

using (var collection = new MagickImageCollection())
{
    ScottPlot.Plot plot = new();
    for (int i = 1; i <= 10; i++)
    {
        double[] values = ScottPlot.Generate.Sin(100, phase: -i * .05);
        plot.Add.Signal(values);
        byte[] bytes = plot.GetImageBytes(400, 300);
        MagickImage image = new(bytes) { AnimationDelay = 20 };
        collection.Add(image);
    }

    collection.Optimize();

    using var outputStream = new MemoryStream();
    collection.Write(outputStream, MagickFormat.Gif);
    byte[] gifBytes = outputStream.ToArray();
    File.WriteAllBytes("animated.gif", gifBytes);
}
```