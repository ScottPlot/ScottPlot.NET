---
Title: "Default Plot Style - ScottPlot 4.1 Cookbook"
Description: "This example demonstrates the default plot style."
Date: 2024-01-07
Version: ScottPlot 4.1.70
URL: /cookbook/4.1/recipes/style_default/
BreadcrumbNames: ["ScottPlot 4.1 Cookbook", "Style", "Default Plot Style"]
BreadcrumbUrls: ["/cookbook/4.1/", "/cookbook/4.1/category/style", "/cookbook/4.1/recipes/style_default/"]
SearchUrl: "/cookbook/4.1/search/"
OgImage: "/cookbook/4.1/images/style_default.png"
---

<h2><a id='default-plot-style' href='/cookbook/4.1/recipes/style_default/'>Default Plot Style</a></h2>

This example demonstrates the default plot style.

```cs
ScottPlot.Version.ShouldBe(4, 1, 70);
var plt = new ScottPlot.Plot(600, 400);

plt.AddSignal(DataGen.Sin(51));
plt.AddSignal(DataGen.Cos(51));
plt.Title("Default Style");
plt.XLabel("Horizontal Axis");
plt.YLabel("Vertical Axis");

plt.SaveFig("style_Default.png");
```

<img src='../../images/style_default.png' class='d-block mx-auto my-5' />


