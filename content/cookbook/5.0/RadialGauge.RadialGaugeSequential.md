---
Title: Sequential Gauge Mode - ScottPlot 5.0 Cookbook
Description: Sequential gauge mode indicates that the base of each gauge starts at the tip of the previous gauge.
URL: /cookbook/5.0/RadialGauge/RadialGaugeSequential/
BreadcrumbNames: ["ScottPlot 5.0 Cookbook", "Radial gauge", "Sequential Gauge Mode"]
BreadcrumbUrls: ["/cookbook/5.0/", "/cookbook/5.0/RadialGauge", "/cookbook/5.0/RadialGauge/RadialGaugeSequential"]
Date: 2024-11-01
Version: ScottPlot 5.0.42
Version: ScottPlot 5.0.42
SearchUrl: "/cookbook/5.0/search/"
ShowEditLink: false
---


<div class='d-flex align-items-center mt-5'>
<h1 class='me-2 text-dark my-0 border-0'>Sequential Gauge Mode</h1>
</div>

Sequential gauge mode indicates that the base of each gauge starts at the tip of the previous gauge.

[![](/cookbook/5.0/images/RadialGaugeSequential.png?241101192719)](/cookbook/5.0/images/RadialGaugeSequential.png?241101192719)

{{< recipe-sp5 >}}ScottPlot.Plot myPlot = new();

myPlot.Add.Palette = new ScottPlot.Palettes.Nord();
double[] values = { 100, 80, 65, 45, 50 };
var radialGaugePlot = myPlot.Add.RadialGaugePlot(values);
radialGaugePlot.GaugeMode = ScottPlot.RadialGaugeMode.Sequential;

myPlot.SavePng("demo.png", 400, 300);
{{< /recipe-sp5 >}}

<div class='my-5 text-center'>This recipe is one of many in the <a href='/cookbook/5.0/RadialGauge'>Radial gauge</a> category</div>


