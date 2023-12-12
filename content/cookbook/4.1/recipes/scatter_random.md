---
Title: "Random X/Y Points - ScottPlot 4.1 Cookbook"
Description: "X data for scatter plots does not have to be evenly spaced, making scatter plots are ideal for displaying random data like this."
Date: 12/11/2023 7:52:02 PM
Version: ScottPlot 4.1.69
URL: /cookbook/4.1/recipes/scatter_random/
BreadcrumbNames: ["ScottPlot 4.1 Cookbook", "Scatter Plot", "Random X/Y Points"]
BreadcrumbUrls: ["/cookbook/4.1/", "/cookbook/4.1/category/plottable-scatter-plot", "/cookbook/4.1/recipes/scatter_random/"]
SearchUrl: "/cookbook/4.1/search/"
OgImage: "/cookbook/4.1/images/scatter_random.png"
---

<h2><a href='/cookbook/4.1/recipes/scatter_random/'>Random X/Y Points</a></h2>

X data for scatter plots does not have to be evenly spaced, making scatter plots are ideal for displaying random data like this.

```cs
var plt = new ScottPlot.Plot(600, 400);

Random rand = new Random(0);
int pointCount = 51;
double[] xs1 = DataGen.RandomNormal(rand, pointCount, 1);
double[] xs2 = DataGen.RandomNormal(rand, pointCount, 3);
double[] ys1 = DataGen.RandomNormal(rand, pointCount, 5);
double[] ys2 = DataGen.RandomNormal(rand, pointCount, 7);

plt.AddScatter(xs1, ys1, markerSize: 0, label: "lines only");
plt.AddScatter(xs2, ys2, lineWidth: 0, label: "markers only");
plt.Legend();

plt.SaveFig("scatter_random.png");
```

<img src='../../images/scatter_random.png' class='d-block mx-auto my-5' />


