---
Title: Clearing Plots - ScottPlot 5.0 Cookbook
Description: Use Clear() to remove all plottables.
URL: /cookbook/5.0/PlottableManagement/Clear/
BreadcrumbNames: ["ScottPlot 5.0 Cookbook", "Plottable Management", "Clearing Plots"]
BreadcrumbUrls: ["/cookbook/5.0/", "/cookbook/5.0/PlottableManagement", "/cookbook/5.0/PlottableManagement/Clear"]
Date: 2024-10-30
Version: ScottPlot 5.0.42
Version: ScottPlot 5.0.42
SearchUrl: "/cookbook/5.0/search/"
ShowEditLink: false
---


<h2 style='border-bottom: 0;'><a href='/cookbook/5.0/PlottableManagement/Clear'>Clearing Plots</a></h2>

<div class="d-flex mb-2">
<a class="btn btn-sm btn-primary me-1" href="/cookbook/5.0/PlottableManagement/Clear">Recipe Permalink</a>
<a class="btn btn-sm btn-success me-1" href="/cookbook/5.0/PlottableManagement">Category: Plottable Management</a>
</div>

Use Clear() to remove all plottables.

[![](/cookbook/5.0/images/Clear.png?241029205813)](/cookbook/5.0/images/Clear.png?241029205813)

{{< recipe-sp5 >}}ScottPlot.Plot myPlot = new();

// add plottables
myPlot.Add.Signal(Generate.Sin());
myPlot.Add.Signal(Generate.Cos());

// remove all plottables
myPlot.Clear();

myPlot.SavePng("demo.png", 400, 300);
{{< /recipe-sp5 >}}

<hr class='my-5 invisible'>


