---
Title: Stock Symbol Background - ScottPlot 5.0 Cookbook
Description: Stock symbol information can be displayed beneath the plot using the background text feature.
URL: /cookbook/5.0/Finance/StockSymbolBackgroundText/
BreadcrumbNames: ["ScottPlot 5.0 Cookbook", "Financial Plot", "Stock Symbol Background"]
BreadcrumbUrls: ["/cookbook/5.0/", "/cookbook/5.0/Finance", "/cookbook/5.0/Finance/StockSymbolBackgroundText"]
Date: 2024-10-31
Version: ScottPlot 5.0.42
Version: ScottPlot 5.0.42
SearchUrl: "/cookbook/5.0/search/"
ShowEditLink: false
---


<h2 style='border-bottom: 0;'><a href='/cookbook/5.0/Finance/StockSymbolBackgroundText'>Stock Symbol Background</a></h2>

<div class="d-flex mb-2">
<a class="btn btn-sm btn-primary me-1" href="/cookbook/5.0/Finance/StockSymbolBackgroundText">Recipe Permalink</a>
<a class="btn btn-sm btn-success me-1" href="/cookbook/5.0/Finance">Category: Financial Plot</a>
</div>

Stock symbol information can be displayed beneath the plot using the background text feature.

[![](/cookbook/5.0/images/StockSymbolBackgroundText.png?241031194635)](/cookbook/5.0/images/StockSymbolBackgroundText.png?241031194635)

{{< recipe-sp5 >}}ScottPlot.Plot myPlot = new();

myPlot.Add.Candlestick(Generate.RandomOHLCs(30));
myPlot.Axes.DateTimeTicksBottom();

var line1 = myPlot.Add.BackgroundText("DANK");
line1.LabelFontColor = Colors.Gray.WithAlpha(.4);
line1.LabelFontSize = 96;
line1.LabelBold = true;

myPlot.SavePng("demo.png", 400, 300);
{{< /recipe-sp5 >}}

<hr class='my-5 invisible'>


