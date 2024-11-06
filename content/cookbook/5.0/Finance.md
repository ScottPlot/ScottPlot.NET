---
Title: Financial Plot - ScottPlot 5.0 Cookbook
Description: Finance plots display price data binned into time ranges
URL: /cookbook/5.0/Finance/
BreadcrumbNames: ["ScottPlot 5.0 Cookbook", "Financial Plot"]
BreadcrumbUrls: ["/cookbook/5.0/", "/cookbook/5.0/Finance"]
Date: 2024-11-06
Version: ScottPlot 5.0.43
Version: ScottPlot 5.0.43
SearchUrl: "/cookbook/5.0/search/"
ShowEditLink: false
---

<h1>Financial Plot</h1>


<div class='d-flex align-items-center mt-5'>
<h1 class='me-2 text-dark my-0 border-0'>Candlestick Chart</h1>
<a href='/cookbook/5.0/Finance/Candlestick' target='_blank'>
<img src='/images/icons/new-window.svg' style='height: 2rem;' class='new-window-icon'>
</a>
</div>

Candlestick charts use symbols to display price data. The rectangle indicates open and close prices, and the center line indicates minimum and maximum price for the given time period. Color indicates whether the price increased or decreased between open and close.

[![](/cookbook/5.0/images/Candlestick.png?241105214550)](/cookbook/5.0/images/Candlestick.png?241105214550)

{{< recipe-sp5 sourceUrl="https://github.com/ScottPlot/ScottPlot/blob/main/src/ScottPlot5/ScottPlot5%20Cookbook/Recipes/PlotTypes/Finance.cs" imageUrl="/cookbook/5.0/images/Candlestick.png?241105214550" >}}ScottPlot.Plot myPlot = new();

var prices = Generate.RandomOHLCs(30);
myPlot.Add.Candlestick(prices);
myPlot.Axes.DateTimeTicksBottom();

myPlot.SavePng("demo.png", 400, 300);
{{< /recipe-sp5 >}}

<hr class='my-5 invisible'>



<div class='d-flex align-items-center mt-5'>
<h1 class='me-2 text-dark my-0 border-0'>OHLC Chart</h1>
<a href='/cookbook/5.0/Finance/OhlcChart' target='_blank'>
<img src='/images/icons/new-window.svg' style='height: 2rem;' class='new-window-icon'>
</a>
</div>

OHLC charts use symbols to display price data (open, high, low, and close) for specific time ranges.

[![](/cookbook/5.0/images/OhlcChart.png?241105214550)](/cookbook/5.0/images/OhlcChart.png?241105214550)

{{< recipe-sp5 sourceUrl="https://github.com/ScottPlot/ScottPlot/blob/main/src/ScottPlot5/ScottPlot5%20Cookbook/Recipes/PlotTypes/Finance.cs" imageUrl="/cookbook/5.0/images/OhlcChart.png?241105214550" >}}ScottPlot.Plot myPlot = new();

var prices = Generate.RandomOHLCs(30);
myPlot.Add.OHLC(prices);
myPlot.Axes.DateTimeTicksBottom();

myPlot.SavePng("demo.png", 400, 300);
{{< /recipe-sp5 >}}

<hr class='my-5 invisible'>



<div class='d-flex align-items-center mt-5'>
<h1 class='me-2 text-dark my-0 border-0'>Finance Chart with Custom Time Bins</h1>
<a href='/cookbook/5.0/Finance/FinanceChartBins' target='_blank'>
<img src='/images/icons/new-window.svg' style='height: 2rem;' class='new-window-icon'>
</a>
</div>

Finance charts can display price range information over arbitrary time scales.

[![](/cookbook/5.0/images/FinanceChartBins.png?241105214550)](/cookbook/5.0/images/FinanceChartBins.png?241105214550)

{{< recipe-sp5 sourceUrl="https://github.com/ScottPlot/ScottPlot/blob/main/src/ScottPlot5/ScottPlot5%20Cookbook/Recipes/PlotTypes/Finance.cs" imageUrl="/cookbook/5.0/images/FinanceChartBins.png?241105214550" >}}ScottPlot.Plot myPlot = new();

