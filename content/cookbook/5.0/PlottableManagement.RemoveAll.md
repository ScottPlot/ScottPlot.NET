---
Title: Removing all Plottables of a Type - ScottPlot 5.0 Cookbook
Description: All plottables of a given type may be removed from a plot with a single command.
URL: /cookbook/5.0/PlottableManagement/RemoveAll/
BreadcrumbNames: ["ScottPlot 5.0 Cookbook", "Plottable Management", "Removing all Plottables of a Type"]
BreadcrumbUrls: ["/cookbook/5.0/", "/cookbook/5.0/PlottableManagement", "/cookbook/5.0/PlottableManagement/RemoveAll"]
Date: 2024-10-30
Version: ScottPlot 5.0.42
Version: ScottPlot 5.0.42
SearchUrl: "/cookbook/5.0/search/"
ShowEditLink: false
---


<h2 style='border-bottom: 0;'><a href='/cookbook/5.0/PlottableManagement/RemoveAll'>Removing all Plottables of a Type</a></h2>

<div class="d-flex mb-2">
<a class="btn btn-sm btn-primary me-1" href="/cookbook/5.0/PlottableManagement/RemoveAll">Recipe Permalink</a>
<a class="btn btn-sm btn-success me-1" href="/cookbook/5.0/PlottableManagement">Category: Plottable Management</a>
</div>

All plottables of a given type may be removed from a plot with a single command.

[![](/cookbook/5.0/images/RemoveAll.png?241029205813)](/cookbook/5.0/images/RemoveAll.png?241029205813)

{{< recipe-sp5 >}}ScottPlot.Plot myPlot = new();

myPlot.Add.Scatter(Generate.Consecutive(51), Generate.Sin(51));
myPlot.Add.Signal(Generate.Cos());
myPlot.Add.HorizontalLine(0.75);

// remove every instance of a specific plottable type
myPlot.Remove<ScottPlot.Plottables.Signal>();

myPlot.SavePng("demo.png", 400, 300);
{{< /recipe-sp5 >}}

<hr class='my-5 invisible'>


