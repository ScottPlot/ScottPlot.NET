---
Title: Bars with Error - ScottPlot 5.0 Cookbook
Description: Bars can have errorbars.
URL: /cookbook/5.0/Bar/BarWithError
BreadcrumbNames: ["ScottPlot 5.0 Cookbook", "Bar Plot", "Bars with Error"]
BreadcrumbUrls: ["/cookbook/5.0/", "/cookbook/5.0/Bar", "/cookbook/5.0/Bar/BarWithError"]
Date: 12/13/2023 2:24:04 PM
Version: ScottPlot 5.0.10-beta
---

# Bars with Error



<div class='alert alert-warning' role='alert'><h4 class='alert-heading py-0 my-0'>⚠️ ScottPlot 5.0.10-beta is a preview package</h4><hr /><p class='mb-0'><span class='fw-semibold'>This page describes a beta release of ScottPlot.</span> It is available on NuGet as a preview package, but its API is not stable and it is not recommended for production use. See the <a href='https://scottplot.net/versions/'>ScottPlot Versions</a> page for more information. </p></div>



Bars can have errorbars.

[![](/cookbook/5.0/images/BarWithError.png)](/cookbook/5.0/images/BarWithError.png)

```cs
ScottPlot.Plot myPlot = new();

List<ScottPlot.Bar> bars = new()
{
    new() { Position = 1, Value = 5, Error = 1, },
    new() { Position = 2, Value = 7, Error = 2, },
    new() { Position = 3, Value = 6, Error = 1, },
    new() { Position = 4, Value = 8, Error = 2, },
};

myPlot.Add.Bars(bars);

myPlot.SavePng("demo.png");

```

