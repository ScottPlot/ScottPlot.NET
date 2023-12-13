---
Title: "Price on Right - ScottPlot 4.1 Cookbook"
Description: "Newer data appears on the ride side of the chart so financial charts are often displayed with the vertical axis label on the right side as well. This is possible by disabling the left vertical axis (YAxis) and enabling the right one (YAxis2). The left and right Y axes are index 0 and 1 (respectively), and the plottable has to be update to indicate which axis index it should render on."
Date: 2023-12-13
Version: ScottPlot 4.1.69
URL: /cookbook/4.1/recipes/finance_right/
BreadcrumbNames: ["ScottPlot 4.1 Cookbook", "Finance", "Price on Right"]
BreadcrumbUrls: ["/cookbook/4.1/", "/cookbook/4.1/category/plottable-finance", "/cookbook/4.1/recipes/finance_right/"]
SearchUrl: "/cookbook/4.1/search/"
OgImage: "/cookbook/4.1/images/finance_right.png"
---

<h2><a id='price-on-right' href='/cookbook/4.1/recipes/finance_right/'>Price on Right</a></h2>

Newer data appears on the ride side of the chart so financial charts are often displayed with the vertical axis label on the right side as well. This is possible by disabling the left vertical axis (YAxis) and enabling the right one (YAxis2). The left and right Y axes are index 0 and 1 (respectively), and the plottable has to be update to indicate which axis index it should render on.

```cs
var plt = new ScottPlot.Plot(600, 400);

OHLC[] prices = DataGen.RandomStockPrices(null, 30, TimeSpan.FromMinutes(5));
var candlePlot = plt.AddCandlesticks(prices);
candlePlot.YAxisIndex = 1;
plt.XAxis.DateTimeFormat(true);

plt.YAxis.Ticks(false);
plt.YAxis2.Ticks(true);
plt.YAxis2.Label("Price (USD)");

plt.SaveFig("finance_right.png");
```

<img src='../../images/finance_right.png' class='d-block mx-auto my-5' />


