---
Title: Gauge Size - ScottPlot 5 Cookbook
Description: The empty space between gauges can be adjusted as a fraction of their width. 
URL: /cookbook/5/RadialGauge/RadialGaugeSize/
BreadcrumbNames: ["ScottPlot 5 Cookbook", "Radial gauge", "Gauge Size"]
BreadcrumbUrls: ["/cookbook/5/", "/cookbook/5/RadialGauge", "/cookbook/5/RadialGauge/RadialGaugeSize"]
Date: 2025-10-11
Version: ScottPlot 5.1.57
Version: ScottPlot 5.1.57
SearchUrl: "/cookbook/5/search/"
ShowEditLink: false
---


<div class='d-flex align-items-center mt-5'>
<h1 class='me-2 text-dark my-0 border-0'>Gauge Size</h1>
</div>

The empty space between gauges can be adjusted as a fraction of their width. 

[![](/cookbook/5/images/RadialGaugeSize.png?251011113742)](/cookbook/5/images/RadialGaugeSize.png?251011113742)

{{< recipe-sp5 sourceUrl="https://github.com/ScottPlot/ScottPlot/blob/main/src/ScottPlot5/ScottPlot5%20Cookbook/Recipes/PlotTypes/RadialGauge.cs" imageUrl="/cookbook/5/images/RadialGaugeSize.png?251011113742" >}}ScottPlot.Plot myPlot = new();

myPlot.Add.Palette = new ScottPlot.Palettes.Nord();
double[] values = { 100, 80, 65, 45, 20 };
var radialGaugePlot = myPlot.Add.RadialGaugePlot(values);
radialGaugePlot.SpaceFraction = .05;

myPlot.SavePng("demo.png", 400, 300);
{{< /recipe-sp5 >}}

<div class='my-5 text-center'>This recipe is one of many in the <a href='/cookbook/5/RadialGauge'>Radial gauge</a> category</div>


