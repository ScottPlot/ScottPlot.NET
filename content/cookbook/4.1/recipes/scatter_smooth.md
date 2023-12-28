---
Title: "Scatter Plot with Smooth Lines - ScottPlot 4.1 Cookbook"
Description: "Lines drawn between scatter plot points are typically connected with straight lines, but the Smooth property can be enabled to connect points with curves instead."
Date: 2023-12-28
Version: ScottPlot 4.1.70
URL: /cookbook/4.1/recipes/scatter_smooth/
BreadcrumbNames: ["ScottPlot 4.1 Cookbook", "Scatter Plot", "Scatter Plot with Smooth Lines"]
BreadcrumbUrls: ["/cookbook/4.1/", "/cookbook/4.1/category/plottable-scatter-plot", "/cookbook/4.1/recipes/scatter_smooth/"]
SearchUrl: "/cookbook/4.1/search/"
OgImage: "/cookbook/4.1/images/scatter_smooth.png"
---

<h2><a id='scatter-plot-with-smooth-lines' href='/cookbook/4.1/recipes/scatter_smooth/'>Scatter Plot with Smooth Lines</a></h2>

Lines drawn between scatter plot points are typically connected with straight lines, but the Smooth property can be enabled to connect points with curves instead.

```cs
var plt = new ScottPlot.Plot(600, 400);

Random rand = new(1234);
double[] xs = DataGen.RandomWalk(rand, 20);
double[] ys = DataGen.RandomWalk(rand, 20);
plt.Palette = new ScottPlot.Palettes.ColorblindFriendly();

var sp1 = plt.AddScatter(xs, ys, label: "default");
sp1.Smooth = true;

var sp2 = plt.AddScatter(xs, ys, label: "high tension");
sp2.Smooth = true;
sp2.SmoothTension = 1.0f;

var sp3 = plt.AddScatter(xs, ys, label: "low tension");
sp3.Smooth = true;
sp3.SmoothTension = 0.2f;

plt.Legend();

plt.SaveFig("scatter_smooth.png");
```

<img src='../../images/scatter_smooth.png' class='d-block mx-auto my-5' />


