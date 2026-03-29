---
Title: Stock Symbol Multiline - ScottPlot 5 Cookbook
Description: Stock symbol information can be displayed beneath the plot using the multiline background text feature.
URL: /cookbook/5/Finance/StockSymbolBackgroundTextMultiline/
BreadcrumbNames: ["ScottPlot 5 Cookbook", "Financial Plot", "Stock Symbol Multiline"]
BreadcrumbUrls: ["/cookbook/5/", "/cookbook/5/Finance", "/cookbook/5/Finance/StockSymbolBackgroundTextMultiline"]
Date: 2026-03-29
Version: ScottPlot 5.1.58
Version: ScottPlot 5.1.58
SearchUrl: "/cookbook/5/search/"
ShowEditLink: false
---


<div class='d-flex align-items-center mt-5'>
<h1 class='me-2 text-dark my-0 border-0'>Stock Symbol Multiline</h1>
</div>

Stock symbol information can be displayed beneath the plot using the multiline background text feature.

[![](/cookbook/5/images/StockSymbolBackgroundTextMultiline.png?260329072039)](/cookbook/5/images/StockSymbolBackgroundTextMultiline.png?260329072039)

{{< recipe-sp5 sourceUrl="https://github.com/ScottPlot/ScottPlot/blob/main/src/ScottPlot5/ScottPlot5%20Cookbook/Recipes/PlotTypes/Finance.cs" imageUrl="/cookbook/5/images/StockSymbolBackgroundTextMultiline.png?260329072039" >}}ScottPlot.Plot myPlot = new();

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

<div class='my-5 text-center'>This recipe is one of many in the <a href='/cookbook/5/Finance'>Financial Plot</a> category</div>


