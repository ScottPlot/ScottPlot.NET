---
Title: Gauge Label Font Percentage - ScottPlot 5.0 Cookbook
Description: Size of the gauge level text as a fraction of the gauge width.
URL: /cookbook/5.0/RadialGauge/RadialGaugeLabelFontPct/
BreadcrumbNames: ["ScottPlot 5.0 Cookbook", "Radial gauge", "Gauge Label Font Percentage"]
BreadcrumbUrls: ["/cookbook/5.0/", "/cookbook/5.0/RadialGauge", "/cookbook/5.0/RadialGauge/RadialGaugeLabelFontPct"]
Date: 2024-10-31
Version: ScottPlot 5.0.42
Version: ScottPlot 5.0.42
SearchUrl: "/cookbook/5.0/search/"
ShowEditLink: false
---


<h2 style='border-bottom: 0;'><a href='/cookbook/5.0/RadialGauge/RadialGaugeLabelFontPct'>Gauge Label Font Percentage</a></h2>

<div class="d-flex mb-2">
<a class="btn btn-sm btn-primary me-1" href="/cookbook/5.0/RadialGauge/RadialGaugeLabelFontPct">Recipe Permalink</a>
<a class="btn btn-sm btn-success me-1" href="/cookbook/5.0/RadialGauge">Category: Radial gauge</a>
</div>

Size of the gauge level text as a fraction of the gauge width.

[![](/cookbook/5.0/images/RadialGaugeLabelFontPct.png?241031194635)](/cookbook/5.0/images/RadialGaugeLabelFontPct.png?241031194635)

{{< recipe-sp5 >}}ScottPlot.Plot myPlot = new();

myPlot.Add.Palette = new ScottPlot.Palettes.Nord();
double[] values = { 100, 80, 65, 45, 20 };

var radialGaugePlot = myPlot.Add.RadialGaugePlot(values);
radialGaugePlot.FontSizeFraction = .4;

myPlot.SavePng("demo.png", 400, 300);
{{< /recipe-sp5 >}}

<hr class='my-5 invisible'>


