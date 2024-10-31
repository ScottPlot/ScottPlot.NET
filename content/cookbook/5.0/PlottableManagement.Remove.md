---
Title: Removing a Plottable - ScottPlot 5.0 Cookbook
Description: Individual items may be removed from the plot.
URL: /cookbook/5.0/PlottableManagement/Remove/
BreadcrumbNames: ["ScottPlot 5.0 Cookbook", "Plottable Management", "Removing a Plottable"]
BreadcrumbUrls: ["/cookbook/5.0/", "/cookbook/5.0/PlottableManagement", "/cookbook/5.0/PlottableManagement/Remove"]
Date: 2024-10-31
Version: ScottPlot 5.0.42
Version: ScottPlot 5.0.42
SearchUrl: "/cookbook/5.0/search/"
ShowEditLink: false
---


<h2 style='border-bottom: 0;'><a href='/cookbook/5.0/PlottableManagement/Remove'>Removing a Plottable</a></h2>

<div class="d-flex mb-2">
<a class="btn btn-sm btn-primary me-1" href="/cookbook/5.0/PlottableManagement/Remove">Recipe Permalink</a>
<a class="btn btn-sm btn-success me-1" href="/cookbook/5.0/PlottableManagement">Category: Plottable Management</a>
</div>

Individual items may be removed from the plot.

[![](/cookbook/5.0/images/Remove.png?241031194635)](/cookbook/5.0/images/Remove.png?241031194635)

{{< recipe-sp5 >}}ScottPlot.Plot myPlot = new();

// add plottables
var sig1 = myPlot.Add.Signal(Generate.Sin());
var sig2 = myPlot.Add.Signal(Generate.Cos());

// remove a specific plottable
myPlot.Remove(sig1);

myPlot.SavePng("demo.png", 400, 300);
{{< /recipe-sp5 >}}

<hr class='my-5 invisible'>


