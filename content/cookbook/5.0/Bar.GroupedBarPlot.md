---
Title: Grouped Bar Plot - ScottPlot 5.0 Cookbook
Description: Bars can be grouped by position and color.
URL: /cookbook/5.0/Bar/GroupedBarPlot/
BreadcrumbNames: ["ScottPlot 5.0 Cookbook", "Bar Plot", "Grouped Bar Plot"]
BreadcrumbUrls: ["/cookbook/5.0/", "/cookbook/5.0/Bar", "/cookbook/5.0/Bar/GroupedBarPlot"]
Date: 2024-10-16
Version: ScottPlot 5.0.40
Version: ScottPlot 5.0.40
SearchUrl: "/cookbook/5.0/search/"
ShowEditLink: false
---

# Grouped Bar Plot


Bars can be grouped by position and color.

[![](/cookbook/5.0/images/GroupedBarPlot.png?241016194708)](/cookbook/5.0/images/GroupedBarPlot.png?241016194708)

{{< code-sp5 >}}

```cs
ScottPlot.Plot myPlot = new();

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

```

{{< /code-sp5 >}}

<a href='https://github.com/ScottPlot/ScottPlot/blob/main/src/ScottPlot5/ScottPlot5%20Cookbook/Recipes/PlotTypes/Bar.cs'><svg xmlns="http://www.w3.org/2000/svg" width="16" height="16" fill="currentColor" class="mb-1 bi bi-github" viewBox="0 0 16 16">
  <path d="M8 0C3.58 0 0 3.58 0 8c0 3.54 2.29 6.53 5.47 7.59.4.07.55-.17.55-.38 0-.19-.01-.82-.01-1.49-2.01.37-2.53-.49-2.69-.94-.09-.23-.48-.94-.82-1.13-.28-.15-.68-.52-.01-.53.63-.01 1.08.58 1.23.82.72 1.21 1.87.87 2.33.66.07-.52.28-.87.51-1.07-1.78-.2-3.64-.89-3.64-3.95 0-.87.31-1.59.82-2.15-.08-.2-.36-1.02.08-2.12 0 0 .67-.21 2.2.82.64-.18 1.32-.27 2-.27s1.36.09 2 .27c1.53-1.04 2.2-.82 2.2-.82.44 1.1.16 1.92.08 2.12.51.56.82 1.27.82 2.15 0 3.07-1.87 3.75-3.65 3.95.29.25.54.73.54 1.48 0 1.07-.01 1.93-.01 2.2 0 .21.15.46.55.38A8.01 8.01 0 0 0 16 8c0-4.42-3.58-8-8-8"/>
</svg> Edit on GitHub</a>

