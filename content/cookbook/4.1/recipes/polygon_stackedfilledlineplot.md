---
Title: "Stacked Filled Line Plot - ScottPlot 4.1 Cookbook"
Description: "A stacked filled line plot effect can be achieved by overlapping polygons."
Date: 2024-01-07
Version: ScottPlot 4.1.70
URL: /cookbook/4.1/recipes/polygon_stackedfilledlineplot/
BreadcrumbNames: ["ScottPlot 4.1 Cookbook", "Polygon", "Stacked Filled Line Plot"]
BreadcrumbUrls: ["/cookbook/4.1/", "/cookbook/4.1/category/plottable-polygon", "/cookbook/4.1/recipes/polygon_stackedfilledlineplot/"]
SearchUrl: "/cookbook/4.1/search/"
OgImage: "/cookbook/4.1/images/polygon_stackedfilledlineplot.png"
---

<h2><a id='stacked-filled-line-plot' href='/cookbook/4.1/recipes/polygon_stackedfilledlineplot/'>Stacked Filled Line Plot</a></h2>

A stacked filled line plot effect can be achieved by overlapping polygons.

```cs
ScottPlot.Version.ShouldBe(4, 1, 70);
var plt = new ScottPlot.Plot(600, 400);

// create sample data
double[] xs = { 1, 2, 3, 4 };
double[] ys1 = { 1, 3, 1, 2 };
double[] ys2 = { 3, 7, 3, 1 };
double[] ys3 = { 5, 2, 5, 6 };

// manually stack plots
ys2 = Enumerable.Range(0, ys2.Length).Select(x => ys2[x] + ys1[x]).ToArray();
ys3 = Enumerable.Range(0, ys2.Length).Select(x => ys3[x] + ys2[x]).ToArray();

// pad data to turn a line into a shaded region
xs = Tools.Pad(xs, cloneEdges: true);
ys1 = Tools.Pad(ys1);
ys2 = Tools.Pad(ys2);
ys3 = Tools.Pad(ys3);

// plot the padded data points as polygons
plt.AddPolygon(xs, ys3, lineWidth: 2);
plt.AddPolygon(xs, ys2, lineWidth: 2);
plt.AddPolygon(xs, ys1, lineWidth: 2);

// use tight margins so we don't see the edges of polygons
plt.AxisAuto(0, 0);

plt.SaveFig("polygon_stackedFilledLinePlot.png");
```

<img src='../../images/polygon_stackedfilledlineplot.png' class='d-block mx-auto my-5' />


