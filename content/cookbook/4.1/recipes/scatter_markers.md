---
Title: "Custom markers - ScottPlot 4.1 Cookbook"
Description: "Markers can be customized using optional arguments and public fields."
Date: 12/11/2023 7:52:02 PM
Version: ScottPlot 4.1.69
URL: /cookbook/4.1/recipes/scatter_markers/
BreadcrumbNames: ["ScottPlot 4.1 Cookbook", "Scatter Plot", "Custom markers"]
BreadcrumbUrls: ["/cookbook/4.1/", "/cookbook/4.1/category/plottable-scatter-plot", "/cookbook/4.1/recipes/scatter_markers/"]
SearchUrl: "/cookbook/4.1/search/"
OgImage: "/cookbook/4.1/images/scatter_markers.png"
---

<h2><a href='/cookbook/4.1/recipes/scatter_markers/'>Custom markers</a></h2>

Markers can be customized using optional arguments and public fields.

```cs
var plt = new ScottPlot.Plot(600, 400);

int pointCount = 51;
double[] x = DataGen.Consecutive(pointCount);
double[] sin = DataGen.Sin(pointCount);
double[] cos = DataGen.Cos(pointCount);

// add scatter plots and customize markers
var sp1 = plt.AddScatter(x, sin, markerSize: 15);
sp1.MarkerShape = MarkerShape.openCircle;

var sp2 = plt.AddScatter(x, cos, markerSize: 7);
sp2.MarkerShape = MarkerShape.filledSquare;

plt.SaveFig("scatter_markers.png");
```

<img src='../../images/scatter_markers.png' class='d-block mx-auto my-5' />


