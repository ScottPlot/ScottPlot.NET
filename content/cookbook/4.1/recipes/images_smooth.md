---
Title: "Image Anti-Aliasing - ScottPlot 4.1 Cookbook"
Description: "Images have an option to enable or disable anti-aliasing"
Date: 2024-01-21
Version: ScottPlot 4.1.71
URL: /cookbook/4.1/recipes/images_smooth/
BreadcrumbNames: ["ScottPlot 4.1 Cookbook", "Image", "Image Anti-Aliasing"]
BreadcrumbUrls: ["/cookbook/4.1/", "/cookbook/4.1/category/plottable-image", "/cookbook/4.1/recipes/images_smooth/"]
SearchUrl: "/cookbook/4.1/search/"
OgImage: "/cookbook/4.1/images/images_smooth.png"
---

<h2><a id='image-anti-aliasing' href='/cookbook/4.1/recipes/images_smooth/'>Image Anti-Aliasing</a></h2>

Images have an option to enable or disable anti-aliasing

{{< code-sp4 >}}

```cs
ScottPlot.Version.ShouldBe(4, 1, 71);
var plt = new ScottPlot.Plot(600, 400);

Bitmap bmp = DataGen.SampleImage();
var imgTop = plt.AddImage(bmp, 0, 2.2);
imgTop.HeightInAxisUnits = 1;
imgTop.WidthInAxisUnits = 30;
imgTop.AntiAlias = true;

var imgBottom = plt.AddImage(bmp, 0, 1.0);
imgBottom.HeightInAxisUnits = 1;
imgBottom.WidthInAxisUnits = 30;
imgBottom.AntiAlias = false;

plt.SaveFig("images_smooth.png");
```

{{< /code-sp4 >}}

<img src='../../images/images_smooth.png' class='d-block mx-auto my-5' />


