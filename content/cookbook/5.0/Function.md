---
Title: Function - ScottPlot 5.0 Cookbook
Description: Function plots are a type of line plot where Y positions are defined by a function that depends on X rather than a collection of discrete data points.
URL: /cookbook/5.0/Function/
BreadcrumbNames: ["ScottPlot 5.0 Cookbook", "Function"]
BreadcrumbUrls: ["/cookbook/5.0/", "/cookbook/5.0/Function"]
Date: 2024-01-18
Version: ScottPlot 5.0.18
Version: ScottPlot 5.0.18
SearchUrl: "/cookbook/5.0/search/"
ShowEditLink: false
---

# Function


<h2><a href='/cookbook/5.0/Function/FunctionQuickstart'>Function Quickstart</a></h2>

Create a function plot from a formula.

[![](/cookbook/5.0/images/FunctionQuickstart.png)](/cookbook/5.0/images/FunctionQuickstart.png)

{{< code-sp5 >}}

```cs
ScottPlot.Plot myPlot = new();

// Functions are defined as delegates with an input and output
var func1 = new Func<double, double>((x) => Math.Sin(x) * Math.Sin(x / 2));
var func2 = new Func<double, double>((x) => Math.Sin(x) * Math.Sin(x / 3));
var func3 = new Func<double, double>((x) => Math.Cos(x) * Math.Sin(x / 5));

// Add functions to the plot
myPlot.Add.Function(func1);
myPlot.Add.Function(func2);
myPlot.Add.Function(func3);

// Manually set axis limits because functions do not have discrete data points
myPlot.Axes.SetLimits(-10, 10, -1.5, 1.5);

myPlot.SavePng("demo.png", 400, 300);

```

{{< /code-sp5 >}}

<hr class='my-5 invisible'>

