---
Title: Signal Offset - ScottPlot 5.0 Cookbook
Description: Signal plots can be offset by a given X and Y value.
URL: /cookbook/5.0/Signal/SignalOffset/
BreadcrumbNames: ["ScottPlot 5.0 Cookbook", "Signal Plot", "Signal Offset"]
BreadcrumbUrls: ["/cookbook/5.0/", "/cookbook/5.0/Signal", "/cookbook/5.0/Signal/SignalOffset"]
Date: 2024-10-31
Version: ScottPlot 5.0.42
Version: ScottPlot 5.0.42
SearchUrl: "/cookbook/5.0/search/"
ShowEditLink: false
---


<h2 style='border-bottom: 0;'><a href='/cookbook/5.0/Signal/SignalOffset'>Signal Offset</a></h2>

<div class="d-flex mb-2">
<a class="btn btn-sm btn-primary me-1" href="/cookbook/5.0/Signal/SignalOffset">Recipe Permalink</a>
<a class="btn btn-sm btn-success me-1" href="/cookbook/5.0/Signal">Category: Signal Plot</a>
</div>

Signal plots can be offset by a given X and Y value.

[![](/cookbook/5.0/images/SignalOffset.png?241031194635)](/cookbook/5.0/images/SignalOffset.png?241031194635)

{{< recipe-sp5 >}}ScottPlot.Plot myPlot = new();

double[] values = ScottPlot.Generate.Sin(51);

var sig1 = myPlot.Add.Signal(values);
sig1.LegendText = "Default";

var sig2 = myPlot.Add.Signal(values);
sig2.Data.XOffset = 10;
sig2.Data.YOffset = .25;
sig2.LegendText = "Offset";

myPlot.Legend.IsVisible = true;

myPlot.SavePng("demo.png", 400, 300);
{{< /recipe-sp5 >}}

<hr class='my-5 invisible'>


