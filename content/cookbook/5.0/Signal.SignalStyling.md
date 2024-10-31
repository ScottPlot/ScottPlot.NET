---
Title: Signal Plot Styling - ScottPlot 5.0 Cookbook
Description: Signal plots can be styled in a variety of ways.
URL: /cookbook/5.0/Signal/SignalStyling/
BreadcrumbNames: ["ScottPlot 5.0 Cookbook", "Signal Plot", "Signal Plot Styling"]
BreadcrumbUrls: ["/cookbook/5.0/", "/cookbook/5.0/Signal", "/cookbook/5.0/Signal/SignalStyling"]
Date: 2024-10-31
Version: ScottPlot 5.0.42
Version: ScottPlot 5.0.42
SearchUrl: "/cookbook/5.0/search/"
ShowEditLink: false
---


<h2 style='border-bottom: 0;'><a href='/cookbook/5.0/Signal/SignalStyling'>Signal Plot Styling</a></h2>

<div class="d-flex mb-2">
<a class="btn btn-sm btn-primary me-1" href="/cookbook/5.0/Signal/SignalStyling">Recipe Permalink</a>
<a class="btn btn-sm btn-success me-1" href="/cookbook/5.0/Signal">Category: Signal Plot</a>
</div>

Signal plots can be styled in a variety of ways.

[![](/cookbook/5.0/images/SignalStyling.png?241031194635)](/cookbook/5.0/images/SignalStyling.png?241031194635)

{{< recipe-sp5 >}}ScottPlot.Plot myPlot = new();

var sig1 = myPlot.Add.Signal(Generate.Sin());
sig1.Color = Colors.Magenta;
sig1.LineWidth = 10;
sig1.LegendText = "Sine";

var sig2 = myPlot.Add.Signal(Generate.Cos());
sig2.Color = Colors.Green;
sig2.LineWidth = 5;
sig2.LegendText = "Cosine";

myPlot.ShowLegend();

myPlot.SavePng("demo.png", 400, 300);
{{< /recipe-sp5 >}}

<hr class='my-5 invisible'>


