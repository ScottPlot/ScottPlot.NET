---
Title: Arrow - ScottPlot 5.0 Cookbook
Description: Arrows point to a location in coordinate space.
URL: /cookbook/5.0/ArrowCoordinated/
BreadcrumbNames: ["ScottPlot 5.0 Cookbook", "Arrow"]
BreadcrumbUrls: ["/cookbook/5.0/", "/cookbook/5.0/ArrowCoordinated"]
Date: 2025-01-13
Version: ScottPlot 5.0.53
Version: ScottPlot 5.0.53
SearchUrl: "/cookbook/5.0/search/"
ShowEditLink: false
---

<h1>Arrow</h1>


<div class='d-flex align-items-center mt-5'>
<h1 class='me-2 text-dark my-0 border-0'>Arrow Quickstart</h1>
<a href='/cookbook/5.0/ArrowCoordinated/ArrowQuickstart' target='_blank'>
<img src='/images/icons/new-window.svg' style='height: 2rem;' class='new-window-icon'>
</a>
</div>

Arrows can be placed on plots to point to a location in coordinate space and extensively customized.

[![](/cookbook/5.0/images/ArrowQuickstart.png?250112204022)](/cookbook/5.0/images/ArrowQuickstart.png?250112204022)

{{< recipe-sp5 sourceUrl="https://github.com/ScottPlot/ScottPlot/blob/main/src/ScottPlot5/ScottPlot5%20Cookbook/Recipes/PlotTypes/Arrow.cs" imageUrl="/cookbook/5.0/images/ArrowQuickstart.png?250112204022" >}}ScottPlot.Plot myPlot = new();

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
{{< /recipe-sp5 >}}

<hr class='my-5 invisible'>


