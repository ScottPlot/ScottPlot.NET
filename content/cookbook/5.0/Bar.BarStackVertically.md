---
Title: Stacked Bar Plot - ScottPlot 5.0 Cookbook
Description: Bars can be positioned on top of each other.
URL: /cookbook/5.0/Bar/BarStackVertically/
BreadcrumbNames: ["ScottPlot 5.0 Cookbook", "Bar Plot", "Stacked Bar Plot"]
BreadcrumbUrls: ["/cookbook/5.0/", "/cookbook/5.0/Bar", "/cookbook/5.0/Bar/BarStackVertically"]
Date: 2024-11-24
Version: ScottPlot 5.0.47
Version: ScottPlot 5.0.47
SearchUrl: "/cookbook/5.0/search/"
ShowEditLink: false
---


<div class='d-flex align-items-center mt-5'>
<h1 class='me-2 text-dark my-0 border-0'>Stacked Bar Plot</h1>
</div>

Bars can be positioned on top of each other.

[![](/cookbook/5.0/images/BarStackVertically.png?241124170640)](/cookbook/5.0/images/BarStackVertically.png?241124170640)

{{< recipe-sp5 sourceUrl="https://github.com/ScottPlot/ScottPlot/blob/main/src/ScottPlot5/ScottPlot5%20Cookbook/Recipes/PlotTypes/Bar.cs" imageUrl="/cookbook/5.0/images/BarStackVertically.png?241124170640" >}}ScottPlot.Plot myPlot = new();

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

<div class='my-5 text-center'>This recipe is one of many in the <a href='/cookbook/5.0/Bar'>Bar Plot</a> category</div>


