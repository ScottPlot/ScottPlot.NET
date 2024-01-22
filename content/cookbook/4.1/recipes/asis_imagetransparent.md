---
Title: "Transparent Images Axis Labels - ScottPlot 4.1 Cookbook"
Description: "Transparency in PNGs is respected, but JPEG files do not support transparency."
Date: 2024-01-21
Version: ScottPlot 4.1.71
URL: /cookbook/4.1/recipes/asis_imagetransparent/
BreadcrumbNames: ["ScottPlot 4.1 Cookbook", "Advanced Axis Features", "Transparent Images Axis Labels"]
BreadcrumbUrls: ["/cookbook/4.1/", "/cookbook/4.1/category/advanced-axis-features", "/cookbook/4.1/recipes/asis_imagetransparent/"]
SearchUrl: "/cookbook/4.1/search/"
OgImage: "/cookbook/4.1/images/asis_imagetransparent.png"
---

<h2><a id='transparent-images-axis-labels' href='/cookbook/4.1/recipes/asis_imagetransparent/'>Transparent Images Axis Labels</a></h2>

Transparency in PNGs is respected, but JPEG files do not support transparency.

{{< code-sp4 >}}

```cs
ScottPlot.Version.ShouldBe(4, 1, 71);
var plt = new ScottPlot.Plot(600, 400);

plt.Style(Style.Light2);
plt.AddSignal(DataGen.Sin(51));
plt.AddSignal(DataGen.Cos(51));

// vertical axis label uses a transparent PNG
plt.YAxis.ImageLabel(new Bitmap("Images/d_theta_dt.png"));

// horizontal axis label uses a non-transparent JPEG
plt.XAxis.ImageLabel(new Bitmap("Images/theta.jpg"));

plt.SaveFig("asis_imageTransparent.png");
```

{{< /code-sp4 >}}

<img src='../../images/asis_imagetransparent.png' class='d-block mx-auto my-5' />


