---
Title: SetTicks Shortcut - ScottPlot 5.0 Cookbook
Description: The default axes have a SetTicks() helper method which replaces the default tick generator with a manual tick generator pre-loaded with the provided ticks.
URL: /cookbook/5.0/CustomizingTicks/SetTicks/
BreadcrumbNames: ["ScottPlot 5.0 Cookbook", "Customizing Ticks", "SetTicks Shortcut"]
BreadcrumbUrls: ["/cookbook/5.0/", "/cookbook/5.0/CustomizingTicks", "/cookbook/5.0/CustomizingTicks/SetTicks"]
Date: 2024-10-30
Version: ScottPlot 5.0.42
Version: ScottPlot 5.0.42
SearchUrl: "/cookbook/5.0/search/"
ShowEditLink: false
---


<h2 style='border-bottom: 0;'><a href='/cookbook/5.0/CustomizingTicks/SetTicks'>SetTicks Shortcut</a></h2>

<div class="d-flex mb-2">
<a class="btn btn-sm btn-primary me-1" href="/cookbook/5.0/CustomizingTicks/SetTicks">Recipe Permalink</a>
<a class="btn btn-sm btn-success me-1" href="/cookbook/5.0/CustomizingTicks">Category: Customizing Ticks</a>
</div>

The default axes have a SetTicks() helper method which replaces the default tick generator with a manual tick generator pre-loaded with the provided ticks.

[![](/cookbook/5.0/images/SetTicks.png?241029205813)](/cookbook/5.0/images/SetTicks.png?241029205813)

{{< recipe-sp5 >}}ScottPlot.Plot myPlot = new();

// display sample data
myPlot.Add.Signal(Generate.Sin());
myPlot.Add.Signal(Generate.Cos());

// use manually defined ticks
double[] tickPositions = { 10, 25, 40 };
string[] tickLabels = { "Alpha", "Beta", "Gamma" };
myPlot.Axes.Bottom.SetTicks(tickPositions, tickLabels);

myPlot.SavePng("demo.png", 400, 300);
{{< /recipe-sp5 >}}

<hr class='my-5 invisible'>


