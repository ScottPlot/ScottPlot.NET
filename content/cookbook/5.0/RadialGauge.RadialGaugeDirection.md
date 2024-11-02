---
Title: Gauge Direction - ScottPlot 5.0 Cookbook
Description: The direction of gauges can be customized. Clockwise is used by default.
URL: /cookbook/5.0/RadialGauge/RadialGaugeDirection/
BreadcrumbNames: ["ScottPlot 5.0 Cookbook", "Radial gauge", "Gauge Direction"]
BreadcrumbUrls: ["/cookbook/5.0/", "/cookbook/5.0/RadialGauge", "/cookbook/5.0/RadialGauge/RadialGaugeDirection"]
Date: 2024-11-02
Version: ScottPlot 5.0.42
Version: ScottPlot 5.0.42
SearchUrl: "/cookbook/5.0/search/"
ShowEditLink: false
---


<div class='d-flex align-items-center mt-5'>
<h1 class='me-2 text-dark my-0 border-0'>Gauge Direction</h1>
</div>

The direction of gauges can be customized. Clockwise is used by default.

[![](/cookbook/5.0/images/RadialGaugeDirection.png?241102170938)](/cookbook/5.0/images/RadialGaugeDirection.png?241102170938)

{{< recipe-sp5 sourceUrl="https://github.com/ScottPlot/ScottPlot/blob/main/src/ScottPlot5/ScottPlot5%20Cookbook/Recipes/PlotTypes/RadialGauge.cs" imageUrl="/cookbook/5.0/images/RadialGaugeDirection.png?241102170938" >}}ScottPlot.Plot myPlot = new();

myPlot.Add.Palette = new ScottPlot.Palettes.Nord();
double[] values = { 100, 80, 65, 45, 20 };

var radialGaugePlot = myPlot.Add.RadialGaugePlot(values);
radialGaugePlot.Clockwise = false;

myPlot.SavePng("demo.png", 400, 300);
{{< /recipe-sp5 >}}

<div class='my-5 text-center'>This recipe is one of many in the <a href='/cookbook/5.0/RadialGauge'>Radial gauge</a> category</div>


