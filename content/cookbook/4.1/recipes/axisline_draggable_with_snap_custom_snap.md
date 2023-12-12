---
Title: "Draggable Custom Snap Function - ScottPlot 4.1 Cookbook"
Description: "Custom logic can be added to draggables to customize how they snap."
Date: 12/11/2023 7:52:02 PM
Version: ScottPlot 4.1.69
URL: /cookbook/4.1/recipes/axisline_draggable_with_snap_custom_snap/
BreadcrumbNames: ["ScottPlot 4.1 Cookbook", "Axis Line and Span", "Draggable Custom Snap Function"]
BreadcrumbUrls: ["/cookbook/4.1/", "/cookbook/4.1/category/plottable-axis-line-and-span", "/cookbook/4.1/recipes/axisline_draggable_with_snap_custom_snap/"]
SearchUrl: "/cookbook/4.1/search/"
OgImage: "/cookbook/4.1/images/axisline_draggable_with_snap_custom_snap.png"
---

<h2><a href='/cookbook/4.1/recipes/axisline_draggable_with_snap_custom_snap/'>Draggable Custom Snap Function</a></h2>

Custom logic can be added to draggables to customize how they snap.

```cs
var plt = new ScottPlot.Plot(600, 400);

double CustomSnapFunction(double value)
{
    // multiple of 3 between 0 and 50
    if (value < 0) return 0;
    else if (value > 50) return 50;
    else return (int)Math.Round(value / 3) * 3;
}

// different snap sytems can be created and customized 
var SnapDisabled = new ScottPlot.SnapLogic.NoSnap1D();
var SnapCustom = new SnapLogic.Custom1D(CustomSnapFunction);

plt.AddSignal(DataGen.Sin(51, mult: 5));
plt.AddSignal(DataGen.Cos(51, mult: 5));

var vLine = plt.AddVerticalLine(30);
vLine.DragEnabled = true;
vLine.DragSnap = new ScottPlot.SnapLogic.Independent2D(SnapCustom, SnapDisabled);

plt.SaveFig("axisLine_draggable_with_snap_custom_snap.png");
```

<img src='../../images/axisline_draggable_with_snap_custom_snap.png' class='d-block mx-auto my-5' />


