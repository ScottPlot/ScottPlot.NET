---
Title: Arrow Quickstart - ScottPlot 5.0 Cookbook
Description: Arrows can be placed on plots to point to a location in coordinate space and extensively customized.
URL: /cookbook/5.0/ArrowCoordinated/ArrowQuickstart/
BreadcrumbNames: ["ScottPlot 5.0 Cookbook", "Arrow", "Arrow Quickstart"]
BreadcrumbUrls: ["/cookbook/5.0/", "/cookbook/5.0/ArrowCoordinated", "/cookbook/5.0/ArrowCoordinated/ArrowQuickstart"]
Date: 2024-10-31
Version: ScottPlot 5.0.42
Version: ScottPlot 5.0.42
SearchUrl: "/cookbook/5.0/search/"
ShowEditLink: false
---


<h2 style='border-bottom: 0;'><a href='/cookbook/5.0/ArrowCoordinated/ArrowQuickstart'>Arrow Quickstart</a></h2>

<div class="d-flex mb-2">
<a class="btn btn-sm btn-primary me-1" href="/cookbook/5.0/ArrowCoordinated/ArrowQuickstart">Recipe Permalink</a>
<a class="btn btn-sm btn-success me-1" href="/cookbook/5.0/ArrowCoordinated">Category: Arrow</a>
</div>

Arrows can be placed on plots to point to a location in coordinate space and extensively customized.

[![](/cookbook/5.0/images/ArrowQuickstart.png?241031194635)](/cookbook/5.0/images/ArrowQuickstart.png?241031194635)

{{< recipe-sp5 >}}ScottPlot.Plot myPlot = new();

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


