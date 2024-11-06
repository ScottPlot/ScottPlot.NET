---
Title: Multiplot Grid - ScottPlot 5.0 Cookbook
Description: The Multiplot's Layout property may be customized to achieve a grid layout.
URL: /cookbook/5.0/MultiplotRecipes/MultiplotGrid/
BreadcrumbNames: ["ScottPlot 5.0 Cookbook", "Multiplot", "Multiplot Grid"]
BreadcrumbUrls: ["/cookbook/5.0/", "/cookbook/5.0/MultiplotRecipes", "/cookbook/5.0/MultiplotRecipes/MultiplotGrid"]
Date: 2024-11-06
Version: ScottPlot 5.0.43
Version: ScottPlot 5.0.43
SearchUrl: "/cookbook/5.0/search/"
ShowEditLink: false
---


<div class='d-flex align-items-center mt-5'>
<h1 class='me-2 text-dark my-0 border-0'>Multiplot Grid</h1>
</div>

The Multiplot's Layout property may be customized to achieve a grid layout.

[![](/cookbook/5.0/images/MultiplotGrid.png?241105214550)](/cookbook/5.0/images/MultiplotGrid.png?241105214550)

{{< recipe-sp5 sourceUrl="https://github.com/ScottPlot/ScottPlot/blob/main/src/ScottPlot5/ScottPlot5%20Cookbook/Recipes/General/MultiplotRecipes.cs" imageUrl="/cookbook/5.0/images/MultiplotGrid.png?241105214550" >}}ScottPlot.Multiplot multiplot = new();

for (int i = 0; i &lt; 6; i++)
{
    ScottPlot.Plot plot = new();
    double[] ys = Generate.Sin(oscillations: i + 1);
    plot.Add.Signal(ys);
    multiplot.AddPlot(plot);
}

multiplot.Layout = new ScottPlot.MultiplotLayouts.Grid(2);

multiplot.SavePng("demo.png", 400, 400);
{{< /recipe-sp5 >}}

<div class='my-5 text-center'>This recipe is one of many in the <a href='/cookbook/5.0/MultiplotRecipes'>Multiplot</a> category</div>


