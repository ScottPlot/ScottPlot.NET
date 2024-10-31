---
Title: Gauge Label Position - ScottPlot 5.0 Cookbook
Description: Gauge level text is positioned at the tip of each gauge by default, but this position can be adjusted by the user.
URL: /cookbook/5.0/RadialGauge/RadialGaugeLabelPos/
BreadcrumbNames: ["ScottPlot 5.0 Cookbook", "Radial gauge", "Gauge Label Position"]
BreadcrumbUrls: ["/cookbook/5.0/", "/cookbook/5.0/RadialGauge", "/cookbook/5.0/RadialGauge/RadialGaugeLabelPos"]
Date: 2024-10-31
Version: ScottPlot 5.0.42
Version: ScottPlot 5.0.42
SearchUrl: "/cookbook/5.0/search/"
ShowEditLink: false
---


<h2 style='border-bottom: 0;'><a href='/cookbook/5.0/RadialGauge/RadialGaugeLabelPos'>Gauge Label Position</a></h2>

<div class="d-flex mb-2">
<a class="btn btn-sm btn-primary me-1" href="/cookbook/5.0/RadialGauge/RadialGaugeLabelPos">Recipe Permalink</a>
<a class="btn btn-sm btn-success me-1" href="/cookbook/5.0/RadialGauge">Category: Radial gauge</a>
</div>

Gauge level text is positioned at the tip of each gauge by default, but this position can be adjusted by the user.

[![](/cookbook/5.0/images/RadialGaugeLabelPos.png?241031194635)](/cookbook/5.0/images/RadialGaugeLabelPos.png?241031194635)

{{< recipe-sp5 >}}ScottPlot.Plot myPlot = new();

myPlot.Add.Palette = new ScottPlot.Palettes.Nord();
double[] values = { 100, 80, 65, 45, 20 };

var radialGaugePlot = myPlot.Add.RadialGaugePlot(values);
radialGaugePlot.LabelPositionFraction = 0.5;

myPlot.SavePng("demo.png", 400, 300);
{{< /recipe-sp5 >}}

<hr class='my-5 invisible'>


