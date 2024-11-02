---
Title: Gauge Angular Range - ScottPlot 5.0 Cookbook
Description: By default gauges are full circles (360 degrees) but smaller gauges can be created by customizing the gauge size.
URL: /cookbook/5.0/RadialGauge/RadialGaugeRange/
BreadcrumbNames: ["ScottPlot 5.0 Cookbook", "Radial gauge", "Gauge Angular Range"]
BreadcrumbUrls: ["/cookbook/5.0/", "/cookbook/5.0/RadialGauge", "/cookbook/5.0/RadialGauge/RadialGaugeRange"]
Date: 2024-11-02
Version: ScottPlot 5.0.42
Version: ScottPlot 5.0.42
SearchUrl: "/cookbook/5.0/search/"
ShowEditLink: false
---


<div class='d-flex align-items-center mt-5'>
<h1 class='me-2 text-dark my-0 border-0'>Gauge Angular Range</h1>
</div>

By default gauges are full circles (360 degrees) but smaller gauges can be created by customizing the gauge size.

[![](/cookbook/5.0/images/RadialGaugeRange.png?241102170938)](/cookbook/5.0/images/RadialGaugeRange.png?241102170938)

{{< recipe-sp5 sourceUrl="https://github.com/ScottPlot/ScottPlot/blob/main/src/ScottPlot5/ScottPlot5%20Cookbook/Recipes/PlotTypes/RadialGauge.cs" imageUrl="/cookbook/5.0/images/RadialGaugeRange.png?241102170938" >}}ScottPlot.Plot myPlot = new();

myPlot.Add.Palette = new ScottPlot.Palettes.Nord();
double[] values = { 100, 80, 65, 45, 20 };

var radialGaugePlot = myPlot.Add.RadialGaugePlot(values);
radialGaugePlot.MaximumAngle = 180;

myPlot.SavePng("demo.png", 400, 300);
{{< /recipe-sp5 >}}

<div class='my-5 text-center'>This recipe is one of many in the <a href='/cookbook/5.0/RadialGauge'>Radial gauge</a> category</div>


