---
Title: Multiplot Quickstart - ScottPlot 5 Cookbook
Description: Use the Multiplot class to create figures with multiple subplots.
URL: /cookbook/5/MultiplotRecipes/MultiplotQuickstart/
BreadcrumbNames: ["ScottPlot 5 Cookbook", "Multiplot", "Multiplot Quickstart"]
BreadcrumbUrls: ["/cookbook/5/", "/cookbook/5/MultiplotRecipes", "/cookbook/5/MultiplotRecipes/MultiplotQuickstart"]
Date: 2026-03-29
Version: ScottPlot 5.1.58
Version: ScottPlot 5.1.58
SearchUrl: "/cookbook/5/search/"
ShowEditLink: false
---


<div class='d-flex align-items-center mt-5'>
<h1 class='me-2 text-dark my-0 border-0'>Multiplot Quickstart</h1>
</div>

Use the Multiplot class to create figures with multiple subplots.

[![](/cookbook/5/images/MultiplotQuickstart.png?260329072039)](/cookbook/5/images/MultiplotQuickstart.png?260329072039)

{{< recipe-sp5 sourceUrl="https://github.com/ScottPlot/ScottPlot/blob/main/src/ScottPlot5/ScottPlot5%20Cookbook/Recipes/General/MultiplotRecipes.cs" imageUrl="/cookbook/5/images/MultiplotQuickstart.png?260329072039" >}}ScottPlot.Multiplot multiplot = new();

// configure the multiplot to use 2 subplots
multiplot.AddPlots(2);
Plot plot1 = multiplot.Subplots.GetPlot(0);
Plot plot2 = multiplot.Subplots.GetPlot(1);

// add sample data to each subplot
plot1.Add.Signal(Generate.Sin());
plot2.Add.Signal(Generate.Cos());

multiplot.SavePng("demo.png", 400, 400);
{{< /recipe-sp5 >}}

<div class='my-5 text-center'>This recipe is one of many in the <a href='/cookbook/5/MultiplotRecipes'>Multiplot</a> category</div>


