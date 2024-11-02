---
Title: Hide Axis and Turn frame lines on/off - ScottPlot 5.0 Cookbook
Description: Demonstrates how to hide axis ticks and turn frame lines on and off.
URL: /cookbook/5.0/AxisAndTicks/HideAxis/
BreadcrumbNames: ["ScottPlot 5.0 Cookbook", "Axis and Ticks", "Hide Axis and Turn frame lines on/off"]
BreadcrumbUrls: ["/cookbook/5.0/", "/cookbook/5.0/AxisAndTicks", "/cookbook/5.0/AxisAndTicks/HideAxis"]
Date: 2024-11-02
Version: ScottPlot 5.0.42
Version: ScottPlot 5.0.42
SearchUrl: "/cookbook/5.0/search/"
ShowEditLink: false
---


<div class='d-flex align-items-center mt-5'>
<h1 class='me-2 text-dark my-0 border-0'>Hide Axis and Turn frame lines on/off</h1>
</div>

Demonstrates how to hide axis ticks and turn frame lines on and off.

[![](/cookbook/5.0/images/HideAxis.png?241102170938)](/cookbook/5.0/images/HideAxis.png?241102170938)

{{< recipe-sp5 sourceUrl="https://github.com/ScottPlot/ScottPlot/blob/main/src/ScottPlot5/ScottPlot5%20Cookbook/Recipes/General/AxisRecipes.cs" imageUrl="/cookbook/5.0/images/HideAxis.png?241102170938" >}}ScottPlot.Plot myPlot = new();

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
{{< /recipe-sp5 >}}

<div class='my-5 text-center'>This recipe is one of many in the <a href='/cookbook/5.0/AxisAndTicks'>Axis and Ticks</a> category</div>


