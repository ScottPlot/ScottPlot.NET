---
Title: Negative Values - ScottPlot 5.0 Cookbook
Description: Radial gauge plots support positive and negative values.
URL: /cookbook/5.0/RadialGauge/RadialGaugeNegative/
BreadcrumbNames: ["ScottPlot 5.0 Cookbook", "Radial gauge", "Negative Values"]
BreadcrumbUrls: ["/cookbook/5.0/", "/cookbook/5.0/RadialGauge", "/cookbook/5.0/RadialGauge/RadialGaugeNegative"]
Date: 2024-11-01
Version: ScottPlot 5.0.42
Version: ScottPlot 5.0.42
SearchUrl: "/cookbook/5.0/search/"
ShowEditLink: false
---


<div class='d-flex align-items-center mt-5'>
<h1 class='me-2 text-dark my-0 border-0'>Negative Values</h1>
</div>

Radial gauge plots support positive and negative values.

[![](/cookbook/5.0/images/RadialGaugeNegative.png?241101192719)](/cookbook/5.0/images/RadialGaugeNegative.png?241101192719)

{{< recipe-sp5 >}}ScottPlot.Plot myPlot = new();

myPlot.Add.Palette = new ScottPlot.Palettes.Nord();
double[] values = { 100, 80, -65, 45, -20 };
myPlot.Add.RadialGaugePlot(values);

myPlot.SavePng("demo.png", 400, 300);
{{< /recipe-sp5 >}}

<div class='my-5 text-center'>This recipe is one of many in the <a href='/cookbook/5.0/RadialGauge'>Radial gauge</a> category</div>


