---
Title: Background Gauges Dim - ScottPlot 5.0 Cookbook
Description: By default the full range of each gauge is drawn as a semitransparent ring. The amount of transparency can be adjusted as desired.
URL: /cookbook/5.0/RadialGauge/RadialGaugeBackDim/
BreadcrumbNames: ["ScottPlot 5.0 Cookbook", "Radial gauge", "Background Gauges Dim"]
BreadcrumbUrls: ["/cookbook/5.0/", "/cookbook/5.0/RadialGauge", "/cookbook/5.0/RadialGauge/RadialGaugeBackDim"]
Date: 2024-10-31
Version: ScottPlot 5.0.42
Version: ScottPlot 5.0.42
SearchUrl: "/cookbook/5.0/search/"
ShowEditLink: false
---


<h2 style='border-bottom: 0;'><a href='/cookbook/5.0/RadialGauge/RadialGaugeBackDim'>Background Gauges Dim</a></h2>

<div class="d-flex mb-2">
<a class="btn btn-sm btn-primary me-1" href="/cookbook/5.0/RadialGauge/RadialGaugeBackDim">Recipe Permalink</a>
<a class="btn btn-sm btn-success me-1" href="/cookbook/5.0/RadialGauge">Category: Radial gauge</a>
</div>

By default the full range of each gauge is drawn as a semitransparent ring. The amount of transparency can be adjusted as desired.

[![](/cookbook/5.0/images/RadialGaugeBackDim.png?241031194635)](/cookbook/5.0/images/RadialGaugeBackDim.png?241031194635)

{{< recipe-sp5 >}}ScottPlot.Plot myPlot = new();

myPlot.Add.Palette = new ScottPlot.Palettes.Nord();
double[] values = { 100, 80, 65, 45, 20 };

var radialGaugePlot = myPlot.Add.RadialGaugePlot(values);
radialGaugePlot.BackgroundTransparencyFraction = .5;

myPlot.SavePng("demo.png", 400, 300);
{{< /recipe-sp5 >}}

<hr class='my-5 invisible'>


