---
Title: Reverse Order - ScottPlot 5 Cookbook
Description: Gauges are displayed from the center outward by default but the order can be customized.
URL: /cookbook/5/RadialGauge/RadialGaugeReverse/
BreadcrumbNames: ["ScottPlot 5 Cookbook", "Radial gauge", "Reverse Order"]
BreadcrumbUrls: ["/cookbook/5/", "/cookbook/5/RadialGauge", "/cookbook/5/RadialGauge/RadialGaugeReverse"]
Date: 2026-03-29
Version: ScottPlot 5.1.58
Version: ScottPlot 5.1.58
SearchUrl: "/cookbook/5/search/"
ShowEditLink: false
---


<div class='d-flex align-items-center mt-5'>
<h1 class='me-2 text-dark my-0 border-0'>Reverse Order</h1>
</div>

Gauges are displayed from the center outward by default but the order can be customized.

[![](/cookbook/5/images/RadialGaugeReverse.png?260329072039)](/cookbook/5/images/RadialGaugeReverse.png?260329072039)

{{< recipe-sp5 sourceUrl="https://github.com/ScottPlot/ScottPlot/blob/main/src/ScottPlot5/ScottPlot5%20Cookbook/Recipes/PlotTypes/RadialGauge.cs" imageUrl="/cookbook/5/images/RadialGaugeReverse.png?260329072039" >}}ScottPlot.Plot myPlot = new();

myPlot.Add.Palette = new ScottPlot.Palettes.Nord();
double[] values = { 100, 80, 65, 45, 50 };
var radialGaugePlot = myPlot.Add.RadialGaugePlot(values);
radialGaugePlot.GaugeMode = ScottPlot.RadialGaugeMode.Sequential;
radialGaugePlot.OrderInsideOut = false;

myPlot.SavePng("demo.png", 400, 300);
{{< /recipe-sp5 >}}

<div class='my-5 text-center'>This recipe is one of many in the <a href='/cookbook/5/RadialGauge'>Radial gauge</a> category</div>


