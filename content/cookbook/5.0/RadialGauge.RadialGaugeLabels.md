---
Title: Show Levels - ScottPlot 5.0 Cookbook
Description: The value of each gauge is displayed as text by default but this behavior can be overridden. Note that this is different than the labels fiels which is what appears in the legened.
URL: /cookbook/5.0/RadialGauge/RadialGaugeLabels/
BreadcrumbNames: ["ScottPlot 5.0 Cookbook", "Radial gauge", "Show Levels"]
BreadcrumbUrls: ["/cookbook/5.0/", "/cookbook/5.0/RadialGauge", "/cookbook/5.0/RadialGauge/RadialGaugeLabels"]
Date: 2024-10-31
Version: ScottPlot 5.0.42
Version: ScottPlot 5.0.42
SearchUrl: "/cookbook/5.0/search/"
ShowEditLink: false
---


<h2 style='border-bottom: 0;'><a href='/cookbook/5.0/RadialGauge/RadialGaugeLabels'>Show Levels</a></h2>

<div class="d-flex mb-2">
<a class="btn btn-sm btn-primary me-1" href="/cookbook/5.0/RadialGauge/RadialGaugeLabels">Recipe Permalink</a>
<a class="btn btn-sm btn-success me-1" href="/cookbook/5.0/RadialGauge">Category: Radial gauge</a>
</div>

The value of each gauge is displayed as text by default but this behavior can be overridden. Note that this is different than the labels fiels which is what appears in the legened.

[![](/cookbook/5.0/images/RadialGaugeLabels.png?241031194635)](/cookbook/5.0/images/RadialGaugeLabels.png?241031194635)

{{< recipe-sp5 >}}ScottPlot.Plot myPlot = new();

myPlot.Add.Palette = new ScottPlot.Palettes.Nord();
double[] values = { 100, 80, 65, 45, 20 };

var radialGaugePlot = myPlot.Add.RadialGaugePlot(values);
radialGaugePlot.ShowLevels = false;

myPlot.SavePng("demo.png", 400, 300);
{{< /recipe-sp5 >}}

<hr class='my-5 invisible'>


