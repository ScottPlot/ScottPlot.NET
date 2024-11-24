---
Title: Candlestick Chart Without Gaps - ScottPlot 5.0 Cookbook
Description: When the DateTimes stored in OHLC objects are used to determine the horizontal position of candlesticks, periods without data like weekends and holidays appear as gaps in the plot. Enabling sequential mode causes the plot to ignore the OHLC DateTimes and display candles at integer positions starting from zero. Users can customize the tick generator to display dates instead of numbers on the horizontal axis if desired.
URL: /cookbook/5.0/Finance/FinancialPlotWithoutGaps/
BreadcrumbNames: ["ScottPlot 5.0 Cookbook", "Financial Plot", "Candlestick Chart Without Gaps"]
BreadcrumbUrls: ["/cookbook/5.0/", "/cookbook/5.0/Finance", "/cookbook/5.0/Finance/FinancialPlotWithoutGaps"]
Date: 2024-11-24
Version: ScottPlot 5.0.47
Version: ScottPlot 5.0.47
SearchUrl: "/cookbook/5.0/search/"
ShowEditLink: false
---


<div class='d-flex align-items-center mt-5'>
<h1 class='me-2 text-dark my-0 border-0'>Candlestick Chart Without Gaps</h1>
</div>

When the DateTimes stored in OHLC objects are used to determine the horizontal position of candlesticks, periods without data like weekends and holidays appear as gaps in the plot. Enabling sequential mode causes the plot to ignore the OHLC DateTimes and display candles at integer positions starting from zero. Users can customize the tick generator to display dates instead of numbers on the horizontal axis if desired.

[![](/cookbook/5.0/images/FinancialPlotWithoutGaps.png?241124170640)](/cookbook/5.0/images/FinancialPlotWithoutGaps.png?241124170640)

{{< recipe-sp5 sourceUrl="https://github.com/ScottPlot/ScottPlot/blob/main/src/ScottPlot5/ScottPlot5%20Cookbook/Recipes/PlotTypes/Finance.cs" imageUrl="/cookbook/5.0/images/FinancialPlotWithoutGaps.png?241124170640" >}}ScottPlot.Plot myPlot = new();

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

<div class='my-5 text-center'>This recipe is one of many in the <a href='/cookbook/5.0/Finance'>Financial Plot</a> category</div>


