---
Title: "Monospace Style - ScottPlot 4.1 Cookbook"
Description: "Customize many plot features using style presets"
Date: 12/11/2023 8:13:09 PM
Version: ScottPlot 4.1.69
URL: /cookbook/4.1/recipes/style_monospace/
BreadcrumbNames: ["ScottPlot 4.1 Cookbook", "Style", "Monospace Style"]
BreadcrumbUrls: ["/cookbook/4.1/", "/cookbook/4.1/category/style", "/cookbook/4.1/recipes/style_monospace/"]
SearchUrl: "/cookbook/4.1/search/"
OgImage: "/cookbook/4.1/images/style_monospace.png"
---

<h2><a id='monospace-style' href='/cookbook/4.1/recipes/style_monospace/'>Monospace Style</a></h2>

Customize many plot features using style presets

```cs
var plt = new ScottPlot.Plot(600, 400);

plt.AddSignal(DataGen.Sin(51));
plt.AddSignal(DataGen.Cos(51));

plt.Style(Style.Monospace);
plt.Title("Style.Monospace");
plt.XLabel("Horizontal Axis");
plt.YLabel("Vertical Axis");

plt.SaveFig("style_monospace.png");
```

<img src='../../images/style_monospace.png' class='d-block mx-auto my-5' />


