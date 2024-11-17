---
Title: Clearing Plots - ScottPlot 5.0 Cookbook
Description: Use Clear() to remove all plottables.
URL: /cookbook/5.0/PlottableManagement/Clear/
BreadcrumbNames: ["ScottPlot 5.0 Cookbook", "Plottable Management", "Clearing Plots"]
BreadcrumbUrls: ["/cookbook/5.0/", "/cookbook/5.0/PlottableManagement", "/cookbook/5.0/PlottableManagement/Clear"]
Date: 2024-11-17
Version: ScottPlot 5.0.46
Version: ScottPlot 5.0.46
SearchUrl: "/cookbook/5.0/search/"
ShowEditLink: false
---


<div class='d-flex align-items-center mt-5'>
<h1 class='me-2 text-dark my-0 border-0'>Clearing Plots</h1>
</div>

Use Clear() to remove all plottables.

[![](/cookbook/5.0/images/Clear.png?241117162641)](/cookbook/5.0/images/Clear.png?241117162641)

{{< recipe-sp5 sourceUrl="https://github.com/ScottPlot/ScottPlot/blob/main/src/ScottPlot5/ScottPlot5%20Cookbook/Recipes/General/PlottableManagement.cs" imageUrl="/cookbook/5.0/images/Clear.png?241117162641" >}}ScottPlot.Plot myPlot = new();

// add plottables
myPlot.Add.Signal(Generate.Sin());
myPlot.Add.Signal(Generate.Cos());

// remove all plottables
myPlot.Clear();

myPlot.SavePng("demo.png", 400, 300);
{{< /recipe-sp5 >}}

<div class='my-5 text-center'>This recipe is one of many in the <a href='/cookbook/5.0/PlottableManagement'>Plottable Management</a> category</div>


