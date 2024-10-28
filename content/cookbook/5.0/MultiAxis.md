---
Title: Multiple Axes - ScottPlot 5.0 Cookbook
Description: Tick mark customization and creation of multi-Axis plots
URL: /cookbook/5.0/MultiAxis/
BreadcrumbNames: ["ScottPlot 5.0 Cookbook", "Multiple Axes"]
BreadcrumbUrls: ["/cookbook/5.0/", "/cookbook/5.0/MultiAxis"]
Date: 2024-10-28
Version: ScottPlot 5.0.41
Version: ScottPlot 5.0.41
SearchUrl: "/cookbook/5.0/search/"
ShowEditLink: false
---

# Multiple Axes


<h2><a href='/cookbook/5.0/MultiAxis/RightAxis'>Right Axis</a></h2>

New plots have one axis on every side. Axes on the right and top are invisible by default. To use the right axis, make it visible, then tell a plottable to use it. 

[![](/cookbook/5.0/images/RightAxis.png?241027221943)](/cookbook/5.0/images/RightAxis.png?241027221943)

{{< recipe-sp5 >}}ScottPlot.Plot myPlot = new();

// plot data with very different scales
var sig1 = myPlot.Add.Signal(Generate.Sin(mult: 0.01));
var sig2 = myPlot.Add.Signal(Generate.Cos(mult: 100));

// tell each signal plot to use a different axis
sig1.Axes.YAxis = myPlot.Axes.Left;
sig2.Axes.YAxis = myPlot.Axes.Right;

// add additional styling options to each axis
myPlot.Axes.Left.Label.Text = "Left Axis";
myPlot.Axes.Right.Label.Text = "Right Axis";
myPlot.Axes.Left.Label.ForeColor = sig1.Color;
myPlot.Axes.Right.Label.ForeColor = sig2.Color;

myPlot.SavePng("demo.png", 400, 300);
{{< /recipe-sp5 >}}

<hr class='my-5 invisible'>


<h2><a href='/cookbook/5.0/MultiAxis/MultiAxisQuickstart'>Multi-Axis</a></h2>

Additional axes may be added to plots. Plottables are displayed using the coordinate system of the primary axes by default, but any plottable can be displayed using any X and Y axis.

[![](/cookbook/5.0/images/MultiAxisQuickstart.png?241027221943)](/cookbook/5.0/images/MultiAxisQuickstart.png?241027221943)

{{< recipe-sp5 >}}ScottPlot.Plot myPlot = new();

// plottables use the standard X and Y axes by default
var sig1 = myPlot.Add.Signal(ScottPlot.Generate.Sin(51, mult: 0.01));
sig1.Axes.XAxis = myPlot.Axes.Bottom; // standard X axis
sig1.Axes.YAxis = myPlot.Axes.Left; // standard Y axis
myPlot.Axes.Left.Label.Text = "Primary Y Axis";

// create a second axis and add it to the plot
var yAxis2 = myPlot.Axes.AddLeftAxis();

// add a new plottable and tell it to use the custom Y axis
var sig2 = myPlot.Add.Signal(ScottPlot.Generate.Cos(51, mult: 100));
sig2.Axes.XAxis = myPlot.Axes.Bottom; // standard X axis
sig2.Axes.YAxis = yAxis2; // custom Y axis
yAxis2.LabelText = "Secondary Y Axis";

myPlot.SavePng("demo.png", 400, 300);
{{< /recipe-sp5 >}}

<hr class='my-5 invisible'>

