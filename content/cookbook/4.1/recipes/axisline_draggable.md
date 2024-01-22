---
Title: "Draggable Axis Lines - ScottPlot 4.1 Cookbook"
Description: "In GUI environments, axis lines can be draggable and moved with the mouse. Drag limits define the boundaries the lines can be dragged."
Date: 2024-01-21
Version: ScottPlot 4.1.71
URL: /cookbook/4.1/recipes/axisline_draggable/
BreadcrumbNames: ["ScottPlot 4.1 Cookbook", "Axis Line and Span", "Draggable Axis Lines"]
BreadcrumbUrls: ["/cookbook/4.1/", "/cookbook/4.1/category/plottable-axis-line-and-span", "/cookbook/4.1/recipes/axisline_draggable/"]
SearchUrl: "/cookbook/4.1/search/"
OgImage: "/cookbook/4.1/images/axisline_draggable.png"
---

<h2><a id='draggable-axis-lines' href='/cookbook/4.1/recipes/axisline_draggable/'>Draggable Axis Lines</a></h2>

In GUI environments, axis lines can be draggable and moved with the mouse. Drag limits define the boundaries the lines can be dragged.

{{< code-sp4 >}}

```cs
ScottPlot.Version.ShouldBe(4, 1, 71);
var plt = new ScottPlot.Plot(600, 400);

// plot sample data
plt.AddSignal(DataGen.Sin(51));
plt.AddSignal(DataGen.Cos(51));

// add axis lines and configure their drag settings
var hLine = plt.AddHorizontalLine(.85);
hLine.DragEnabled = true;
hLine.DragLimitMin = -1;
hLine.DragLimitMax = 1;

var vLine = plt.AddVerticalLine(23);
vLine.DragEnabled = true;
vLine.DragLimitMin = 0;
vLine.DragLimitMax = 50;

// you can access the position of an axis line at any time
string message = $"Vertical line is at X={vLine.X}";

plt.SaveFig("axisLine_draggable.png");
```

{{< /code-sp4 >}}

<img src='../../images/axisline_draggable.png' class='d-block mx-auto my-5' />


