---
Title: Bollinger Bands - ScottPlot 5.0 Cookbook
Description: Tools exist for creating Bollinger Bands which display weighted moving mean and variance for time series financial data.
URL: /cookbook/5.0/Finance/FinanceBollinger/
BreadcrumbNames: ["ScottPlot 5.0 Cookbook", "Financial Plot", "Bollinger Bands"]
BreadcrumbUrls: ["/cookbook/5.0/", "/cookbook/5.0/Finance", "/cookbook/5.0/Finance/FinanceBollinger"]
Date: 2024-11-01
Version: ScottPlot 5.0.42
Version: ScottPlot 5.0.42
SearchUrl: "/cookbook/5.0/search/"
ShowEditLink: false
---


<div class='d-flex align-items-center mt-5'>
<h1 class='me-2 text-dark my-0 border-0'>Bollinger Bands</h1>
</div>

Tools exist for creating Bollinger Bands which display weighted moving mean and variance for time series financial data.

[![](/cookbook/5.0/images/FinanceBollinger.png?241101192719)](/cookbook/5.0/images/FinanceBollinger.png?241101192719)

{{< recipe-sp5 >}}ScottPlot.Plot myPlot = new();

// generate and plot time series price data
var prices = Generate.RandomOHLCs(100);
myPlot.Add.Candlestick(prices);
myPlot.Axes.DateTimeTicksBottom();

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
sp2.LinePattern = LinePattern.Dotted;

// display lower bands (positive variance) as a dashed line
var sp3 = myPlot.Add.Scatter(bb.Dates, bb.LowerValues);
sp3.MarkerSize = 0;
sp3.Color = Colors.Navy;
sp3.LinePattern = LinePattern.Dotted;

myPlot.SavePng("demo.png", 400, 300);
{{< /recipe-sp5 >}}

<div class='my-5 text-center'>This recipe is one of many in the <a href='/cookbook/5.0/Finance'>Financial Plot</a> category</div>


