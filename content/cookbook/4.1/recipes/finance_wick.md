---
Title: "Custom Wick Color - ScottPlot 4.1 Cookbook"
Description: "By default candle wicks are the same color as their bodies, but this can be customized."
Date: 2024-01-21
Version: ScottPlot 4.1.71
URL: /cookbook/4.1/recipes/finance_wick/
BreadcrumbNames: ["ScottPlot 4.1 Cookbook", "Finance", "Custom Wick Color"]
BreadcrumbUrls: ["/cookbook/4.1/", "/cookbook/4.1/category/plottable-finance", "/cookbook/4.1/recipes/finance_wick/"]
SearchUrl: "/cookbook/4.1/search/"
OgImage: "/cookbook/4.1/images/finance_wick.png"
---

<h2><a id='custom-wick-color' href='/cookbook/4.1/recipes/finance_wick/'>Custom Wick Color</a></h2>

By default candle wicks are the same color as their bodies, but this can be customized.

{{< code-sp4 >}}

```cs
ScottPlot.Version.ShouldBe(4, 1, 71);
var plt = new ScottPlot.Plot(600, 400);

OHLC[] prices = DataGen.RandomStockPrices(null, 30, TimeSpan.FromMinutes(5));
var fp = plt.AddCandlesticks(prices);
fp.WickColor = Color.Black;

plt.SaveFig("finance_wick.png");
```

{{< /code-sp4 >}}

<img src='../../images/finance_wick.png' class='d-block mx-auto my-5' />


