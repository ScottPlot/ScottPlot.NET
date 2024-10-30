---
Title: Multiplot Quickstart - ScottPlot 5.0 Cookbook
Description: Use the Multiplot class to create figures with multiple subplots.
URL: /cookbook/5.0/MultiplotRecipes/MultiplotQuickstart/
BreadcrumbNames: ["ScottPlot 5.0 Cookbook", "Multiplot", "Multiplot Quickstart"]
BreadcrumbUrls: ["/cookbook/5.0/", "/cookbook/5.0/MultiplotRecipes", "/cookbook/5.0/MultiplotRecipes/MultiplotQuickstart"]
Date: 2024-10-30
Version: ScottPlot 5.0.42
Version: ScottPlot 5.0.42
SearchUrl: "/cookbook/5.0/search/"
ShowEditLink: false
---


<h2 style='border-bottom: 0;'><a href='/cookbook/5.0/MultiplotRecipes/MultiplotQuickstart'>Multiplot Quickstart</a></h2>

<div class="d-flex mb-2">
<a class="btn btn-sm btn-primary me-1" href="/cookbook/5.0/MultiplotRecipes/MultiplotQuickstart">Recipe Permalink</a>
<a class="btn btn-sm btn-success me-1" href="/cookbook/5.0/MultiplotRecipes">Category: Multiplot</a>
</div>

Use the Multiplot class to create figures with multiple subplots.

[![](/cookbook/5.0/images/MultiplotQuickstart.png?241029205813)](/cookbook/5.0/images/MultiplotQuickstart.png?241029205813)

{{< recipe-sp5 >}}ScottPlot.Multiplot multiplot = new();

ScottPlot.Plot plot1 = new();
plot1.Add.Signal(Generate.Sin());

ScottPlot.Plot plot2 = new();
plot2.Add.Signal(Generate.Cos());

multiplot.AddPlot(plot1);
multiplot.AddPlot(plot2);

multiplot.SavePng("demo.png", 400, 400);
{{< /recipe-sp5 >}}

<hr class='my-5 invisible'>


