---
Title: Signal Plot Styling - ScottPlot 5.0 Cookbook
Description: Signal plots can be styled in a variety of ways.
URL: /cookbook/5.0/Signal/SignalStyling/
BreadcrumbNames: ["ScottPlot 5.0 Cookbook", "Signal Plot", "Signal Plot Styling"]
BreadcrumbUrls: ["/cookbook/5.0/", "/cookbook/5.0/Signal", "/cookbook/5.0/Signal/SignalStyling"]
Date: 2024-01-08
Version: ScottPlot 5.0.11-beta
Version: ScottPlot 5.0.11-beta
SearchUrl: "/cookbook/5.0/search/"
---

# Signal Plot Styling



<div class='alert alert-warning' role='alert'><h4 class='alert-heading py-0 my-0'>⚠️ ScottPlot 5.0.11-beta is a preview package</h4><hr /><p class='mb-0'><span class='fw-semibold'>This page describes a beta release of ScottPlot.</span> It is available on NuGet as a preview package, but its API is not stable and it is not recommended for production use. See the <a href='https://scottplot.net/versions/'>ScottPlot Versions</a> page for more information. </p></div>



Signal plots can be styled in a variety of ways.

[![](/cookbook/5.0/images/SignalStyling.png)](/cookbook/5.0/images/SignalStyling.png)

```cs
ScottPlot.Version.ShouldBe(5, 0, 11);
ScottPlot.Plot myPlot = new();

var sig1 = myPlot.Add.Signal(Generate.Sin());
sig1.Color = Colors.Magenta;
sig1.LineWidth = 10;
sig1.Label = "Sine";

var sig2 = myPlot.Add.Signal(Generate.Cos());
sig2.Color = Colors.Green;
sig2.LineWidth = 5;
sig2.Label = "Cosine";

myPlot.ShowLegend();

myPlot.SavePng("demo.png");

```

