---
Title: "Blue1 Style - ScottPlot 4.1 Cookbook"
Description: "Customize many plot features using style presets"
Date: 2023-12-24
Version: ScottPlot 4.1.69
URL: /cookbook/4.1/recipes/style_blue1/
BreadcrumbNames: ["ScottPlot 4.1 Cookbook", "Style", "Blue1 Style"]
BreadcrumbUrls: ["/cookbook/4.1/", "/cookbook/4.1/category/style", "/cookbook/4.1/recipes/style_blue1/"]
SearchUrl: "/cookbook/4.1/search/"
OgImage: "/cookbook/4.1/images/style_blue1.png"
---

<h2><a id='blue1-style' href='/cookbook/4.1/recipes/style_blue1/'>Blue1 Style</a></h2>

Customize many plot features using style presets

```cs
var plt = new ScottPlot.Plot(600, 400);

plt.AddSignal(DataGen.Sin(51));
plt.AddSignal(DataGen.Cos(51));

plt.Style(Style.Blue1);
plt.Title("Style.Blue1");
plt.XLabel("Horizontal Axis");
plt.YLabel("Vertical Axis");

plt.SaveFig("style_blue1.png");
```

<img src='../../images/style_blue1.png' class='d-block mx-auto my-5' />


