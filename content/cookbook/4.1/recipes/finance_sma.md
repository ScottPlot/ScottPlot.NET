---
Title: "Simple Moving Average (SMA) - ScottPlot 4.1 Cookbook"
Description: "A simple moving average (SMA) technical indicator can be calculated and drawn as a scatter plot."
Date: 2023-12-13
Version: ScottPlot 4.1.69
URL: /cookbook/4.1/recipes/finance_sma/
BreadcrumbNames: ["ScottPlot 4.1 Cookbook", "Finance", "Simple Moving Average (SMA)"]
BreadcrumbUrls: ["/cookbook/4.1/", "/cookbook/4.1/category/plottable-finance", "/cookbook/4.1/recipes/finance_sma/"]
SearchUrl: "/cookbook/4.1/search/"
OgImage: "/cookbook/4.1/images/finance_sma.png"
---

<h2><a id='simple-moving-average-(sma)' href='/cookbook/4.1/recipes/finance_sma/'>Simple Moving Average (SMA)</a></h2>

A simple moving average (SMA) technical indicator can be calculated and drawn as a scatter plot.

```cs
var plt = new ScottPlot.Plot(600, 400);

OHLC[] ohlcs = DataGen.RandomStockPrices(null, 75);
var candlePlot = plt.AddCandlesticks(ohlcs);

var sma8 = candlePlot.GetSMA(8);
plt.AddScatterLines(sma8.xs, sma8.ys, Color.Blue, 2);

var sma20 = candlePlot.GetSMA(20);
plt.AddScatterLines(sma20.xs, sma20.ys, Color.Navy, 2);

plt.SaveFig("finance_sma.png");
```

<img src='../../images/finance_sma.png' class='d-block mx-auto my-5' />


