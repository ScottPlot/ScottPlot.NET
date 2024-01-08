---
Title: Simple Moving Average - ScottPlot 5.0 Cookbook
Description: Tools exist for creating simple moving average (SMA) curves and displaying them next to finanial data.
URL: /cookbook/5.0/Finance/FinanceSma/
BreadcrumbNames: ["ScottPlot 5.0 Cookbook", "Financial Plot", "Simple Moving Average"]
BreadcrumbUrls: ["/cookbook/5.0/", "/cookbook/5.0/Finance", "/cookbook/5.0/Finance/FinanceSma"]
Date: 2024-01-08
Version: ScottPlot 5.0.11-beta
Version: ScottPlot 5.0.11-beta
SearchUrl: "/cookbook/5.0/search/"
---

# Simple Moving Average



<div class='alert alert-warning' role='alert'><h4 class='alert-heading py-0 my-0'>⚠️ ScottPlot 5.0.11-beta is a preview package</h4><hr /><p class='mb-0'><span class='fw-semibold'>This page describes a beta release of ScottPlot.</span> It is available on NuGet as a preview package, but its API is not stable and it is not recommended for production use. See the <a href='https://scottplot.net/versions/'>ScottPlot Versions</a> page for more information. </p></div>



Tools exist for creating simple moving average (SMA) curves and displaying them next to finanial data.

[![](/cookbook/5.0/images/FinanceSma.png)](/cookbook/5.0/images/FinanceSma.png)

```cs
ScottPlot.Version.ShouldBe(5, 0, 11);
ScottPlot.Plot myPlot = new();

// generate and plot time series price data
var prices = Generate.RandomOHLCs(75);
myPlot.Add.Candlestick(prices);
myPlot.Axes.DateTimeTicks(Edge.Bottom);

// calculate SMA and display it as a scatter plot
int[] windowSizes = { 3, 8, 20 };
foreach (int windowSize in windowSizes)
{
    ScottPlot.Finance.SimpleMovingAverage sma = new(prices, windowSize);
    var sp = myPlot.Add.Scatter(sma.Dates, sma.Means);
    sp.Label = $"SMA {windowSize}";
    sp.MarkerSize = 0;
    sp.LineWidth = 3;
    sp.Color = Colors.Navy.WithAlpha(1 - windowSize / 30.0);
}

myPlot.ShowLegend();

myPlot.SavePng("demo.png");

```

