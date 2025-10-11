---
Title: Stock Symbol Background - ScottPlot 5 Cookbook
Description: Stock symbol information can be displayed beneath the plot using the background text feature.
URL: /cookbook/5/Finance/StockSymbolBackgroundText/
BreadcrumbNames: ["ScottPlot 5 Cookbook", "Financial Plot", "Stock Symbol Background"]
BreadcrumbUrls: ["/cookbook/5/", "/cookbook/5/Finance", "/cookbook/5/Finance/StockSymbolBackgroundText"]
Date: 2025-10-11
Version: ScottPlot 5.1.57
Version: ScottPlot 5.1.57
SearchUrl: "/cookbook/5/search/"
ShowEditLink: false
---


<div class='d-flex align-items-center mt-5'>
<h1 class='me-2 text-dark my-0 border-0'>Stock Symbol Background</h1>
</div>

Stock symbol information can be displayed beneath the plot using the background text feature.

[![](/cookbook/5/images/StockSymbolBackgroundText.png?251011113742)](/cookbook/5/images/StockSymbolBackgroundText.png?251011113742)

{{< recipe-sp5 sourceUrl="https://github.com/ScottPlot/ScottPlot/blob/main/src/ScottPlot5/ScottPlot5%20Cookbook/Recipes/PlotTypes/Finance.cs" imageUrl="/cookbook/5/images/StockSymbolBackgroundText.png?251011113742" >}}ScottPlot.Plot myPlot = new();

myPlot.Add.Candlestick(Generate.RandomOHLCs(30));
myPlot.Axes.DateTimeTicksBottom();

var line1 = myPlot.Add.BackgroundText("DANK");
line1.LabelFontColor = Colors.Gray.WithAlpha(.4);
line1.LabelFontSize = 96;
line1.LabelBold = true;

myPlot.SavePng("demo.png", 400, 300);
{{< /recipe-sp5 >}}

<div class='my-5 text-center'>This recipe is one of many in the <a href='/cookbook/5/Finance'>Financial Plot</a> category</div>


