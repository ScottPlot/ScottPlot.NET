---
Title: Signal Marker Size - ScottPlot 5.0 Cookbook
Description: Signal plots can have markers displayed at each point which are only visible when the plot is zoomed in.
URL: /cookbook/5.0/Signal/SignalMarkerSize/
BreadcrumbNames: ["ScottPlot 5.0 Cookbook", "Signal Plot", "Signal Marker Size"]
BreadcrumbUrls: ["/cookbook/5.0/", "/cookbook/5.0/Signal", "/cookbook/5.0/Signal/SignalMarkerSize"]
Date: 2024-01-08
Version: ScottPlot 5.0.11-beta
Version: ScottPlot 5.0.11-beta
SearchUrl: "/cookbook/5.0/search/"
---

# Signal Marker Size



<div class='alert alert-warning' role='alert'><h4 class='alert-heading py-0 my-0'>⚠️ ScottPlot 5.0.11-beta is a preview package</h4><hr /><p class='mb-0'><span class='fw-semibold'>This page describes a beta release of ScottPlot.</span> It is available on NuGet as a preview package, but its API is not stable and it is not recommended for production use. See the <a href='https://scottplot.net/versions/'>ScottPlot Versions</a> page for more information. </p></div>



Signal plots can have markers displayed at each point which are only visible when the plot is zoomed in.

[![](/cookbook/5.0/images/SignalMarkerSize.png)](/cookbook/5.0/images/SignalMarkerSize.png)

```cs
ScottPlot.Version.ShouldBe(5, 0, 11);
ScottPlot.Plot myPlot = new();

var sig1 = myPlot.Add.Signal(Generate.Cos());
sig1.Label = "Default";
sig1.Data.YOffset = 3;

var sig2 = myPlot.Add.Signal(Generate.Cos());
sig2.Label = "Large Markers";
sig2.MaximumMarkerSize = 20;
sig2.Data.YOffset = 2;

var sig3 = myPlot.Add.Signal(Generate.Cos());
sig3.Label = "Hidden Markers";
sig3.MaximumMarkerSize = 0;
sig3.Data.YOffset = 1;

myPlot.Legend.IsVisible = true;

myPlot.SavePng("demo.png");

```

