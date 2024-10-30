---
Title: Simple Moving Average - ScottPlot 5.0 Cookbook
Description: Tools exist for creating simple moving average (SMA) curves and displaying them next to finanial data.
URL: /cookbook/5.0/Finance/FinanceSma/
BreadcrumbNames: ["ScottPlot 5.0 Cookbook", "Financial Plot", "Simple Moving Average"]
BreadcrumbUrls: ["/cookbook/5.0/", "/cookbook/5.0/Finance", "/cookbook/5.0/Finance/FinanceSma"]
Date: 2024-10-30
Version: ScottPlot 5.0.42
Version: ScottPlot 5.0.42
SearchUrl: "/cookbook/5.0/search/"
ShowEditLink: false
---


<h2 style='border-bottom: 0;'><a href='/cookbook/5.0/Finance/FinanceSma'>Simple Moving Average</a></h2>

<div class="d-flex mb-2">
<a class="btn btn-sm btn-primary me-1" href="/cookbook/5.0/Finance/FinanceSma">Recipe Permalink</a>
<a class="btn btn-sm btn-success me-1" href="/cookbook/5.0/Finance">Category: Financial Plot</a>
</div>

Tools exist for creating simple moving average (SMA) curves and displaying them next to finanial data.

[![](/cookbook/5.0/images/FinanceSma.png?241029205813)](/cookbook/5.0/images/FinanceSma.png?241029205813)

{{< recipe-sp5 >}}ScottPlot.Plot myPlot = new();

// generate and plot time series price data
var prices = Generate.RandomOHLCs(75);
myPlot.Add.Candlestick(prices);
myPlot.Axes.DateTimeTicksBottom();

// calculate SMA and display it as a scatter plot
int[] windowSizes = { 3, 8, 20 };
foreach (int windowSize in windowSizes)
{
    ScottPlot.Finance.SimpleMovingAverage sma = new(prices, windowSize);
    var sp = myPlot.Add.Scatter(sma.Dates, sma.Means);
    sp.LegendText = $"SMA {windowSize}";
    sp.MarkerSize = 0;
    sp.LineWidth = 3;
    sp.Color = Colors.Navy.WithAlpha(1 - windowSize / 30.0);
}

myPlot.ShowLegend();

myPlot.SavePng("demo.png", 400, 300);
{{< /recipe-sp5 >}}

<hr class='my-5 invisible'>


