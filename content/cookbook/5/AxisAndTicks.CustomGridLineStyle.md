---
Title: Grid Line Style - ScottPlot 5 Cookbook
Description: Grid lines have many options to allow extensive customization.
URL: /cookbook/5/AxisAndTicks/CustomGridLineStyle/
BreadcrumbNames: ["ScottPlot 5 Cookbook", "Axis and Ticks", "Grid Line Style"]
BreadcrumbUrls: ["/cookbook/5/", "/cookbook/5/AxisAndTicks", "/cookbook/5/AxisAndTicks/CustomGridLineStyle"]
Date: 2026-03-29
Version: ScottPlot 5.1.58
Version: ScottPlot 5.1.58
SearchUrl: "/cookbook/5/search/"
ShowEditLink: false
---


<div class='d-flex align-items-center mt-5'>
<h1 class='me-2 text-dark my-0 border-0'>Grid Line Style</h1>
</div>

Grid lines have many options to allow extensive customization.

[![](/cookbook/5/images/CustomGridLineStyle.png?260329072039)](/cookbook/5/images/CustomGridLineStyle.png?260329072039)

{{< recipe-sp5 sourceUrl="https://github.com/ScottPlot/ScottPlot/blob/main/src/ScottPlot5/ScottPlot5%20Cookbook/Recipes/General/AxisRecipes.cs" imageUrl="/cookbook/5/images/CustomGridLineStyle.png?260329072039" >}}ScottPlot.Plot myPlot = new();

myPlot.Add.Signal(Generate.Sin(51));
myPlot.Add.Signal(Generate.Cos(51));

myPlot.Grid.LineColor = Colors.Blue.WithAlpha(.2);
myPlot.Grid.LinePattern = LinePattern.Dotted;

myPlot.SavePng("demo.png", 400, 300);
{{< /recipe-sp5 >}}

<div class='my-5 text-center'>This recipe is one of many in the <a href='/cookbook/5/AxisAndTicks'>Axis and Ticks</a> category</div>


