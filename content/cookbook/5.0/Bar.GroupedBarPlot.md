---
Title: Grouped Bar Plot - ScottPlot 5.0 Cookbook
Description: Bars can be grouped by position and color.
URL: /cookbook/5.0/Bar/GroupedBarPlot/
BreadcrumbNames: ["ScottPlot 5.0 Cookbook", "Bar Plot", "Grouped Bar Plot"]
BreadcrumbUrls: ["/cookbook/5.0/", "/cookbook/5.0/Bar", "/cookbook/5.0/Bar/GroupedBarPlot"]
Date: 2024-11-01
Version: ScottPlot 5.0.42
Version: ScottPlot 5.0.42
SearchUrl: "/cookbook/5.0/search/"
ShowEditLink: false
---


<div class='d-flex align-items-center mt-5'>
<h1 class='me-2 text-dark my-0 border-0'>Grouped Bar Plot</h1>
</div>

Bars can be grouped by position and color.

[![](/cookbook/5.0/images/GroupedBarPlot.png?241101192719)](/cookbook/5.0/images/GroupedBarPlot.png?241101192719)

{{< recipe-sp5 >}}ScottPlot.Plot myPlot = new();

ScottPlot.Palettes.Category10 palette = new();

ScottPlot.Bar[] bars =
{
    // first group
    new() { Position = 1, Value = 2, FillColor = palette.GetColor(0), Error = 1 },
    new() { Position = 2, Value = 5, FillColor = palette.GetColor(1), Error = 2 },
    new() { Position = 3, Value = 7, FillColor = palette.GetColor(2), Error = 1 },

    // second group
    new() { Position = 5, Value = 4, FillColor = palette.GetColor(0), Error = 2 },
    new() { Position = 6, Value = 7, FillColor = palette.GetColor(1), Error = 1 },
    new() { Position = 7, Value = 13, FillColor = palette.GetColor(2), Error = 3 },

    // third group
    new() { Position = 9, Value = 5, FillColor = palette.GetColor(0), Error = 1 },
    new() { Position = 10, Value = 6, FillColor = palette.GetColor(1), Error = 3 },
    new() { Position = 11, Value = 11, FillColor = palette.GetColor(2), Error = 2 },
};

myPlot.Add.Bars(bars);

// build the legend manually
myPlot.Legend.IsVisible = true;
myPlot.Legend.Alignment = Alignment.UpperLeft;
myPlot.Legend.ManualItems.Add(new() { LabelText = "Monday", FillColor = palette.GetColor(0) });
myPlot.Legend.ManualItems.Add(new() { LabelText = "Tuesday", FillColor = palette.GetColor(1) });
myPlot.Legend.ManualItems.Add(new() { LabelText = "Wednesday", FillColor = palette.GetColor(2) });

// show group labels on the bottom axis
Tick[] ticks =
{
    new(2, "Group 1"),
    new(6, "Group 2"),
    new(10, "Group 3"),
};
myPlot.Axes.Bottom.TickGenerator = new ScottPlot.TickGenerators.NumericManual(ticks);
myPlot.Axes.Bottom.MajorTickStyle.Length = 0;
myPlot.HideGrid();

// tell the plot to autoscale with no padding beneath the bars
myPlot.Axes.Margins(bottom: 0);

myPlot.SavePng("demo.png", 400, 300);
{{< /recipe-sp5 >}}

<div class='my-5 text-center'>This recipe is one of many in the <a href='/cookbook/5.0/Bar'>Bar Plot</a> category</div>


