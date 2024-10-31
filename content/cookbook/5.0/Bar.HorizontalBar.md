---
Title: Horizontal Bar Plot - ScottPlot 5.0 Cookbook
Description: Bar plots can be displayed horizontally.
URL: /cookbook/5.0/Bar/HorizontalBar/
BreadcrumbNames: ["ScottPlot 5.0 Cookbook", "Bar Plot", "Horizontal Bar Plot"]
BreadcrumbUrls: ["/cookbook/5.0/", "/cookbook/5.0/Bar", "/cookbook/5.0/Bar/HorizontalBar"]
Date: 2024-10-31
Version: ScottPlot 5.0.42
Version: ScottPlot 5.0.42
SearchUrl: "/cookbook/5.0/search/"
ShowEditLink: false
---


<h2 style='border-bottom: 0;'><a href='/cookbook/5.0/Bar/HorizontalBar'>Horizontal Bar Plot</a></h2>

<div class="d-flex mb-2">
<a class="btn btn-sm btn-primary me-1" href="/cookbook/5.0/Bar/HorizontalBar">Recipe Permalink</a>
<a class="btn btn-sm btn-success me-1" href="/cookbook/5.0/Bar">Category: Bar Plot</a>
</div>

Bar plots can be displayed horizontally.

[![](/cookbook/5.0/images/HorizontalBar.png?241031194635)](/cookbook/5.0/images/HorizontalBar.png?241031194635)

{{< recipe-sp5 >}}ScottPlot.Plot myPlot = new();

ScottPlot.Bar[] bars =
{
    new() { Position = 1, Value = 5, Error = 1, },
    new() { Position = 2, Value = 7, Error = 2, },
    new() { Position = 3, Value = 6, Error = 1, },
    new() { Position = 4, Value = 8, Error = 2, },
};

var barPlot = myPlot.Add.Bars(bars);
barPlot.Horizontal = true;

myPlot.Axes.Margins(left: 0);

myPlot.SavePng("demo.png", 400, 300);
{{< /recipe-sp5 >}}

<hr class='my-5 invisible'>


