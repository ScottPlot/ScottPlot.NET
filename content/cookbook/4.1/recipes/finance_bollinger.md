---
Title: "Bollinger Bands - ScottPlot 4.1 Cookbook"
Description: "Bollinger bands are a common technical indicator that show the average +/- two times the standard deviation of a given time range preceeding it."
Date: 12/11/2023 8:04:06 PM
Version: ScottPlot 4.1.69
URL: /cookbook/4.1/recipes/finance_bollinger/
BreadcrumbNames: ["ScottPlot 4.1 Cookbook", "Finance", "Bollinger Bands"]
BreadcrumbUrls: ["/cookbook/4.1/", "/cookbook/4.1/category/plottable-finance", "/cookbook/4.1/recipes/finance_bollinger/"]
SearchUrl: "/cookbook/4.1/search/"
OgImage: "/cookbook/4.1/images/finance_bollinger.png"
---

<h2><a href='/cookbook/4.1/recipes/finance_bollinger/'>Bollinger Bands</a></h2>

Bollinger bands are a common technical indicator that show the average +/- two times the standard deviation of a given time range preceeding it.

```cs
var plt = new ScottPlot.Plot(600, 400);

OHLC[] ohlcs = DataGen.RandomStockPrices(null, 100);
var candlePlot = plt.AddCandlesticks(ohlcs);

var bol = candlePlot.GetBollingerBands(20);
plt.AddScatterLines(bol.xs, bol.sma, Color.Blue);
plt.AddScatterLines(bol.xs, bol.lower, Color.Blue, lineStyle: LineStyle.Dash);
plt.AddScatterLines(bol.xs, bol.upper, Color.Blue, lineStyle: LineStyle.Dash);

plt.SaveFig("finance_bollinger.png");
```

<img src='../../images/finance_bollinger.png' class='d-block mx-auto my-5' />


