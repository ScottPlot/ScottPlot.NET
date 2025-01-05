---
Title: Negative Values - ScottPlot 5.0 Cookbook
Description: Radial gauge plots support positive and negative values.
URL: /cookbook/5.0/RadialGauge/RadialGaugeNegative/
BreadcrumbNames: ["ScottPlot 5.0 Cookbook", "Radial gauge", "Negative Values"]
BreadcrumbUrls: ["/cookbook/5.0/", "/cookbook/5.0/RadialGauge", "/cookbook/5.0/RadialGauge/RadialGaugeNegative"]
Date: 2025-01-05
Version: ScottPlot 5.0.48
Version: ScottPlot 5.0.48
SearchUrl: "/cookbook/5.0/search/"
ShowEditLink: false
---


<div class='d-flex align-items-center mt-5'>
<h1 class='me-2 text-dark my-0 border-0'>Negative Values</h1>
</div>

Radial gauge plots support positive and negative values.

[![](/cookbook/5.0/images/RadialGaugeNegative.png?250105183901)](/cookbook/5.0/images/RadialGaugeNegative.png?250105183901)

{{< recipe-sp5 sourceUrl="https://github.com/ScottPlot/ScottPlot/blob/main/src/ScottPlot5/ScottPlot5%20Cookbook/Recipes/PlotTypes/RadialGauge.cs" imageUrl="/cookbook/5.0/images/RadialGaugeNegative.png?250105183901" >}}ScottPlot.Plot myPlot = new();

myPlot.Add.Palette = new ScottPlot.Palettes.Nord();
double[] values = { 100, 80, -65, 45, -20 };
myPlot.Add.RadialGaugePlot(values);

myPlot.SavePng("demo.png", 400, 300);
{{< /recipe-sp5 >}}

<div class='my-5 text-center'>This recipe is one of many in the <a href='/cookbook/5.0/RadialGauge'>Radial gauge</a> category</div>


