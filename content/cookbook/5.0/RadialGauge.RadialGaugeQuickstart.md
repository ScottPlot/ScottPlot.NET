---
Title: Radial gauge from values - ScottPlot 5.0 Cookbook
Description: A radial gauge chart can be created from a few values.
URL: /cookbook/5.0/RadialGauge/RadialGaugeQuickstart/
BreadcrumbNames: ["ScottPlot 5.0 Cookbook", "Radial gauge", "Radial gauge from values"]
BreadcrumbUrls: ["/cookbook/5.0/", "/cookbook/5.0/RadialGauge", "/cookbook/5.0/RadialGauge/RadialGaugeQuickstart"]
Date: 2024-10-31
Version: ScottPlot 5.0.42
Version: ScottPlot 5.0.42
SearchUrl: "/cookbook/5.0/search/"
ShowEditLink: false
---


<h2 style='border-bottom: 0;'><a href='/cookbook/5.0/RadialGauge/RadialGaugeQuickstart'>Radial gauge from values</a></h2>

<div class="d-flex mb-2">
<a class="btn btn-sm btn-primary me-1" href="/cookbook/5.0/RadialGauge/RadialGaugeQuickstart">Recipe Permalink</a>
<a class="btn btn-sm btn-success me-1" href="/cookbook/5.0/RadialGauge">Category: Radial gauge</a>
</div>

A radial gauge chart can be created from a few values.

[![](/cookbook/5.0/images/RadialGaugeQuickstart.png?241031194635)](/cookbook/5.0/images/RadialGaugeQuickstart.png?241031194635)

{{< recipe-sp5 >}}ScottPlot.Plot myPlot = new();

double[] values = { 100, 80, 65, 45, 20 };
myPlot.Add.RadialGaugePlot(values);

myPlot.SavePng("demo.png", 400, 300);
{{< /recipe-sp5 >}}

<hr class='my-5 invisible'>


