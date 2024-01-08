---
Title: "Crosshair - ScottPlot 4.1 Cookbook"
Description: "The Crosshair plot type draws vertical and horizontal lines that intersect at a point on the plot and the coordinates of those lines are displayed on top of the axis ticks. This plot type is typically updated after MouseMove events to track the mouse"
Date: 2024-01-07
Version: ScottPlot 4.1.70
URL: /cookbook/4.1/recipes/crosshair_quickstart/
BreadcrumbNames: ["ScottPlot 4.1 Cookbook", "Crosshair", "Crosshair"]
BreadcrumbUrls: ["/cookbook/4.1/", "/cookbook/4.1/category/plottable-crosshair", "/cookbook/4.1/recipes/crosshair_quickstart/"]
SearchUrl: "/cookbook/4.1/search/"
OgImage: "/cookbook/4.1/images/crosshair_quickstart.png"
---

<h2><a id='crosshair' href='/cookbook/4.1/recipes/crosshair_quickstart/'>Crosshair</a></h2>

The Crosshair plot type draws vertical and horizontal lines that intersect at a point on the plot and the coordinates of those lines are displayed on top of the axis ticks. This plot type is typically updated after MouseMove events to track the mouse

```cs
ScottPlot.Version.ShouldBe(4, 1, 70);
var plt = new ScottPlot.Plot(600, 400);

plt.AddSignal(ScottPlot.DataGen.Sin(51));
plt.AddSignal(ScottPlot.DataGen.Cos(51));
plt.AddCrosshair(42, 0.48);

plt.Title("Crosshair Demo");
plt.XLabel("Horizontal Axis");
plt.YLabel("Vertical Axis");

plt.SaveFig("crosshair_quickstart.png");
```

<img src='../../images/crosshair_quickstart.png' class='d-block mx-auto my-5' />


