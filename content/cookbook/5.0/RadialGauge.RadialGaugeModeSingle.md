---
Title: Single Gauge Mode - ScottPlot 5.0 Cookbook
Description: The SingleGauge mode draws all gauges stacked together as a single gauge. This is useful for showing a progress gauges composed of many individual smaller gauges.
URL: /cookbook/5.0/RadialGauge/RadialGaugeModeSingle/
BreadcrumbNames: ["ScottPlot 5.0 Cookbook", "Radial gauge", "Single Gauge Mode"]
BreadcrumbUrls: ["/cookbook/5.0/", "/cookbook/5.0/RadialGauge", "/cookbook/5.0/RadialGauge/RadialGaugeModeSingle"]
Date: 2025-01-26
Version: ScottPlot 5.0.55
Version: ScottPlot 5.0.55
SearchUrl: "/cookbook/5.0/search/"
ShowEditLink: false
---


<div class='d-flex align-items-center mt-5'>
<h1 class='me-2 text-dark my-0 border-0'>Single Gauge Mode</h1>
</div>

The SingleGauge mode draws all gauges stacked together as a single gauge. This is useful for showing a progress gauges composed of many individual smaller gauges.

[![](/cookbook/5.0/images/RadialGaugeModeSingle.png?250126165944)](/cookbook/5.0/images/RadialGaugeModeSingle.png?250126165944)

{{< recipe-sp5 sourceUrl="https://github.com/ScottPlot/ScottPlot/blob/main/src/ScottPlot5/ScottPlot5%20Cookbook/Recipes/PlotTypes/RadialGauge.cs" imageUrl="/cookbook/5.0/images/RadialGaugeModeSingle.png?250126165944" >}}ScottPlot.Plot myPlot = new();

myPlot.Add.Palette = new ScottPlot.Palettes.Nord();
double[] values = { 100, 80, 65, 45 };

var radialGaugePlot = myPlot.Add.RadialGaugePlot(values);
radialGaugePlot.GaugeMode = ScottPlot.RadialGaugeMode.SingleGauge;
radialGaugePlot.MaximumAngle = 180;
radialGaugePlot.StartingAngle = 180;

myPlot.SavePng("demo.png", 400, 300);
{{< /recipe-sp5 >}}

<div class='my-5 text-center'>This recipe is one of many in the <a href='/cookbook/5.0/RadialGauge'>Radial gauge</a> category</div>


