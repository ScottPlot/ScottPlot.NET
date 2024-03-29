---
Title: "Image Border - ScottPlot 4.1 Cookbook"
Description: "The borders of images can be customized."
Date: 2024-01-21
Version: ScottPlot 4.1.71
URL: /cookbook/4.1/recipes/image_border/
BreadcrumbNames: ["ScottPlot 4.1 Cookbook", "Image", "Image Border"]
BreadcrumbUrls: ["/cookbook/4.1/", "/cookbook/4.1/category/plottable-image", "/cookbook/4.1/recipes/image_border/"]
SearchUrl: "/cookbook/4.1/search/"
OgImage: "/cookbook/4.1/images/image_border.png"
---

<h2><a id='image-border' href='/cookbook/4.1/recipes/image_border/'>Image Border</a></h2>

The borders of images can be customized.

{{< code-sp4 >}}

```cs
ScottPlot.Version.ShouldBe(4, 1, 71);
var plt = new ScottPlot.Plot(600, 400);

plt.AddSignal(DataGen.Sin(51));
plt.AddSignal(DataGen.Cos(51));

Bitmap monaLisa = DataGen.SampleImage();

var img = plt.AddImage(monaLisa, 10, .5, rotation: 30);
img.BorderColor = Color.Magenta;
img.BorderSize = 5;

plt.SaveFig("image_border.png");
```

{{< /code-sp4 >}}

<img src='../../images/image_border.png' class='d-block mx-auto my-5' />


