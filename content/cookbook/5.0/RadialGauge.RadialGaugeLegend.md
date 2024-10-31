---
Title: Gauge Labels in Legend - ScottPlot 5.0 Cookbook
Description: Radial gauge labels will appear in the legend if they are assigned. 
URL: /cookbook/5.0/RadialGauge/RadialGaugeLegend/
BreadcrumbNames: ["ScottPlot 5.0 Cookbook", "Radial gauge", "Gauge Labels in Legend"]
BreadcrumbUrls: ["/cookbook/5.0/", "/cookbook/5.0/RadialGauge", "/cookbook/5.0/RadialGauge/RadialGaugeLegend"]
Date: 2024-10-31
Version: ScottPlot 5.0.42
Version: ScottPlot 5.0.42
SearchUrl: "/cookbook/5.0/search/"
ShowEditLink: false
---


<h2 style='border-bottom: 0;'><a href='/cookbook/5.0/RadialGauge/RadialGaugeLegend'>Gauge Labels in Legend</a></h2>

<div class="d-flex mb-2">
<a class="btn btn-sm btn-primary me-1" href="/cookbook/5.0/RadialGauge/RadialGaugeLegend">Recipe Permalink</a>
<a class="btn btn-sm btn-success me-1" href="/cookbook/5.0/RadialGauge">Category: Radial gauge</a>
</div>

Radial gauge labels will appear in the legend if they are assigned. 

[![](/cookbook/5.0/images/RadialGaugeLegend.png?241031194635)](/cookbook/5.0/images/RadialGaugeLegend.png?241031194635)

{{< recipe-sp5 >}}ScottPlot.Plot myPlot = new();

myPlot.Add.Palette = new ScottPlot.Palettes.Nord();
double[] values = { 100, 80, 65, 45, 20 };

var radialGaugePlot = myPlot.Add.RadialGaugePlot(values);
radialGaugePlot.Labels = new string[] { "alpha", "beta", "gamma", "delta", "epsilon" };
myPlot.ShowLegend();

myPlot.SavePng("demo.png", 400, 300);
{{< /recipe-sp5 >}}

<hr class='my-5 invisible'>


