---
Title: "Custom Colors - ScottPlot 4.1 Cookbook"
Description: "Candles that close below their open price are colored differently from candles which close at or above it. These colors can be customized. Combine this styling with a custom wick color (which also controls the candle border) to create a different visual style."
Date: 2024-01-07
Version: ScottPlot 4.1.70
URL: /cookbook/4.1/recipes/finance_color/
BreadcrumbNames: ["ScottPlot 4.1 Cookbook", "Finance", "Custom Colors"]
BreadcrumbUrls: ["/cookbook/4.1/", "/cookbook/4.1/category/plottable-finance", "/cookbook/4.1/recipes/finance_color/"]
SearchUrl: "/cookbook/4.1/search/"
OgImage: "/cookbook/4.1/images/finance_color.png"
---

<h2><a id='custom-colors' href='/cookbook/4.1/recipes/finance_color/'>Custom Colors</a></h2>

Candles that close below their open price are colored differently from candles which close at or above it. These colors can be customized. Combine this styling with a custom wick color (which also controls the candle border) to create a different visual style.

```cs
ScottPlot.Version.ShouldBe(4, 1, 70);
var plt = new ScottPlot.Plot(600, 400);

OHLC[] prices = DataGen.RandomStockPrices(null, 30, TimeSpan.FromMinutes(5));
var fp = plt.AddCandlesticks(prices);
fp.ColorDown = Color.Black;
fp.ColorUp = Color.White;
fp.WickColor = Color.Black;

plt.SaveFig("finance_color.png");
```

<img src='../../images/finance_color.png' class='d-block mx-auto my-5' />


