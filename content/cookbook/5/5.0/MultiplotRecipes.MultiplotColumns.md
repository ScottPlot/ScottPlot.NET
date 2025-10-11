---
Title: Multiplot Columns - ScottPlot 5.0 Cookbook
Description: The Multiplot's Layout property may be customized to achieve a column layout.
URL: /cookbook/5.0/MultiplotRecipes/MultiplotColumns/
BreadcrumbNames: ["ScottPlot 5.0 Cookbook", "Multiplot", "Multiplot Columns"]
BreadcrumbUrls: ["/cookbook/5.0/", "/cookbook/5.0/MultiplotRecipes", "/cookbook/5.0/MultiplotRecipes/MultiplotColumns"]
Date: 2025-01-26
Version: ScottPlot 5.0.55
Version: ScottPlot 5.0.55
SearchUrl: "/cookbook/5.0/search/"
ShowEditLink: false
---


<div class='d-flex align-items-center mt-5'>
<h1 class='me-2 text-dark my-0 border-0'>Multiplot Columns</h1>
</div>

The Multiplot's Layout property may be customized to achieve a column layout.

[![](/cookbook/5.0/images/MultiplotColumns.png?250126165944)](/cookbook/5.0/images/MultiplotColumns.png?250126165944)

{{< recipe-sp5 sourceUrl="https://github.com/ScottPlot/ScottPlot/blob/main/src/ScottPlot5/ScottPlot5%20Cookbook/Recipes/General/MultiplotRecipes.cs" imageUrl="/cookbook/5.0/images/MultiplotColumns.png?250126165944" >}}ScottPlot.Multiplot multiplot = new();

// configure the multiplot to use 2 subplots
multiplot.AddPlots(2);
Plot plot1 = multiplot.Subplots.GetPlot(0);
Plot plot2 = multiplot.Subplots.GetPlot(1);

// add sample data to each subplot
plot1.Add.Signal(Generate.Sin());
plot2.Add.Signal(Generate.Cos());

// apply a custom layout
multiplot.Layout = new ScottPlot.MultiplotLayouts.Columns();

multiplot.SavePng("demo.png", 400, 400);
{{< /recipe-sp5 >}}

<div class='my-5 text-center'>This recipe is one of many in the <a href='/cookbook/5.0/MultiplotRecipes'>Multiplot</a> category</div>


