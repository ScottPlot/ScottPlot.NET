---
Title: "Image Scaling - ScottPlot 4.1 Cookbook"
Description: "Size of the image (in relative pixel units) can be adjusted."
Date: 2024-01-21
Version: ScottPlot 4.1.71
URL: /cookbook/4.1/recipes/image_scaling/
BreadcrumbNames: ["ScottPlot 4.1 Cookbook", "Image", "Image Scaling"]
BreadcrumbUrls: ["/cookbook/4.1/", "/cookbook/4.1/category/plottable-image", "/cookbook/4.1/recipes/image_scaling/"]
SearchUrl: "/cookbook/4.1/search/"
OgImage: "/cookbook/4.1/images/image_scaling.png"
---

<h2><a id='image-scaling' href='/cookbook/4.1/recipes/image_scaling/'>Image Scaling</a></h2>

Size of the image (in relative pixel units) can be adjusted.

{{< code-sp4 >}}

```cs
ScottPlot.Version.ShouldBe(4, 1, 71);
var plt = new ScottPlot.Plot(600, 400);

plt.AddSignal(DataGen.Sin(51));
plt.AddSignal(DataGen.Cos(51));

Bitmap monaLisa = DataGen.SampleImage();

plt.AddImage(monaLisa, 5, .5);
plt.AddImage(monaLisa, 15, .5, scale: .5);
plt.AddImage(monaLisa, 30, .5, scale: 2);

plt.SaveFig("image_scaling.png");
```

{{< /code-sp4 >}}

<img src='../../images/image_scaling.png' class='d-block mx-auto my-5' />


