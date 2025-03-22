---
Title: Multiplot Quickstart - ScottPlot 5.0 Cookbook
Description: Use the Multiplot class to create figures with multiple subplots.
URL: /cookbook/5.0/MultiplotRecipes/MultiplotQuickstart/
BreadcrumbNames: ["ScottPlot 5.0 Cookbook", "Multiplot", "Multiplot Quickstart"]
BreadcrumbUrls: ["/cookbook/5.0/", "/cookbook/5.0/MultiplotRecipes", "/cookbook/5.0/MultiplotRecipes/MultiplotQuickstart"]
Date: 2025-03-22
Version: ScottPlot 5.0.55
Version: ScottPlot 5.0.55
SearchUrl: "/cookbook/5.0/search/"
ShowEditLink: false
---


<div class='d-flex align-items-center mt-5'>
<h1 class='me-2 text-dark my-0 border-0'>Multiplot Quickstart</h1>
</div>

Use the Multiplot class to create figures with multiple subplots.

[![](/cookbook/5.0/images/MultiplotQuickstart.png?250322130304)](/cookbook/5.0/images/MultiplotQuickstart.png?250322130304)

{{< recipe-sp5 sourceUrl="https://github.com/ScottPlot/ScottPlot/blob/main/src/ScottPlot5/ScottPlot5%20Cookbook/Recipes/General/MultiplotRecipes.cs" imageUrl="/cookbook/5.0/images/MultiplotQuickstart.png?250322130304" >}}ScottPlot.Multiplot multiplot = new();

// configure the multiplot to use 2 subplots
multiplot.AddPlots(2);
Plot plot1 = multiplot.Subplots.GetPlot(0);
Plot plot2 = multiplot.Subplots.GetPlot(1);

// add sample data to each subplot
plot1.Add.Signal(Generate.Sin());
plot2.Add.Signal(Generate.Cos());

multiplot.SavePng("demo.png", 400, 400);
{{< /recipe-sp5 >}}

<div class='my-5 text-center'>This recipe is one of many in the <a href='/cookbook/5.0/MultiplotRecipes'>Multiplot</a> category</div>


