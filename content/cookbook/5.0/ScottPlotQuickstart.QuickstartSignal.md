---
Title: Signal Plot - ScottPlot 5.0 Cookbook
Description: Signal plots display Y values at evenly spaced X positions. Signal plots should be used instead of Scatter plots whenever possible.
URL: /cookbook/5.0/ScottPlotQuickstart/QuickstartSignal/
BreadcrumbNames: ["ScottPlot 5.0 Cookbook", "Quickstart", "Signal Plot"]
BreadcrumbUrls: ["/cookbook/5.0/", "/cookbook/5.0/ScottPlotQuickstart", "/cookbook/5.0/ScottPlotQuickstart/QuickstartSignal"]
Date: 2024-10-31
Version: ScottPlot 5.0.42
Version: ScottPlot 5.0.42
SearchUrl: "/cookbook/5.0/search/"
ShowEditLink: false
---


<h2 style='border-bottom: 0;'><a href='/cookbook/5.0/ScottPlotQuickstart/QuickstartSignal'>Signal Plot</a></h2>

<div class="d-flex mb-2">
<a class="btn btn-sm btn-primary me-1" href="/cookbook/5.0/ScottPlotQuickstart/QuickstartSignal">Recipe Permalink</a>
<a class="btn btn-sm btn-success me-1" href="/cookbook/5.0/ScottPlotQuickstart">Category: Quickstart</a>
</div>

Signal plots display Y values at evenly spaced X positions. Signal plots should be used instead of Scatter plots whenever possible.

[![](/cookbook/5.0/images/QuickstartSignal.png?241031194635)](/cookbook/5.0/images/QuickstartSignal.png?241031194635)

{{< recipe-sp5 >}}ScottPlot.Plot myPlot = new();

// create sample data
double[] sin = Generate.Sin(51);

// add a signal plot to the plot
myPlot.Add.Signal(sin);

myPlot.SavePng("demo.png", 400, 300);
{{< /recipe-sp5 >}}

<hr class='my-5 invisible'>


