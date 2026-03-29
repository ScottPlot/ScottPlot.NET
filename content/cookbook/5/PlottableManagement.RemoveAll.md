---
Title: Removing all Plottables of a Type - ScottPlot 5 Cookbook
Description: All plottables of a given type may be removed from a plot with a single command.
URL: /cookbook/5/PlottableManagement/RemoveAll/
BreadcrumbNames: ["ScottPlot 5 Cookbook", "Plottable Management", "Removing all Plottables of a Type"]
BreadcrumbUrls: ["/cookbook/5/", "/cookbook/5/PlottableManagement", "/cookbook/5/PlottableManagement/RemoveAll"]
Date: 2026-03-29
Version: ScottPlot 5.1.58
Version: ScottPlot 5.1.58
SearchUrl: "/cookbook/5/search/"
ShowEditLink: false
---


<div class='d-flex align-items-center mt-5'>
<h1 class='me-2 text-dark my-0 border-0'>Removing all Plottables of a Type</h1>
</div>

All plottables of a given type may be removed from a plot with a single command.

[![](/cookbook/5/images/RemoveAll.png?260329072039)](/cookbook/5/images/RemoveAll.png?260329072039)

{{< recipe-sp5 sourceUrl="https://github.com/ScottPlot/ScottPlot/blob/main/src/ScottPlot5/ScottPlot5%20Cookbook/Recipes/General/PlottableManagement.cs" imageUrl="/cookbook/5/images/RemoveAll.png?260329072039" >}}ScottPlot.Plot myPlot = new();

myPlot.Add.Scatter(Generate.Consecutive(51), Generate.Sin(51));
myPlot.Add.Signal(Generate.Cos());
myPlot.Add.HorizontalLine(0.75);

// remove every instance of a specific plottable type
myPlot.Remove&lt;ScottPlot.Plottables.Signal&gt;();

myPlot.SavePng("demo.png", 400, 300);
{{< /recipe-sp5 >}}

<div class='my-5 text-center'>This recipe is one of many in the <a href='/cookbook/5/PlottableManagement'>Plottable Management</a> category</div>


