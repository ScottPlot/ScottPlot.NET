---
Title: "Rotated Y Ticks - ScottPlot 4.1 Cookbook"
Description: "Vertical tick labels can be rotated as desired."
Date: 2024-01-07
Version: ScottPlot 4.1.70
URL: /cookbook/4.1/recipes/ticks_rotatedy/
BreadcrumbNames: ["ScottPlot 4.1 Cookbook", "Axis and Ticks", "Rotated Y Ticks"]
BreadcrumbUrls: ["/cookbook/4.1/", "/cookbook/4.1/category/axis-and-ticks", "/cookbook/4.1/recipes/ticks_rotatedy/"]
SearchUrl: "/cookbook/4.1/search/"
OgImage: "/cookbook/4.1/images/ticks_rotatedy.png"
---

<h2><a id='rotated-y-ticks' href='/cookbook/4.1/recipes/ticks_rotatedy/'>Rotated Y Ticks</a></h2>

Vertical tick labels can be rotated as desired.

```cs
ScottPlot.Version.ShouldBe(4, 1, 70);
var plt = new ScottPlot.Plot(600, 400);

// plot sample data
plt.AddSignal(DataGen.Sin(51));
plt.AddSignal(DataGen.Cos(51));
plt.XAxis.Label("Horizontal Axis");
plt.YAxis.Label("Vertical Axis");

// rotate horizontal axis tick labels
plt.YAxis.TickLabelStyle(rotation: 45);

plt.SaveFig("ticks_rotatedY.png");
```

<img src='../../images/ticks_rotatedy.png' class='d-block mx-auto my-5' />


