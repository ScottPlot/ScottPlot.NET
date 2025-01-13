---
Title: Bars with Error - ScottPlot 5.0 Cookbook
Description: Bars can have errorbars.
URL: /cookbook/5.0/Bar/BarWithError/
BreadcrumbNames: ["ScottPlot 5.0 Cookbook", "Bar Plot", "Bars with Error"]
BreadcrumbUrls: ["/cookbook/5.0/", "/cookbook/5.0/Bar", "/cookbook/5.0/Bar/BarWithError"]
Date: 2025-01-13
Version: ScottPlot 5.0.53
Version: ScottPlot 5.0.53
SearchUrl: "/cookbook/5.0/search/"
ShowEditLink: false
---


<div class='d-flex align-items-center mt-5'>
<h1 class='me-2 text-dark my-0 border-0'>Bars with Error</h1>
</div>

Bars can have errorbars.

[![](/cookbook/5.0/images/BarWithError.png?250112204022)](/cookbook/5.0/images/BarWithError.png?250112204022)

{{< recipe-sp5 sourceUrl="https://github.com/ScottPlot/ScottPlot/blob/main/src/ScottPlot5/ScottPlot5%20Cookbook/Recipes/PlotTypes/Bar.cs" imageUrl="/cookbook/5.0/images/BarWithError.png?250112204022" >}}ScottPlot.Plot myPlot = new();

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

<div class='my-5 text-center'>This recipe is one of many in the <a href='/cookbook/5.0/Bar'>Bar Plot</a> category</div>


