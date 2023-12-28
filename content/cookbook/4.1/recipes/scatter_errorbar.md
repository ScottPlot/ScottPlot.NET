---
Title: "Scatter Plot with Errorbars - ScottPlot 4.1 Cookbook"
Description: "An array of values can be supplied for error bars and redering options can be customized as desired"
Date: 2023-12-28
Version: ScottPlot 4.1.70
URL: /cookbook/4.1/recipes/scatter_errorbar/
BreadcrumbNames: ["ScottPlot 4.1 Cookbook", "Scatter Plot", "Scatter Plot with Errorbars"]
BreadcrumbUrls: ["/cookbook/4.1/", "/cookbook/4.1/category/plottable-scatter-plot", "/cookbook/4.1/recipes/scatter_errorbar/"]
SearchUrl: "/cookbook/4.1/search/"
OgImage: "/cookbook/4.1/images/scatter_errorbar.png"
---

<h2><a id='scatter-plot-with-errorbars' href='/cookbook/4.1/recipes/scatter_errorbar/'>Scatter Plot with Errorbars</a></h2>

An array of values can be supplied for error bars and redering options can be customized as desired

```cs
var plt = new ScottPlot.Plot(600, 400);

int pointCount = 20;
Random rand = new Random(0);
double[] xs = DataGen.Consecutive(pointCount);
double[] ys = DataGen.RandomWalk(rand, pointCount);
double[] xErr = DataGen.RandomNormal(rand, pointCount, .2);
double[] yErr = DataGen.RandomNormal(rand, pointCount);

var sp = plt.AddScatter(xs, ys);
sp.XError = xErr;
sp.YError = yErr;
sp.ErrorCapSize = 3;
sp.ErrorLineWidth = 1;
sp.LineStyle = LineStyle.Dot;

plt.SaveFig("scatter_errorbar.png");
```

<img src='../../images/scatter_errorbar.png' class='d-block mx-auto my-5' />


