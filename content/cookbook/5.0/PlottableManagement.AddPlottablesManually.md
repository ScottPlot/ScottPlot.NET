---
Title: Add Plottables Manually - ScottPlot 5.0 Cookbook
Description: Although the Plot.Add class has many helpful methods for creating plottable objects and adding them to the plot, users can instantiate plottable objects themselves and use Add.Plottable() to place it on the plot. This strategy allows users to create their own plottables (implementing IPlottable) with custom appearance or behavior.
URL: /cookbook/5.0/PlottableManagement/AddPlottablesManually/
BreadcrumbNames: ["ScottPlot 5.0 Cookbook", "Plottable Management", "Add Plottables Manually"]
BreadcrumbUrls: ["/cookbook/5.0/", "/cookbook/5.0/PlottableManagement", "/cookbook/5.0/PlottableManagement/AddPlottablesManually"]
Date: 2024-10-31
Version: ScottPlot 5.0.42
Version: ScottPlot 5.0.42
SearchUrl: "/cookbook/5.0/search/"
ShowEditLink: false
---


<h2 style='border-bottom: 0;'><a href='/cookbook/5.0/PlottableManagement/AddPlottablesManually'>Add Plottables Manually</a></h2>

<div class="d-flex mb-2">
<a class="btn btn-sm btn-primary me-1" href="/cookbook/5.0/PlottableManagement/AddPlottablesManually">Recipe Permalink</a>
<a class="btn btn-sm btn-success me-1" href="/cookbook/5.0/PlottableManagement">Category: Plottable Management</a>
</div>

Although the Plot.Add class has many helpful methods for creating plottable objects and adding them to the plot, users can instantiate plottable objects themselves and use Add.Plottable() to place it on the plot. This strategy allows users to create their own plottables (implementing IPlottable) with custom appearance or behavior.

[![](/cookbook/5.0/images/AddPlottablesManually.png?241031194635)](/cookbook/5.0/images/AddPlottablesManually.png?241031194635)

{{< recipe-sp5 >}}ScottPlot.Plot myPlot = new();

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

<hr class='my-5 invisible'>


