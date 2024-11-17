---
Title: Gauge Label Position - ScottPlot 5.0 Cookbook
Description: Gauge level text is positioned at the tip of each gauge by default, but this position can be adjusted by the user.
URL: /cookbook/5.0/RadialGauge/RadialGaugeLabelPos/
BreadcrumbNames: ["ScottPlot 5.0 Cookbook", "Radial gauge", "Gauge Label Position"]
BreadcrumbUrls: ["/cookbook/5.0/", "/cookbook/5.0/RadialGauge", "/cookbook/5.0/RadialGauge/RadialGaugeLabelPos"]
Date: 2024-11-17
Version: ScottPlot 5.0.46
Version: ScottPlot 5.0.46
SearchUrl: "/cookbook/5.0/search/"
ShowEditLink: false
---


<div class='d-flex align-items-center mt-5'>
<h1 class='me-2 text-dark my-0 border-0'>Gauge Label Position</h1>
</div>

Gauge level text is positioned at the tip of each gauge by default, but this position can be adjusted by the user.

[![](/cookbook/5.0/images/RadialGaugeLabelPos.png?241117162641)](/cookbook/5.0/images/RadialGaugeLabelPos.png?241117162641)

{{< recipe-sp5 sourceUrl="https://github.com/ScottPlot/ScottPlot/blob/main/src/ScottPlot5/ScottPlot5%20Cookbook/Recipes/PlotTypes/RadialGauge.cs" imageUrl="/cookbook/5.0/images/RadialGaugeLabelPos.png?241117162641" >}}ScottPlot.Plot myPlot = new();

myPlot.Add.Palette = new ScottPlot.Palettes.Nord();
double[] values = { 100, 80, 65, 45, 20 };

var radialGaugePlot = myPlot.Add.RadialGaugePlot(values);
radialGaugePlot.LabelPositionFraction = 0.5;

myPlot.SavePng("demo.png", 400, 300);
{{< /recipe-sp5 >}}

<div class='my-5 text-center'>This recipe is one of many in the <a href='/cookbook/5.0/RadialGauge'>Radial gauge</a> category</div>


