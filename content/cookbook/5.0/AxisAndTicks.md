---
Title: Axis and Ticks - ScottPlot 5.0 Cookbook
Description: Examples of common customizations for axis labels and ticks
URL: /cookbook/5.0/AxisAndTicks
BreadcrumbNames: ["ScottPlot 5.0 Cookbook", "Axis and Ticks"]
BreadcrumbUrls: ["/cookbook/5.0/", "/cookbook/5.0/AxisAndTicks"]
Date: 2023-12-24
Version: ScottPlot 5.0.11-beta
Version: ScottPlot 5.0.11-beta
SearchUrl: "/cookbook/5.0/search/"
---

# Axis and Ticks



<div class='alert alert-warning' role='alert'><h4 class='alert-heading py-0 my-0'>⚠️ ScottPlot 5.0.11-beta is a preview package</h4><hr /><p class='mb-0'><span class='fw-semibold'>This page describes a beta release of ScottPlot.</span> It is available on NuGet as a preview package, but its API is not stable and it is not recommended for production use. See the <a href='https://scottplot.net/versions/'>ScottPlot Versions</a> page for more information. </p></div>



## Adding Axis Labels

Axis labels are the text labels centered on each axis. The text inside these labels can be changed, and the style of the text can be extensively customized.

[![](/cookbook/5.0/images/AxisLabels.png)](/cookbook/5.0/images/AxisLabels.png)

```cs
ScottPlot.Plot myPlot = new();

myPlot.Add.Signal(ScottPlot.Generate.Sin(51));
myPlot.Add.Signal(ScottPlot.Generate.Cos(51));

myPlot.XAxis.Label.Text = "Horizontal Axis";
myPlot.YAxis.Label.Text = "Vertical Axis";

myPlot.SavePng("demo.png");

```


## Manually Set Axis Limits

Axis Limits can be set manually in different ways.

[![](/cookbook/5.0/images/SetAxisLimits.png)](/cookbook/5.0/images/SetAxisLimits.png)

```cs
ScottPlot.Plot myPlot = new();

myPlot.Add.Signal(ScottPlot.Generate.Sin(51));
myPlot.Add.Signal(ScottPlot.Generate.Cos(51));

// Interact with a specific axis
myPlot.XAxis.Min = -100;
myPlot.XAxis.Max = 150;
myPlot.YAxis.Min = -5;
myPlot.YAxis.Max = 5;

// Call a helper function
myPlot.SetAxisLimits(-100, 150, -5, 5);

myPlot.SavePng("demo.png");

```


## Read Axis Limits

The current axis limits can be read in multiple ways.

[![](/cookbook/5.0/images/GetAxisLimits.png)](/cookbook/5.0/images/GetAxisLimits.png)

```cs
ScottPlot.Plot myPlot = new();

myPlot.Add.Signal(ScottPlot.Generate.Sin(51));
myPlot.Add.Signal(ScottPlot.Generate.Cos(51));

// Interact with a specific axis
double top = myPlot.YAxis.Max;
double bottom = myPlot.YAxis.Min;

// Call a helper function
AxisLimits limits = myPlot.GetAxisLimits();
double left = limits.Rect.Left;
double center = limits.Rect.HorizontalCenter;

myPlot.SavePng("demo.png");

```


## Zoom to Fit Data

The axis limits can be automatically adjusted to fit the data. Optional arguments allow users to define the amount of whitespace around the edges of the data.

[![](/cookbook/5.0/images/AutoScale.png)](/cookbook/5.0/images/AutoScale.png)

```cs
ScottPlot.Plot myPlot = new();

myPlot.Add.Signal(ScottPlot.Generate.Sin(51));
myPlot.Add.Signal(ScottPlot.Generate.Cos(51));

// set limits that do not fit the data
myPlot.SetAxisLimits(-100, 150, -5, 5);

// reset limits to fit the data
myPlot.AutoScale();

myPlot.SavePng("demo.png");

```


## Frameless Plot

How to create a plot containig only the data area and no axes.

[![](/cookbook/5.0/images/Frameless.png)](/cookbook/5.0/images/Frameless.png)

```cs
ScottPlot.Plot myPlot = new();

myPlot.FigureBackground = Colors.Magenta; // should not be seen
myPlot.DataBackground = Colors.WhiteSmoke;

myPlot.Add.Signal(ScottPlot.Generate.Sin(51));
myPlot.Add.Signal(ScottPlot.Generate.Cos(51));

myPlot.XAxes.ForEach(x => x.IsVisible = false);
myPlot.YAxes.ForEach(x => x.IsVisible = false);
myPlot.TitlePanel.IsVisible = false;

myPlot.SavePng("demo.png");

```

