---
Title: Bar Positioning - ScottPlot 5.0 Cookbook
Description: The exact position and size of each bar may be customized.
URL: /cookbook/5.0/Bar/BarPosition/
BreadcrumbNames: ["ScottPlot 5.0 Cookbook", "Bar Plot", "Bar Positioning"]
BreadcrumbUrls: ["/cookbook/5.0/", "/cookbook/5.0/Bar", "/cookbook/5.0/Bar/BarPosition"]
Date: 2023-12-28
Version: ScottPlot 5.0.11-beta
Version: ScottPlot 5.0.11-beta
SearchUrl: "/cookbook/5.0/search/"
---

# Bar Positioning



<div class='alert alert-warning' role='alert'><h4 class='alert-heading py-0 my-0'>⚠️ ScottPlot 5.0.11-beta is a preview package</h4><hr /><p class='mb-0'><span class='fw-semibold'>This page describes a beta release of ScottPlot.</span> It is available on NuGet as a preview package, but its API is not stable and it is not recommended for production use. See the <a href='https://scottplot.net/versions/'>ScottPlot Versions</a> page for more information. </p></div>



The exact position and size of each bar may be customized.

[![](/cookbook/5.0/images/BarPosition.png)](/cookbook/5.0/images/BarPosition.png)

```cs
ScottPlot.Plot myPlot = new();

List<ScottPlot.Bar> bars = new()
{
    new() { Position = 1, Value = 5, ValueBase = 3, },
    new() { Position = 2, Value = 7, ValueBase = 0, },
    new() { Position = 4, Value = 3, ValueBase = 2, },
};

myPlot.Add.Bars(bars);

myPlot.SavePng("demo.png");

```

