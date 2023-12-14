---
Title: OHLC Chart - ScottPlot 5.0 Cookbook
Description: OHLC charts use symbols to display price data (open, high, low, and close) for specific time ranges.
URL: /cookbook/5.0/Finance/OHLC/index.html
BreadcrumbNames: ["ScottPlot 5.0 Cookbook", "Financial Plot", "OHLC Chart"]
BreadcrumbUrls: ["/cookbook/5.0/", "/cookbook/5.0/Finance", "/cookbook/5.0/Finance/OHLC"]
Date: 2023-12-14
Version: ScottPlot 5.0.10-beta
Version: ScottPlot 5.0.10-beta
SearchUrl: "/cookbook/5.0/search/"
---

# OHLC Chart



<div class='alert alert-warning' role='alert'><h4 class='alert-heading py-0 my-0'>⚠️ ScottPlot 5.0.10-beta is a preview package</h4><hr /><p class='mb-0'><span class='fw-semibold'>This page describes a beta release of ScottPlot.</span> It is available on NuGet as a preview package, but its API is not stable and it is not recommended for production use. See the <a href='https://scottplot.net/versions/'>ScottPlot Versions</a> page for more information. </p></div>



OHLC charts use symbols to display price data (open, high, low, and close) for specific time ranges.

[![](/cookbook/5.0/images/OHLC.png)](/cookbook/5.0/images/OHLC.png)

```cs
ScottPlot.Plot myPlot = new();

ScottPlot.RandomDataGenerator gen = new(0);
var prices = gen.RandomOHLCs(30);
myPlot.Add.OHLC(prices);
myPlot.AxisStyler.DateTimeTicks(Edge.Bottom);

myPlot.SavePng("demo.png");

```

