---
Title: "Filled Line Plot - ScottPlot 4.1 Cookbook"
Description: "Polygons can be used to create 2D shapes resembling filled line plots. When mixed with semitransprent fills, these can be useful for displaying data."
Date: 2023-12-24
Version: ScottPlot 4.1.69
URL: /cookbook/4.1/recipes/polygon_filledlineplot/
BreadcrumbNames: ["ScottPlot 4.1 Cookbook", "Polygon", "Filled Line Plot"]
BreadcrumbUrls: ["/cookbook/4.1/", "/cookbook/4.1/category/plottable-polygon", "/cookbook/4.1/recipes/polygon_filledlineplot/"]
SearchUrl: "/cookbook/4.1/search/"
OgImage: "/cookbook/4.1/images/polygon_filledlineplot.png"
---

<h2><a id='filled-line-plot' href='/cookbook/4.1/recipes/polygon_filledlineplot/'>Filled Line Plot</a></h2>

Polygons can be used to create 2D shapes resembling filled line plots. When mixed with semitransprent fills, these can be useful for displaying data.

```cs
var plt = new ScottPlot.Plot(600, 400);

// create sample data
double[] xs = { 1, 2, 3, 4 };
double[] ys1 = { 1, 3, 1, 2 };
double[] ys2 = { 3, 7, 3, 1 };
double[] ys3 = { 5, 2, 5, 6 };

// pad data to turn a line into a shaded region
xs = Tools.Pad(xs, cloneEdges: true);
ys1 = Tools.Pad(ys1);
ys2 = Tools.Pad(ys2);
ys3 = Tools.Pad(ys3);

// plot the padded data points as polygons
plt.AddPolygon(xs, ys3, plt.GetNextColor(.7), lineWidth: 2);
plt.AddPolygon(xs, ys2, plt.GetNextColor(.7), lineWidth: 2);
plt.AddPolygon(xs, ys1, plt.GetNextColor(.7), lineWidth: 2);

// use tight margins so we don't see the edges of polygons
plt.AxisAuto(0, 0);

plt.SaveFig("polygon_filledLinePlot.png");
```

<img src='../../images/polygon_filledlineplot.png' class='d-block mx-auto my-5' />


