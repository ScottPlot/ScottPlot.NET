---
Title: Advanced Axis Features - ScottPlot 5.0 Cookbook
Description: How to further customize axes
URL: /cookbook/5.0/AdvancedAxis/
BreadcrumbNames: ["ScottPlot 5.0 Cookbook", "Advanced Axis Features"]
BreadcrumbUrls: ["/cookbook/5.0/", "/cookbook/5.0/AdvancedAxis"]
Date: 2024-04-23
Version: ScottPlot 5.0.27
Version: ScottPlot 5.0.27
SearchUrl: "/cookbook/5.0/search/"
ShowEditLink: false
---

# Advanced Axis Features


<h2><a href='/cookbook/5.0/AdvancedAxis/InvertedAxis'>Inverted Axis</a></h2>

Users can display data on an inverted axis by setting axis limits setting the lower edge to a value more positive than the upper edge.

[![](/cookbook/5.0/images/InvertedAxis.png?240423091821)](/cookbook/5.0/images/InvertedAxis.png?240423091821)

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

[![](/cookbook/5.0/images/InvertedAutoAxis.png?240423091821)](/cookbook/5.0/images/InvertedAutoAxis.png?240423091821)

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


<h2><a href='/cookbook/5.0/AdvancedAxis/SquareAxisUnits'>SquareAxisUnits</a></h2>

Axis rules can be put in place which force the vertical scale (units per pixel) to match the horizontal scale so circles always appear as circles and not stretched ellipses.

[![](/cookbook/5.0/images/SquareAxisUnits.png?240423091821)](/cookbook/5.0/images/SquareAxisUnits.png?240423091821)

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

