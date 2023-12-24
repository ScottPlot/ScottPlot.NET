---
Title: Candlestick Chart - ScottPlot 5.0 Cookbook
Description: Candlestick charts use symbols to display price data. The rectangle indicates open and close prices, and the center line indicates minimum and maximum price for the given time period. Color indicates whether the price increased or decreased between open and close.
URL: /cookbook/5.0/Finance/Candlestick
BreadcrumbNames: ["ScottPlot 5.0 Cookbook", "Financial Plot", "Candlestick Chart"]
BreadcrumbUrls: ["/cookbook/5.0/", "/cookbook/5.0/Finance", "/cookbook/5.0/Finance/Candlestick"]
Date: 2023-12-24
Version: ScottPlot 5.0.11-beta
Version: ScottPlot 5.0.11-beta
SearchUrl: "/cookbook/5.0/search/"
---

# Candlestick Chart



<div class='alert alert-warning' role='alert'><h4 class='alert-heading py-0 my-0'>⚠️ ScottPlot 5.0.11-beta is a preview package</h4><hr /><p class='mb-0'><span class='fw-semibold'>This page describes a beta release of ScottPlot.</span> It is available on NuGet as a preview package, but its API is not stable and it is not recommended for production use. See the <a href='https://scottplot.net/versions/'>ScottPlot Versions</a> page for more information. </p></div>



Candlestick charts use symbols to display price data. The rectangle indicates open and close prices, and the center line indicates minimum and maximum price for the given time period. Color indicates whether the price increased or decreased between open and close.

[![](/cookbook/5.0/images/Candlestick.png)](/cookbook/5.0/images/Candlestick.png)

```cs
ScottPlot.Plot myPlot = new();

ScottPlot.RandomDataGenerator gen = new(0);
var prices = gen.RandomOHLCs(30);
myPlot.Add.Candlestick(prices);
myPlot.AxisStyler.DateTimeTicks(Edge.Bottom);

myPlot.SavePng("demo.png");

```

