---
Title: "Candlesticks with Custom Tick Labels - ScottPlot 4.1 Cookbook"
Description: "A better way to represent time on the horizontal axis is to use traditional Cartesian coordinates so each candlestick is placed at X positions (0, 1, 2, etc.), then manually define the locations and label text of important positions on the plot. This is clunky, but possible. This inelegance is why financial charting is probably best done with real financial charting libraries, not a scientific charting library like ScottPlot..."
Date: 2024-01-07
Version: ScottPlot 4.1.70
URL: /cookbook/4.1/recipes/finance_ticklabels/
BreadcrumbNames: ["ScottPlot 4.1 Cookbook", "Finance", "Candlesticks with Custom Tick Labels"]
BreadcrumbUrls: ["/cookbook/4.1/", "/cookbook/4.1/category/plottable-finance", "/cookbook/4.1/recipes/finance_ticklabels/"]
SearchUrl: "/cookbook/4.1/search/"
OgImage: "/cookbook/4.1/images/finance_ticklabels.png"
---

<h2><a id='candlesticks-with-custom-tick-labels' href='/cookbook/4.1/recipes/finance_ticklabels/'>Candlesticks with Custom Tick Labels</a></h2>

A better way to represent time on the horizontal axis is to use traditional Cartesian coordinates so each candlestick is placed at X positions (0, 1, 2, etc.), then manually define the locations and label text of important positions on the plot. This is clunky, but possible. This inelegance is why financial charting is probably best done with real financial charting libraries, not a scientific charting library like ScottPlot...

```cs
ScottPlot.Version.ShouldBe(4, 1, 70);
var plt = new ScottPlot.Plot(600, 400);

OHLC[] prices = DataGen.RandomStockPrices(null, 30);
plt.AddCandlesticks(prices);

// manually indicate where axis ticks should be and what their labels should say
double[] tickPositions = { 0, 6, 13, 20, 27 };
string[] tickLabels = { "Sep 23", "Sep 30", "Oct 7", "Oct 14", "Oct 21" };
plt.XTicks(tickPositions, tickLabels);

plt.SaveFig("finance_tickLabels.png");
```

<img src='../../images/finance_ticklabels.png' class='d-block mx-auto my-5' />


