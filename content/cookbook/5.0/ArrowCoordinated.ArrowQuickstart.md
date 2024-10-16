---
Title: Arrow Quickstart - ScottPlot 5.0 Cookbook
Description: Arrows can be placed on plots to point to a location in coordinate space and extensively customized.
URL: /cookbook/5.0/ArrowCoordinated/ArrowQuickstart/
BreadcrumbNames: ["ScottPlot 5.0 Cookbook", "Arrow", "Arrow Quickstart"]
BreadcrumbUrls: ["/cookbook/5.0/", "/cookbook/5.0/ArrowCoordinated", "/cookbook/5.0/ArrowCoordinated/ArrowQuickstart"]
Date: 2024-10-16
Version: ScottPlot 5.0.40
Version: ScottPlot 5.0.40
SearchUrl: "/cookbook/5.0/search/"
ShowEditLink: false
---

# Arrow Quickstart


Arrows can be placed on plots to point to a location in coordinate space and extensively customized.

[![](/cookbook/5.0/images/ArrowQuickstart.png?241016194708)](/cookbook/5.0/images/ArrowQuickstart.png?241016194708)

{{< code-sp5 >}}

```cs
ScottPlot.Plot myPlot = new();

// create a line
Coordinates arrowTip = new(0, 0);
Coordinates arrowBase = new(1, 1);
CoordinateLine arrowLine = new(arrowBase, arrowTip);

// add a simple arrow
myPlot.Add.Arrow(arrowLine);

// arrow line and fill styles can be customized
var arrow2 = myPlot.Add.Arrow(arrowLine.WithDelta(1, 0));
arrow2.ArrowLineColor = Colors.Red;
arrow2.ArrowMinimumLength = 100;
arrow2.ArrowLineColor = Colors.Black;
arrow2.ArrowFillColor = Colors.Transparent;

// the shape of the arrowhead can be adjusted
var skinny = myPlot.Add.Arrow(arrowLine.WithDelta(2, 0));
skinny.ArrowFillColor = Colors.Green;
skinny.ArrowLineWidth = 0;
skinny.ArrowWidth = 3;
skinny.ArrowheadLength = 20;
skinny.ArrowheadAxisLength = 20;
skinny.ArrowheadWidth = 7;

var fat = myPlot.Add.Arrow(arrowLine.WithDelta(3, 0));
fat.ArrowFillColor = Colors.Blue;
fat.ArrowLineWidth = 0;
fat.ArrowWidth = 18;
fat.ArrowheadLength = 20;
fat.ArrowheadAxisLength = 20;
fat.ArrowheadWidth = 30;

// offset backs the arrow away from the tip coordinate
myPlot.Add.Marker(arrowLine.WithDelta(4, 0).End);
var arrow4 = myPlot.Add.Arrow(arrowLine.WithDelta(4, 0));
arrow4.ArrowOffset = 15;

myPlot.Axes.SetLimits(-1, 6, -1, 2);

myPlot.SavePng("demo.png", 400, 300);

```

{{< /code-sp5 >}}

<a href='https://github.com/ScottPlot/ScottPlot/blob/main/src/ScottPlot5/ScottPlot5%20Cookbook/Recipes/PlotTypes/Arrow.cs'><svg xmlns="http://www.w3.org/2000/svg" width="16" height="16" fill="currentColor" class="mb-1 bi bi-github" viewBox="0 0 16 16">
  <path d="M8 0C3.58 0 0 3.58 0 8c0 3.54 2.29 6.53 5.47 7.59.4.07.55-.17.55-.38 0-.19-.01-.82-.01-1.49-2.01.37-2.53-.49-2.69-.94-.09-.23-.48-.94-.82-1.13-.28-.15-.68-.52-.01-.53.63-.01 1.08.58 1.23.82.72 1.21 1.87.87 2.33.66.07-.52.28-.87.51-1.07-1.78-.2-3.64-.89-3.64-3.95 0-.87.31-1.59.82-2.15-.08-.2-.36-1.02.08-2.12 0 0 .67-.21 2.2.82.64-.18 1.32-.27 2-.27s1.36.09 2 .27c1.53-1.04 2.2-.82 2.2-.82.44 1.1.16 1.92.08 2.12.51.56.82 1.27.82 2.15 0 3.07-1.87 3.75-3.65 3.95.29.25.54.73.54 1.48 0 1.07-.01 1.93-.01 2.2 0 .21.15.46.55.38A8.01 8.01 0 0 0 16 8c0-4.42-3.58-8-8-8"/>
</svg> Edit on GitHub</a>

