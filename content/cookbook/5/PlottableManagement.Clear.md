---
Title: Clearing Plots - ScottPlot 5 Cookbook
Description: Use Clear() to remove all plottables.
URL: /cookbook/5/PlottableManagement/Clear/
BreadcrumbNames: ["ScottPlot 5 Cookbook", "Plottable Management", "Clearing Plots"]
BreadcrumbUrls: ["/cookbook/5/", "/cookbook/5/PlottableManagement", "/cookbook/5/PlottableManagement/Clear"]
Date: 2026-03-29
Version: ScottPlot 5.1.58
Version: ScottPlot 5.1.58
SearchUrl: "/cookbook/5/search/"
ShowEditLink: false
---


<div class='d-flex align-items-center mt-5'>
<h1 class='me-2 text-dark my-0 border-0'>Clearing Plots</h1>
</div>

Use Clear() to remove all plottables.

[![](/cookbook/5/images/Clear.png?260329072039)](/cookbook/5/images/Clear.png?260329072039)

{{< recipe-sp5 sourceUrl="https://github.com/ScottPlot/ScottPlot/blob/main/src/ScottPlot5/ScottPlot5%20Cookbook/Recipes/General/PlottableManagement.cs" imageUrl="/cookbook/5/images/Clear.png?260329072039" >}}ScottPlot.Plot myPlot = new();

// add plottables
myPlot.Add.Signal(Generate.Sin());
myPlot.Add.Signal(Generate.Cos());

// remove all plottables
myPlot.Clear();

myPlot.SavePng("demo.png", 400, 300);
{{< /recipe-sp5 >}}

<div class='my-5 text-center'>This recipe is one of many in the <a href='/cookbook/5/PlottableManagement'>Plottable Management</a> category</div>


