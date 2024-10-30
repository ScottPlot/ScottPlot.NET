---
Title: Sequential Gauge Mode - ScottPlot 5.0 Cookbook
Description: Sequential gauge mode indicates that the base of each gauge starts at the tip of the previous gauge.
URL: /cookbook/5.0/RadialGauge/RadialGaugeSequential/
BreadcrumbNames: ["ScottPlot 5.0 Cookbook", "Radial gauge", "Sequential Gauge Mode"]
BreadcrumbUrls: ["/cookbook/5.0/", "/cookbook/5.0/RadialGauge", "/cookbook/5.0/RadialGauge/RadialGaugeSequential"]
Date: 2024-10-30
Version: ScottPlot 5.0.42
Version: ScottPlot 5.0.42
SearchUrl: "/cookbook/5.0/search/"
ShowEditLink: false
---


<h2 style='border-bottom: 0;'><a href='/cookbook/5.0/RadialGauge/RadialGaugeSequential'>Sequential Gauge Mode</a></h2>

<div class="d-flex mb-2">
<a class="btn btn-sm btn-primary me-1" href="/cookbook/5.0/RadialGauge/RadialGaugeSequential">Recipe Permalink</a>
<a class="btn btn-sm btn-success me-1" href="/cookbook/5.0/RadialGauge">Category: Radial gauge</a>
</div>

Sequential gauge mode indicates that the base of each gauge starts at the tip of the previous gauge.

[![](/cookbook/5.0/images/RadialGaugeSequential.png?241029205813)](/cookbook/5.0/images/RadialGaugeSequential.png?241029205813)

{{< recipe-sp5 >}}ScottPlot.Plot myPlot = new();

myPlot.Add.Palette = new ScottPlot.Palettes.Nord();
double[] values = { 100, 80, 65, 45, 50 };
var radialGaugePlot = myPlot.Add.RadialGaugePlot(values);
radialGaugePlot.GaugeMode = ScottPlot.RadialGaugeMode.Sequential;

myPlot.SavePng("demo.png", 400, 300);
{{< /recipe-sp5 >}}

<hr class='my-5 invisible'>


