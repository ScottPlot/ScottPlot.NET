---
Title: "Spline Interpolation Types - ScottPlot 4.1 Cookbook"
Description: "Different methods are available for smoothing data using interpolation, curve fitting, or corner cutting. Notice that some methods produce curves which pass through the original data points and others do not."
Date: 2023-12-13
Version: ScottPlot 4.1.69
URL: /cookbook/4.1/recipes/misc_interpolation_types/
BreadcrumbNames: ["ScottPlot 4.1 Cookbook", "Miscellaneous", "Spline Interpolation Types"]
BreadcrumbUrls: ["/cookbook/4.1/", "/cookbook/4.1/category/misc", "/cookbook/4.1/recipes/misc_interpolation_types/"]
SearchUrl: "/cookbook/4.1/search/"
OgImage: "/cookbook/4.1/images/misc_interpolation_types.png"
---

<h2><a id='spline-interpolation-types' href='/cookbook/4.1/recipes/misc_interpolation_types/'>Spline Interpolation Types</a></h2>

Different methods are available for smoothing data using interpolation, curve fitting, or corner cutting. Notice that some methods produce curves which pass through the original data points and others do not.

```cs
var plt = new ScottPlot.Plot(600, 400);

plt.Palette = ScottPlot.Palette.ColorblindFriendly;

// generate random data
System.Random rand = new(12345);
var xs = ScottPlot.DataGen.RandomWalk(rand, 20);
var ys = ScottPlot.DataGen.RandomWalk(rand, 20);
plt.AddScatter(xs, ys, lineStyle: ScottPlot.LineStyle.Dash, markerSize: 10, label: "original");

// interpolate the same data in different ways
(double[] bzX, double[] bzY) = ScottPlot.Statistics.Interpolation.Bezier.InterpolateXY(xs, ys, .005);
(double[] crX, double[] crY) = ScottPlot.Statistics.Interpolation.CatmullRom.InterpolateXY(xs, ys, 15);
(double[] chX, double[] chY) = ScottPlot.Statistics.Interpolation.Chaikin.InterpolateXY(xs, ys, 4);
(double[] cbX, double[] cbY) = ScottPlot.Statistics.Interpolation.Cubic.InterpolateXY(xs, ys, 200);

// display the different curves as line plots
plt.AddScatterLines(bzX, bzY, lineWidth: 2, label: $"Bezier");
plt.AddScatterLines(crX, crY, lineWidth: 2, label: $"Catmull-Rom");
plt.AddScatterLines(chX, chY, lineWidth: 2, label: $"Chaikin");
plt.AddScatterLines(cbX, cbY, lineWidth: 2, label: $"Cubic");

// style the plot
plt.Legend();
plt.Frameless();
plt.Grid(false);
plt.XAxis2.Label("Spline Interpolation", size: 28, bold: true);

plt.SaveFig("misc_interpolation_types.png");
```

<img src='../../images/misc_interpolation_types.png' class='d-block mx-auto my-5' />


