---
Title: Signal Marker Size - ScottPlot 5.0 Cookbook
Description: Signal plots can have markers displayed at each point which are only visible when the plot is zoomed in.
URL: /cookbook/5.0/Signal/SignalMarkerSize/
BreadcrumbNames: ["ScottPlot 5.0 Cookbook", "Signal Plot", "Signal Marker Size"]
BreadcrumbUrls: ["/cookbook/5.0/", "/cookbook/5.0/Signal", "/cookbook/5.0/Signal/SignalMarkerSize"]
Date: 2024-10-31
Version: ScottPlot 5.0.42
Version: ScottPlot 5.0.42
SearchUrl: "/cookbook/5.0/search/"
ShowEditLink: false
---


<h2 style='border-bottom: 0;'><a href='/cookbook/5.0/Signal/SignalMarkerSize'>Signal Marker Size</a></h2>

<div class="d-flex mb-2">
<a class="btn btn-sm btn-primary me-1" href="/cookbook/5.0/Signal/SignalMarkerSize">Recipe Permalink</a>
<a class="btn btn-sm btn-success me-1" href="/cookbook/5.0/Signal">Category: Signal Plot</a>
</div>

Signal plots can have markers displayed at each point which are only visible when the plot is zoomed in.

[![](/cookbook/5.0/images/SignalMarkerSize.png?241031194635)](/cookbook/5.0/images/SignalMarkerSize.png?241031194635)

{{< recipe-sp5 >}}ScottPlot.Plot myPlot = new();

var sig1 = myPlot.Add.Signal(Generate.Cos());
sig1.LegendText = "Default";
sig1.Data.YOffset = 3;

var sig2 = myPlot.Add.Signal(Generate.Cos());
sig2.LegendText = "Large Markers";
sig2.MaximumMarkerSize = 20;
sig2.Data.YOffset = 2;

var sig3 = myPlot.Add.Signal(Generate.Cos());
sig3.LegendText = "Hidden Markers";
sig3.MaximumMarkerSize = 0;
sig3.Data.YOffset = 1;

myPlot.Legend.IsVisible = true;

myPlot.SavePng("demo.png", 400, 300);
{{< /recipe-sp5 >}}

<hr class='my-5 invisible'>


