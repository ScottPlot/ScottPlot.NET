---
Title: "Gray1 Style - ScottPlot 4.1 Cookbook"
Description: "Customize many plot features using style presets"
Date: 2023-12-24
Version: ScottPlot 4.1.69
URL: /cookbook/4.1/recipes/style_gray1/
BreadcrumbNames: ["ScottPlot 4.1 Cookbook", "Style", "Gray1 Style"]
BreadcrumbUrls: ["/cookbook/4.1/", "/cookbook/4.1/category/style", "/cookbook/4.1/recipes/style_gray1/"]
SearchUrl: "/cookbook/4.1/search/"
OgImage: "/cookbook/4.1/images/style_gray1.png"
---

<h2><a id='gray1-style' href='/cookbook/4.1/recipes/style_gray1/'>Gray1 Style</a></h2>

Customize many plot features using style presets

```cs
var plt = new ScottPlot.Plot(600, 400);

plt.AddSignal(DataGen.Sin(51));
plt.AddSignal(DataGen.Cos(51));

plt.Style(Style.Gray1);
plt.Title("Style.Gray1");
plt.XLabel("Horizontal Axis");
plt.YLabel("Vertical Axis");

plt.SaveFig("style_Gray1.png");
```

<img src='../../images/style_gray1.png' class='d-block mx-auto my-5' />


