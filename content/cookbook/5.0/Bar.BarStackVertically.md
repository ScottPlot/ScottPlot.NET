---
Title: Stacked Bar Plot - ScottPlot 5.0 Cookbook
Description: Bars can be positioned on top of each other.
URL: /cookbook/5.0/Bar/BarStackVertically/index.html
BreadcrumbNames: ["ScottPlot 5.0 Cookbook", "Bar Plot", "Stacked Bar Plot"]
BreadcrumbUrls: ["/cookbook/5.0/", "/cookbook/5.0/Bar", "/cookbook/5.0/Bar/BarStackVertically"]
Date: 2023-12-14
Version: ScottPlot 5.0.10-beta
---

# Stacked Bar Plot



<div class='alert alert-warning' role='alert'><h4 class='alert-heading py-0 my-0'>⚠️ ScottPlot 5.0.10-beta is a preview package</h4><hr /><p class='mb-0'><span class='fw-semibold'>This page describes a beta release of ScottPlot.</span> It is available on NuGet as a preview package, but its API is not stable and it is not recommended for production use. See the <a href='https://scottplot.net/versions/'>ScottPlot Versions</a> page for more information. </p></div>



Bars can be positioned on top of each other.

[![](/cookbook/5.0/images/BarStackVertically.png)](/cookbook/5.0/images/BarStackVertically.png)

```cs
ScottPlot.Plot myPlot = new();

Color[] colors = {
    myPlot.Palette.GetColor(0),
    myPlot.Palette.GetColor(1),
    myPlot.Palette.GetColor(2),
};

ScottPlot.Bar[] bars =
{
    // first set of stacked bars
    new() { Position = 1, ValueBase = 0, Value = 2, FillColor = colors[0] },
    new() { Position = 1, ValueBase = 2, Value = 5, FillColor = colors[1] },
    new() { Position = 1, ValueBase = 5, Value = 10, FillColor = colors[2] },

    // second set of stacked bars
    new() { Position = 2, ValueBase = 0, Value = 4, FillColor = colors[0] },
    new() { Position = 2, ValueBase = 4, Value = 7, FillColor = colors[1] },
    new() { Position = 2, ValueBase = 7, Value = 10, FillColor = colors[2] },
};

myPlot.Add.Bars(bars);

Tick[] ticks =
{
    new(1, "Spring"),
    new(2, "Summer"),
};

myPlot.BottomAxis.TickGenerator = new ScottPlot.TickGenerators.NumericManual(ticks);
myPlot.BottomAxis.MajorTickLength = 0;
myPlot.DisableGrid();

myPlot.SavePng("demo.png");

```

