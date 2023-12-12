---
Title: "Scatter List Draggable - ScottPlot 4.1 Cookbook"
Description: "There exists a Scatter Plot List with draggable points."
Date: 12/11/2023 8:13:10 PM
Version: ScottPlot 4.1.69
URL: /cookbook/4.1/recipes/scatterlist_draggable/
BreadcrumbNames: ["ScottPlot 4.1 Cookbook", "Scatter Plot", "Scatter List Draggable"]
BreadcrumbUrls: ["/cookbook/4.1/", "/cookbook/4.1/category/plottable-scatter-plot", "/cookbook/4.1/recipes/scatterlist_draggable/"]
SearchUrl: "/cookbook/4.1/search/"
OgImage: "/cookbook/4.1/images/scatterlist_draggable.png"
---

<h2><a id='scatter-list-draggable' href='/cookbook/4.1/recipes/scatterlist_draggable/'>Scatter List Draggable</a></h2>

There exists a Scatter Plot List with draggable points.

```cs
var plt = new ScottPlot.Plot(600, 400);

double[] xs = ScottPlot.DataGen.Consecutive(51);
double[] ys = ScottPlot.DataGen.Sin(51);

var scatter = new ScottPlot.Plottable.ScatterPlotListDraggable();
scatter.AddRange(xs, ys);

plt.Add(scatter);

plt.SaveFig("scatterList_draggable.png");
```

<img src='../../images/scatterlist_draggable.png' class='d-block mx-auto my-5' />


