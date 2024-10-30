---
Title: Finance Chart with Custom Time Bins - ScottPlot 5.0 Cookbook
Description: Finance charts can display price range information over arbitrary time scales.
URL: /cookbook/5.0/Finance/FinanceChartBins/
BreadcrumbNames: ["ScottPlot 5.0 Cookbook", "Financial Plot", "Finance Chart with Custom Time Bins"]
BreadcrumbUrls: ["/cookbook/5.0/", "/cookbook/5.0/Finance", "/cookbook/5.0/Finance/FinanceChartBins"]
Date: 2024-10-30
Version: ScottPlot 5.0.42
Version: ScottPlot 5.0.42
SearchUrl: "/cookbook/5.0/search/"
ShowEditLink: false
---


<h2 style='border-bottom: 0;'><a href='/cookbook/5.0/Finance/FinanceChartBins'>Finance Chart with Custom Time Bins</a></h2>

<div class="d-flex mb-2">
<a class="btn btn-sm btn-primary me-1" href="/cookbook/5.0/Finance/FinanceChartBins">Recipe Permalink</a>
<a class="btn btn-sm btn-success me-1" href="/cookbook/5.0/Finance">Category: Financial Plot</a>
</div>

Finance charts can display price range information over arbitrary time scales.

[![](/cookbook/5.0/images/FinanceChartBins.png?241029205813)](/cookbook/5.0/images/FinanceChartBins.png?241029205813)

{{< recipe-sp5 >}}ScottPlot.Plot myPlot = new();

DateTime timeOpen = new(1985, 09, 24, 9, 30, 0); // 9:30 AM
DateTime timeClose = new(1985, 09, 24, 16, 0, 0); // 4:00 PM
TimeSpan timeSpan = TimeSpan.FromMinutes(10); // 10 minute bins

List<OHLC> prices = new();
for (DateTime dt = timeOpen; dt <= timeClose; dt += timeSpan)
{
    double open = Generate.RandomNumber(20, 40) + prices.Count;
    double close = Generate.RandomNumber(20, 40) + prices.Count;
    double high = Math.Max(open, close) + Generate.RandomNumber(5);
    double low = Math.Min(open, close) - Generate.RandomNumber(5);
    prices.Add(new OHLC(open, high, low, close, dt, timeSpan));
}

myPlot.Add.Candlestick(prices);
myPlot.Axes.DateTimeTicksBottom();

myPlot.SavePng("demo.png", 400, 300);
{{< /recipe-sp5 >}}

<hr class='my-5 invisible'>


