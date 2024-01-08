---
Title: "No Axis Lines - ScottPlot 4.1 Cookbook"
Description: "A radar chart can have no drawn axis as well."
Date: 2024-01-07
Version: ScottPlot 4.1.70
URL: /cookbook/4.1/recipes/radar_nolines/
BreadcrumbNames: ["ScottPlot 4.1 Cookbook", "Radar Chart", "No Axis Lines"]
BreadcrumbUrls: ["/cookbook/4.1/", "/cookbook/4.1/category/plottable-radar", "/cookbook/4.1/recipes/radar_nolines/"]
SearchUrl: "/cookbook/4.1/search/"
OgImage: "/cookbook/4.1/images/radar_nolines.png"
---

<h2><a id='no-axis-lines' href='/cookbook/4.1/recipes/radar_nolines/'>No Axis Lines</a></h2>

A radar chart can have no drawn axis as well.

```cs
ScottPlot.Version.ShouldBe(4, 1, 70);
var plt = new ScottPlot.Plot(600, 400);

double[,] values = {
        { 78, 83, 84, 76, 43 },
        { 100, 50, 70, 60, 90 }
    };

var radarPlot = plt.AddRadar(values);
radarPlot.AxisType = RadarAxis.None;
radarPlot.ShowAxisValues = false;

plt.SaveFig("radar_noLines.png");
```

<img src='../../images/radar_nolines.png' class='d-block mx-auto my-5' />


