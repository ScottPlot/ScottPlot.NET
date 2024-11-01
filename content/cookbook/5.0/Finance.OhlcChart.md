---
Title: OHLC Chart - ScottPlot 5.0 Cookbook
Description: OHLC charts use symbols to display price data (open, high, low, and close) for specific time ranges.
URL: /cookbook/5.0/Finance/OhlcChart/
BreadcrumbNames: ["ScottPlot 5.0 Cookbook", "Financial Plot", "OHLC Chart"]
BreadcrumbUrls: ["/cookbook/5.0/", "/cookbook/5.0/Finance", "/cookbook/5.0/Finance/OhlcChart"]
Date: 2024-11-01
Version: ScottPlot 5.0.42
Version: ScottPlot 5.0.42
SearchUrl: "/cookbook/5.0/search/"
ShowEditLink: false
---


<div class='d-flex align-items-center mt-5'>
<h1 class='me-2 text-dark my-0 border-0'>OHLC Chart</h1>
</div>

OHLC charts use symbols to display price data (open, high, low, and close) for specific time ranges.

[![](/cookbook/5.0/images/OhlcChart.png?241101192719)](/cookbook/5.0/images/OhlcChart.png?241101192719)

{{< recipe-sp5 >}}ScottPlot.Plot myPlot = new();

var prices = Generate.RandomOHLCs(30);
myPlot.Add.OHLC(prices);
myPlot.Axes.DateTimeTicksBottom();

myPlot.SavePng("demo.png", 400, 300);
{{< /recipe-sp5 >}}

<div class='my-5 text-center'>This recipe is one of many in the <a href='/cookbook/5.0/Finance'>Financial Plot</a> category</div>


