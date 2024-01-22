---
Title: Financial Plot - ScottPlot 5.0 Cookbook
Description: Finance plots display price data binned into time ranges
URL: /cookbook/5.0/Finance/
BreadcrumbNames: ["ScottPlot 5.0 Cookbook", "Financial Plot"]
BreadcrumbUrls: ["/cookbook/5.0/", "/cookbook/5.0/Finance"]
Date: 2024-01-22
Version: ScottPlot 5.0.20
Version: ScottPlot 5.0.20
SearchUrl: "/cookbook/5.0/search/"
ShowEditLink: false
---

# Financial Plot


<h2><a href='/cookbook/5.0/Finance/Candlestick'>Candlestick Chart</a></h2>

Candlestick charts use symbols to display price data. The rectangle indicates open and close prices, and the center line indicates minimum and maximum price for the given time period. Color indicates whether the price increased or decreased between open and close.

[![](/cookbook/5.0/images/Candlestick.png)](/cookbook/5.0/images/Candlestick.png)

{{< code-sp5 >}}

```cs
ScottPlot.Plot myPlot = new();

var prices = Generate.RandomOHLCs(30);
myPlot.Add.Candlestick(prices);
myPlot.Axes.DateTimeTicks(Edge.Bottom);

myPlot.SavePng("demo.png", 400, 300);

```

{{< /code-sp5 >}}

<hr class='my-5 invisible'>


<h2><a href='/cookbook/5.0/Finance/OhlcChart'>OHLC Chart</a></h2>

OHLC charts use symbols to display price data (open, high, low, and close) for specific time ranges.

[![](/cookbook/5.0/images/OhlcChart.png)](/cookbook/5.0/images/OhlcChart.png)

{{< code-sp5 >}}

```cs
ScottPlot.Plot myPlot = new();

var prices = Generate.RandomOHLCs(30);
myPlot.Add.OHLC(prices);
myPlot.Axes.DateTimeTicks(Edge.Bottom);

myPlot.SavePng("demo.png", 400, 300);

```

{{< /code-sp5 >}}

<hr class='my-5 invisible'>


<h2><a href='/cookbook/5.0/Finance/FinanceRightAxis'>Price on Right</a></h2>

Finance charts can be created which display price information on the right axis.

[![](/cookbook/5.0/images/FinanceRightAxis.png)](/cookbook/5.0/images/FinanceRightAxis.png)

{{< code-sp5 >}}

```cs
ScottPlot.Plot myPlot = new();

// add candlesticks to the plot
var prices = Generate.RandomOHLCs(30);
var candles = myPlot.Add.Candlestick(prices);

// configure the candlesticks to use the plot's right axis
candles.Axes.YAxis = myPlot.Axes.Right;
candles.Axes.YAxis.Label.Text = "Price";

// style the bottom axis to display date
myPlot.Axes.DateTimeTicks(Edge.Bottom);

myPlot.SavePng("demo.png", 400, 300);

```

{{< /code-sp5 >}}

<hr class='my-5 invisible'>


<h2><a href='/cookbook/5.0/Finance/FinanceSma'>Simple Moving Average</a></h2>

Tools exist for creating simple moving average (SMA) curves and displaying them next to finanial data.

[![](/cookbook/5.0/images/FinanceSma.png)](/cookbook/5.0/images/FinanceSma.png)

{{< code-sp5 >}}

```cs
ScottPlot.Plot myPlot = new();

// generate and plot time series price data
var prices = Generate.RandomOHLCs(75);
myPlot.Add.Candlestick(prices);
myPlot.Axes.DateTimeTicks(Edge.Bottom);

// calculate SMA and display it as a scatter plot
int[] windowSizes = { 3, 8, 20 };
foreach (int windowSize in windowSizes)
{
    ScottPlot.Finance.SimpleMovingAverage sma = new(prices, windowSize);
    var sp = myPlot.Add.Scatter(sma.Dates, sma.Means);
    sp.Label = $"SMA {windowSize}";
    sp.MarkerSize = 0;
    sp.LineWidth = 3;
    sp.Color = Colors.Navy.WithAlpha(1 - windowSize / 30.0);
}

myPlot.ShowLegend();

myPlot.SavePng("demo.png", 400, 300);

```

{{< /code-sp5 >}}

<hr class='my-5 invisible'>


<h2><a href='/cookbook/5.0/Finance/FinanceBollinger'>Bollinger Bands</a></h2>

Tools exist for creating Bollinger Bands which display weighted moving mean and variance for time series financial data.

[![](/cookbook/5.0/images/FinanceBollinger.png)](/cookbook/5.0/images/FinanceBollinger.png)

{{< code-sp5 >}}

```cs
ScottPlot.Plot myPlot = new();

// generate and plot time series price data
var prices = Generate.RandomOHLCs(100);
myPlot.Add.Candlestick(prices);
myPlot.Axes.DateTimeTicks(Edge.Bottom);

// calculate Bollinger Bands
ScottPlot.Finance.BollingerBands bb = new(prices, 20);

// display center line (mean) as a solid line
var sp1 = myPlot.Add.Scatter(bb.Dates, bb.Means);
sp1.MarkerSize = 0;
sp1.Color = Colors.Navy;

// display upper bands (positive variance) as a dashed line
var sp2 = myPlot.Add.Scatter(bb.Dates, bb.UpperValues);
sp2.MarkerSize = 0;
sp2.Color = Colors.Navy;
sp2.LinePattern = LinePattern.Dotted;

// display lower bands (positive variance) as a dashed line
var sp3 = myPlot.Add.Scatter(bb.Dates, bb.LowerValues);
sp3.MarkerSize = 0;
sp3.Color = Colors.Navy;
sp3.LinePattern = LinePattern.Dotted;

myPlot.SavePng("demo.png", 400, 300);

```

{{< /code-sp5 >}}

<hr class='my-5 invisible'>


<h2><a href='/cookbook/5.0/Finance/FinancialPlotWithoutGaps'>Financial Plot Without Gaps</a></h2>

When the DateTimes stored in OHLC objects are used to determine the horizontal position of candlesticks, periods without data like weekends and holidays appear as gaps in the plot. Enabling sequential mode causes the plot to ignore the OHLC DateTimes and display candles at integer positions starting from zero. Since this is not a true DateTime axis, users enabling this mode must customize the tick labels themselves.

[![](/cookbook/5.0/images/FinancialPlotWithoutGaps.png)](/cookbook/5.0/images/FinancialPlotWithoutGaps.png)

{{< code-sp5 >}}

```cs
ScottPlot.Plot myPlot = new();

// create a candlestick plot
var prices = Generate.RandomOHLCs(31);
var candlePlot = myPlot.Add.Candlestick(prices);

// enable sequential mode to place candles at X = 0, 1, 2, ...
candlePlot.Sequential = true;

// determine a few candles to display ticks for
int tickCount = 5;
int tickDelta = prices.Count / tickCount;
DateTime[] tickDates = prices
    .Where((x, i) => i % tickDelta == 0)
    .Select(x => x.DateTime)
    .ToArray();

// use a manual tick generator for the horizontal axis
double[] tickPositions = Generate.Consecutive(tickDates.Length, tickDelta);
string[] tickLabels = tickDates.Select(x => x.ToString("MM/dd")).ToArray();
ScottPlot.TickGenerators.NumericManual tickGen = new(tickPositions, tickLabels);
myPlot.Axes.Bottom.TickGenerator = tickGen;

myPlot.SavePng("demo.png", 400, 300);

```

{{< /code-sp5 >}}

<hr class='my-5 invisible'>

