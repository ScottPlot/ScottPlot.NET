---
Title: Price on Right - ScottPlot 5.0 Cookbook
Description: Finance charts can be created which display price information on the right axis.
URL: /cookbook/5.0/Finance/FinanceRightAxis/
BreadcrumbNames: ["ScottPlot 5.0 Cookbook", "Financial Plot", "Price on Right"]
BreadcrumbUrls: ["/cookbook/5.0/", "/cookbook/5.0/Finance", "/cookbook/5.0/Finance/FinanceRightAxis"]
Date: 2024-11-24
Version: ScottPlot 5.0.47
Version: ScottPlot 5.0.47
SearchUrl: "/cookbook/5.0/search/"
ShowEditLink: false
---


<div class='d-flex align-items-center mt-5'>
<h1 class='me-2 text-dark my-0 border-0'>Price on Right</h1>
</div>

Finance charts can be created which display price information on the right axis.

[![](/cookbook/5.0/images/FinanceRightAxis.png?241124170640)](/cookbook/5.0/images/FinanceRightAxis.png?241124170640)

{{< recipe-sp5 sourceUrl="https://github.com/ScottPlot/ScottPlot/blob/main/src/ScottPlot5/ScottPlot5%20Cookbook/Recipes/PlotTypes/Finance.cs" imageUrl="/cookbook/5.0/images/FinanceRightAxis.png?241124170640" >}}ScottPlot.Plot myPlot = new();

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

<div class='my-5 text-center'>This recipe is one of many in the <a href='/cookbook/5.0/Finance'>Financial Plot</a> category</div>


