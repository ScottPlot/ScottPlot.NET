---
Title: Add Plottables Manually - ScottPlot 5 Cookbook
Description: Although the Plot.Add class has many helpful methods for creating plottable objects and adding them to the plot, users can instantiate plottable objects themselves and use Add.Plottable() to place it on the plot. This strategy allows users to create their own plottables (implementing IPlottable) with custom appearance or behavior.
URL: /cookbook/5/PlottableManagement/AddPlottablesManually/
BreadcrumbNames: ["ScottPlot 5 Cookbook", "Plottable Management", "Add Plottables Manually"]
BreadcrumbUrls: ["/cookbook/5/", "/cookbook/5/PlottableManagement", "/cookbook/5/PlottableManagement/AddPlottablesManually"]
Date: 2026-03-29
Version: ScottPlot 5.1.58
Version: ScottPlot 5.1.58
SearchUrl: "/cookbook/5/search/"
ShowEditLink: false
---


<div class='d-flex align-items-center mt-5'>
<h1 class='me-2 text-dark my-0 border-0'>Add Plottables Manually</h1>
</div>

Although the Plot.Add class has many helpful methods for creating plottable objects and adding them to the plot, users can instantiate plottable objects themselves and use Add.Plottable() to place it on the plot. This strategy allows users to create their own plottables (implementing IPlottable) with custom appearance or behavior.

[![](/cookbook/5/images/AddPlottablesManually.png?260329072039)](/cookbook/5/images/AddPlottablesManually.png?260329072039)

{{< recipe-sp5 sourceUrl="https://github.com/ScottPlot/ScottPlot/blob/main/src/ScottPlot5/ScottPlot5%20Cookbook/Recipes/General/PlottableManagement.cs" imageUrl="/cookbook/5/images/AddPlottablesManually.png?260329072039" >}}ScottPlot.Plot myPlot = new();

// create a plottable and modify it as desired
ScottPlot.Plottables.LinePlot line = new()
{
    Start = new Coordinates(1, 2),
    End = new Coordinates(3, 4),
};

// add the custom plottable to the plot
myPlot.Add.Plottable(line);

myPlot.SavePng("demo.png", 400, 300);
{{< /recipe-sp5 >}}

<div class='my-5 text-center'>This recipe is one of many in the <a href='/cookbook/5/PlottableManagement'>Plottable Management</a> category</div>


