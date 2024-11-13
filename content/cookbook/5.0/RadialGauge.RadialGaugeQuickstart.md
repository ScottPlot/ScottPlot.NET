---
Title: Radial gauge from values - ScottPlot 5.0 Cookbook
Description: A radial gauge chart can be created from a few values.
URL: /cookbook/5.0/RadialGauge/RadialGaugeQuickstart/
BreadcrumbNames: ["ScottPlot 5.0 Cookbook", "Radial gauge", "Radial gauge from values"]
BreadcrumbUrls: ["/cookbook/5.0/", "/cookbook/5.0/RadialGauge", "/cookbook/5.0/RadialGauge/RadialGaugeQuickstart"]
Date: 2024-11-13
Version: ScottPlot 5.0.45
Version: ScottPlot 5.0.45
SearchUrl: "/cookbook/5.0/search/"
ShowEditLink: false
---


<div class='d-flex align-items-center mt-5'>
<h1 class='me-2 text-dark my-0 border-0'>Radial gauge from values</h1>
</div>

A radial gauge chart can be created from a few values.

[![](/cookbook/5.0/images/RadialGaugeQuickstart.png?241112193154)](/cookbook/5.0/images/RadialGaugeQuickstart.png?241112193154)

{{< recipe-sp5 sourceUrl="https://github.com/ScottPlot/ScottPlot/blob/main/src/ScottPlot5/ScottPlot5%20Cookbook/Recipes/PlotTypes/RadialGauge.cs" imageUrl="/cookbook/5.0/images/RadialGaugeQuickstart.png?241112193154" >}}ScottPlot.Plot myPlot = new();

double[] values = { 100, 80, 65, 45, 20 };
myPlot.Add.RadialGaugePlot(values);

myPlot.SavePng("demo.png", 400, 300);
{{< /recipe-sp5 >}}

<div class='my-5 text-center'>This recipe is one of many in the <a href='/cookbook/5.0/RadialGauge'>Radial gauge</a> category</div>


