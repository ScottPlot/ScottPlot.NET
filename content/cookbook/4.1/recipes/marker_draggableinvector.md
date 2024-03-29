---
Title: "Draggable Marker Snap - ScottPlot 4.1 Cookbook"
Description: "This example shows how to add a draggable marker which is constrained to positions defined by an array of X/Y pairs."
Date: 2024-01-21
Version: ScottPlot 4.1.71
URL: /cookbook/4.1/recipes/marker_draggableinvector/
BreadcrumbNames: ["ScottPlot 4.1 Cookbook", "Marker", "Draggable Marker Snap"]
BreadcrumbUrls: ["/cookbook/4.1/", "/cookbook/4.1/category/plottable-marker", "/cookbook/4.1/recipes/marker_draggableinvector/"]
SearchUrl: "/cookbook/4.1/search/"
OgImage: "/cookbook/4.1/images/marker_draggableinvector.png"
---

<h2><a id='draggable-marker-snap' href='/cookbook/4.1/recipes/marker_draggableinvector/'>Draggable Marker Snap</a></h2>

This example shows how to add a draggable marker which is constrained to positions defined by an array of X/Y pairs.

{{< code-sp4 >}}

```cs
ScottPlot.Version.ShouldBe(4, 1, 71);
var plt = new ScottPlot.Plot(600, 400);

// create random data and display it with a scatter plot
double[] xs = DataGen.Consecutive(50);
double[] ys = DataGen.Random(new Random(0), 50);
plt.AddScatter(xs, ys, label: "data");

// place the marker at the first data point
var marker = plt.AddMarkerDraggable(xs[0], ys[0], MarkerShape.filledDiamond, 15, Color.Magenta);

// constrain snapping to the array of data points
marker.DragSnap = new ScottPlot.SnapLogic.Nearest2D(xs, ys);

plt.Legend();

plt.SaveFig("marker_draggableinvector.png");
```

{{< /code-sp4 >}}

<img src='../../images/marker_draggableinvector.png' class='d-block mx-auto my-5' />


