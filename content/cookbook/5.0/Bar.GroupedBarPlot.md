---
Title: Grouped Bar Plot - ScottPlot 5.0 Cookbook
Description: Bars can be grouped by position and color.
URL: /cookbook/5.0/Bar/GroupedBarPlot
BreadcrumbNames: ["ScottPlot 5.0 Cookbook", "Bar Plot", "Grouped Bar Plot"]
BreadcrumbUrls: ["/cookbook/5.0/", "/cookbook/5.0/Bar", "/cookbook/5.0/Bar/GroupedBarPlot"]
Date: 2023-12-13
Version: ScottPlot 5.0.10-beta
---

# Grouped Bar Plot



<div class='alert alert-warning' role='alert'><h4 class='alert-heading py-0 my-0'>⚠️ ScottPlot 5.0.10-beta is a preview package</h4><hr /><p class='mb-0'><span class='fw-semibold'>This page describes a beta release of ScottPlot.</span> It is available on NuGet as a preview package, but its API is not stable and it is not recommended for production use. See the <a href='https://scottplot.net/versions/'>ScottPlot Versions</a> page for more information. </p></div>



Bars can be grouped by position and color.

[![](/cookbook/5.0/images/GroupedBarPlot.png)](/cookbook/5.0/images/GroupedBarPlot.png)

```cs
ScottPlot.Plot myPlot = new();

Color[] colors = {
    myPlot.Palette.GetColor(0),
    myPlot.Palette.GetColor(1),
    myPlot.Palette.GetColor(2),
};

ScottPlot.Bar[] bars =
{
    // first group
    new() { Position = 1, Value = 2, FillColor = colors[0], Error = 1 },
    new() { Position = 2, Value = 5, FillColor = colors[1], Error = 2 },
    new() { Position = 3, Value = 7, FillColor = colors[2], Error = 1 },

    // second group
    new() { Position = 5, Value = 4, FillColor = colors[0], Error = 2 },
    new() { Position = 6, Value = 7, FillColor = colors[1], Error = 1 },
    new() { Position = 7, Value = 13, FillColor = colors[2], Error = 3 },

    // third group
    new() { Position = 9, Value = 5, FillColor = colors[0], Error = 1 },
    new() { Position = 10, Value = 6, FillColor = colors[1], Error = 3 },
    new() { Position = 11, Value = 11, FillColor = colors[2], Error = 2 },
};

myPlot.Add.Bars(bars);

// build the legend manually
myPlot.Legend.IsVisible = true;
myPlot.Legend.Alignment = Alignment.UpperLeft;
myPlot.Legend.ManualItems.Add(new LegendItem() { Label = "Monday", FillColor = colors[0] });
myPlot.Legend.ManualItems.Add(new LegendItem() { Label = "Tuesday", FillColor = colors[1] });
myPlot.Legend.ManualItems.Add(new LegendItem() { Label = "Wednesday", FillColor = colors[2] });

// show group labels on the bottom axis
Tick[] ticks =
{
    new(2, "Group 1"),
    new(6, "Group 2"),
    new(10, "Group 3"),
};
myPlot.BottomAxis.TickGenerator = new ScottPlot.TickGenerators.NumericManual(ticks);
myPlot.BottomAxis.MajorTickLength = 0;
myPlot.DisableGrid();

myPlot.SavePng("demo.png");

```

