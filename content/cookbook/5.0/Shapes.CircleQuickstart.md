---
Title: Circle - ScottPlot 5.0 Cookbook
Description: A circle can be placed on the plot and styled as desired.
URL: /cookbook/5.0/Shapes/CircleQuickstart/
BreadcrumbNames: ["ScottPlot 5.0 Cookbook", "Shapes", "Circle"]
BreadcrumbUrls: ["/cookbook/5.0/", "/cookbook/5.0/Shapes", "/cookbook/5.0/Shapes/CircleQuickstart"]
Date: 2024-10-31
Version: ScottPlot 5.0.42
Version: ScottPlot 5.0.42
SearchUrl: "/cookbook/5.0/search/"
ShowEditLink: false
---


<h2 style='border-bottom: 0;'><a href='/cookbook/5.0/Shapes/CircleQuickstart'>Circle</a></h2>

<div class="d-flex mb-2">
<a class="btn btn-sm btn-primary me-1" href="/cookbook/5.0/Shapes/CircleQuickstart">Recipe Permalink</a>
<a class="btn btn-sm btn-success me-1" href="/cookbook/5.0/Shapes">Category: Shapes</a>
</div>

A circle can be placed on the plot and styled as desired.

[![](/cookbook/5.0/images/CircleQuickstart.png?241031194635)](/cookbook/5.0/images/CircleQuickstart.png?241031194635)

{{< recipe-sp5 >}}ScottPlot.Plot myPlot = new();

var c1 = myPlot.Add.Circle(1, 0, .5);
var c2 = myPlot.Add.Circle(2, 0, .5);
var c3 = myPlot.Add.Circle(3, 0, .5);

c1.FillStyle.Color = Colors.Blue;
c2.FillStyle.Color = Colors.Blue.Darken(.75);
c3.FillStyle.Color = Colors.Blue.Lighten(.75);

c1.LineWidth = 0;
c2.LineWidth = 0;
c3.LineWidth = 0;

// force circles to remain circles
ScottPlot.AxisRules.SquareZoomOut squareRule = new(myPlot.Axes.Bottom, myPlot.Axes.Left);
myPlot.Axes.Rules.Add(squareRule);

myPlot.SavePng("demo.png", 400, 300);
{{< /recipe-sp5 >}}

<hr class='my-5 invisible'>


