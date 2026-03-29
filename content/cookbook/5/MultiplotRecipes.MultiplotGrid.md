---
Title: Multiplot Grid - ScottPlot 5 Cookbook
Description: The Multiplot's Layout property may be customized to achieve a grid layout.
URL: /cookbook/5/MultiplotRecipes/MultiplotGrid/
BreadcrumbNames: ["ScottPlot 5 Cookbook", "Multiplot", "Multiplot Grid"]
BreadcrumbUrls: ["/cookbook/5/", "/cookbook/5/MultiplotRecipes", "/cookbook/5/MultiplotRecipes/MultiplotGrid"]
Date: 2026-03-29
Version: ScottPlot 5.1.58
Version: ScottPlot 5.1.58
SearchUrl: "/cookbook/5/search/"
ShowEditLink: false
---


<div class='d-flex align-items-center mt-5'>
<h1 class='me-2 text-dark my-0 border-0'>Multiplot Grid</h1>
</div>

The Multiplot's Layout property may be customized to achieve a grid layout.

[![](/cookbook/5/images/MultiplotGrid.png?260329072039)](/cookbook/5/images/MultiplotGrid.png?260329072039)

{{< recipe-sp5 sourceUrl="https://github.com/ScottPlot/ScottPlot/blob/main/src/ScottPlot5/ScottPlot5%20Cookbook/Recipes/General/MultiplotRecipes.cs" imageUrl="/cookbook/5/images/MultiplotGrid.png?260329072039" >}}ScottPlot.Multiplot multiplot = new();

// configure the multiplot to have 6 subplots
multiplot.AddPlots(6);

// add sample data to each subplot
for (int i = 0; i &lt; multiplot.Subplots.Count; i++)
{
    Plot plot = multiplot.GetPlot(i);
    double[] ys = Generate.Sin(oscillations: i + 1);
    plot.Add.Signal(ys);
}

// configure the multiplot to use a grid layout
multiplot.Layout = new ScottPlot.MultiplotLayouts.Grid(rows: 2, columns: 3);

multiplot.SavePng("demo.png", 400, 400);
{{< /recipe-sp5 >}}

<div class='my-5 text-center'>This recipe is one of many in the <a href='/cookbook/5/MultiplotRecipes'>Multiplot</a> category</div>


