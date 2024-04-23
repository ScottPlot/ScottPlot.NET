---
Title: Financial Plot - ScottPlot 5.0 Cookbook
Description: Finance plots display price data binned into time ranges
URL: /cookbook/5.0/Finance/
BreadcrumbNames: ["ScottPlot 5.0 Cookbook", "Financial Plot"]
BreadcrumbUrls: ["/cookbook/5.0/", "/cookbook/5.0/Finance"]
Date: 2024-04-23
Version: ScottPlot 5.0.27
Version: ScottPlot 5.0.27
SearchUrl: "/cookbook/5.0/search/"
ShowEditLink: false
---

# Financial Plot


<h2><a href='/cookbook/5.0/Finance/Candlestick'>Candlestick Chart</a></h2>

Candlestick charts use symbols to display price data. The rectangle indicates open and close prices, and the center line indicates minimum and maximum price for the given time period. Color indicates whether the price increased or decreased between open and close.

[![](/cookbook/5.0/images/Candlestick.png?240423091821)](/cookbook/5.0/images/Candlestick.png?240423091821)

{{< code-sp5 >}}

```cs
ScottPlot.Plot myPlot = new();

var prices = Generate.RandomOHLCs(30);
myPlot.Add.Candlestick(prices);
myPlot.Axes.DateTimeTicksBottom();

myPlot.SavePng("demo.png", 400, 300);

```

{{< /code-sp5 >}}

<hr class='my-5 invisible'>


<h2><a href='/cookbook/5.0/Finance/OhlcChart'>OHLC Chart</a></h2>

OHLC charts use symbols to display price data (open, high, low, and close) for specific time ranges.

[![](/cookbook/5.0/images/OhlcChart.png?240423091821)](/cookbook/5.0/images/OhlcChart.png?240423091821)

{{< code-sp5 >}}

```cs
ScottPlot.Plot myPlot = new();

var prices = Generate.RandomOHLCs(30);
myPlot.Add.OHLC(prices);
myPlot.Axes.DateTimeTicksBottom();

myPlot.SavePng("demo.png", 400, 300);

```

{{< /code-sp5 >}}

<hr class='my-5 invisible'>


<h2><a href='/cookbook/5.0/Finance/FinanceChartBins'>Finance Chart with Custom Time Bins</a></h2>

Finance charts can display price range information over arbitrary time scales.

[![](/cookbook/5.0/images/FinanceChartBins.png?240423091821)](/cookbook/5.0/images/FinanceChartBins.png?240423091821)

{{< code-sp5 >}}

```cs
ScottPlot.Plot myPlot = new();

DateTime timeOpen = new(1985, 09, 24, 9, 30, 0); // 9:30 AM
DateTime timeClose = new(1985, 09, 24, 16, 0, 0); // 4:00 PM
TimeSpan timeSpan = TimeSpan.FromMinutes(10); // 10 minute bins

List<OHLC> prices = new();
for (DateTime dt = timeOpen; dt <= timeClose; dt += timeSpan)
{
    double open = Generate.RandomNumber(20, 40) + prices.Count;
    double close = Generate.RandomNumber(20, 40) + prices.Count;
    double high = Math.Max(open, close) + Generate.RandomNumber(5);
    double low = Math.Min(open, close) - Generate.RandomNumber(5);
    prices.Add(new OHLC(open, high, low, close, dt, timeSpan));
}

myPlot.Add.Candlestick(prices);
myPlot.Axes.DateTimeTicksBottom();

myPlot.SavePng("demo.png", 400, 300);

```

{{< /code-sp5 >}}

<hr class='my-5 invisible'>


<h2><a href='/cookbook/5.0/Finance/FinanceRightAxis'>Price on Right</a></h2>

Finance charts can be created which display price information on the right axis.

[![](/cookbook/5.0/images/FinanceRightAxis.png?240423091821)](/cookbook/5.0/images/FinanceRightAxis.png?240423091821)

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
myPlot.Axes.DateTimeTicksBottom();

myPlot.SavePng("demo.png", 400, 300);

```

{{< /code-sp5 >}}

<hr class='my-5 invisible'>


<h2><a href='/cookbook/5.0/Finance/FinanceSma'>Simple Moving Average</a></h2>

Tools exist for creating simple moving average (SMA) curves and displaying them next to finanial data.

[![](/cookbook/5.0/images/FinanceSma.png?240423091821)](/cookbook/5.0/images/FinanceSma.png?240423091821)

{{< code-sp5 >}}

```cs
ScottPlot.Plot myPlot = new();

