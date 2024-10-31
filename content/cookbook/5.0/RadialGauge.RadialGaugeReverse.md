---
Title: Reverse Order - ScottPlot 5.0 Cookbook
Description: Gauges are displayed from the center outward by default but the order can be customized.
URL: /cookbook/5.0/RadialGauge/RadialGaugeReverse/
BreadcrumbNames: ["ScottPlot 5.0 Cookbook", "Radial gauge", "Reverse Order"]
BreadcrumbUrls: ["/cookbook/5.0/", "/cookbook/5.0/RadialGauge", "/cookbook/5.0/RadialGauge/RadialGaugeReverse"]
Date: 2024-10-31
Version: ScottPlot 5.0.42
Version: ScottPlot 5.0.42
SearchUrl: "/cookbook/5.0/search/"
ShowEditLink: false
---


<h2 style='border-bottom: 0;'><a href='/cookbook/5.0/RadialGauge/RadialGaugeReverse'>Reverse Order</a></h2>

<div class="d-flex mb-2">
<a class="btn btn-sm btn-primary me-1" href="/cookbook/5.0/RadialGauge/RadialGaugeReverse">Recipe Permalink</a>
<a class="btn btn-sm btn-success me-1" href="/cookbook/5.0/RadialGauge">Category: Radial gauge</a>
</div>

Gauges are displayed from the center outward by default but the order can be customized.

[![](/cookbook/5.0/images/RadialGaugeReverse.png?241031194635)](/cookbook/5.0/images/RadialGaugeReverse.png?241031194635)

{{< recipe-sp5 >}}ScottPlot.Plot myPlot = new();

myPlot.Add.Palette = new ScottPlot.Palettes.Nord();
double[] values = { 100, 80, 65, 45, 50 };
var radialGaugePlot = myPlot.Add.RadialGaugePlot(values);
radialGaugePlot.GaugeMode = ScottPlot.RadialGaugeMode.Sequential;
radialGaugePlot.OrderInsideOut = false;

myPlot.SavePng("demo.png", 400, 300);
{{< /recipe-sp5 >}}

<hr class='my-5 invisible'>


