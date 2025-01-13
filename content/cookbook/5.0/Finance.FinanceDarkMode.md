---
Title: Finance Chart Dark Mode - ScottPlot 5.0 Cookbook
Description: A dark mode finance plot can be achieved by customizing color options of the candles and figure.
URL: /cookbook/5.0/Finance/FinanceDarkMode/
BreadcrumbNames: ["ScottPlot 5.0 Cookbook", "Financial Plot", "Finance Chart Dark Mode"]
BreadcrumbUrls: ["/cookbook/5.0/", "/cookbook/5.0/Finance", "/cookbook/5.0/Finance/FinanceDarkMode"]
Date: 2025-01-13
Version: ScottPlot 5.0.53
Version: ScottPlot 5.0.53
SearchUrl: "/cookbook/5.0/search/"
ShowEditLink: false
---


<div class='d-flex align-items-center mt-5'>
<h1 class='me-2 text-dark my-0 border-0'>Finance Chart Dark Mode</h1>
</div>

A dark mode finance plot can be achieved by customizing color options of the candles and figure.

[![](/cookbook/5.0/images/FinanceDarkMode.png?250112204022)](/cookbook/5.0/images/FinanceDarkMode.png?250112204022)

{{< recipe-sp5 sourceUrl="https://github.com/ScottPlot/ScottPlot/blob/main/src/ScottPlot5/ScottPlot5%20Cookbook/Recipes/PlotTypes/Finance.cs" imageUrl="/cookbook/5.0/images/FinanceDarkMode.png?250112204022" >}}ScottPlot.Plot myPlot = new();

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

<div class='my-5 text-center'>This recipe is one of many in the <a href='/cookbook/5.0/Finance'>Financial Plot</a> category</div>


