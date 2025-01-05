---
Title: Multiple Axes - ScottPlot 5.0 Cookbook
Description: Tick mark customization and creation of multi-Axis plots
URL: /cookbook/5.0/MultiAxis/
BreadcrumbNames: ["ScottPlot 5.0 Cookbook", "Multiple Axes"]
BreadcrumbUrls: ["/cookbook/5.0/", "/cookbook/5.0/MultiAxis"]
Date: 2025-01-05
Version: ScottPlot 5.0.48
Version: ScottPlot 5.0.48
SearchUrl: "/cookbook/5.0/search/"
ShowEditLink: false
---

<h1>Multiple Axes</h1>


<div class='d-flex align-items-center mt-5'>
<h1 class='me-2 text-dark my-0 border-0'>Right Axis</h1>
<a href='/cookbook/5.0/MultiAxis/RightAxis' target='_blank'>
<img src='/images/icons/new-window.svg' style='height: 2rem;' class='new-window-icon'>
</a>
</div>

New plots have one axis on every side. Axes on the right and top are invisible by default. To use the right axis, make it visible, then tell a plottable to use it. 

[![](/cookbook/5.0/images/RightAxis.png?250105183901)](/cookbook/5.0/images/RightAxis.png?250105183901)

{{< recipe-sp5 sourceUrl="https://github.com/ScottPlot/ScottPlot/blob/main/src/ScottPlot5/ScottPlot5%20Cookbook/Recipes/General/MultiAxis.cs" imageUrl="/cookbook/5.0/images/RightAxis.png?250105183901" >}}ScottPlot.Plot myPlot = new();

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



<div class='d-flex align-items-center mt-5'>
<h1 class='me-2 text-dark my-0 border-0'>Multi-Axis</h1>
<a href='/cookbook/5.0/MultiAxis/MultiAxisQuickstart' target='_blank'>
<img src='/images/icons/new-window.svg' style='height: 2rem;' class='new-window-icon'>
</a>
</div>

Additional axes may be added to plots. Plottables are displayed using the coordinate system of the primary axes by default, but any plottable can be displayed using any X and Y axis.

[![](/cookbook/5.0/images/MultiAxisQuickstart.png?250105183901)](/cookbook/5.0/images/MultiAxisQuickstart.png?250105183901)

{{< recipe-sp5 sourceUrl="https://github.com/ScottPlot/ScottPlot/blob/main/src/ScottPlot5/ScottPlot5%20Cookbook/Recipes/General/MultiAxis.cs" imageUrl="/cookbook/5.0/images/MultiAxisQuickstart.png?250105183901" >}}ScottPlot.Plot myPlot = new();

// plottables use the standard X and Y axes by default
var sig1 = myPlot.Add.Signal(Generate.Sin(51, mult: 0.01));
sig1.Axes.XAxis = myPlot.Axes.Bottom; // standard X axis
sig1.Axes.YAxis = myPlot.Axes.Left; // standard Y axis
myPlot.Axes.Left.Label.Text = "Primary Y Axis";

// create a second axis and add it to the plot
var yAxis2 = myPlot.Axes.AddLeftAxis();

// add a new plottable and tell it to use the custom Y axis
var sig2 = myPlot.Add.Signal(Generate.Cos(51, mult: 100));
sig2.Axes.XAxis = myPlot.Axes.Bottom; // standard X axis
sig2.Axes.YAxis = yAxis2; // custom Y axis
yAxis2.LabelText = "Secondary Y Axis";

myPlot.SavePng("demo.png", 400, 300);
{{< /recipe-sp5 >}}

<hr class='my-5 invisible'>



<div class='d-flex align-items-center mt-5'>
<h1 class='me-2 text-dark my-0 border-0'>Right Axis Only</h1>
<a href='/cookbook/5.0/MultiAxis/RightAxisOnly' target='_blank'>
<img src='/images/icons/new-window.svg' style='height: 2rem;' class='new-window-icon'>
</a>
</div>

The default Y axis is the one on the left of the plot, but the right Y axis may be used instead.

[![](/cookbook/5.0/images/RightAxisOnly.png?250105183901)](/cookbook/5.0/images/RightAxisOnly.png?250105183901)

{{< recipe-sp5 sourceUrl="https://github.com/ScottPlot/ScottPlot/blob/main/src/ScottPlot5/ScottPlot5%20Cookbook/Recipes/General/MultiAxis.cs" imageUrl="/cookbook/5.0/images/RightAxisOnly.png?250105183901" >}}ScottPlot.Plot myPlot = new();

// add a plottable to the plot
var sig = myPlot.Add.Signal(Generate.Sin());

// configure the plottable to use the right Y axis
sig.Axes.YAxis = myPlot.Axes.Right;

// configure the grid to display ticks from the right Y axis
myPlot.Grid.YAxis = myPlot.Axes.Right;

// style the right axis as desired
myPlot.Axes.Right.Label.Text = "Hello, Right Axis";
myPlot.Axes.Right.Label.FontSize = 18;

// it is recommended to remove tick generators from unused axes
myPlot.Axes.Left.RemoveTickGenerator();

// pass in the custom axis when calling SetLimits()
myPlot.Axes.SetLimitsY(bottom: -2, top: 2, yAxis: myPlot.Axes.Right);

myPlot.SavePng("demo.png", 400, 300);
{{< /recipe-sp5 >}}

<hr class='my-5 invisible'>


