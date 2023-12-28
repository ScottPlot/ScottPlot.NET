---
Title: "Position Labels on Additional Axes - ScottPlot 4.1 Cookbook"
Description: "Position labels can be added to multi-axis plots. The axis line must be told which axis to render the label on."
Date: 2023-12-28
Version: ScottPlot 4.1.70
URL: /cookbook/4.1/recipes/axisline_positionlabels2/
BreadcrumbNames: ["ScottPlot 4.1 Cookbook", "Axis Line and Span", "Position Labels on Additional Axes"]
BreadcrumbUrls: ["/cookbook/4.1/", "/cookbook/4.1/category/plottable-axis-line-and-span", "/cookbook/4.1/recipes/axisline_positionlabels2/"]
SearchUrl: "/cookbook/4.1/search/"
OgImage: "/cookbook/4.1/images/axisline_positionlabels2.png"
---

<h2><a id='position-labels-on-additional-axes' href='/cookbook/4.1/recipes/axisline_positionlabels2/'>Position Labels on Additional Axes</a></h2>

Position labels can be added to multi-axis plots. The axis line must be told which axis to render the label on.

```cs
var plt = new ScottPlot.Plot(600, 400);

var hlineA = plt.AddHorizontalLine(3);
hlineA.YAxisIndex = 1;
hlineA.PositionLabel = true;
hlineA.PositionLabelOppositeAxis = true;
hlineA.PositionLabelBackground = hlineA.Color;

var hlineB = plt.AddHorizontalLine(7);
hlineB.YAxisIndex = 2;
hlineB.PositionLabel = true;
hlineB.PositionLabelOppositeAxis = true;
hlineB.PositionLabelBackground = hlineB.Color;

// tell the line which axis to draw the label on
var yAxis2 = plt.XAxis2;
var yAxis3 = plt.AddAxis(ScottPlot.Renderable.Edge.Right);
hlineA.PositionLabelAxis = yAxis2;
hlineB.PositionLabelAxis = yAxis3;

plt.YAxis2.Ticks(true);
plt.SetAxisLimits(yMin: -10, yMax: 10, yAxisIndex: 1);
plt.SetAxisLimits(yMin: -10, yMax: 10, yAxisIndex: 2);

plt.SaveFig("axisLine_positionLabels2.png");
```

<img src='../../images/axisline_positionlabels2.png' class='d-block mx-auto my-5' />


