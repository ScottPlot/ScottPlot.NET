---
Title: Circle - ScottPlot 5.0 Cookbook
Description: A circle can be placed on the plot and styled as desired.
URL: /cookbook/5.0/Shapes/CircleQuickstart/
BreadcrumbNames: ["ScottPlot 5.0 Cookbook", "Shapes", "Circle"]
BreadcrumbUrls: ["/cookbook/5.0/", "/cookbook/5.0/Shapes", "/cookbook/5.0/Shapes/CircleQuickstart"]
Date: 2025-01-26
Version: ScottPlot 5.0.55
Version: ScottPlot 5.0.55
SearchUrl: "/cookbook/5.0/search/"
ShowEditLink: false
---


<div class='d-flex align-items-center mt-5'>
<h1 class='me-2 text-dark my-0 border-0'>Circle</h1>
</div>

A circle can be placed on the plot and styled as desired.

[![](/cookbook/5.0/images/CircleQuickstart.png?250126165944)](/cookbook/5.0/images/CircleQuickstart.png?250126165944)

{{< recipe-sp5 sourceUrl="https://github.com/ScottPlot/ScottPlot/blob/main/src/ScottPlot5/ScottPlot5%20Cookbook/Recipes/PlotTypes/Shapes.cs" imageUrl="/cookbook/5.0/images/CircleQuickstart.png?250126165944" >}}ScottPlot.Plot myPlot = new();

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

<div class='my-5 text-center'>This recipe is one of many in the <a href='/cookbook/5.0/Shapes'>Shapes</a> category</div>