DateTime timeOpen = new(1985, 09, 24, 9, 30, 0); // 9:30 AM
DateTime timeClose = new(1985, 09, 24, 16, 0, 0); // 4:00 PM
TimeSpan timeSpan = TimeSpan.FromMinutes(10); // 10 minute bins

List&lt;OHLC&gt; prices = new();
for (DateTime dt = timeOpen; dt &lt;= timeClose; dt += timeSpan)
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
{{< /recipe-sp5 >}}

<hr class='my-5 invisible'>



<div class='d-flex align-items-center mt-5'>
<h1 class='me-2 text-dark my-0 border-0'>Price on Right</h1>
<a href='/cookbook/5.0/Finance/FinanceRightAxis' target='_blank'>
<img src='/images/icons/new-window.svg' style='height: 2rem;' class='new-window-icon'>
</a>
</div>

Finance charts can be created which display price information on the right axis.

[![](/cookbook/5.0/images/FinanceRightAxis.png?241105214550)](/cookbook/5.0/images/FinanceRightAxis.png?241105214550)

{{< recipe-sp5 sourceUrl="https://github.com/ScottPlot/ScottPlot/blob/main/src/ScottPlot5/ScottPlot5%20Cookbook/Recipes/PlotTypes/Finance.cs" imageUrl="/cookbook/5.0/images/FinanceRightAxis.png?241105214550" >}}ScottPlot.Plot myPlot = new();

// add candlesticks to the plot
var prices = Generate.RandomOHLCs(30);
var candles = myPlot.Add.Candlestick(prices);

// configure the candlesticks to use the plot's right axis
candles.Axes.YAxis = myPlot.Axes.Right;
candles.Axes.YAxis.Label.Text = "Price";

// style the bottom axis to display date
myPlot.Axes.DateTimeTicksBottom();

myPlot.SavePng("demo.png", 400, 300);
{{< /recipe-sp5 >}}

<hr class='my-5 invisible'>



<div class='d-flex align-items-center mt-5'>
<h1 class='me-2 text-dark my-0 border-0'>Simple Moving Average</h1>
<a href='/cookbook/5.0/Finance/FinanceSma' target='_blank'>
<img src='/images/icons/new-window.svg' style='height: 2rem;' class='new-window-icon'>
</a>
</div>

Tools exist for creating simple moving average (SMA) curves and displaying them next to finanial data.

[![](/cookbook/5.0/images/FinanceSma.png?241105214550)](/cookbook/5.0/images/FinanceSma.png?241105214550)

{{< recipe-sp5 sourceUrl="https://github.com/ScottPlot/ScottPlot/blob/main/src/ScottPlot5/ScottPlot5%20Cookbook/Recipes/PlotTypes/Finance.cs" imageUrl="/cookbook/5.0/images/FinanceSma.png?241105214550" >}}ScottPlot.Plot myPlot = new();

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
{{< /recipe-sp5 >}}

<hr class='my-5 invisible'>



<div class='d-flex align-items-center mt-5'>
<h1 class='me-2 text-dark my-0 border-0'>Bollinger Bands</h1>
<a href='/cookbook/5.0/Finance/FinanceBollinger' target='_blank'>
<img src='/images/icons/new-window.svg' style='height: 2rem;' class='new-window-icon'>
</a>
</div>

Tools exist for creating Bollinger Bands which display weighted moving mean and variance for time series financial data.

[![](/cookbook/5.0/images/FinanceBollinger.png?241105214550)](/cookbook/5.0/images/FinanceBollinger.png?241105214550)

{{< recipe-sp5 sourceUrl="https://github.com/ScottPlot/ScottPlot/blob/main/src/ScottPlot5/ScottPlot5%20Cookbook/Recipes/PlotTypes/Finance.cs" imageUrl="/cookbook/5.0/images/FinanceBollinger.png?241105214550" >}}ScottPlot.Plot myPlot = new();

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
{{< /recipe-sp5 >}}

