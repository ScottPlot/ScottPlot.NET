---
Title: Right Axis - ScottPlot 5.0 Cookbook
Description: New plots have one axis on every side. Axes on the right and top are invisible by default. To use the right axis, make it visible, then tell a plottable to use it. 
URL: /cookbook/5.0/MultiAxis/RightAxis/
BreadcrumbNames: ["ScottPlot 5.0 Cookbook", "Multiple Axes", "Right Axis"]
BreadcrumbUrls: ["/cookbook/5.0/", "/cookbook/5.0/MultiAxis", "/cookbook/5.0/MultiAxis/RightAxis"]
Date: 2024-10-30
Version: ScottPlot 5.0.42
Version: ScottPlot 5.0.42
SearchUrl: "/cookbook/5.0/search/"
ShowEditLink: false
---


<h2 style='border-bottom: 0;'><a href='/cookbook/5.0/MultiAxis/RightAxis'>Right Axis</a></h2>

<div class="d-flex mb-2">
<a class="btn btn-sm btn-primary me-1" href="/cookbook/5.0/MultiAxis/RightAxis">Recipe Permalink</a>
<a class="btn btn-sm btn-success me-1" href="/cookbook/5.0/MultiAxis">Category: Multiple Axes</a>
</div>

New plots have one axis on every side. Axes on the right and top are invisible by default. To use the right axis, make it visible, then tell a plottable to use it. 

[![](/cookbook/5.0/images/RightAxis.png?241029205813)](/cookbook/5.0/images/RightAxis.png?241029205813)

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


