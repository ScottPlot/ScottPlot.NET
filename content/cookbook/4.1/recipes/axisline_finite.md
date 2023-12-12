---
Title: "Finite Axis Line - ScottPlot 4.1 Cookbook"
Description: "Axis lines can have lower and/or upper bounds. This can be useful for labeling points of interest."
Date: 12/11/2023 8:04:06 PM
Version: ScottPlot 4.1.69
URL: /cookbook/4.1/recipes/axisline_finite/
BreadcrumbNames: ["ScottPlot 4.1 Cookbook", "Axis Line and Span", "Finite Axis Line"]
BreadcrumbUrls: ["/cookbook/4.1/", "/cookbook/4.1/category/plottable-axis-line-and-span", "/cookbook/4.1/recipes/axisline_finite/"]
SearchUrl: "/cookbook/4.1/search/"
OgImage: "/cookbook/4.1/images/axisline_finite.png"
---

<h2><a href='/cookbook/4.1/recipes/axisline_finite/'>Finite Axis Line</a></h2>

Axis lines can have lower and/or upper bounds. This can be useful for labeling points of interest.

```cs
var plt = new ScottPlot.Plot(600, 400);

plt.AddFunction(x => Math.Pow(x, 2), lineStyle: LineStyle.Dash);
plt.AddFunction(x => Math.Sqrt(x), lineStyle: LineStyle.Dash);

// mark a coordinate from the lower left
var point1 = plt.AddPoint(1, 1, size: 10, shape: MarkerShape.openCircle);
var hLine1 = plt.AddHorizontalLine(1, width: 2);
hLine1.Max = 1;
hLine1.Color = point1.Color;
var vLine1 = plt.AddVerticalLine(1, width: 2);
vLine1.Max = 1;
vLine1.Color = point1.Color;

// use finate upper and lower limits draw a cross on a point
var point2 = plt.AddPoint(4, 2, size: 10, shape: MarkerShape.openCircle);
var vLine2 = plt.AddVerticalLine(4, width: 2);
vLine2.Min = 1.5;
vLine2.Max = 2.5;
vLine2.Color = point2.Color;
var hLine2 = plt.AddHorizontalLine(2, width: 2);
hLine2.Min = 3.5;
hLine2.Max = 4.5;
hLine2.Color = point2.Color;

// mark a coordinate from the top right
var point3 = plt.AddPoint(2, 4, size: 10, shape: MarkerShape.openCircle);
var hLine3 = plt.AddHorizontalLine(4, width: 2);
hLine3.Min = 2;
hLine3.Color = point3.Color;
var vLine3 = plt.AddVerticalLine(2, width: 2);
vLine3.Min = 4;
vLine3.Color = point3.Color;

plt.SetAxisLimits(0, 5, 0, 5);

plt.SaveFig("axisLine_finite.png");
```

<img src='../../images/axisline_finite.png' class='d-block mx-auto my-5' />


