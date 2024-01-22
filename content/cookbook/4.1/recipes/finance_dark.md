---
Title: "Dark Mode - ScottPlot 4.1 Cookbook"
Description: "A dark mode finance plot can be realized by customizing color options of the candles and figure. Colors in this example were chosen to mimic TC2000."
Date: 2024-01-21
Version: ScottPlot 4.1.71
URL: /cookbook/4.1/recipes/finance_dark/
BreadcrumbNames: ["ScottPlot 4.1 Cookbook", "Finance", "Dark Mode"]
BreadcrumbUrls: ["/cookbook/4.1/", "/cookbook/4.1/category/plottable-finance", "/cookbook/4.1/recipes/finance_dark/"]
SearchUrl: "/cookbook/4.1/search/"
OgImage: "/cookbook/4.1/images/finance_dark.png"
---

<h2><a id='dark-mode' href='/cookbook/4.1/recipes/finance_dark/'>Dark Mode</a></h2>

A dark mode finance plot can be realized by customizing color options of the candles and figure. Colors in this example were chosen to mimic TC2000.

{{< code-sp4 >}}

```cs
ScottPlot.Version.ShouldBe(4, 1, 71);
var plt = new ScottPlot.Plot(600, 400);

// add some random candles
OHLC[] prices = DataGen.RandomStockPrices(null, 100, TimeSpan.FromMinutes(5));
double[] xs = prices.Select(x => x.DateTime.ToOADate()).ToArray();
var candlePlot = plt.AddCandlesticks(prices);
candlePlot.YAxisIndex = 1;

plt.XAxis.DateTimeFormat(true);

// add SMA indicators for 8 and 20 days
var sma8 = candlePlot.GetSMA(8);
var sma20 = candlePlot.GetSMA(20);
var sma8plot = plt.AddScatterLines(sma8.xs, sma8.ys, Color.Cyan, 2, label: "8 day SMA");
var sma20plot = plt.AddScatterLines(sma20.xs, sma20.ys, Color.Yellow, 2, label: "20 day SMA");
sma8plot.YAxisIndex = 1;
sma20plot.YAxisIndex = 1;

// customize candle styling
candlePlot.ColorDown = ColorTranslator.FromHtml("#00FF00");
candlePlot.ColorUp = ColorTranslator.FromHtml("#FF0000");

// customize figure styling
plt.Layout(padding: 12);
plt.Style(figureBackground: Color.Black, dataBackground: Color.Black);
plt.Frameless();
plt.XAxis.TickLabelStyle(color: Color.White);
plt.XAxis.TickMarkColor(ColorTranslator.FromHtml("#333333"));
plt.XAxis.MajorGrid(color: ColorTranslator.FromHtml("#333333"));

// hide the left axis and show a right axis
plt.YAxis.Ticks(false);
plt.YAxis.Grid(false);
plt.YAxis2.Ticks(true);
plt.YAxis2.Grid(true);
plt.YAxis2.TickLabelStyle(color: ColorTranslator.FromHtml("#00FF00"));
plt.YAxis2.TickMarkColor(ColorTranslator.FromHtml("#333333"));
plt.YAxis2.MajorGrid(color: ColorTranslator.FromHtml("#333333"));

// customize the legend style
var legend = plt.Legend();
legend.FillColor = Color.Transparent;
legend.OutlineColor = Color.Transparent;
legend.Font.Color = Color.White;
legend.Font.Bold = true;

plt.SaveFig("finance_dark.png");
```

{{< /code-sp4 >}}

<img src='../../images/finance_dark.png' class='d-block mx-auto my-5' />


