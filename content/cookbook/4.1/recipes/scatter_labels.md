---
Title: "Scatter Plot Labels - ScottPlot 4.1 Cookbook"
Description: "Individual points can be labeled."
Date: 2024-01-07
Version: ScottPlot 4.1.70
URL: /cookbook/4.1/recipes/scatter_labels/
BreadcrumbNames: ["ScottPlot 4.1 Cookbook", "Scatter Plot", "Scatter Plot Labels"]
BreadcrumbUrls: ["/cookbook/4.1/", "/cookbook/4.1/category/plottable-scatter-plot", "/cookbook/4.1/recipes/scatter_labels/"]
SearchUrl: "/cookbook/4.1/search/"
OgImage: "/cookbook/4.1/images/scatter_labels.png"
---

<h2><a id='scatter-plot-labels' href='/cookbook/4.1/recipes/scatter_labels/'>Scatter Plot Labels</a></h2>

Individual points can be labeled.

```cs
ScottPlot.Version.ShouldBe(4, 1, 70);
var plt = new ScottPlot.Plot(600, 400);

double[] xs = { 18.5, 20.6, 22.3, 24.5, 26.6, 15, 15 };
double[] ys = { 1.43, 1.48, 1.6, 1.59, 1.53, 1.52, 1.6 };
string[] labels = { "A", "B", "C", "D", "E", "F", "G" };

var sp = plt.AddScatter(xs, ys);
sp.DataPointLabels = labels;
sp.DataPointLabelFont.Size = 24;

plt.SetAxisLimits(12, 28, 1.3, 1.7);

plt.SaveFig("scatter_labels.png");
```

<img src='../../images/scatter_labels.png' class='d-block mx-auto my-5' />


