---
Title: "Fill Between Curves - ScottPlot 4.1 Cookbook"
Description: "A shaded area between two curves can be created by enclosing the area as a polygon. For this to work the two curves must share the same X points."
Date: 12/11/2023 7:52:02 PM
Version: ScottPlot 4.1.69
URL: /cookbook/4.1/recipes/polygon_fillbetween/
BreadcrumbNames: ["ScottPlot 4.1 Cookbook", "Polygon", "Fill Between Curves"]
BreadcrumbUrls: ["/cookbook/4.1/", "/cookbook/4.1/category/plottable-polygon", "/cookbook/4.1/recipes/polygon_fillbetween/"]
SearchUrl: "/cookbook/4.1/search/"
OgImage: "/cookbook/4.1/images/polygon_fillbetween.png"
---

<h2><a href='/cookbook/4.1/recipes/polygon_fillbetween/'>Fill Between Curves</a></h2>

A shaded area between two curves can be created by enclosing the area as a polygon. For this to work the two curves must share the same X points.

```cs
var plt = new ScottPlot.Plot(600, 400);

Random rand = new(0);
int pointCount = 100;
double[] xs = ScottPlot.DataGen.Consecutive(pointCount);

// plot a shaded region
double[] lower = ScottPlot.DataGen.Sin(pointCount, 5, offset: 3);
double[] upper = ScottPlot.DataGen.Cos(pointCount, 5, offset: -3);
var poly = plt.AddFill(xs, lower, upper);
poly.FillColor = Color.FromArgb(50, Color.Green);

// plot a line within that region
double[] ys = ScottPlot.DataGen.Random(rand, pointCount);
var sig = plt.AddSignal(ys);
sig.Color = plt.Palette.GetColor(0);

plt.Margins(0, .5);

plt.SaveFig("polygon_fillBetween.png");
```

<img src='../../images/polygon_fillbetween.png' class='d-block mx-auto my-5' />


