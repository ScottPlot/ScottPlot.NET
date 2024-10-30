---
Title: OHLC Chart Without Gaps - ScottPlot 5.0 Cookbook
Description: When the DateTimes stored in OHLC objects are used to determine the horizontal position, periods without data like weekends and holidays appear as gaps in the plot. Enabling sequential mode causes the plot to ignore the OHLC DateTimes and place OHLCs at integer positions starting from zero. Users can customize the tick generator to display dates instead of numbers on the horizontal axis if desired.
URL: /cookbook/5.0/Finance/FinancialPlotWithoutGapsOhlc/
BreadcrumbNames: ["ScottPlot 5.0 Cookbook", "Financial Plot", "OHLC Chart Without Gaps"]
BreadcrumbUrls: ["/cookbook/5.0/", "/cookbook/5.0/Finance", "/cookbook/5.0/Finance/FinancialPlotWithoutGapsOhlc"]
Date: 2024-10-30
Version: ScottPlot 5.0.42
Version: ScottPlot 5.0.42
SearchUrl: "/cookbook/5.0/search/"
ShowEditLink: false
---


<h2 style='border-bottom: 0;'><a href='/cookbook/5.0/Finance/FinancialPlotWithoutGapsOhlc'>OHLC Chart Without Gaps</a></h2>

<div class="d-flex mb-2">
<a class="btn btn-sm btn-primary me-1" href="/cookbook/5.0/Finance/FinancialPlotWithoutGapsOhlc">Recipe Permalink</a>
<a class="btn btn-sm btn-success me-1" href="/cookbook/5.0/Finance">Category: Financial Plot</a>
</div>

When the DateTimes stored in OHLC objects are used to determine the horizontal position, periods without data like weekends and holidays appear as gaps in the plot. Enabling sequential mode causes the plot to ignore the OHLC DateTimes and place OHLCs at integer positions starting from zero. Users can customize the tick generator to display dates instead of numbers on the horizontal axis if desired.

[![](/cookbook/5.0/images/FinancialPlotWithoutGapsOhlc.png?241029205813)](/cookbook/5.0/images/FinancialPlotWithoutGapsOhlc.png?241029205813)

{{< recipe-sp5 >}}ScottPlot.Plot myPlot = new();

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
{{< /recipe-sp5 >}}

<hr class='my-5 invisible'>


