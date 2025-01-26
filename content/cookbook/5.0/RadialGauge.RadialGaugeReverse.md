---
Title: Reverse Order - ScottPlot 5.0 Cookbook
Description: Gauges are displayed from the center outward by default but the order can be customized.
URL: /cookbook/5.0/RadialGauge/RadialGaugeReverse/
BreadcrumbNames: ["ScottPlot 5.0 Cookbook", "Radial gauge", "Reverse Order"]
BreadcrumbUrls: ["/cookbook/5.0/", "/cookbook/5.0/RadialGauge", "/cookbook/5.0/RadialGauge/RadialGaugeReverse"]
Date: 2025-01-26
Version: ScottPlot 5.0.55
Version: ScottPlot 5.0.55
SearchUrl: "/cookbook/5.0/search/"
ShowEditLink: false
---


<div class='d-flex align-items-center mt-5'>
<h1 class='me-2 text-dark my-0 border-0'>Reverse Order</h1>
</div>

Gauges are displayed from the center outward by default but the order can be customized.

[![](/cookbook/5.0/images/RadialGaugeReverse.png?250126165944)](/cookbook/5.0/images/RadialGaugeReverse.png?250126165944)

{{< recipe-sp5 sourceUrl="https://github.com/ScottPlot/ScottPlot/blob/main/src/ScottPlot5/ScottPlot5%20Cookbook/Recipes/PlotTypes/RadialGauge.cs" imageUrl="/cookbook/5.0/images/RadialGaugeReverse.png?250126165944" >}}ScottPlot.Plot myPlot = new();

myPlot.Add.Palette = new ScottPlot.Palettes.Nord();
double[] values = { 100, 80, 65, 45, 50 };
var radialGaugePlot = myPlot.Add.RadialGaugePlot(values);
radialGaugePlot.GaugeMode = ScottPlot.RadialGaugeMode.Sequential;
radialGaugePlot.OrderInsideOut = false;

myPlot.SavePng("demo.png", 400, 300);
{{< /recipe-sp5 >}}

<div class='my-5 text-center'>This recipe is one of many in the <a href='/cookbook/5.0/RadialGauge'>Radial gauge</a> category</div>


