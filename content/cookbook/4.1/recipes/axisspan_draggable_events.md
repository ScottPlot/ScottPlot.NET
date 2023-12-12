---
Title: "Draggable Axis Span Events - ScottPlot 4.1 Cookbook"
Description: "Axis spans can be dragged using the mouse. Span events can be useful for binding span edge values to UI elements."
Date: 12/11/2023 8:13:09 PM
Version: ScottPlot 4.1.69
URL: /cookbook/4.1/recipes/axisspan_draggable_events/
BreadcrumbNames: ["ScottPlot 4.1 Cookbook", "Axis Line and Span", "Draggable Axis Span Events"]
BreadcrumbUrls: ["/cookbook/4.1/", "/cookbook/4.1/category/plottable-axis-line-and-span", "/cookbook/4.1/recipes/axisspan_draggable_events/"]
SearchUrl: "/cookbook/4.1/search/"
OgImage: "/cookbook/4.1/images/axisspan_draggable_events.png"
---

<h2><a id='draggable-axis-span-events' href='/cookbook/4.1/recipes/axisspan_draggable_events/'>Draggable Axis Span Events</a></h2>

Axis spans can be dragged using the mouse. Span events can be useful for binding span edge values to UI elements.

```cs
var plt = new ScottPlot.Plot(600, 400);

// plot sample data
plt.AddSignal(DataGen.Sin(51));
plt.AddSignal(DataGen.Cos(51));

var minText = plt.AddTooltip("min: default", 0, 1);
var maxText = plt.AddTooltip("max: default", 50, 1);

var edge1Tooltip = plt.AddTooltip("Edge1: 0", 0, 0.6);
var edge2Tooltip = plt.AddTooltip("Edge2: 50", 50, 0.2);

// dragging can be enabled and optionally limited to a range
var hSpan = plt.AddHorizontalSpan(0, 50);
hSpan.DragEnabled = true;
hSpan.DragLimitMin = 0;
hSpan.DragLimitMax = 50;
hSpan.Label = "Draggable vSpan";

hSpan.MinDragged += (s, e) => minText.Label = $"Min: {e}";
hSpan.MaxDragged += (s, e) => maxText.Label = $"Max: {e}";
hSpan.Edge1Dragged += (s, e) =>
{
    edge1Tooltip.X = e;
    edge1Tooltip.Label = $"Edge1: {e}";
};
hSpan.Edge2Dragged += (s, e) =>
{
    edge2Tooltip.X = e;
    edge2Tooltip.Label = $"Edge2: {e}";
};

plt.Legend(true);

plt.SaveFig("axisSpan_draggable_events.png");
```

<img src='../../images/axisspan_draggable_events.png' class='d-block mx-auto my-5' />


