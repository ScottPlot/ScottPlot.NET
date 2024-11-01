---
Title: Horizontal Bar Plot - ScottPlot 5.0 Cookbook
Description: Bar plots can be displayed horizontally.
URL: /cookbook/5.0/Bar/HorizontalBar/
BreadcrumbNames: ["ScottPlot 5.0 Cookbook", "Bar Plot", "Horizontal Bar Plot"]
BreadcrumbUrls: ["/cookbook/5.0/", "/cookbook/5.0/Bar", "/cookbook/5.0/Bar/HorizontalBar"]
Date: 2024-11-01
Version: ScottPlot 5.0.42
Version: ScottPlot 5.0.42
SearchUrl: "/cookbook/5.0/search/"
ShowEditLink: false
---


<div class='d-flex align-items-center mt-5'>
<h1 class='me-2 text-dark my-0 border-0'>Horizontal Bar Plot</h1>
</div>

Bar plots can be displayed horizontally.

[![](/cookbook/5.0/images/HorizontalBar.png?241101192719)](/cookbook/5.0/images/HorizontalBar.png?241101192719)

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

<div class='my-5 text-center'>This recipe is one of many in the <a href='/cookbook/5.0/Bar'>Bar Plot</a> category</div>


