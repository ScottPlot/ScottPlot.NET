---
Title: Negative Values - ScottPlot 5.0 Cookbook
Description: Radial gauge plots support positive and negative values.
URL: /cookbook/5.0/RadialGauge/RadialGaugeNegative/
BreadcrumbNames: ["ScottPlot 5.0 Cookbook", "Radial gauge", "Negative Values"]
BreadcrumbUrls: ["/cookbook/5.0/", "/cookbook/5.0/RadialGauge", "/cookbook/5.0/RadialGauge/RadialGaugeNegative"]
Date: 2024-10-30
Version: ScottPlot 5.0.42
Version: ScottPlot 5.0.42
SearchUrl: "/cookbook/5.0/search/"
ShowEditLink: false
---


<h2 style='border-bottom: 0;'><a href='/cookbook/5.0/RadialGauge/RadialGaugeNegative'>Negative Values</a></h2>

<div class="d-flex mb-2">
<a class="btn btn-sm btn-primary me-1" href="/cookbook/5.0/RadialGauge/RadialGaugeNegative">Recipe Permalink</a>
<a class="btn btn-sm btn-success me-1" href="/cookbook/5.0/RadialGauge">Category: Radial gauge</a>
</div>

Radial gauge plots support positive and negative values.

[![](/cookbook/5.0/images/RadialGaugeNegative.png?241029205813)](/cookbook/5.0/images/RadialGaugeNegative.png?241029205813)

{{< recipe-sp5 >}}ScottPlot.Plot myPlot = new();

myPlot.Add.Palette = new ScottPlot.Palettes.Nord();
double[] values = { 100, 80, -65, 45, -20 };
myPlot.Add.RadialGaugePlot(values);

myPlot.SavePng("demo.png", 400, 300);
{{< /recipe-sp5 >}}

<hr class='my-5 invisible'>


