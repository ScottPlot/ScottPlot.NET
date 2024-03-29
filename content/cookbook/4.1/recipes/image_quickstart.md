---
Title: "Image Quickstart - ScottPlot 4.1 Cookbook"
Description: "The Image plottable places a Bitmap at coordinte in axis space."
Date: 2024-01-21
Version: ScottPlot 4.1.71
URL: /cookbook/4.1/recipes/image_quickstart/
BreadcrumbNames: ["ScottPlot 4.1 Cookbook", "Image", "Image Quickstart"]
BreadcrumbUrls: ["/cookbook/4.1/", "/cookbook/4.1/category/plottable-image", "/cookbook/4.1/recipes/image_quickstart/"]
SearchUrl: "/cookbook/4.1/search/"
OgImage: "/cookbook/4.1/images/image_quickstart.png"
---

<h2><a id='image-quickstart' href='/cookbook/4.1/recipes/image_quickstart/'>Image Quickstart</a></h2>

The Image plottable places a Bitmap at coordinte in axis space.

{{< code-sp4 >}}

```cs
ScottPlot.Version.ShouldBe(4, 1, 71);
var plt = new ScottPlot.Plot(600, 400);

plt.AddSignal(DataGen.Sin(51));
plt.AddSignal(DataGen.Cos(51));

Bitmap monaLisa = DataGen.SampleImage();

plt.AddImage(monaLisa, 10, .5);

plt.SaveFig("image_quickstart.png");
```

{{< /code-sp4 >}}

<img src='../../images/image_quickstart.png' class='d-block mx-auto my-5' />


