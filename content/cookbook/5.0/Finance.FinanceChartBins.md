---
Title: Finance Chart with Custom Time Bins - ScottPlot 5.0 Cookbook
Description: Finance charts can display price range information over arbitrary time scales.
URL: /cookbook/5.0/Finance/FinanceChartBins/
BreadcrumbNames: ["ScottPlot 5.0 Cookbook", "Financial Plot", "Finance Chart with Custom Time Bins"]
BreadcrumbUrls: ["/cookbook/5.0/", "/cookbook/5.0/Finance", "/cookbook/5.0/Finance/FinanceChartBins"]
Date: 2024-04-23
Version: ScottPlot 5.0.27
Version: ScottPlot 5.0.27
SearchUrl: "/cookbook/5.0/search/"
ShowEditLink: false
---

# Finance Chart with Custom Time Bins


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

<a href='https://github.com/ScottPlot/ScottPlot/blob/main/src/ScottPlot5/ScottPlot5%20Cookbook/Recipes/PlotTypes/Finance.cs'><svg xmlns="http://www.w3.org/2000/svg" width="16" height="16" fill="currentColor" class="mb-1 bi bi-github" viewBox="0 0 16 16">
  <path d="M8 0C3.58 0 0 3.58 0 8c0 3.54 2.29 6.53 5.47 7.59.4.07.55-.17.55-.38 0-.19-.01-.82-.01-1.49-2.01.37-2.53-.49-2.69-.94-.09-.23-.48-.94-.82-1.13-.28-.15-.68-.52-.01-.53.63-.01 1.08.58 1.23.82.72 1.21 1.87.87 2.33.66.07-.52.28-.87.51-1.07-1.78-.2-3.64-.89-3.64-3.95 0-.87.31-1.59.82-2.15-.08-.2-.36-1.02.08-2.12 0 0 .67-.21 2.2.82.64-.18 1.32-.27 2-.27s1.36.09 2 .27c1.53-1.04 2.2-.82 2.2-.82.44 1.1.16 1.92.08 2.12.51.56.82 1.27.82 2.15 0 3.07-1.87 3.75-3.65 3.95.29.25.54.73.54 1.48 0 1.07-.01 1.93-.01 2.2 0 .21.15.46.55.38A8.01 8.01 0 0 0 16 8c0-4.42-3.58-8-8-8"/>
</svg> Edit on GitHub</a>

