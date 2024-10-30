---
Title: Multiplot Grid - ScottPlot 5.0 Cookbook
Description: The Multiplot's Layout property may be customized to achieve a grid layout.
URL: /cookbook/5.0/MultiplotRecipes/MultiplotGrid/
BreadcrumbNames: ["ScottPlot 5.0 Cookbook", "Multiplot", "Multiplot Grid"]
BreadcrumbUrls: ["/cookbook/5.0/", "/cookbook/5.0/MultiplotRecipes", "/cookbook/5.0/MultiplotRecipes/MultiplotGrid"]
Date: 2024-10-30
Version: ScottPlot 5.0.42
Version: ScottPlot 5.0.42
SearchUrl: "/cookbook/5.0/search/"
ShowEditLink: false
---


<h2 style='border-bottom: 0;'><a href='/cookbook/5.0/MultiplotRecipes/MultiplotGrid'>Multiplot Grid</a></h2>

<div class="d-flex mb-2">
<a class="btn btn-sm btn-primary me-1" href="/cookbook/5.0/MultiplotRecipes/MultiplotGrid">Recipe Permalink</a>
<a class="btn btn-sm btn-success me-1" href="/cookbook/5.0/MultiplotRecipes">Category: Multiplot</a>
</div>

The Multiplot's Layout property may be customized to achieve a grid layout.

[![](/cookbook/5.0/images/MultiplotGrid.png?241029205813)](/cookbook/5.0/images/MultiplotGrid.png?241029205813)

{{< recipe-sp5 >}}ScottPlot.Multiplot multiplot = new();

for (int i = 0; i < 6; i++)
{
    ScottPlot.Plot plot = new();
    double[] ys = Generate.Sin(oscillations: i + 1);
    plot.Add.Signal(ys);
    multiplot.AddPlot(plot);
}

multiplot.Layout = new ScottPlot.MultiplotLayouts.Grid(2);

multiplot.SavePng("demo.png", 400, 400);
{{< /recipe-sp5 >}}

<hr class='my-5 invisible'>


