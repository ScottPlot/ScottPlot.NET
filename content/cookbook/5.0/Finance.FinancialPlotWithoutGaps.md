---
Title: Financial Plot Without Gaps - ScottPlot 5.0 Cookbook
Description: When the DateTimes stored in OHLC objects are used to determine the horizontal position of candlesticks, periods without data like weekends and holidays appear as gaps in the plot. Enabling sequential mode causes the plot to ignore the OHLC DateTimes and display candles at integer positions starting from zero. Since this is not a true DateTime axis, users enabling this mode must customize the tick labels themselves.
URL: /cookbook/5.0/Finance/FinancialPlotWithoutGaps/
BreadcrumbNames: ["ScottPlot 5.0 Cookbook", "Financial Plot", "Financial Plot Without Gaps"]
BreadcrumbUrls: ["/cookbook/5.0/", "/cookbook/5.0/Finance", "/cookbook/5.0/Finance/FinancialPlotWithoutGaps"]
Date: 2024-01-17
Version: ScottPlot 5.0.17
Version: ScottPlot 5.0.17
SearchUrl: "/cookbook/5.0/search/"
ShowEditLink: false
---

# Financial Plot Without Gaps


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

<a href='https://github.com/ScottPlot/ScottPlot/blob/main/src/ScottPlot5/ScottPlot5%20Cookbook/Recipes/PlotTypes/Finance.cs'><svg xmlns="http://www.w3.org/2000/svg" width="16" height="16" fill="currentColor" class="mb-1 bi bi-github" viewBox="0 0 16 16">
  <path d="M8 0C3.58 0 0 3.58 0 8c0 3.54 2.29 6.53 5.47 7.59.4.07.55-.17.55-.38 0-.19-.01-.82-.01-1.49-2.01.37-2.53-.49-2.69-.94-.09-.23-.48-.94-.82-1.13-.28-.15-.68-.52-.01-.53.63-.01 1.08.58 1.23.82.72 1.21 1.87.87 2.33.66.07-.52.28-.87.51-1.07-1.78-.2-3.64-.89-3.64-3.95 0-.87.31-1.59.82-2.15-.08-.2-.36-1.02.08-2.12 0 0 .67-.21 2.2.82.64-.18 1.32-.27 2-.27s1.36.09 2 .27c1.53-1.04 2.2-.82 2.2-.82.44 1.1.16 1.92.08 2.12.51.56.82 1.27.82 2.15 0 3.07-1.87 3.75-3.65 3.95.29.25.54.73.54 1.48 0 1.07-.01 1.93-.01 2.2 0 .21.15.46.55.38A8.01 8.01 0 0 0 16 8c0-4.42-3.58-8-8-8"/>
</svg> Edit on GitHub</a>

