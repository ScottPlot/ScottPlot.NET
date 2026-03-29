---
Title: Floating Axis - ScottPlot 5 Cookbook
Description: A floating or centered axis may be realized by hiding the default axes which appear at the edges of the plot and creating a new floating axis and adding it to the plot.
URL: /cookbook/5/AxisAndTicks/FloatingAxis/
BreadcrumbNames: ["ScottPlot 5 Cookbook", "Axis and Ticks", "Floating Axis"]
BreadcrumbUrls: ["/cookbook/5/", "/cookbook/5/AxisAndTicks", "/cookbook/5/AxisAndTicks/FloatingAxis"]
Date: 2026-03-29
Version: ScottPlot 5.1.58
Version: ScottPlot 5.1.58
SearchUrl: "/cookbook/5/search/"
ShowEditLink: false
---


<div class='d-flex align-items-center mt-5'>
<h1 class='me-2 text-dark my-0 border-0'>Floating Axis</h1>
</div>

A floating or centered axis may be realized by hiding the default axes which appear at the edges of the plot and creating a new floating axis and adding it to the plot.

[![](/cookbook/5/images/FloatingAxis.png?260329072039)](/cookbook/5/images/FloatingAxis.png?260329072039)

{{< recipe-sp5 sourceUrl="https://github.com/ScottPlot/ScottPlot/blob/main/src/ScottPlot5/ScottPlot5%20Cookbook/Recipes/General/AxisRecipes.cs" imageUrl="/cookbook/5/images/FloatingAxis.png?260329072039" >}}ScottPlot.Plot myPlot = new();

// create floating X and Y axes using one of the existing axes for reference
ScottPlot.Plottables.FloatingAxis floatingX = new(myPlot.Axes.Bottom);
ScottPlot.Plottables.FloatingAxis floatingY = new(myPlot.Axes.Left);

// hide the default axes and add the custom ones to the plot
myPlot.Axes.Frameless();
myPlot.HideGrid();
myPlot.Add.Plottable(floatingX);
myPlot.Add.Plottable(floatingY);

// add sample data last so it appears on top
myPlot.Add.Signal(Generate.Sin(51));
myPlot.Add.Signal(Generate.Cos(51));

myPlot.SavePng("demo.png", 400, 300);
{{< /recipe-sp5 >}}

<div class='my-5 text-center'>This recipe is one of many in the <a href='/cookbook/5/AxisAndTicks'>Axis and Ticks</a> category</div>


