---
Title: "Candlestick Chart - ScottPlot 4.1 Cookbook"
Description: "Price movement over time periods are represented using OHLC objects. A single OHLC holds open, high, low, and close pricing. Users can create their own OHLC arrays, or use the sample data generator to practice working with financial data."
Date: 2024-01-07
Version: ScottPlot 4.1.70
URL: /cookbook/4.1/recipes/finance_quickstart/
BreadcrumbNames: ["ScottPlot 4.1 Cookbook", "Finance", "Candlestick Chart"]
BreadcrumbUrls: ["/cookbook/4.1/", "/cookbook/4.1/category/plottable-finance", "/cookbook/4.1/recipes/finance_quickstart/"]
SearchUrl: "/cookbook/4.1/search/"
OgImage: "/cookbook/4.1/images/finance_quickstart.png"
---

<h2><a id='candlestick-chart' href='/cookbook/4.1/recipes/finance_quickstart/'>Candlestick Chart</a></h2>

Price movement over time periods are represented using OHLC objects. A single OHLC holds open, high, low, and close pricing. Users can create their own OHLC arrays, or use the sample data generator to practice working with financial data.

```cs
ScottPlot.Version.ShouldBe(4, 1, 70);
var plt = new ScottPlot.Plot(600, 400);

// Each candle is represented by a single OHLC object.
OHLC price = new(
    open: 100,
    high: 120,
    low: 80,
    close: 105,
    timeStart: new DateTime(1985, 09, 24),
    timeSpan: TimeSpan.FromDays(1));

// Users could be build their own array of OHLCs, or lean on 
// the sample data generator to simulate price data over time.
OHLC[] prices = DataGen.RandomStockPrices(new Random(0), 60);

// Add a financial chart to the plot using an array of OHLC objects
plt.AddCandlesticks(prices);

plt.SaveFig("finance_quickstart.png");
```

<img src='../../images/finance_quickstart.png' class='d-block mx-auto my-5' />


