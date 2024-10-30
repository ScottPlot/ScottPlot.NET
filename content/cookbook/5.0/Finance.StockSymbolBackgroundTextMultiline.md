---
Title: Stock Symbol Multiline - ScottPlot 5.0 Cookbook
Description: Stock symbol information can be displayed beneath the plot using the multiline background text feature.
URL: /cookbook/5.0/Finance/StockSymbolBackgroundTextMultiline/
BreadcrumbNames: ["ScottPlot 5.0 Cookbook", "Financial Plot", "Stock Symbol Multiline"]
BreadcrumbUrls: ["/cookbook/5.0/", "/cookbook/5.0/Finance", "/cookbook/5.0/Finance/StockSymbolBackgroundTextMultiline"]
Date: 2024-10-30
Version: ScottPlot 5.0.42
Version: ScottPlot 5.0.42
SearchUrl: "/cookbook/5.0/search/"
ShowEditLink: false
---


<h2 style='border-bottom: 0;'><a href='/cookbook/5.0/Finance/StockSymbolBackgroundTextMultiline'>Stock Symbol Multiline</a></h2>

<div class="d-flex mb-2">
<a class="btn btn-sm btn-primary me-1" href="/cookbook/5.0/Finance/StockSymbolBackgroundTextMultiline">Recipe Permalink</a>
<a class="btn btn-sm btn-success me-1" href="/cookbook/5.0/Finance">Category: Financial Plot</a>
</div>

Stock symbol information can be displayed beneath the plot using the multiline background text feature.

[![](/cookbook/5.0/images/StockSymbolBackgroundTextMultiline.png?241029205813)](/cookbook/5.0/images/StockSymbolBackgroundTextMultiline.png?241029205813)

{{< recipe-sp5 >}}ScottPlot.Plot myPlot = new();

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

<hr class='my-5 invisible'>


