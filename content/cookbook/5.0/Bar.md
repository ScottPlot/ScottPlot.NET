---
Title: Bar Plot - ScottPlot 5.0 Cookbook
Description: Bar plots represent values as horizontal or vertical rectangles
URL: /cookbook/5.0/Bar/
BreadcrumbNames: ["ScottPlot 5.0 Cookbook", "Bar Plot"]
BreadcrumbUrls: ["/cookbook/5.0/", "/cookbook/5.0/Bar"]
Date: 2024-01-08
Version: ScottPlot 5.0.11-beta
Version: ScottPlot 5.0.11-beta
SearchUrl: "/cookbook/5.0/search/"
ShowEditLink: false
---

# Bar Plot



<div class='alert alert-warning' role='alert'><h4 class='alert-heading py-0 my-0'>⚠️ ScottPlot 5.0.11-beta is a preview package</h4><hr /><p class='mb-0'><span class='fw-semibold'>This page describes a beta release of ScottPlot.</span> It is available on NuGet as a preview package, but its API is not stable and it is not recommended for production use. See the <a href='https://scottplot.net/versions/'>ScottPlot Versions</a> page for more information. </p></div>



<h2><a href='/cookbook/5.0/Bar/Quickstart'>Bar Plot Quickstart</a></h2>

Bar plots can be added from a series of values.

[![](/cookbook/5.0/images/Quickstart.png)](/cookbook/5.0/images/Quickstart.png)

```cs
ScottPlot.Version.ShouldBe(5, 0, 11);
ScottPlot.Plot myPlot = new();

// add bars
double[] values = { 5, 10, 7, 13 };
myPlot.Add.Bars(values);

// tell the plot to autoscale with no padding beneath the bars
myPlot.Axes.Margins(bottom: 0);

myPlot.SavePng("demo.png");

```

<hr class='my-5 invisible'>


<h2><a href='/cookbook/5.0/Bar/BarPosition'>Bar Positioning</a></h2>

The exact position and size of each bar may be customized.

[![](/cookbook/5.0/images/BarPosition.png)](/cookbook/5.0/images/BarPosition.png)

```cs
ScottPlot.Version.ShouldBe(5, 0, 11);
ScottPlot.Plot myPlot = new();

List<ScottPlot.Bar> bars = new()
{
    new() { Position = 1, Value = 5, ValueBase = 3, },
    new() { Position = 2, Value = 7, ValueBase = 0, },
    new() { Position = 4, Value = 3, ValueBase = 2, },
};

myPlot.Add.Bars(bars);

myPlot.SavePng("demo.png");

```

<hr class='my-5 invisible'>


<h2><a href='/cookbook/5.0/Bar/BarWithError'>Bars with Error</a></h2>

Bars can have errorbars.

[![](/cookbook/5.0/images/BarWithError.png)](/cookbook/5.0/images/BarWithError.png)

```cs
ScottPlot.Version.ShouldBe(5, 0, 11);
ScottPlot.Plot myPlot = new();

List<ScottPlot.Bar> bars = new()
{
    new() { Position = 1, Value = 5, Error = 1, },
    new() { Position = 2, Value = 7, Error = 2, },
    new() { Position = 3, Value = 6, Error = 1, },
    new() { Position = 4, Value = 8, Error = 2, },
};

myPlot.Add.Bars(bars);

// tell the plot to autoscale with no padding beneath the bars
myPlot.Axes.Margins(bottom: 0);

myPlot.SavePng("demo.png");

```

<hr class='my-5 invisible'>


<h2><a href='/cookbook/5.0/Bar/BarTickLabels'>Bars with Labeled Ticks</a></h2>

Bars can be labeled by manually specifying axis tick mark positions and labels.

[![](/cookbook/5.0/images/BarTickLabels.png)](/cookbook/5.0/images/BarTickLabels.png)

```cs
ScottPlot.Version.ShouldBe(5, 0, 11);
ScottPlot.Plot myPlot = new();

myPlot.Add.Bar(position: 1, value: 5, error: 1);
myPlot.Add.Bar(position: 2, value: 7, error: 2);
myPlot.Add.Bar(position: 3, value: 6, error: 1);
myPlot.Add.Bar(position: 4, value: 8, error: 2);

Tick[] ticks =
{
    new(1, "Apple"),
    new(2, "Orange"),
    new(3, "Pear"),
    new(4, "Banana"),
};

myPlot.Axes.Bottom.TickGenerator = new ScottPlot.TickGenerators.NumericManual(ticks);
myPlot.Axes.Bottom.MajorTickLength = 0;
myPlot.HideGrid();

// tell the plot to autoscale with no padding beneath the bars
myPlot.Axes.Margins(bottom: 0);

myPlot.SavePng("demo.png");

```

<hr class='my-5 invisible'>


<h2><a href='/cookbook/5.0/Bar/BarStackVertically'>Stacked Bar Plot</a></h2>

Bars can be positioned on top of each other.

[![](/cookbook/5.0/images/BarStackVertically.png)](/cookbook/5.0/images/BarStackVertically.png)

```cs
ScottPlot.Version.ShouldBe(5, 0, 11);
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

myPlot.Axes.Bottom.TickGenerator = new ScottPlot.TickGenerators.NumericManual(ticks);
myPlot.Axes.Bottom.MajorTickLength = 0;
myPlot.HideGrid();

// tell the plot to autoscale with no padding beneath the bars
myPlot.Axes.Margins(bottom: 0);

myPlot.SavePng("demo.png");

```

<hr class='my-5 invisible'>


<h2><a href='/cookbook/5.0/Bar/GroupedBarPlot'>Grouped Bar Plot</a></h2>

Bars can be grouped by position and color.

[![](/cookbook/5.0/images/GroupedBarPlot.png)](/cookbook/5.0/images/GroupedBarPlot.png)

```cs
ScottPlot.Version.ShouldBe(5, 0, 11);
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
myPlot.Legend.Location = Alignment.UpperLeft;
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
myPlot.Axes.Bottom.TickGenerator = new ScottPlot.TickGenerators.NumericManual(ticks);
myPlot.Axes.Bottom.MajorTickLength = 0;
myPlot.HideGrid();

// tell the plot to autoscale with no padding beneath the bars
myPlot.Axes.Margins(bottom: 0);

myPlot.SavePng("demo.png");

```

<hr class='my-5 invisible'>

