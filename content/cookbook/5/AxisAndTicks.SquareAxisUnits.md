---
Title: Square Axis Units - ScottPlot 5 Cookbook
Description: Axis rules can be put in place which force the vertical scale (units per pixel) to match the horizontal scale so circles always appear as circles and not stretched ellipses.
URL: /cookbook/5/AxisAndTicks/SquareAxisUnits/
BreadcrumbNames: ["ScottPlot 5 Cookbook", "Axis and Ticks", "Square Axis Units"]
BreadcrumbUrls: ["/cookbook/5/", "/cookbook/5/AxisAndTicks", "/cookbook/5/AxisAndTicks/SquareAxisUnits"]
Date: 2026-03-29
Version: ScottPlot 5.1.58
Version: ScottPlot 5.1.58
SearchUrl: "/cookbook/5/search/"
ShowEditLink: false
---


<div class='d-flex align-items-center mt-5'>
<h1 class='me-2 text-dark my-0 border-0'>Square Axis Units</h1>
</div>

Axis rules can be put in place which force the vertical scale (units per pixel) to match the horizontal scale so circles always appear as circles and not stretched ellipses.

[![](/cookbook/5/images/SquareAxisUnits.png?260329072039)](/cookbook/5/images/SquareAxisUnits.png?260329072039)

{{< recipe-sp5 sourceUrl="https://github.com/ScottPlot/ScottPlot/blob/main/src/ScottPlot5/ScottPlot5%20Cookbook/Recipes/General/AxisRecipes.cs" imageUrl="/cookbook/5/images/SquareAxisUnits.png?260329072039" >}}ScottPlot.Plot myPlot = new();

myPlot.Add.Circle(0, 0, 10);

// force pixels to have a 1:1 scale ratio
myPlot.Axes.SquareUnits();

// even if you try to "stretch" the axis, it will adjust the axis limits automatically
myPlot.Axes.SetLimits(-10, 10, -20, 20);

myPlot.SavePng("demo.png", 400, 300);
{{< /recipe-sp5 >}}

<div class='my-5 text-center'>This recipe is one of many in the <a href='/cookbook/5/AxisAndTicks'>Axis and Ticks</a> category</div>


