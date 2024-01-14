---
Title: "Draggable With Snapping - ScottPlot 4.1 Cookbook"
Description: "Draggables can be configured to snap to the nearest integer or to a user-defined list of Positions out of the box."
Date: 2024-01-14
Version: ScottPlot 4.1.70
URL: /cookbook/4.1/recipes/axisline_draggable_with_snap/
BreadcrumbNames: ["ScottPlot 4.1 Cookbook", "Axis Line and Span", "Draggable With Snapping"]
BreadcrumbUrls: ["/cookbook/4.1/", "/cookbook/4.1/category/plottable-axis-line-and-span", "/cookbook/4.1/recipes/axisline_draggable_with_snap/"]
SearchUrl: "/cookbook/4.1/search/"
OgImage: "/cookbook/4.1/images/axisline_draggable_with_snap.png"
---

<h2><a id='draggable-with-snapping' href='/cookbook/4.1/recipes/axisline_draggable_with_snap/'>Draggable With Snapping</a></h2>

Draggables can be configured to snap to the nearest integer or to a user-defined list of Positions out of the box.

{{< code-sp4 >}}

```cs
ScottPlot.Version.ShouldBe(4, 1, 70);
var plt = new ScottPlot.Plot(600, 400);

plt.AddSignal(DataGen.Sin(51, mult: 5));
plt.AddSignal(DataGen.Cos(51, mult: 5));
double[] snapPositions = DataGen.Consecutive(11, 5);

// different snap sytems can be created and customized 
var SnapDisabled = new ScottPlot.SnapLogic.NoSnap1D();
var SnapNearestInt = new ScottPlot.SnapLogic.Integer1D();
var SnapNearestInList = new ScottPlot.SnapLogic.Nearest1D(snapPositions);

var hLine = plt.AddHorizontalLine(2);
hLine.DragEnabled = true;
hLine.DragSnap = new ScottPlot.SnapLogic.Independent2D(x: SnapDisabled, y: SnapNearestInt);

var vLine = plt.AddVerticalLine(30);
vLine.DragEnabled = true;
vLine.DragSnap = new ScottPlot.SnapLogic.Independent2D(x: SnapNearestInList, y: SnapDisabled);

plt.SaveFig("axisLine_draggable_with_snap.png");
```

{{< /code-sp4 >}}

<img src='../../images/axisline_draggable_with_snap.png' class='d-block mx-auto my-5' />


