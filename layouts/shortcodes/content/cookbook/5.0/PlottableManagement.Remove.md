---
Title: Removing a Plottable - ScottPlot 5.0 Cookbook
Description: Individual items may be removed from the plot.
URL: /cookbook/5.0/PlottableManagement/Remove/
BreadcrumbNames: ["ScottPlot 5.0 Cookbook", "Plottable Management", "Removing a Plottable"]
BreadcrumbUrls: ["/cookbook/5.0/", "/cookbook/5.0/PlottableManagement", "/cookbook/5.0/PlottableManagement/Remove"]
Date: 2025-08-23
Version: ScottPlot 5.0.56
Version: ScottPlot 5.0.56
SearchUrl: "/cookbook/5.0/search/"
ShowEditLink: false
---


<div class='d-flex align-items-center mt-5'>
<h1 class='me-2 text-dark my-0 border-0'>Removing a Plottable</h1>
</div>

Individual items may be removed from the plot.

[![](/cookbook/5.0/images/Remove.png?250822231048)](/cookbook/5.0/images/Remove.png?250822231048)

{{< recipe-sp5 sourceUrl="https://github.com/ScottPlot/ScottPlot/blob/main/src/ScottPlot5/ScottPlot5%20Cookbook/Recipes/General/PlottableManagement.cs" imageUrl="/cookbook/5.0/images/Remove.png?250822231048" >}}ScottPlot.Plot myPlot = new();

// add plottables
var sig1 = myPlot.Add.Signal(Generate.Sin());
var sig2 = myPlot.Add.Signal(Generate.Cos());

// remove a specific plottable
myPlot.Remove(sig1);

myPlot.SavePng("demo.png", 400, 300);
{{< /recipe-sp5 >}}

<div class='my-5 text-center'>This recipe is one of many in the <a href='/cookbook/5.0/PlottableManagement'>Plottable Management</a> category</div>


