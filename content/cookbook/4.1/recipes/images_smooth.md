---
Title: "Image Anti-Aliasing - ScottPlot 4.1 Cookbook"
Description: "Images have an option to enable or disable anti-aliasing"
Date: 12/11/2023 8:04:06 PM
Version: ScottPlot 4.1.69
URL: /cookbook/4.1/recipes/images_smooth/
BreadcrumbNames: ["ScottPlot 4.1 Cookbook", "Image", "Image Anti-Aliasing"]
BreadcrumbUrls: ["/cookbook/4.1/", "/cookbook/4.1/category/plottable-image", "/cookbook/4.1/recipes/images_smooth/"]
SearchUrl: "/cookbook/4.1/search/"
OgImage: "/cookbook/4.1/images/images_smooth.png"
---

<h2><a href='/cookbook/4.1/recipes/images_smooth/'>Image Anti-Aliasing</a></h2>

Images have an option to enable or disable anti-aliasing

```cs
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

<img src='../../images/images_smooth.png' class='d-block mx-auto my-5' />


