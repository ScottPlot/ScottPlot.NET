---
Title: "Custom lines - ScottPlot 4.1 Cookbook"
Description: "Line color, size, and style can be customized. Setting markerSize to 0 prevents markers from being rendered."
Date: 12/11/2023 7:52:02 PM
Version: ScottPlot 4.1.69
URL: /cookbook/4.1/recipes/scatter_linestyle/
BreadcrumbNames: ["ScottPlot 4.1 Cookbook", "Scatter Plot", "Custom lines"]
BreadcrumbUrls: ["/cookbook/4.1/", "/cookbook/4.1/category/plottable-scatter-plot", "/cookbook/4.1/recipes/scatter_linestyle/"]
SearchUrl: "/cookbook/4.1/search/"
OgImage: "/cookbook/4.1/images/scatter_linestyle.png"
---

<h2><a href='/cookbook/4.1/recipes/scatter_linestyle/'>Custom lines</a></h2>

Line color, size, and style can be customized. Setting markerSize to 0 prevents markers from being rendered.

```cs
var plt = new ScottPlot.Plot(600, 400);

int pointCount = 51;
double[] x = DataGen.Consecutive(pointCount);
double[] sin = DataGen.Sin(pointCount);
double[] cos = DataGen.Cos(pointCount);
double[] cos2 = DataGen.Cos(pointCount, mult: -1);

plt.AddScatter(x, sin, color: Color.Magenta, lineWidth: 0, markerSize: 10);
plt.AddScatter(x, cos, color: Color.Green, lineWidth: 5, markerSize: 0);
plt.AddScatter(x, cos2, color: Color.Blue, lineWidth: 3, markerSize: 0, lineStyle: LineStyle.DashDot);

var legend = plt.Legend();
legend.FixedLineWidth = false;

plt.SaveFig("scatter_lineStyle.png");
```

<img src='../../images/scatter_linestyle.png' class='d-block mx-auto my-5' />


