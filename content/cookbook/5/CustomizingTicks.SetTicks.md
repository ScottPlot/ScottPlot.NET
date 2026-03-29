---
Title: SetTicks Shortcut - ScottPlot 5 Cookbook
Description: The default axes have a SetTicks() helper method which replaces the default tick generator with a manual tick generator pre-loaded with the provided ticks.
URL: /cookbook/5/CustomizingTicks/SetTicks/
BreadcrumbNames: ["ScottPlot 5 Cookbook", "Customizing Ticks", "SetTicks Shortcut"]
BreadcrumbUrls: ["/cookbook/5/", "/cookbook/5/CustomizingTicks", "/cookbook/5/CustomizingTicks/SetTicks"]
Date: 2026-03-29
Version: ScottPlot 5.1.58
Version: ScottPlot 5.1.58
SearchUrl: "/cookbook/5/search/"
ShowEditLink: false
---


<div class='d-flex align-items-center mt-5'>
<h1 class='me-2 text-dark my-0 border-0'>SetTicks Shortcut</h1>
</div>

The default axes have a SetTicks() helper method which replaces the default tick generator with a manual tick generator pre-loaded with the provided ticks.

[![](/cookbook/5/images/SetTicks.png?260329072039)](/cookbook/5/images/SetTicks.png?260329072039)

{{< recipe-sp5 sourceUrl="https://github.com/ScottPlot/ScottPlot/blob/main/src/ScottPlot5/ScottPlot5%20Cookbook/Recipes/General/TickRecipes.cs" imageUrl="/cookbook/5/images/SetTicks.png?260329072039" >}}ScottPlot.Plot myPlot = new();

// display sample data
myPlot.Add.Signal(Generate.Sin());
myPlot.Add.Signal(Generate.Cos());

// use manually defined ticks
double[] tickPositions = { 10, 25, 40 };
string[] tickLabels = { "Alpha", "Beta", "Gamma" };
myPlot.Axes.Bottom.SetTicks(tickPositions, tickLabels);

myPlot.SavePng("demo.png", 400, 300);
{{< /recipe-sp5 >}}

<div class='my-5 text-center'>This recipe is one of many in the <a href='/cookbook/5/CustomizingTicks'>Customizing Ticks</a> category</div>


