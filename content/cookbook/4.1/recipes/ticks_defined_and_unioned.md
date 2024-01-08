---
Title: "Manual and Automatic Tick Labels - ScottPlot 4.1 Cookbook"
Description: "Tick positions and labels can be defined manually, but also added alongside automatic tick labels."
Date: 2024-01-07
Version: ScottPlot 4.1.70
URL: /cookbook/4.1/recipes/ticks_defined_and_unioned/
BreadcrumbNames: ["ScottPlot 4.1 Cookbook", "Advanced Axis Features", "Manual and Automatic Tick Labels"]
BreadcrumbUrls: ["/cookbook/4.1/", "/cookbook/4.1/category/advanced-axis-features", "/cookbook/4.1/recipes/ticks_defined_and_unioned/"]
SearchUrl: "/cookbook/4.1/search/"
OgImage: "/cookbook/4.1/images/ticks_defined_and_unioned.png"
---

<h2><a id='manual-and-automatic-tick-labels' href='/cookbook/4.1/recipes/ticks_defined_and_unioned/'>Manual and Automatic Tick Labels</a></h2>

Tick positions and labels can be defined manually, but also added alongside automatic tick labels.

```cs
ScottPlot.Version.ShouldBe(4, 1, 70);
var plt = new ScottPlot.Plot(600, 400);

plt.AddSignal(DataGen.Sin(15), 2);
plt.AddSignal(DataGen.Cos(15), 2);

double[] positions = { Math.PI, 2 * Math.PI };
string[] labels = { "π", "2π" };
plt.XAxis.AutomaticTickPositions(positions, labels);
plt.XAxis.TickDensity(0.5);

plt.SaveFig("ticks_defined_and_unioned.png");
```

<img src='../../images/ticks_defined_and_unioned.png' class='d-block mx-auto my-5' />


