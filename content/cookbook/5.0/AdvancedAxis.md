---
Title: Advanced Axis Features - ScottPlot 5.0 Cookbook
Description: How to further customize axes
URL: /cookbook/5.0/AdvancedAxis/
BreadcrumbNames: ["ScottPlot 5.0 Cookbook", "Advanced Axis Features"]
BreadcrumbUrls: ["/cookbook/5.0/", "/cookbook/5.0/AdvancedAxis"]
Date: 2024-10-16
Version: ScottPlot 5.0.40
Version: ScottPlot 5.0.40
SearchUrl: "/cookbook/5.0/search/"
ShowEditLink: false
---

# Advanced Axis Features


<h2><a href='/cookbook/5.0/AdvancedAxis/InvertedAxis'>Inverted Axis</a></h2>

Users can display data on an inverted axis by setting axis limits setting the lower edge to a value more positive than the upper edge.

[![](/cookbook/5.0/images/InvertedAxis.png?241016194708)](/cookbook/5.0/images/InvertedAxis.png?241016194708)

{{< code-sp5 >}}

```cs
ScottPlot.Plot myPlot = new();

myPlot.Add.Signal(Generate.Sin());
myPlot.Add.Signal(Generate.Cos());

myPlot.Axes.SetLimitsY(bottom: 1.5, top: -1.5);

myPlot.SavePng("demo.png", 400, 300);

```

{{< /code-sp5 >}}

<hr class='my-5 invisible'>


<h2><a href='/cookbook/5.0/AdvancedAxis/InvertedAutoAxis'>Inverted Auto-Axis</a></h2>

Customize the logic for the automatic axis scaler to ensure that axis limits for a particular axis are always inverted when autoscaled.

[![](/cookbook/5.0/images/InvertedAutoAxis.png?241016194708)](/cookbook/5.0/images/InvertedAutoAxis.png?241016194708)

{{< code-sp5 >}}

```cs
ScottPlot.Plot myPlot = new();

myPlot.Add.Signal(Generate.Sin());
myPlot.Add.Signal(Generate.Cos());

myPlot.Axes.AutoScaler.InvertedY = true;

myPlot.SavePng("demo.png", 400, 300);

```

{{< /code-sp5 >}}

<hr class='my-5 invisible'>


<h2><a href='/cookbook/5.0/AdvancedAxis/SquareAxisUnits'>Square Axis Units</a></h2>

Axis rules can be put in place which force the vertical scale (units per pixel) to match the horizontal scale so circles always appear as circles and not stretched ellipses.

[![](/cookbook/5.0/images/SquareAxisUnits.png?241016194708)](/cookbook/5.0/images/SquareAxisUnits.png?241016194708)

{{< code-sp5 >}}

```cs
ScottPlot.Plot myPlot = new();

myPlot.Add.Circle(0, 0, 10);

// force pixels to have a 1:1 scale ratio
myPlot.Axes.SquareUnits();

// even if you try to "stretch" the axis, it will adjust the axis limits automatically
myPlot.Axes.SetLimits(-10, 10, -20, 20);

myPlot.SavePng("demo.png", 400, 300);

```

{{< /code-sp5 >}}

<hr class='my-5 invisible'>


<h2><a href='/cookbook/5.0/AdvancedAxis/ExperimentalAxisWithSubtitle'>Axis with Subtitle</a></h2>

Users can create their own fully custom axes to replace the default ones (as demonstrated in the demo app). Some experimental axes are available for users who may be interested in alternative axis display styles.

[![](/cookbook/5.0/images/ExperimentalAxisWithSubtitle.png?241016194708)](/cookbook/5.0/images/ExperimentalAxisWithSubtitle.png?241016194708)

{{< code-sp5 >}}

```cs
ScottPlot.Plot myPlot = new();

// Plot some sample data
myPlot.Add.Signal(Generate.Sin());
myPlot.Add.Signal(Generate.Cos());

// Instantiate a custom axis and customize it as desired
ScottPlot.AxisPanels.Experimental.LeftAxisWithSubtitle customAxisY = new()
{
    LabelText = "My Custom Y Axis",
    SubLabelText = "It comes with a subtitle for the axis"
};

// Remove the default Y axis and add the custom one to the plot
myPlot.Axes.Remove(myPlot.Axes.Left);
myPlot.Axes.AddLeftAxis(customAxisY);

myPlot.SavePng("demo.png", 400, 300);

```

{{< /code-sp5 >}}

<hr class='my-5 invisible'>


<h2><a href='/cookbook/5.0/AdvancedAxis/AxisAntiAliasing'>Axis AntiAliasing</a></h2>

To improve crispness of straight vertical and horizontal lines, Anti-aliasing is disabled by default for axis frames, tick marks, and grid lines. Anti-aliasing can be enabled for all these objects by calling the AntiAlias helper method.

[![](/cookbook/5.0/images/AxisAntiAliasing.png?241016194708)](/cookbook/5.0/images/AxisAntiAliasing.png?241016194708)

{{< code-sp5 >}}

```cs
ScottPlot.Plot myPlot = new();

double[] dataX = { 1, 2, 3, 4, 5 };
double[] dataY = { 1, 4, 9, 16, 25 };
myPlot.Add.Scatter(dataX, dataY);

myPlot.Axes.AntiAlias(true);

myPlot.SavePng("demo.png", 400, 300);

```

{{< /code-sp5 >}}

<hr class='my-5 invisible'>


<h2><a href='/cookbook/5.0/AdvancedAxis/HideAxis'>Hide Axis and Turn frame lines on/off</a></h2>

Demonstrates how to hide axis ticks and turn frame lines on and off.

[![](/cookbook/5.0/images/HideAxis.png?241016194708)](/cookbook/5.0/images/HideAxis.png?241016194708)

{{< code-sp5 >}}

```cs
ScottPlot.Plot myPlot = new();

myPlot.Add.Signal(Generate.Sin());
myPlot.Add.Signal(Generate.Cos());

// Hide axis label and tick
myPlot.Axes.Bottom.TickLabelStyle.IsVisible = false;
myPlot.Axes.Bottom.MajorTickStyle.Length = 0;
myPlot.Axes.Bottom.MinorTickStyle.Length = 0;

// Hide axis edge line
myPlot.Axes.Bottom.FrameLineStyle.Width = 0;
myPlot.Axes.Right.FrameLineStyle.Width = 0;
myPlot.Axes.Top.FrameLineStyle.Width = 0;

myPlot.SavePng("demo.png", 400, 300);

```

{{< /code-sp5 >}}

<hr class='my-5 invisible'>

