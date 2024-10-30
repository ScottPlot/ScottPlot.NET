---
Title: Bars with Error - ScottPlot 5.0 Cookbook
Description: Bars can have errorbars.
URL: /cookbook/5.0/Bar/BarWithError/
BreadcrumbNames: ["ScottPlot 5.0 Cookbook", "Bar Plot", "Bars with Error"]
BreadcrumbUrls: ["/cookbook/5.0/", "/cookbook/5.0/Bar", "/cookbook/5.0/Bar/BarWithError"]
Date: 2024-10-30
Version: ScottPlot 5.0.42
Version: ScottPlot 5.0.42
SearchUrl: "/cookbook/5.0/search/"
ShowEditLink: false
---


<h2 style='border-bottom: 0;'><a href='/cookbook/5.0/Bar/BarWithError'>Bars with Error</a></h2>

<div class="d-flex mb-2">
<a class="btn btn-sm btn-primary me-1" href="/cookbook/5.0/Bar/BarWithError">Recipe Permalink</a>
<a class="btn btn-sm btn-success me-1" href="/cookbook/5.0/Bar">Category: Bar Plot</a>
</div>

Bars can have errorbars.

[![](/cookbook/5.0/images/BarWithError.png?241029205813)](/cookbook/5.0/images/BarWithError.png?241029205813)

{{< recipe-sp5 >}}ScottPlot.Plot myPlot = new();

ScottPlot.Bar[] bars =
{
    new() { Position = 1, Value = 5, Error = 1, FillColor = Colors.Red },
    new() { Position = 2, Value = 7, Error = 2, FillColor = Colors.Orange },
    new() { Position = 3, Value = 6, Error = 1, FillColor = Colors.Green },
    new() { Position = 4, Value = 8, Error = 2, FillColor = Colors.Blue },
};

myPlot.Add.Bars(bars);

// tell the plot to autoscale with no padding beneath the bars
myPlot.Axes.Margins(bottom: 0);

myPlot.SavePng("demo.png", 400, 300);
{{< /recipe-sp5 >}}

<hr class='my-5 invisible'>