// generate and plot time series price data
var prices = Generate.RandomOHLCs(75);
myPlot.Add.Candlestick(prices);
myPlot.Axes.DateTimeTicksBottom();

// calculate SMA and display it as a scatter plot
int[] windowSizes = { 3, 8, 20 };
foreach (int windowSize in windowSizes)
{
    ScottPlot.Finance.SimpleMovingAverage sma = new(prices, windowSize);
    var sp = myPlot.Add.Scatter(sma.Dates, sma.Means);
    sp.LegendText = $"SMA {windowSize}";
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

[![](/cookbook/5.0/images/FinanceBollinger.png?240423091821)](/cookbook/5.0/images/FinanceBollinger.png?240423091821)

{{< code-sp5 >}}

```cs
ScottPlot.Plot myPlot = new();

// generate and plot time series price data
var prices = Generate.RandomOHLCs(100);
myPlot.Add.Candlestick(prices);
myPlot.Axes.DateTimeTicksBottom();

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


<h2><a href='/cookbook/5.0/Finance/FinancialPlotWithoutGaps'>Candlestick Chart Without Gaps</a></h2>

When the DateTimes stored in OHLC objects are used to determine the horizontal position of candlesticks, periods without data like weekends and holidays appear as gaps in the plot. Enabling sequential mode causes the plot to ignore the OHLC DateTimes and display candles at integer positions starting from zero. Users can customize the tick generator to display dates instead of numbers on the horizontal axis if desired.

[![](/cookbook/5.0/images/FinancialPlotWithoutGaps.png?240423091821)](/cookbook/5.0/images/FinancialPlotWithoutGaps.png?240423091821)

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

// By default, horizontal tick labels will be numbers (1, 2, 3...)
// We can use a manual tick generator to display dates on the horizontal axis
double[] tickPositions = Generate.Consecutive(tickDates.Length, tickDelta);
string[] tickLabels = tickDates.Select(x => x.ToString("MM/dd")).ToArray();
ScottPlot.TickGenerators.NumericManual tickGen = new(tickPositions, tickLabels);
myPlot.Axes.Bottom.TickGenerator = tickGen;

myPlot.SavePng("demo.png", 400, 300);

```

{{< /code-sp5 >}}

<hr class='my-5 invisible'>


<h2><a href='/cookbook/5.0/Finance/FinancialPlotWithoutGapsOhlc'>OHLC Chart Without Gaps</a></h2>

When the DateTimes stored in OHLC objects are used to determine the horizontal position, periods without data like weekends and holidays appear as gaps in the plot. Enabling sequential mode causes the plot to ignore the OHLC DateTimes and place OHLCs at integer positions starting from zero. Users can customize the tick generator to display dates instead of numbers on the horizontal axis if desired.

[![](/cookbook/5.0/images/FinancialPlotWithoutGapsOhlc.png?240423091821)](/cookbook/5.0/images/FinancialPlotWithoutGapsOhlc.png?240423091821)

{{< code-sp5 >}}

```cs
ScottPlot.Plot myPlot = new();

// create a OHLC plot
var prices = Generate.RandomOHLCs(31);
var ohlcPlot = myPlot.Add.OHLC(prices);

// enable sequential mode to place OHLCs at X = 0, 1, 2, ...
ohlcPlot.Sequential = true;

// determine a few OHLCs to display ticks for
int tickCount = 5;
int tickDelta = prices.Count / tickCount;
DateTime[] tickDates = prices
    .Where((x, i) => i % tickDelta == 0)
    .Select(x => x.DateTime)
    .ToArray();

// By default, horizontal tick labels will be numbers (1, 2, 3...)
// We can use a manual tick generator to display dates on the horizontal axis
double[] tickPositions = Generate.Consecutive(tickDates.Length, tickDelta);
string[] tickLabels = tickDates.Select(x => x.ToString("MM/dd")).ToArray();
ScottPlot.TickGenerators.NumericManual tickGen = new(tickPositions, tickLabels);
myPlot.Axes.Bottom.TickGenerator = tickGen;

myPlot.SavePng("demo.png", 400, 300);

```

{{< /code-sp5 >}}

<hr class='my-5 invisible'>

