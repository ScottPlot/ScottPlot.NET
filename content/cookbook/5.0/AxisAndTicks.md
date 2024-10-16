---
Title: Axis and Ticks - ScottPlot 5.0 Cookbook
Description: Examples of common customizations for axis labels and ticks
URL: /cookbook/5.0/AxisAndTicks/
BreadcrumbNames: ["ScottPlot 5.0 Cookbook", "Axis and Ticks"]
BreadcrumbUrls: ["/cookbook/5.0/", "/cookbook/5.0/AxisAndTicks"]
Date: 2024-10-16
Version: ScottPlot 5.0.40
Version: ScottPlot 5.0.40
SearchUrl: "/cookbook/5.0/search/"
ShowEditLink: false
---

# Axis and Ticks


<h2><a href='/cookbook/5.0/AxisAndTicks/SetAxisLimits'>Set Axis Limits</a></h2>

Axis Limits can be set by the user.

[![](/cookbook/5.0/images/SetAxisLimits.png?241016194708)](/cookbook/5.0/images/SetAxisLimits.png?241016194708)

{{< code-sp5 >}}

```cs
ScottPlot.Plot myPlot = new();

myPlot.Add.Signal(Generate.Sin(51));
myPlot.Add.Signal(Generate.Cos(51));

myPlot.Axes.SetLimits(-100, 150, -5, 5);

myPlot.SavePng("demo.png", 400, 300);

```

{{< /code-sp5 >}}

<hr class='my-5 invisible'>


<h2><a href='/cookbook/5.0/AxisAndTicks/GetAxisLimits'>Read Axis Limits</a></h2>

Use GetLimits() to obtain the current axis limits.

[![](/cookbook/5.0/images/GetAxisLimits.png?241016194708)](/cookbook/5.0/images/GetAxisLimits.png?241016194708)

{{< code-sp5 >}}

```cs
ScottPlot.Plot myPlot = new();

myPlot.Add.Signal(Generate.Sin(51));
myPlot.Add.Signal(Generate.Cos(51));

AxisLimits limits = myPlot.Axes.GetLimits();
double xMin = limits.Left;
double xMax = limits.Right;
double yMin = limits.Bottom;
double yMax = limits.Top;

myPlot.SavePng("demo.png", 400, 300);

```

{{< /code-sp5 >}}

<hr class='my-5 invisible'>


<h2><a href='/cookbook/5.0/AxisAndTicks/AutoScale'>AutoScale Axis Limits to Fit Data</a></h2>

The axis limits can be automatically adjusted to fit the data. Optional arguments allow users to define the amount of whitespace around the edges of the data.In older versions of ScottPlot this functionality was achieved by a method named AxisAuto().

[![](/cookbook/5.0/images/AutoScale.png?241016194708)](/cookbook/5.0/images/AutoScale.png?241016194708)

{{< code-sp5 >}}

```cs
ScottPlot.Plot myPlot = new();

myPlot.Add.Signal(Generate.Sin(51));
myPlot.Add.Signal(Generate.Cos(51));

// set limits that do not fit the data
myPlot.Axes.SetLimits(-100, 150, -5, 5);

// reset limits to fit the data
myPlot.Axes.AutoScale();

myPlot.SavePng("demo.png", 400, 300);

```

{{< /code-sp5 >}}

<hr class='my-5 invisible'>

