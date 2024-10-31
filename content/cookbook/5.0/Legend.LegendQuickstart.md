---
Title: Legend Quickstart - ScottPlot 5.0 Cookbook
Description: Many plottables have a Label property that can be set so they appear in the legend.
URL: /cookbook/5.0/Legend/LegendQuickstart/
BreadcrumbNames: ["ScottPlot 5.0 Cookbook", "Legends", "Legend Quickstart"]
BreadcrumbUrls: ["/cookbook/5.0/", "/cookbook/5.0/Legend", "/cookbook/5.0/Legend/LegendQuickstart"]
Date: 2024-10-31
Version: ScottPlot 5.0.42
Version: ScottPlot 5.0.42
SearchUrl: "/cookbook/5.0/search/"
ShowEditLink: false
---


<h2 style='border-bottom: 0;'><a href='/cookbook/5.0/Legend/LegendQuickstart'>Legend Quickstart</a></h2>

<div class="d-flex mb-2">
<a class="btn btn-sm btn-primary me-1" href="/cookbook/5.0/Legend/LegendQuickstart">Recipe Permalink</a>
<a class="btn btn-sm btn-success me-1" href="/cookbook/5.0/Legend">Category: Legends</a>
</div>

Many plottables have a Label property that can be set so they appear in the legend.

[![](/cookbook/5.0/images/LegendQuickstart.png?241031194635)](/cookbook/5.0/images/LegendQuickstart.png?241031194635)

{{< recipe-sp5 >}}ScottPlot.Plot myPlot = new();

var sig1 = myPlot.Add.Signal(Generate.Sin(51));
sig1.LegendText = "Sin";

var sig2 = myPlot.Add.Signal(Generate.Cos(51));
sig2.LegendText = "Cos";

myPlot.ShowLegend();

myPlot.SavePng("demo.png", 400, 300);
{{< /recipe-sp5 >}}

<hr class='my-5 invisible'>


