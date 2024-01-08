---
Title: Bollinger Bands - ScottPlot 5.0 Cookbook
Description: Tools exist for creating Bollinger Bands which display weighted moving mean and variance for time series financial data.
URL: /cookbook/5.0/Finance/FinanceBollinger/
BreadcrumbNames: ["ScottPlot 5.0 Cookbook", "Financial Plot", "Bollinger Bands"]
BreadcrumbUrls: ["/cookbook/5.0/", "/cookbook/5.0/Finance", "/cookbook/5.0/Finance/FinanceBollinger"]
Date: 2024-01-08
Version: ScottPlot 5.0.11-beta
Version: ScottPlot 5.0.11-beta
SearchUrl: "/cookbook/5.0/search/"
---

# Bollinger Bands



<div class='alert alert-warning' role='alert'><h4 class='alert-heading py-0 my-0'>⚠️ ScottPlot 5.0.11-beta is a preview package</h4><hr /><p class='mb-0'><span class='fw-semibold'>This page describes a beta release of ScottPlot.</span> It is available on NuGet as a preview package, but its API is not stable and it is not recommended for production use. See the <a href='https://scottplot.net/versions/'>ScottPlot Versions</a> page for more information. </p></div>



Tools exist for creating Bollinger Bands which display weighted moving mean and variance for time series financial data.

[![](/cookbook/5.0/images/FinanceBollinger.png)](/cookbook/5.0/images/FinanceBollinger.png)

```cs
ScottPlot.Version.ShouldBe(5, 0, 11);
ScottPlot.Plot myPlot = new();

// generate and plot time series price data
var prices = Generate.RandomOHLCs(100);
myPlot.Add.Candlestick(prices);
myPlot.Axes.DateTimeTicks(Edge.Bottom);

// calculate Bollinger Bands
ScottPlot.Finance.BollingerBands bb = new(prices, 20);

// display center line (mean) as a solid line
var sp1 = myPlot.Add.Scatter(bb.Dates, bb.Means);
sp1.MarkerSize = 0;
sp1.Color = Colors.Navy;

// display upper bands (positive variance) as a dashed line
var sp2 = myPlot.Add.Scatter(bb.Dates, bb.UpperValues);
sp2.MarkerSize = 0;
sp2.Color = Colors.Navy;
sp2.LineStyle.Pattern = LinePattern.Dotted;

// display lower bands (positive variance) as a dashed line
var sp3 = myPlot.Add.Scatter(bb.Dates, bb.LowerValues);
sp3.MarkerSize = 0;
sp3.Color = Colors.Navy;
sp3.LineStyle.Pattern = LinePattern.Dotted;

myPlot.SavePng("demo.png");

```

