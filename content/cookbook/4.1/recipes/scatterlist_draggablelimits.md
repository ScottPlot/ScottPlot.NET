---
Title: "Scatter List Draggable Limits - ScottPlot 4.1 Cookbook"
Description: "A custom function can be used to limit the range of draggable points."
Date: 2023-12-13
Version: ScottPlot 4.1.69
URL: /cookbook/4.1/recipes/scatterlist_draggablelimits/
BreadcrumbNames: ["ScottPlot 4.1 Cookbook", "Scatter Plot", "Scatter List Draggable Limits"]
BreadcrumbUrls: ["/cookbook/4.1/", "/cookbook/4.1/category/plottable-scatter-plot", "/cookbook/4.1/recipes/scatterlist_draggablelimits/"]
SearchUrl: "/cookbook/4.1/search/"
OgImage: "/cookbook/4.1/images/scatterlist_draggablelimits.png"
---

<h2><a id='scatter-list-draggable-limits' href='/cookbook/4.1/recipes/scatterlist_draggablelimits/'>Scatter List Draggable Limits</a></h2>

A custom function can be used to limit the range of draggable points.

```cs
var plt = new ScottPlot.Plot(600, 400);

// plot sample data
double[] xs = ScottPlot.DataGen.Consecutive(20);
double[] ys = ScottPlot.DataGen.Sin(20);
var scatter = new ScottPlot.Plottable.ScatterPlotListDraggable();
scatter.AddRange(xs, ys);
scatter.MarkerSize = 5;
plt.Add(scatter);

// use a custom function to limit the movement of points
static Coordinate MoveBetweenAdjacent(List<double> xs, List<double> ys, int index, Coordinate requested)
{
    int leftIndex = Math.Max(index - 1, 0);
    int rightIndex = Math.Min(index + 1, xs.Count - 1);

    double newX = requested.X;
    newX = Math.Max(newX, xs[leftIndex]);
    newX = Math.Min(newX, xs[rightIndex]);

    return new Coordinate(newX, requested.Y);
}

scatter.MovePointFunc = MoveBetweenAdjacent;

plt.SaveFig("scatterList_draggableLimits.png");
```

<img src='../../images/scatterlist_draggablelimits.png' class='d-block mx-auto my-5' />


