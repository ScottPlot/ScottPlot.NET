---
Title: "Straight Axis Lines - ScottPlot 4.1 Cookbook"
Description: "Change the axis type to polygon to display radar charts with straight lines."
Date: 2024-01-21
Version: ScottPlot 4.1.71
URL: /cookbook/4.1/recipes/radar_straightlines/
BreadcrumbNames: ["ScottPlot 4.1 Cookbook", "Radar Chart", "Straight Axis Lines"]
BreadcrumbUrls: ["/cookbook/4.1/", "/cookbook/4.1/category/plottable-radar", "/cookbook/4.1/recipes/radar_straightlines/"]
SearchUrl: "/cookbook/4.1/search/"
OgImage: "/cookbook/4.1/images/radar_straightlines.png"
---

<h2><a id='straight-axis-lines' href='/cookbook/4.1/recipes/radar_straightlines/'>Straight Axis Lines</a></h2>

Change the axis type to polygon to display radar charts with straight lines.

{{< code-sp4 >}}

```cs
ScottPlot.Version.ShouldBe(4, 1, 71);
var plt = new ScottPlot.Plot(600, 400);

double[,] values = {
        { 78, 83, 84, 76, 43 },
        { 100, 50, 70, 60, 90 }
    };

var radarPlot = plt.AddRadar(values);
radarPlot.AxisType = RadarAxis.Polygon;

plt.SaveFig("radar_straightLines.png");
```

{{< /code-sp4 >}}

<img src='../../images/radar_straightlines.png' class='d-block mx-auto my-5' />


