---
Title: "Draggable Marker - ScottPlot 4.1 Cookbook"
Description: "A special type of marker exists which allows dragging with the mouse."
Date: 2023-12-28
Version: ScottPlot 4.1.70
URL: /cookbook/4.1/recipes/marker_draggable/
BreadcrumbNames: ["ScottPlot 4.1 Cookbook", "Marker", "Draggable Marker"]
BreadcrumbUrls: ["/cookbook/4.1/", "/cookbook/4.1/category/plottable-marker", "/cookbook/4.1/recipes/marker_draggable/"]
SearchUrl: "/cookbook/4.1/search/"
OgImage: "/cookbook/4.1/images/marker_draggable.png"
---

<h2><a id='draggable-marker' href='/cookbook/4.1/recipes/marker_draggable/'>Draggable Marker</a></h2>

A special type of marker exists which allows dragging with the mouse.

```cs
var plt = new ScottPlot.Plot(600, 400);

plt.AddSignal(ScottPlot.DataGen.Sin(51));
plt.AddSignal(ScottPlot.DataGen.Cos(51));

var myDraggableMarker = new ScottPlot.Plottable.DraggableMarkerPlot()
{
    X = 25,
    Y = .57,
    Color = Color.Magenta,
    MarkerShape = MarkerShape.filledDiamond,
    MarkerSize = 15,
    Text = "drag the point!",
};

myDraggableMarker.TextFont.Size = 16;

plt.Add(myDraggableMarker);

plt.SaveFig("marker_draggable.png");
```

<img src='../../images/marker_draggable.png' class='d-block mx-auto my-5' />