<hr class='my-5 invisible'>



<div class='d-flex align-items-center mt-5'>
<h1 class='me-2 text-dark my-0 border-0'>Candlestick Chart Without Gaps</h1>
<a href='/cookbook/5.0/Finance/FinancialPlotWithoutGaps' target='_blank'>
<img src='/images/icons/new-window.svg' style='height: 2rem;' class='new-window-icon'>
</a>
</div>

When the DateTimes stored in OHLC objects are used to determine the horizontal position of candlesticks, periods without data like weekends and holidays appear as gaps in the plot. Enabling sequential mode causes the plot to ignore the OHLC DateTimes and display candles at integer positions starting from zero. Users can customize the tick generator to display dates instead of numbers on the horizontal axis if desired.

[![](/cookbook/5.0/images/FinancialPlotWithoutGaps.png?241105214550)](/cookbook/5.0/images/FinancialPlotWithoutGaps.png?241105214550)

{{< recipe-sp5 sourceUrl="https://github.com/ScottPlot/ScottPlot/blob/main/src/ScottPlot5/ScottPlot5%20Cookbook/Recipes/PlotTypes/Finance.cs" imageUrl="/cookbook/5.0/images/FinancialPlotWithoutGaps.png?241105214550" >}}ScottPlot.Plot myPlot = new();

// create a candlestick plot
var prices = Generate.RandomOHLCs(31);
var candlePlot = myPlot.Add.Candlestick(prices);

// enable sequential mode to place candles at X = 0, 1, 2, ...
candlePlot.Sequential = true;

// determine a few candles to display ticks for
int tickCount = 5;
int tickDelta = prices.Count / tickCount;
DateTime[] tickDates = prices
    .Where((x, i) =&gt; i % tickDelta == 0)
    .Select(x =&gt; x.DateTime)
    .ToArray();

// By default, horizontal tick labels will be numbers (1, 2, 3...)
// We can use a manual tick generator to display dates on the horizontal axis
double[] tickPositions = Generate.Consecutive(tickDates.Length, tickDelta);
string[] tickLabels = tickDates.Select(x =&gt; x.ToString("MM/dd")).ToArray();
ScottPlot.TickGenerators.NumericManual tickGen = new(tickPositions, tickLabels);
myPlot.Axes.Bottom.TickGenerator = tickGen;

myPlot.SavePng("demo.png", 400, 300);
{{< /recipe-sp5 >}}

<hr class='my-5 invisible'>



<div class='d-flex align-items-center mt-5'>
<h1 class='me-2 text-dark my-0 border-0'>OHLC Chart Without Gaps</h1>
<a href='/cookbook/5.0/Finance/FinancialPlotWithoutGapsOhlc' target='_blank'>
<img src='/images/icons/new-window.svg' style='height: 2rem;' class='new-window-icon'>
</a>
</div>

When the DateTimes stored in OHLC objects are used to determine the horizontal position, periods without data like weekends and holidays appear as gaps in the plot. Enabling sequential mode causes the plot to ignore the OHLC DateTimes and place OHLCs at integer positions starting from zero. Users can customize the tick generator to display dates instead of numbers on the horizontal axis if desired.

[![](/cookbook/5.0/images/FinancialPlotWithoutGapsOhlc.png?241105214550)](/cookbook/5.0/images/FinancialPlotWithoutGapsOhlc.png?241105214550)

{{< recipe-sp5 sourceUrl="https://github.com/ScottPlot/ScottPlot/blob/main/src/ScottPlot5/ScottPlot5%20Cookbook/Recipes/PlotTypes/Finance.cs" imageUrl="/cookbook/5.0/images/FinancialPlotWithoutGapsOhlc.png?241105214550" >}}ScottPlot.Plot myPlot = new();

