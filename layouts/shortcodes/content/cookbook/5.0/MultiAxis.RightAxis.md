---
Title: Right Axis - ScottPlot 5.0 Cookbook
Description: New plots have one axis on every side. Axes on the right and top are invisible by default. To use the right axis, make it visible, then tell a plottable to use it. 
URL: /cookbook/5.0/MultiAxis/RightAxis/
BreadcrumbNames: ["ScottPlot 5.0 Cookbook", "Multiple Axes", "Right Axis"]
BreadcrumbUrls: ["/cookbook/5.0/", "/cookbook/5.0/MultiAxis", "/cookbook/5.0/MultiAxis/RightAxis"]
Date: 2025-03-22
Version: ScottPlot 5.0.55
Version: ScottPlot 5.0.55
SearchUrl: "/cookbook/5.0/search/"
ShowEditLink: false
---


<div class='d-flex align-items-center mt-5'>
<h1 class='me-2 text-dark my-0 border-0'>Right Axis</h1>
</div>

New plots have one axis on every side. Axes on the right and top are invisible by default. To use the right axis, make it visible, then tell a plottable to use it. 

[![](/cookbook/5.0/images/RightAxis.png?250322130304)](/cookbook/5.0/images/RightAxis.png?250322130304)

{{< recipe-sp5 sourceUrl="https://github.com/ScottPlot/ScottPlot/blob/main/src/ScottPlot5/ScottPlot5%20Cookbook/Recipes/General/MultiAxis.cs" imageUrl="/cookbook/5.0/images/RightAxis.png?250322130304" >}}ScottPlot.Plot myPlot = new();

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

<div class='my-5 text-center'>This recipe is one of many in the <a href='/cookbook/5.0/MultiAxis'>Multiple Axes</a> category</div>


