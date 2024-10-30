---
Title: Multiplot Columns - ScottPlot 5.0 Cookbook
Description: The Multiplot's Layout property may be customized to achieve a column layout.
URL: /cookbook/5.0/MultiplotRecipes/MultiplotColumns/
BreadcrumbNames: ["ScottPlot 5.0 Cookbook", "Multiplot", "Multiplot Columns"]
BreadcrumbUrls: ["/cookbook/5.0/", "/cookbook/5.0/MultiplotRecipes", "/cookbook/5.0/MultiplotRecipes/MultiplotColumns"]
Date: 2024-10-30
Version: ScottPlot 5.0.42
Version: ScottPlot 5.0.42
SearchUrl: "/cookbook/5.0/search/"
ShowEditLink: false
---


<h2 style='border-bottom: 0;'><a href='/cookbook/5.0/MultiplotRecipes/MultiplotColumns'>Multiplot Columns</a></h2>

<div class="d-flex mb-2">
<a class="btn btn-sm btn-primary me-1" href="/cookbook/5.0/MultiplotRecipes/MultiplotColumns">Recipe Permalink</a>
<a class="btn btn-sm btn-success me-1" href="/cookbook/5.0/MultiplotRecipes">Category: Multiplot</a>
</div>

The Multiplot's Layout property may be customized to achieve a column layout.

[![](/cookbook/5.0/images/MultiplotColumns.png?241029205813)](/cookbook/5.0/images/MultiplotColumns.png?241029205813)

{{< recipe-sp5 >}}ScottPlot.Multiplot multiplot = new();

ScottPlot.Plot plot1 = new();
plot1.Add.Signal(Generate.Sin());

ScottPlot.Plot plot2 = new();
plot2.Add.Signal(Generate.Cos());

multiplot.AddPlot(plot1);
multiplot.AddPlot(plot2);
multiplot.Layout = new ScottPlot.MultiplotLayouts.Columns();

multiplot.SavePng("demo.png", 400, 400);
{{< /recipe-sp5 >}}

<hr class='my-5 invisible'>


