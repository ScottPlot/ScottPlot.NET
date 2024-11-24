---
Title: Financial DateTime Axis - ScottPlot 5.0 Cookbook
Description: A special axis system has been created for financial charts. Unlike standard DateTime axes which assume the horizontal scale is linearly spaced time, the financial DateTime system allows for dates to be skipped. This is ideal for financial charts where date ranges are skipped such as after-hours trading or non-trading days.
URL: /cookbook/5.0/Finance/FinancialDateTimeAxis/
BreadcrumbNames: ["ScottPlot 5.0 Cookbook", "Financial Plot", "Financial DateTime Axis"]
BreadcrumbUrls: ["/cookbook/5.0/", "/cookbook/5.0/Finance", "/cookbook/5.0/Finance/FinancialDateTimeAxis"]
Date: 2024-11-24
Version: ScottPlot 5.0.47
Version: ScottPlot 5.0.47
SearchUrl: "/cookbook/5.0/search/"
ShowEditLink: false
---


<div class='d-flex align-items-center mt-5'>
<h1 class='me-2 text-dark my-0 border-0'>Financial DateTime Axis</h1>
</div>

A special axis system has been created for financial charts. Unlike standard DateTime axes which assume the horizontal scale is linearly spaced time, the financial DateTime system allows for dates to be skipped. This is ideal for financial charts where date ranges are skipped such as after-hours trading or non-trading days.

[![](/cookbook/5.0/images/FinancialDateTimeAxis.png?241124170640)](/cookbook/5.0/images/FinancialDateTimeAxis.png?241124170640)

{{< recipe-sp5 sourceUrl="https://github.com/ScottPlot/ScottPlot/blob/main/src/ScottPlot5/ScottPlot5%20Cookbook/Recipes/PlotTypes/Finance.cs" imageUrl="/cookbook/5.0/images/FinancialDateTimeAxis.png?241124170640" >}}ScottPlot.Plot myPlot = new();

// generate sample data using a collection of dates and price ranges
DateTime[] dates = Generate.ConsecutiveHours(100);
List&lt;OHLC&gt; candles = Generate.RandomOHLCs(30);
var candlestickPlot = myPlot.Add.Candlestick(candles);

// enable sequential mode so candles are placed 1 unit apart (0, 1, 2, etc.)
candlestickPlot.Sequential = true;

// disable the default tick generator (and grid) and make space for the new one
myPlot.Axes.Bottom.TickGenerator = new ScottPlot.TickGenerators.EmptyTickGenerator();
myPlot.Axes.Bottom.MinimumSize = 30;

// add the financial DateTime tick generator
ScottPlot.Plottables.FinancialTimeAxis financeAxis = new(dates);
myPlot.Add.Plottable(financeAxis);

myPlot.SavePng("demo.png", 400, 300);
{{< /recipe-sp5 >}}

<div class='my-5 text-center'>This recipe is one of many in the <a href='/cookbook/5.0/Finance'>Financial Plot</a> category</div>


