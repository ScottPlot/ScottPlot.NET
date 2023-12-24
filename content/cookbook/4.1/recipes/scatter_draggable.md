---
Title: "Draggable Scatter Plot Vertical - ScottPlot 4.1 Cookbook"
Description: "You can restrict dragging to just X or Y directions."
Date: 2023-12-24
Version: ScottPlot 4.1.69
URL: /cookbook/4.1/recipes/scatter_draggable/
BreadcrumbNames: ["ScottPlot 4.1 Cookbook", "Scatter Plot", "Draggable Scatter Plot Vertical"]
BreadcrumbUrls: ["/cookbook/4.1/", "/cookbook/4.1/category/plottable-scatter-plot", "/cookbook/4.1/recipes/scatter_draggable/"]
SearchUrl: "/cookbook/4.1/search/"
OgImage: "/cookbook/4.1/images/scatter_draggable.png"
---

<h2><a id='draggable-scatter-plot-vertical' href='/cookbook/4.1/recipes/scatter_draggable/'>Draggable Scatter Plot Vertical</a></h2>

You can restrict dragging to just X or Y directions.

```cs
var plt = new ScottPlot.Plot(600, 400);

double[] x = ScottPlot.DataGen.Consecutive(50);
double[] y = ScottPlot.DataGen.Cos(50);

var scatter = new ScottPlot.Plottable.ScatterPlotDraggable(x, y)
{
    DragCursor = Cursor.Crosshair,
    DragEnabled = true,   // controls whether anything can be dragged
    DragEnabledX = false, // controls whether points can be dragged horizontally 
    DragEnabledY = true,  // controls whether points can be dragged vertically
};

plt.Add(scatter);

plt.SaveFig("scatter_draggable.png");
```

<img src='../../images/scatter_draggable.png' class='d-block mx-auto my-5' />


