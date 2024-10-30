---
Title: Rotated Tick with Long Labels - ScottPlot 5.0 Cookbook
Description: The axis size can be increased to accommodate rotated or long tick labels.
URL: /cookbook/5.0/CustomizingTicks/RotatedTicksLongLabels/
BreadcrumbNames: ["ScottPlot 5.0 Cookbook", "Customizing Ticks", "Rotated Tick with Long Labels"]
BreadcrumbUrls: ["/cookbook/5.0/", "/cookbook/5.0/CustomizingTicks", "/cookbook/5.0/CustomizingTicks/RotatedTicksLongLabels"]
Date: 2024-10-30
Version: ScottPlot 5.0.42
Version: ScottPlot 5.0.42
SearchUrl: "/cookbook/5.0/search/"
ShowEditLink: false
---


<h2 style='border-bottom: 0;'><a href='/cookbook/5.0/CustomizingTicks/RotatedTicksLongLabels'>Rotated Tick with Long Labels</a></h2>

<div class="d-flex mb-2">
<a class="btn btn-sm btn-primary me-1" href="/cookbook/5.0/CustomizingTicks/RotatedTicksLongLabels">Recipe Permalink</a>
<a class="btn btn-sm btn-success me-1" href="/cookbook/5.0/CustomizingTicks">Category: Customizing Ticks</a>
</div>

The axis size can be increased to accommodate rotated or long tick labels.

[![](/cookbook/5.0/images/RotatedTicksLongLabels.png?241029205813)](/cookbook/5.0/images/RotatedTicksLongLabels.png?241029205813)

{{< recipe-sp5 >}}ScottPlot.Plot myPlot = new();

// create a bar plot
double[] values = { 5, 10, 7, 13, 25, 60 };
myPlot.Add.Bars(values);
myPlot.Axes.Margins(bottom: 0);

// create a tick for each bar
Tick[] ticks =
{
    new(0, "First Long Title"),
    new(1, "Second Long Title"),
    new(2, "Third Long Title"),
    new(3, "Fourth Long Title"),
    new(4, "Fifth Long Title"),
    new(5, "Sixth Long Title")
};
myPlot.Axes.Bottom.TickGenerator = new ScottPlot.TickGenerators.NumericManual(ticks);
myPlot.Axes.Bottom.TickLabelStyle.Rotation = 45;
myPlot.Axes.Bottom.TickLabelStyle.Alignment = Alignment.MiddleLeft;

// determine the width of the largest tick label
float largestLabelWidth = 0;
using SKPaint paint = new();
foreach (Tick tick in ticks)
{
    PixelSize size = myPlot.Axes.Bottom.TickLabelStyle.Measure(tick.Label, paint).Size;
    largestLabelWidth = Math.Max(largestLabelWidth, size.Width);
}

// ensure axis panels do not get smaller than the largest label
myPlot.Axes.Bottom.MinimumSize = largestLabelWidth;
myPlot.Axes.Right.MinimumSize = largestLabelWidth;

myPlot.SavePng("demo.png", 400, 300);
{{< /recipe-sp5 >}}

<hr class='my-5 invisible'>


