---
Title: "Black Style - ScottPlot 4.1 Cookbook"
Description: "Customize many plot features using style presets"
Date: 2023-12-28
Version: ScottPlot 4.1.70
URL: /cookbook/4.1/recipes/style_black/
BreadcrumbNames: ["ScottPlot 4.1 Cookbook", "Style", "Black Style"]
BreadcrumbUrls: ["/cookbook/4.1/", "/cookbook/4.1/category/style", "/cookbook/4.1/recipes/style_black/"]
SearchUrl: "/cookbook/4.1/search/"
OgImage: "/cookbook/4.1/images/style_black.png"
---

<h2><a id='black-style' href='/cookbook/4.1/recipes/style_black/'>Black Style</a></h2>

Customize many plot features using style presets

```cs
var plt = new ScottPlot.Plot(600, 400);

plt.AddSignal(DataGen.Sin(51));
plt.AddSignal(DataGen.Cos(51));

plt.Style(Style.Black);
plt.Title("Style.Black");
plt.XLabel("Horizontal Axis");
plt.YLabel("Vertical Axis");

plt.SaveFig("style_Black.png");
```

<img src='../../images/style_black.png' class='d-block mx-auto my-5' />


