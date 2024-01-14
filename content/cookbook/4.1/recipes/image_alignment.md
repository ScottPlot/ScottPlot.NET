---
Title: "Image Alignment - ScottPlot 4.1 Cookbook"
Description: "By default the X/Y coordinates define the upper left position of the image, but alignment can be customized by defining the anchor."
Date: 2024-01-14
Version: ScottPlot 4.1.70
URL: /cookbook/4.1/recipes/image_alignment/
BreadcrumbNames: ["ScottPlot 4.1 Cookbook", "Image", "Image Alignment"]
BreadcrumbUrls: ["/cookbook/4.1/", "/cookbook/4.1/category/plottable-image", "/cookbook/4.1/recipes/image_alignment/"]
SearchUrl: "/cookbook/4.1/search/"
OgImage: "/cookbook/4.1/images/image_alignment.png"
---

<h2><a id='image-alignment' href='/cookbook/4.1/recipes/image_alignment/'>Image Alignment</a></h2>

By default the X/Y coordinates define the upper left position of the image, but alignment can be customized by defining the anchor.

{{< code-sp4 >}}

```cs
ScottPlot.Version.ShouldBe(4, 1, 70);
var plt = new ScottPlot.Plot(600, 400);

plt.AddSignal(DataGen.Sin(51));
plt.AddSignal(DataGen.Cos(51));

Bitmap monaLisa = DataGen.SampleImage();

plt.AddImage(monaLisa, 10, 0);
plt.AddPoint(10, 0, Color.Magenta, size: 20);

plt.AddImage(monaLisa, 25, 0, anchor: Alignment.MiddleCenter);
plt.AddPoint(25, 0, Color.Magenta, size: 20);

plt.AddImage(monaLisa, 40, 0, anchor: Alignment.LowerRight);
plt.AddPoint(40, 0, Color.Magenta, size: 20);

plt.SaveFig("image_alignment.png");
```

{{< /code-sp4 >}}

<img src='../../images/image_alignment.png' class='d-block mx-auto my-5' />


