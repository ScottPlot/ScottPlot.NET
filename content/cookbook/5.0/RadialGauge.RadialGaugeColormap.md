---
Title: Gauge Colors - ScottPlot 5.0 Cookbook
Description: Gauge colors can be customized by changing the default palette.
URL: /cookbook/5.0/RadialGauge/RadialGaugeColormap/
BreadcrumbNames: ["ScottPlot 5.0 Cookbook", "Radial gauge", "Gauge Colors"]
BreadcrumbUrls: ["/cookbook/5.0/", "/cookbook/5.0/RadialGauge", "/cookbook/5.0/RadialGauge/RadialGaugeColormap"]
Date: 2024-10-31
Version: ScottPlot 5.0.42
Version: ScottPlot 5.0.42
SearchUrl: "/cookbook/5.0/search/"
ShowEditLink: false
---


<h2 style='border-bottom: 0;'><a href='/cookbook/5.0/RadialGauge/RadialGaugeColormap'>Gauge Colors</a></h2>

<div class="d-flex mb-2">
<a class="btn btn-sm btn-primary me-1" href="/cookbook/5.0/RadialGauge/RadialGaugeColormap">Recipe Permalink</a>
<a class="btn btn-sm btn-success me-1" href="/cookbook/5.0/RadialGauge">Category: Radial gauge</a>
</div>

Gauge colors can be customized by changing the default palette.

[![](/cookbook/5.0/images/RadialGaugeColormap.png?241031194635)](/cookbook/5.0/images/RadialGaugeColormap.png?241031194635)

{{< recipe-sp5 >}}ScottPlot.Plot myPlot = new();

myPlot.Add.Palette = new ScottPlot.Palettes.Nord();
double[] values = { 100, 80, 65, 45, 20 };
myPlot.Add.RadialGaugePlot(values);

myPlot.SavePng("demo.png", 400, 300);
{{< /recipe-sp5 >}}

<hr class='my-5 invisible'>


