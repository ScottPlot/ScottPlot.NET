---
Title: "Customization - ScottPlot 4.1 Cookbook"
Description: "You can customize the colour, cap size, and line width of the error bars."
Date: 12/11/2023 8:04:06 PM
Version: ScottPlot 4.1.69
URL: /cookbook/4.1/recipes/errorbar_customization/
BreadcrumbNames: ["ScottPlot 4.1 Cookbook", "Error Bar", "Customization"]
BreadcrumbUrls: ["/cookbook/4.1/", "/cookbook/4.1/category/plottable-error-bar", "/cookbook/4.1/recipes/errorbar_customization/"]
SearchUrl: "/cookbook/4.1/search/"
OgImage: "/cookbook/4.1/images/errorbar_customization.png"
---

<h2><a href='/cookbook/4.1/recipes/errorbar_customization/'>Customization</a></h2>

You can customize the colour, cap size, and line width of the error bars.

```cs
var plt = new ScottPlot.Plot(600, 400);

Random rand = new Random(0);
int pointCount = 20;

double[] xs = DataGen.Consecutive(pointCount);
double[] ys = DataGen.RandomNormal(rand, pointCount, mean: 20, stdDev: 2);

double[] yErr = DataGen.RandomNormal(rand, pointCount).Select(e => Math.Abs(e)).ToArray();

plt.AddScatter(xs, ys, System.Drawing.Color.Blue, lineStyle: LineStyle.Dot);

var errorBars = plt.AddErrorBars(xs, ys, null, yErr);
errorBars.CapSize = 8;
errorBars.Color = System.Drawing.Color.Green;
errorBars.LineWidth = 3;

plt.SaveFig("errorBar_customization.png");
```

<img src='../../images/errorbar_customization.png' class='d-block mx-auto my-5' />


