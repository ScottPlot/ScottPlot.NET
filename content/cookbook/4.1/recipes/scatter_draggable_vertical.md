---
Title: "Draggable Scatter Plot - ScottPlot 4.1 Cookbook"
Description: "Want to modify the scatter points interactively? A ScatterPlotDraggable lets you move the points around with the mouse. As you move the points around, the values in the original arrays change to reflect their new positions."
Date: 2024-01-14
Version: ScottPlot 4.1.70
URL: /cookbook/4.1/recipes/scatter_draggable_vertical/
BreadcrumbNames: ["ScottPlot 4.1 Cookbook", "Scatter Plot", "Draggable Scatter Plot"]
BreadcrumbUrls: ["/cookbook/4.1/", "/cookbook/4.1/category/plottable-scatter-plot", "/cookbook/4.1/recipes/scatter_draggable_vertical/"]
SearchUrl: "/cookbook/4.1/search/"
OgImage: "/cookbook/4.1/images/scatter_draggable_vertical.png"
---

<h2><a id='draggable-scatter-plot' href='/cookbook/4.1/recipes/scatter_draggable_vertical/'>Draggable Scatter Plot</a></h2>

Want to modify the scatter points interactively? A ScatterPlotDraggable lets you move the points around with the mouse. As you move the points around, the values in the original arrays change to reflect their new positions.

{{< code-sp4 >}}

```cs
ScottPlot.Version.ShouldBe(4, 1, 70);
var plt = new ScottPlot.Plot(600, 400);

double[] x = ScottPlot.DataGen.Consecutive(50);
double[] y = ScottPlot.DataGen.Cos(50);

var scatter = new ScottPlot.Plottable.ScatterPlotDraggable(x, y)
{
    DragCursor = Cursor.Crosshair,
    DragEnabled = true,
};

plt.Add(scatter);

plt.SaveFig("scatter_draggable_vertical.png");
```

{{< /code-sp4 >}}

<img src='../../images/scatter_draggable_vertical.png' class='d-block mx-auto my-5' />


