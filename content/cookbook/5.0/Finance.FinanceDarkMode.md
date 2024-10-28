---
Title: Finance Chart Dark Mode - ScottPlot 5.0 Cookbook
Description: A dark mode finance plot can be achieved by customizing color options of the candles and figure.
URL: /cookbook/5.0/Finance/FinanceDarkMode/
BreadcrumbNames: ["ScottPlot 5.0 Cookbook", "Financial Plot", "Finance Chart Dark Mode"]
BreadcrumbUrls: ["/cookbook/5.0/", "/cookbook/5.0/Finance", "/cookbook/5.0/Finance/FinanceDarkMode"]
Date: 2024-10-28
Version: ScottPlot 5.0.41
Version: ScottPlot 5.0.41
SearchUrl: "/cookbook/5.0/search/"
ShowEditLink: false
---

# Finance Chart Dark Mode


A dark mode finance plot can be achieved by customizing color options of the candles and figure.

[![](/cookbook/5.0/images/FinanceDarkMode.png?241027220842)](/cookbook/5.0/images/FinanceDarkMode.png?241027220842)

{{< recipe-sp5 >}}

```cs
ScottPlot.Plot myPlot = new();

// add sample financial data
OHLC[] prices = Generate.Financial.OHLCsByMinute(60);
var candlePlot = myPlot.Add.Candlestick(prices);
candlePlot.Axes.YAxis = myPlot.Axes.Right;

// setup DateTime ticks on the bottom
myPlot.Axes.DateTimeTicksBottom();

// use currency tick formatting on the right
myPlot.Axes.Right.TickGenerator = new ScottPlot.TickGenerators.NumericAutomatic()
{
    LabelFormatter = (double value) => value.ToString("C")
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

```

{{< /recipe-sp5 >}}

<a href='https://github.com/ScottPlot/ScottPlot/blob/main/src/ScottPlot5/ScottPlot5%20Cookbook/Recipes/PlotTypes/Finance.cs'><svg xmlns="http://www.w3.org/2000/svg" width="16" height="16" fill="currentColor" class="mb-1 bi bi-github" viewBox="0 0 16 16">
  <path d="M8 0C3.58 0 0 3.58 0 8c0 3.54 2.29 6.53 5.47 7.59.4.07.55-.17.55-.38 0-.19-.01-.82-.01-1.49-2.01.37-2.53-.49-2.69-.94-.09-.23-.48-.94-.82-1.13-.28-.15-.68-.52-.01-.53.63-.01 1.08.58 1.23.82.72 1.21 1.87.87 2.33.66.07-.52.28-.87.51-1.07-1.78-.2-3.64-.89-3.64-3.95 0-.87.31-1.59.82-2.15-.08-.2-.36-1.02.08-2.12 0 0 .67-.21 2.2.82.64-.18 1.32-.27 2-.27s1.36.09 2 .27c1.53-1.04 2.2-.82 2.2-.82.44 1.1.16 1.92.08 2.12.51.56.82 1.27.82 2.15 0 3.07-1.87 3.75-3.65 3.95.29.25.54.73.54 1.48 0 1.07-.01 1.93-.01 2.2 0 .21.15.46.55.38A8.01 8.01 0 0 0 16 8c0-4.42-3.58-8-8-8"/>
</svg> Edit on GitHub</a>

