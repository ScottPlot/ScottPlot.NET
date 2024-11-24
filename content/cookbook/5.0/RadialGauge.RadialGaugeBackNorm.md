---
Title: Background Gauges Normalization - ScottPlot 5.0 Cookbook
Description: Gauge backgrounds are drawn as full circles by default. This behavior can be disabled to draw partial backgrounds for non-circular gauges.
URL: /cookbook/5.0/RadialGauge/RadialGaugeBackNorm/
BreadcrumbNames: ["ScottPlot 5.0 Cookbook", "Radial gauge", "Background Gauges Normalization"]
BreadcrumbUrls: ["/cookbook/5.0/", "/cookbook/5.0/RadialGauge", "/cookbook/5.0/RadialGauge/RadialGaugeBackNorm"]
Date: 2024-11-24
Version: ScottPlot 5.0.47
Version: ScottPlot 5.0.47
SearchUrl: "/cookbook/5.0/search/"
ShowEditLink: false
---


<div class='d-flex align-items-center mt-5'>
<h1 class='me-2 text-dark my-0 border-0'>Background Gauges Normalization</h1>
</div>

Gauge backgrounds are drawn as full circles by default. This behavior can be disabled to draw partial backgrounds for non-circular gauges.

[![](/cookbook/5.0/images/RadialGaugeBackNorm.png?241124170640)](/cookbook/5.0/images/RadialGaugeBackNorm.png?241124170640)

{{< recipe-sp5 sourceUrl="https://github.com/ScottPlot/ScottPlot/blob/main/src/ScottPlot5/ScottPlot5%20Cookbook/Recipes/PlotTypes/RadialGauge.cs" imageUrl="/cookbook/5.0/images/RadialGaugeBackNorm.png?241124170640" >}}ScottPlot.Plot myPlot = new();

myPlot.Add.Palette = new ScottPlot.Palettes.Nord();
double[] values = { 100, 80, 65, 45, 20 };

var radialGaugePlot = myPlot.Add.RadialGaugePlot(values);
radialGaugePlot.CircularBackground = false;
radialGaugePlot.MaximumAngle = 180;
radialGaugePlot.StartingAngle = 180;

myPlot.SavePng("demo.png", 400, 300);
{{< /recipe-sp5 >}}

<div class='my-5 text-center'>This recipe is one of many in the <a href='/cookbook/5.0/RadialGauge'>Radial gauge</a> category</div>


