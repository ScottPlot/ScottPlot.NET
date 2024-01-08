---
Title: "OHLC Chart - ScottPlot 4.1 Cookbook"
Description: "OHLC charts are an alternative to candlestick charts. They show high and low prices as a vertical line, and indicate open and close prices with little ticks to the left and to the right."
Date: 2024-01-07
Version: ScottPlot 4.1.70
URL: /cookbook/4.1/recipes/finance_ohlc/
BreadcrumbNames: ["ScottPlot 4.1 Cookbook", "Finance", "OHLC Chart"]
BreadcrumbUrls: ["/cookbook/4.1/", "/cookbook/4.1/category/plottable-finance", "/cookbook/4.1/recipes/finance_ohlc/"]
SearchUrl: "/cookbook/4.1/search/"
OgImage: "/cookbook/4.1/images/finance_ohlc.png"
---

<h2><a id='ohlc-chart' href='/cookbook/4.1/recipes/finance_ohlc/'>OHLC Chart</a></h2>

OHLC charts are an alternative to candlestick charts. They show high and low prices as a vertical line, and indicate open and close prices with little ticks to the left and to the right.

```cs
ScottPlot.Version.ShouldBe(4, 1, 70);
var plt = new ScottPlot.Plot(600, 400);

OHLC[] prices = DataGen.RandomStockPrices(null, 60);
plt.AddOHLCs(prices);

plt.SaveFig("finance_ohlc.png");
```

<img src='../../images/finance_ohlc.png' class='d-block mx-auto my-5' />