// create a OHLC plot
var prices = Generate.RandomOHLCs(31);
var ohlcPlot = myPlot.Add.OHLC(prices);

// enable sequential mode to place OHLCs at X = 0, 1, 2, ...
ohlcPlot.Sequential = true;

// determine a few OHLCs to display ticks for
int tickCount = 5;
int tickDelta = prices.Count / tickCount;
DateTime[] tickDates = prices
    .Where((x, i) =&gt; i % tickDelta == 0)
    .Select(x =&gt; x.DateTime)
    .ToArray();

// By default, horizontal tick labels will be numbers (1, 2, 3...)
// We can use a manual tick generator to display dates on the horizontal axis
double[] tickPositions = Generate.Consecutive(tickDates.Length, tickDelta);
string[] tickLabels = tickDates.Select(x =&gt; x.ToString("MM/dd")).ToArray();
ScottPlot.TickGenerators.NumericManual tickGen = new(tickPositions, tickLabels);
myPlot.Axes.Bottom.TickGenerator = tickGen;

myPlot.SavePng("demo.png", 400, 300);
{{< /recipe-sp5 >}}

<hr class='my-5 invisible'>



<div class='d-flex align-items-center mt-5'>
<h1 class='me-2 text-dark my-0 border-0'>Stock Symbol Background</h1>
<a href='/cookbook/5.0/Finance/StockSymbolBackgroundText' target='_blank'>
<img src='/images/icons/new-window.svg' style='height: 2rem;' class='new-window-icon'>
</a>
</div>

Stock symbol information can be displayed beneath the plot using the background text feature.

[![](/cookbook/5.0/images/StockSymbolBackgroundText.png?241105214550)](/cookbook/5.0/images/StockSymbolBackgroundText.png?241105214550)

{{< recipe-sp5 sourceUrl="https://github.com/ScottPlot/ScottPlot/blob/main/src/ScottPlot5/ScottPlot5%20Cookbook/Recipes/PlotTypes/Finance.cs" imageUrl="/cookbook/5.0/images/StockSymbolBackgroundText.png?241105214550" >}}ScottPlot.Plot myPlot = new();

myPlot.Add.Candlestick(Generate.RandomOHLCs(30));
myPlot.Axes.DateTimeTicksBottom();

var line1 = myPlot.Add.BackgroundText("DANK");
line1.LabelFontColor = Colors.Gray.WithAlpha(.4);
line1.LabelFontSize = 96;
line1.LabelBold = true;

myPlot.SavePng("demo.png", 400, 300);
{{< /recipe-sp5 >}}

<hr class='my-5 invisible'>



<div class='d-flex align-items-center mt-5'>
<h1 class='me-2 text-dark my-0 border-0'>Stock Symbol Multiline</h1>
<a href='/cookbook/5.0/Finance/StockSymbolBackgroundTextMultiline' target='_blank'>
<img src='/images/icons/new-window.svg' style='height: 2rem;' class='new-window-icon'>
</a>
</div>

Stock symbol information can be displayed beneath the plot using the multiline background text feature.

[![](/cookbook/5.0/images/StockSymbolBackgroundTextMultiline.png?241105214550)](/cookbook/5.0/images/StockSymbolBackgroundTextMultiline.png?241105214550)

{{< recipe-sp5 sourceUrl="https://github.com/ScottPlot/ScottPlot/blob/main/src/ScottPlot5/ScottPlot5%20Cookbook/Recipes/PlotTypes/Finance.cs" imageUrl="/cookbook/5.0/images/StockSymbolBackgroundTextMultiline.png?241105214550" >}}ScottPlot.Plot myPlot = new();

myPlot.Add.Candlestick(Generate.RandomOHLCs(30));
myPlot.Axes.DateTimeTicksBottom();

(var line1, var line2) = myPlot.Add.BackgroundText("DANK", "Highest Recommendation by Reddit");

line1.LabelFontColor = Colors.Gray.WithAlpha(.4);
line1.LabelFontSize = 64;
line1.LabelBold = true;

