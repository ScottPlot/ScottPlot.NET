---
Title: "Spline Interpolation - ScottPlot 4.1 Cookbook"
Description: "Interpolated splines create curves with many X/Y points to smoothly connect a limited number of input points."
Date: 2023-12-28
Version: ScottPlot 4.1.70
URL: /cookbook/4.1/recipes/misc_interpolation/
BreadcrumbNames: ["ScottPlot 4.1 Cookbook", "Miscellaneous", "Spline Interpolation"]
BreadcrumbUrls: ["/cookbook/4.1/", "/cookbook/4.1/category/misc", "/cookbook/4.1/recipes/misc_interpolation/"]
SearchUrl: "/cookbook/4.1/search/"
OgImage: "/cookbook/4.1/images/misc_interpolation.png"
---

<h2><a id='spline-interpolation' href='/cookbook/4.1/recipes/misc_interpolation/'>Spline Interpolation</a></h2>

Interpolated splines create curves with many X/Y points to smoothly connect a limited number of input points.

```cs
var plt = new ScottPlot.Plot(600, 400);

// create a small number of X/Y data points and display them
Random rand = new(1234);
double[] xs = DataGen.RandomWalk(rand, 20);
double[] ys = DataGen.RandomWalk(rand, 20);

// interpolate the data to create a smooth curve
(double[] smoothXs, double[] smoothYs) = ScottPlot.Statistics.Interpolation.Cubic.InterpolateXY(xs, ys, 200);

// plot the original vs interpolated lines
plt.AddScatter(xs, ys, Color.Green, markerSize: 10, lineWidth: 1, label: "Original");
plt.AddScatter(smoothXs, smoothYs, Color.Magenta, label: "Interpolated");
plt.Legend();

plt.SaveFig("misc_interpolation.png");
```

<img src='../../images/misc_interpolation.png' class='d-block mx-auto my-5' />


