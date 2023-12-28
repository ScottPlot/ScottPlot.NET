---
Title: "Draggable Axis Span - ScottPlot 4.1 Cookbook"
Description: "Axis spans can be dragged using the mouse. Drag limits are boundaries over which the edges of spans cannot cross."
Date: 2023-12-28
Version: ScottPlot 4.1.70
URL: /cookbook/4.1/recipes/axisspan_draggable/
BreadcrumbNames: ["ScottPlot 4.1 Cookbook", "Axis Line and Span", "Draggable Axis Span"]
BreadcrumbUrls: ["/cookbook/4.1/", "/cookbook/4.1/category/plottable-axis-line-and-span", "/cookbook/4.1/recipes/axisspan_draggable/"]
SearchUrl: "/cookbook/4.1/search/"
OgImage: "/cookbook/4.1/images/axisspan_draggable.png"
---

<h2><a id='draggable-axis-span' href='/cookbook/4.1/recipes/axisspan_draggable/'>Draggable Axis Span</a></h2>

Axis spans can be dragged using the mouse. Drag limits are boundaries over which the edges of spans cannot cross.

```cs
var plt = new ScottPlot.Plot(600, 400);

// plot sample data
plt.AddSignal(DataGen.Sin(51));
plt.AddSignal(DataGen.Cos(51));

// dragging can be enabled and optionally limited to a range
var vSpan = plt.AddVerticalSpan(.15, .85);
vSpan.DragEnabled = true;
vSpan.DragLimitMin = -1;
vSpan.DragLimitMax = 1;
vSpan.BorderColor = Color.Red;
vSpan.BorderLineStyle = LineStyle.Dot;
vSpan.BorderLineWidth = 2;
vSpan.HatchColor = Color.FromArgb(100, Color.Blue);
vSpan.HatchStyle = Drawing.HatchStyle.SmallCheckerBoard;
vSpan.Label = "Customized vSpan";


// spans can be configured to allow dragging but disallow resizing
var hSpan = plt.AddHorizontalSpan(10, 25);
hSpan.DragEnabled = true;
hSpan.DragFixedSize = true;
hSpan.Label = "Standard hSpan";
plt.Legend(true);

plt.SaveFig("axisSpan_draggable.png");
```

<img src='../../images/axisspan_draggable.png' class='d-block mx-auto my-5' />