line2.LabelFontColor = Colors.Gray.WithAlpha(.4);
line2.LabelFontSize = 18;
line2.LabelBold = false;

myPlot.SavePng("demo.png", 400, 300);
{{< /recipe-sp5 >}}

<hr class='my-5 invisible'>



<div class='d-flex align-items-center mt-5'>
<h1 class='me-2 text-dark my-0 border-0'>Finance Chart Dark Mode</h1>
<a href='/cookbook/5.0/Finance/FinanceDarkMode' target='_blank'>
<img src='/images/icons/new-window.svg' style='height: 2rem;' class='new-window-icon'>
</a>
</div>

A dark mode finance plot can be achieved by customizing color options of the candles and figure.

[![](/cookbook/5.0/images/FinanceDarkMode.png?241105214550)](/cookbook/5.0/images/FinanceDarkMode.png?241105214550)

{{< recipe-sp5 sourceUrl="https://github.com/ScottPlot/ScottPlot/blob/main/src/ScottPlot5/ScottPlot5%20Cookbook/Recipes/PlotTypes/Finance.cs" imageUrl="/cookbook/5.0/images/FinanceDarkMode.png?241105214550" >}}ScottPlot.Plot myPlot = new();

// add sample financial data
OHLC[] prices = Generate.Financial.OHLCsByMinute(60);
var candlePlot = myPlot.Add.Candlestick(prices);
candlePlot.Axes.YAxis = myPlot.Axes.Right;

// setup DateTime ticks on the bottom
myPlot.Axes.DateTimeTicksBottom();

// use currency tick formatting on the right
myPlot.Axes.Right.TickGenerator = new ScottPlot.TickGenerators.NumericAutomatic()
{
    LabelFormatter = (double value) =&gt; value.ToString("C")
};

// customize candle styling
candlePlot.RisingColor = ScottPlot.Color.FromHtml("#FF0000");
candlePlot.FallingColor = ScottPlot.Color.FromHtml("#00FF00");

// add SMA indicators
int[] windowSizes = { 3, 8, 20 };
foreach (int windowSize in windowSizes)
{
    ScottPlot.Finance.SimpleMovingAverage sma = new(prices, windowSize);
    var sp = myPlot.Add.Scatter(sma.Dates, sma.Means);
    sp.Axes.YAxis = myPlot.Axes.Right;
    sp.MarkerSize = 0;
    sp.LineWidth = 1.5f;
    sp.LinePattern = LinePattern.DenselyDashed;
    sp.Color = Colors.Yellow.WithAlpha(1 - windowSize / 30.0);
}

// add symbol information and push it to the back of the plot
(var line1, var line2) = myPlot.Add.BackgroundText("DANK", "Recommended by Reddit");

line1.LabelFontColor = Colors.Gray.WithAlpha(.4);
line1.LabelFontSize = 72;
line1.LabelBold = true;
line1.Axes.YAxis = myPlot.Axes.Right;

line2.LabelFontColor = Colors.Gray.WithAlpha(.4);
line2.LabelFontSize = 24;
line2.LabelBold = false;
line2.Axes.YAxis = myPlot.Axes.Right;

// customize miscellaneous plot component colors
myPlot.FigureBackground.Color = Colors.Black;
myPlot.DataBackground.Color = Colors.Black;
myPlot.Axes.Color(ScottPlot.Color.FromHtml("#999999"));
myPlot.Axes.Right.MajorTickStyle.Color = Colors.Transparent;
myPlot.Axes.Right.MinorTickStyle.Color = Colors.Transparent;
myPlot.Axes.Bottom.MajorTickStyle.Color = Colors.Transparent;
myPlot.Axes.FrameWidth(0);
myPlot.Grid.MajorLineColor = ScottPlot.Color.FromHtml("#222222");
myPlot.Grid.YAxis = myPlot.Axes.Right;

myPlot.SavePng("demo.png", 400, 300);
{{< /recipe-sp5 >}}

<hr class='my-5 invisible'>


