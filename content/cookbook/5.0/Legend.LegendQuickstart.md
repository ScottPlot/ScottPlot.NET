---
Title: Legend Quickstart - ScottPlot 5.0 Cookbook
Description: Many plottables have a Label property that can be set so they appear in the legend.
URL: /cookbook/5.0/Legend/LegendQuickstart/
BreadcrumbNames: ["ScottPlot 5.0 Cookbook", "Legends", "Legend Quickstart"]
BreadcrumbUrls: ["/cookbook/5.0/", "/cookbook/5.0/Legend", "/cookbook/5.0/Legend/LegendQuickstart"]
Date: 2024-11-06
Version: ScottPlot 5.0.43
Version: ScottPlot 5.0.43
SearchUrl: "/cookbook/5.0/search/"
ShowEditLink: false
---


<div class='d-flex align-items-center mt-5'>
<h1 class='me-2 text-dark my-0 border-0'>Legend Quickstart</h1>
</div>

Many plottables have a Label property that can be set so they appear in the legend.

[![](/cookbook/5.0/images/LegendQuickstart.png?241105214550)](/cookbook/5.0/images/LegendQuickstart.png?241105214550)

{{< recipe-sp5 sourceUrl="https://github.com/ScottPlot/ScottPlot/blob/main/src/ScottPlot5/ScottPlot5%20Cookbook/Recipes/General/Legend.cs" imageUrl="/cookbook/5.0/images/LegendQuickstart.png?241105214550" >}}ScottPlot.Plot myPlot = new();

var sig1 = myPlot.Add.Signal(Generate.Sin(51));
sig1.LegendText = "Sin";

var sig2 = myPlot.Add.Signal(Generate.Cos(51));
sig2.LegendText = "Cos";

myPlot.ShowLegend();

myPlot.SavePng("demo.png", 400, 300);
{{< /recipe-sp5 >}}

<div class='my-5 text-center'>This recipe is one of many in the <a href='/cookbook/5.0/Legend'>Legends</a> category</div>


