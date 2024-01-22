---
Title: "Manual Tick Labels - ScottPlot 4.1 Cookbook"
Description: "Tick positions and labels can be defined manually."
Date: 2024-01-21
Version: ScottPlot 4.1.71
URL: /cookbook/4.1/recipes/ticks_defined/
BreadcrumbNames: ["ScottPlot 4.1 Cookbook", "Advanced Axis Features", "Manual Tick Labels"]
BreadcrumbUrls: ["/cookbook/4.1/", "/cookbook/4.1/category/advanced-axis-features", "/cookbook/4.1/recipes/ticks_defined/"]
SearchUrl: "/cookbook/4.1/search/"
OgImage: "/cookbook/4.1/images/ticks_defined.png"
---

<h2><a id='manual-tick-labels' href='/cookbook/4.1/recipes/ticks_defined/'>Manual Tick Labels</a></h2>

Tick positions and labels can be defined manually.

{{< code-sp4 >}}

```cs
ScottPlot.Version.ShouldBe(4, 1, 71);
var plt = new ScottPlot.Plot(600, 400);

// plot sample data
plt.AddSignal(DataGen.Sin(51));
plt.AddSignal(DataGen.Cos(51));

// manually define X axis tick positions and labels
double[] xPositions = { 7, 21, 37, 46 };
string[] xLabels = { "VII", "XXI", "XXXVII", "XLVI" };
plt.XAxis.ManualTickPositions(xPositions, xLabels);

// manually define Y axis tick positions and labels
double[] yPositions = { -1, 0, .5, 1 };
string[] yLabels = { "bottom", "center", "half", "top" };
plt.YAxis.ManualTickPositions(yPositions, yLabels);

plt.SaveFig("ticks_defined.png");
```

{{< /code-sp4 >}}

<img src='../../images/ticks_defined.png' class='d-block mx-auto my-5' />


