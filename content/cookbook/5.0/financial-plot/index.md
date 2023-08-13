---
title: Financial Plot - ScottPlot 5.0 Cookbook
description: Finance plots display price data binned into time ranges
url: /cookbook/5.0/financial-plot/
date: 8/13/2023 5:22:29 PM
---

This page is part of the [ScottPlot 5.0 Cookbook](../)


<div class='alert alert-warning' role='alert'><h4 class='alert-heading py-0 my-0'>⚠️ ScottPlot 5.0.8-beta is a preview package</h4><hr /><p class='mb-0'><span class='fw-semibold'>This page describes a beta release of ScottPlot.</span> It is available on NuGet as a preview package, but its API is not stable and it is not recommended for production use. See the <a href='https://scottplot.net/versions/'>ScottPlot Versions</a> page for more information. </p></div>



## OHLC Chart

OHLC charts use symbols to display price data (open, high, low, and close) for specific time ranges.

[![](ohlc-chart.png)](ohlc-chart.png)

```cs
ScottPlot.Plot myPlot = new();

ScottPlot.RandomDataGenerator gen = new(0);
var prices = gen.RandomOHLCs(30);
myPlot.Add.OHLC(prices);
myPlot.AxisStyler.DateTimeTicks(Edge.Bottom);

myPlot.SavePng("ohlc-chart.png");
```


## Candlestick Chart

Candlestick charts use symbols to display price data. The rectangle indicates open and close prices, and the center line indicates minimum and maximum price for the given time period. Color indicates whether the price increased or decreased between open and close.

[![](candlestick-chart.png)](candlestick-chart.png)

```cs
ScottPlot.Plot myPlot = new();

ScottPlot.RandomDataGenerator gen = new(0);
var prices = gen.RandomOHLCs(30);
myPlot.Add.Candlestick(prices);
myPlot.AxisStyler.DateTimeTicks(Edge.Bottom);

myPlot.SavePng("candlestick-chart.png");
```

