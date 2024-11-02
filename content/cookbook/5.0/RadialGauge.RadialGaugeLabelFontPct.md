---
Title: Gauge Label Font Percentage - ScottPlot 5.0 Cookbook
Description: Size of the gauge level text as a fraction of the gauge width.
URL: /cookbook/5.0/RadialGauge/RadialGaugeLabelFontPct/
BreadcrumbNames: ["ScottPlot 5.0 Cookbook", "Radial gauge", "Gauge Label Font Percentage"]
BreadcrumbUrls: ["/cookbook/5.0/", "/cookbook/5.0/RadialGauge", "/cookbook/5.0/RadialGauge/RadialGaugeLabelFontPct"]
Date: 2024-11-02
Version: ScottPlot 5.0.42
Version: ScottPlot 5.0.42
SearchUrl: "/cookbook/5.0/search/"
ShowEditLink: false
---


<div class='d-flex align-items-center mt-5'>
<h1 class='me-2 text-dark my-0 border-0'>Gauge Label Font Percentage</h1>
</div>

Size of the gauge level text as a fraction of the gauge width.

[![](/cookbook/5.0/images/RadialGaugeLabelFontPct.png?241102170938)](/cookbook/5.0/images/RadialGaugeLabelFontPct.png?241102170938)

{{< recipe-sp5 sourceUrl="https://github.com/ScottPlot/ScottPlot/blob/main/src/ScottPlot5/ScottPlot5%20Cookbook/Recipes/PlotTypes/RadialGauge.cs" imageUrl="/cookbook/5.0/images/RadialGaugeLabelFontPct.png?241102170938" >}}ScottPlot.Plot myPlot = new();

myPlot.Add.Palette = new ScottPlot.Palettes.Nord();
double[] values = { 100, 80, 65, 45, 20 };

var radialGaugePlot = myPlot.Add.RadialGaugePlot(values);
radialGaugePlot.FontSizeFraction = .4;

myPlot.SavePng("demo.png", 400, 300);
{{< /recipe-sp5 >}}

<div class='my-5 text-center'>This recipe is one of many in the <a href='/cookbook/5.0/RadialGauge'>Radial gauge</a> category</div>


