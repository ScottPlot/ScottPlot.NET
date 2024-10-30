---
Title: Bar Positioning - ScottPlot 5.0 Cookbook
Description: The exact position and size of each bar may be customized.
URL: /cookbook/5.0/Bar/BarPosition/
BreadcrumbNames: ["ScottPlot 5.0 Cookbook", "Bar Plot", "Bar Positioning"]
BreadcrumbUrls: ["/cookbook/5.0/", "/cookbook/5.0/Bar", "/cookbook/5.0/Bar/BarPosition"]
Date: 2024-10-30
Version: ScottPlot 5.0.42
Version: ScottPlot 5.0.42
SearchUrl: "/cookbook/5.0/search/"
ShowEditLink: false
---


<h2 style='border-bottom: 0;'><a href='/cookbook/5.0/Bar/BarPosition'>Bar Positioning</a></h2>

<div class="d-flex mb-2">
<a class="btn btn-sm btn-primary me-1" href="/cookbook/5.0/Bar/BarPosition">Recipe Permalink</a>
<a class="btn btn-sm btn-success me-1" href="/cookbook/5.0/Bar">Category: Bar Plot</a>
</div>

The exact position and size of each bar may be customized.

[![](/cookbook/5.0/images/BarPosition.png?241029205813)](/cookbook/5.0/images/BarPosition.png?241029205813)

{{< recipe-sp5 >}}ScottPlot.Plot myPlot = new();

ScottPlot.Bar[] bars =
{
    new() { Position = 1, Value = 5, ValueBase = 3, FillColor = Colors.Red },
    new() { Position = 2, Value = 7, ValueBase = 0, FillColor = Colors.Blue },
    new() { Position = 4, Value = 3, ValueBase = 2, FillColor = Colors.Green },
};

myPlot.Add.Bars(bars);

myPlot.SavePng("demo.png", 400, 300);
{{< /recipe-sp5 >}}

<hr class='my-5 invisible'>


