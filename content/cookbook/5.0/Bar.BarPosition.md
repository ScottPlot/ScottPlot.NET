---
Title: Bar Positioning - ScottPlot 5.0 Cookbook
Description: The exact position and size of each bar may be customized.
URL: /cookbook/5.0/Bar/BarPosition/
BreadcrumbNames: ["ScottPlot 5.0 Cookbook", "Bar Plot", "Bar Positioning"]
BreadcrumbUrls: ["/cookbook/5.0/", "/cookbook/5.0/Bar", "/cookbook/5.0/Bar/BarPosition"]
Date: 2024-11-02
Version: ScottPlot 5.0.42
Version: ScottPlot 5.0.42
SearchUrl: "/cookbook/5.0/search/"
ShowEditLink: false
---


<div class='d-flex align-items-center mt-5'>
<h1 class='me-2 text-dark my-0 border-0'>Bar Positioning</h1>
</div>

The exact position and size of each bar may be customized.

[![](/cookbook/5.0/images/BarPosition.png?241102170938)](/cookbook/5.0/images/BarPosition.png?241102170938)

{{< recipe-sp5 sourceUrl="https://github.com/ScottPlot/ScottPlot/blob/main/src/ScottPlot5/ScottPlot5%20Cookbook/Recipes/PlotTypes/Bar.cs" imageUrl="/cookbook/5.0/images/BarPosition.png?241102170938" >}}ScottPlot.Plot myPlot = new();

ScottPlot.Bar[] bars =
{
    new() { Position = 1, Value = 5, ValueBase = 3, FillColor = Colors.Red },
    new() { Position = 2, Value = 7, ValueBase = 0, FillColor = Colors.Blue },
    new() { Position = 4, Value = 3, ValueBase = 2, FillColor = Colors.Green },
};

myPlot.Add.Bars(bars);

myPlot.SavePng("demo.png", 400, 300);
{{< /recipe-sp5 >}}

<div class='my-5 text-center'>This recipe is one of many in the <a href='/cookbook/5.0/Bar'>Bar Plot</a> category</div>


