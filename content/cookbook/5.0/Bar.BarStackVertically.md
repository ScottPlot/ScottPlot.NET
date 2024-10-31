---
Title: Stacked Bar Plot - ScottPlot 5.0 Cookbook
Description: Bars can be positioned on top of each other.
URL: /cookbook/5.0/Bar/BarStackVertically/
BreadcrumbNames: ["ScottPlot 5.0 Cookbook", "Bar Plot", "Stacked Bar Plot"]
BreadcrumbUrls: ["/cookbook/5.0/", "/cookbook/5.0/Bar", "/cookbook/5.0/Bar/BarStackVertically"]
Date: 2024-10-31
Version: ScottPlot 5.0.42
Version: ScottPlot 5.0.42
SearchUrl: "/cookbook/5.0/search/"
ShowEditLink: false
---


<h2 style='border-bottom: 0;'><a href='/cookbook/5.0/Bar/BarStackVertically'>Stacked Bar Plot</a></h2>

<div class="d-flex mb-2">
<a class="btn btn-sm btn-primary me-1" href="/cookbook/5.0/Bar/BarStackVertically">Recipe Permalink</a>
<a class="btn btn-sm btn-success me-1" href="/cookbook/5.0/Bar">Category: Bar Plot</a>
</div>

Bars can be positioned on top of each other.

[![](/cookbook/5.0/images/BarStackVertically.png?241031194635)](/cookbook/5.0/images/BarStackVertically.png?241031194635)

{{< recipe-sp5 >}}ScottPlot.Plot myPlot = new();

ScottPlot.Palettes.Category10 palette = new();

ScottPlot.Bar[] bars =
{
    // first set of stacked bars
    new() { Position = 1, ValueBase = 0, Value = 2, FillColor = palette.GetColor(0) },
    new() { Position = 1, ValueBase = 2, Value = 5, FillColor = palette.GetColor(1) },
    new() { Position = 1, ValueBase = 5, Value = 10, FillColor = palette.GetColor(2) },

    // second set of stacked bars
    new() { Position = 2, ValueBase = 0, Value = 4, FillColor = palette.GetColor(0) },
    new() { Position = 2, ValueBase = 4, Value = 7, FillColor = palette.GetColor(1) },
    new() { Position = 2, ValueBase = 7, Value = 10, FillColor = palette.GetColor(2) },
};

myPlot.Add.Bars(bars);

Tick[] ticks =
{
    new(1, "Spring"),
    new(2, "Summer"),
};

myPlot.Axes.Bottom.TickGenerator = new ScottPlot.TickGenerators.NumericManual(ticks);
myPlot.Axes.Bottom.MajorTickStyle.Length = 0;
myPlot.HideGrid();

// tell the plot to autoscale with no padding beneath the bars
myPlot.Axes.Margins(bottom: 0);

myPlot.SavePng("demo.png", 400, 300);
{{< /recipe-sp5 >}}

<hr class='my-5 invisible'>


