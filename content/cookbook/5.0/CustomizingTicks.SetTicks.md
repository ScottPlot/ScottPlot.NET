---
Title: SetTicks Shortcut - ScottPlot 5.0 Cookbook
Description: The default axes have a SetTicks() helper method which replaces the default tick generator with a manual tick generator pre-loaded with the provided ticks.
URL: /cookbook/5.0/CustomizingTicks/SetTicks/
BreadcrumbNames: ["ScottPlot 5.0 Cookbook", "Customizing Ticks", "SetTicks Shortcut"]
BreadcrumbUrls: ["/cookbook/5.0/", "/cookbook/5.0/CustomizingTicks", "/cookbook/5.0/CustomizingTicks/SetTicks"]
Date: 2024-11-24
Version: ScottPlot 5.0.47
Version: ScottPlot 5.0.47
SearchUrl: "/cookbook/5.0/search/"
ShowEditLink: false
---


<div class='d-flex align-items-center mt-5'>
<h1 class='me-2 text-dark my-0 border-0'>SetTicks Shortcut</h1>
</div>

The default axes have a SetTicks() helper method which replaces the default tick generator with a manual tick generator pre-loaded with the provided ticks.

[![](/cookbook/5.0/images/SetTicks.png?241124170640)](/cookbook/5.0/images/SetTicks.png?241124170640)

{{< recipe-sp5 sourceUrl="https://github.com/ScottPlot/ScottPlot/blob/main/src/ScottPlot5/ScottPlot5%20Cookbook/Recipes/General/TickRecipes.cs" imageUrl="/cookbook/5.0/images/SetTicks.png?241124170640" >}}ScottPlot.Plot myPlot = new();

// display sample data
myPlot.Add.Signal(Generate.Sin());
myPlot.Add.Signal(Generate.Cos());

// use manually defined ticks
double[] tickPositions = { 10, 25, 40 };
string[] tickLabels = { "Alpha", "Beta", "Gamma" };
myPlot.Axes.Bottom.SetTicks(tickPositions, tickLabels);

myPlot.SavePng("demo.png", 400, 300);
{{< /recipe-sp5 >}}

<div class='my-5 text-center'>This recipe is one of many in the <a href='/cookbook/5.0/CustomizingTicks'>Customizing Ticks</a> category</div>


