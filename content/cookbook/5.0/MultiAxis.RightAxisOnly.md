---
Title: Right Axis Only - ScottPlot 5.0 Cookbook
Description: The default Y axis is the one on the left of the plot, but the right Y axis may be used instead.
URL: /cookbook/5.0/MultiAxis/RightAxisOnly/
BreadcrumbNames: ["ScottPlot 5.0 Cookbook", "Multiple Axes", "Right Axis Only"]
BreadcrumbUrls: ["/cookbook/5.0/", "/cookbook/5.0/MultiAxis", "/cookbook/5.0/MultiAxis/RightAxisOnly"]
Date: 2025-01-13
Version: ScottPlot 5.0.53
Version: ScottPlot 5.0.53
SearchUrl: "/cookbook/5.0/search/"
ShowEditLink: false
---


<div class='d-flex align-items-center mt-5'>
<h1 class='me-2 text-dark my-0 border-0'>Right Axis Only</h1>
</div>

The default Y axis is the one on the left of the plot, but the right Y axis may be used instead.

[![](/cookbook/5.0/images/RightAxisOnly.png?250112204022)](/cookbook/5.0/images/RightAxisOnly.png?250112204022)

{{< recipe-sp5 sourceUrl="https://github.com/ScottPlot/ScottPlot/blob/main/src/ScottPlot5/ScottPlot5%20Cookbook/Recipes/General/MultiAxis.cs" imageUrl="/cookbook/5.0/images/RightAxisOnly.png?250112204022" >}}ScottPlot.Plot myPlot = new();

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

<div class='my-5 text-center'>This recipe is one of many in the <a href='/cookbook/5.0/MultiAxis'>Multiple Axes</a> category</div>


