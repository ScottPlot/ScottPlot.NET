---
Title: Gauge Size - ScottPlot 5.0 Cookbook
Description: The empty space between gauges can be adjusted as a fraction of their width. 
URL: /cookbook/5.0/RadialGauge/RadialGaugeSize/
BreadcrumbNames: ["ScottPlot 5.0 Cookbook", "Radial gauge", "Gauge Size"]
BreadcrumbUrls: ["/cookbook/5.0/", "/cookbook/5.0/RadialGauge", "/cookbook/5.0/RadialGauge/RadialGaugeSize"]
Date: 2024-10-30
Version: ScottPlot 5.0.42
Version: ScottPlot 5.0.42
SearchUrl: "/cookbook/5.0/search/"
ShowEditLink: false
---


<h2 style='border-bottom: 0;'><a href='/cookbook/5.0/RadialGauge/RadialGaugeSize'>Gauge Size</a></h2>

<div class="d-flex mb-2">
<a class="btn btn-sm btn-primary me-1" href="/cookbook/5.0/RadialGauge/RadialGaugeSize">Recipe Permalink</a>
<a class="btn btn-sm btn-success me-1" href="/cookbook/5.0/RadialGauge">Category: Radial gauge</a>
</div>

The empty space between gauges can be adjusted as a fraction of their width. 

[![](/cookbook/5.0/images/RadialGaugeSize.png?241029205813)](/cookbook/5.0/images/RadialGaugeSize.png?241029205813)

{{< recipe-sp5 >}}ScottPlot.Plot myPlot = new();

myPlot.Add.Palette = new ScottPlot.Palettes.Nord();
double[] values = { 100, 80, 65, 45, 20 };
var radialGaugePlot = myPlot.Add.RadialGaugePlot(values);
radialGaugePlot.SpaceFraction = .05;

myPlot.SavePng("demo.png", 400, 300);
{{< /recipe-sp5 >}}

<hr class='my-5 invisible'>


