---
Title: Price on Right - ScottPlot 5.0 Cookbook
Description: Finance charts can be created which display price information on the right axis.
URL: /cookbook/5.0/Finance/FinanceRightAxis/
BreadcrumbNames: ["ScottPlot 5.0 Cookbook", "Financial Plot", "Price on Right"]
BreadcrumbUrls: ["/cookbook/5.0/", "/cookbook/5.0/Finance", "/cookbook/5.0/Finance/FinanceRightAxis"]
Date: 2024-10-31
Version: ScottPlot 5.0.42
Version: ScottPlot 5.0.42
SearchUrl: "/cookbook/5.0/search/"
ShowEditLink: false
---


<h2 style='border-bottom: 0;'><a href='/cookbook/5.0/Finance/FinanceRightAxis'>Price on Right</a></h2>

<div class="d-flex mb-2">
<a class="btn btn-sm btn-primary me-1" href="/cookbook/5.0/Finance/FinanceRightAxis">Recipe Permalink</a>
<a class="btn btn-sm btn-success me-1" href="/cookbook/5.0/Finance">Category: Financial Plot</a>
</div>

Finance charts can be created which display price information on the right axis.

[![](/cookbook/5.0/images/FinanceRightAxis.png?241031194635)](/cookbook/5.0/images/FinanceRightAxis.png?241031194635)

{{< recipe-sp5 >}}ScottPlot.Plot myPlot = new();

// add candlesticks to the plot
var prices = Generate.RandomOHLCs(30);
var candles = myPlot.Add.Candlestick(prices);

// configure the candlesticks to use the plot's right axis
candles.Axes.YAxis = myPlot.Axes.Right;
candles.Axes.YAxis.Label.Text = "Price";

// style the bottom axis to display date
myPlot.Axes.DateTimeTicksBottom();

myPlot.SavePng("demo.png", 400, 300);
{{< /recipe-sp5 >}}

<hr class='my-5 invisible'>


