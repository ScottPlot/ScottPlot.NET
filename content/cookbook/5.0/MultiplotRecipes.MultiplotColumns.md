---
Title: Multiplot Columns - ScottPlot 5.0 Cookbook
Description: The Multiplot's Layout property may be customized to achieve a column layout.
URL: /cookbook/5.0/MultiplotRecipes/MultiplotColumns/
BreadcrumbNames: ["ScottPlot 5.0 Cookbook", "Multiplot", "Multiplot Columns"]
BreadcrumbUrls: ["/cookbook/5.0/", "/cookbook/5.0/MultiplotRecipes", "/cookbook/5.0/MultiplotRecipes/MultiplotColumns"]
Date: 2024-11-13
Version: ScottPlot 5.0.45
Version: ScottPlot 5.0.45
SearchUrl: "/cookbook/5.0/search/"
ShowEditLink: false
---


<div class='d-flex align-items-center mt-5'>
<h1 class='me-2 text-dark my-0 border-0'>Multiplot Columns</h1>
</div>

The Multiplot's Layout property may be customized to achieve a column layout.

[![](/cookbook/5.0/images/MultiplotColumns.png?241112193154)](/cookbook/5.0/images/MultiplotColumns.png?241112193154)

{{< recipe-sp5 sourceUrl="https://github.com/ScottPlot/ScottPlot/blob/main/src/ScottPlot5/ScottPlot5%20Cookbook/Recipes/General/MultiplotRecipes.cs" imageUrl="/cookbook/5.0/images/MultiplotColumns.png?241112193154" >}}ScottPlot.Multiplot multiplot = new();

ScottPlot.Plot plot1 = new();
plot1.Add.Signal(Generate.Sin());

ScottPlot.Plot plot2 = new();
plot2.Add.Signal(Generate.Cos());

multiplot.AddPlot(plot1);
multiplot.AddPlot(plot2);
multiplot.Layout = new ScottPlot.MultiplotLayouts.Columns();

multiplot.SavePng("demo.png", 400, 400);
{{< /recipe-sp5 >}}

<div class='my-5 text-center'>This recipe is one of many in the <a href='/cookbook/5.0/MultiplotRecipes'>Multiplot</a> category</div>


