---
Title: Hide Axis and Turn frame lines on/off - ScottPlot 5.0 Cookbook
Description: Demonstrates how to hide axis ticks and turn frame lines on and off.
URL: /cookbook/5.0/AxisAndTicks/HideAxis/
BreadcrumbNames: ["ScottPlot 5.0 Cookbook", "Axis and Ticks", "Hide Axis and Turn frame lines on/off"]
BreadcrumbUrls: ["/cookbook/5.0/", "/cookbook/5.0/AxisAndTicks", "/cookbook/5.0/AxisAndTicks/HideAxis"]
Date: 2024-10-30
Version: ScottPlot 5.0.42
Version: ScottPlot 5.0.42
SearchUrl: "/cookbook/5.0/search/"
ShowEditLink: false
---


<h2 style='border-bottom: 0;'><a href='/cookbook/5.0/AxisAndTicks/HideAxis'>Hide Axis and Turn frame lines on/off</a></h2>

<div class="d-flex mb-2">
<a class="btn btn-sm btn-primary me-1" href="/cookbook/5.0/AxisAndTicks/HideAxis">Recipe Permalink</a>
<a class="btn btn-sm btn-success me-1" href="/cookbook/5.0/AxisAndTicks">Category: Axis and Ticks</a>
</div>

Demonstrates how to hide axis ticks and turn frame lines on and off.

[![](/cookbook/5.0/images/HideAxis.png?241029205813)](/cookbook/5.0/images/HideAxis.png?241029205813)

{{< recipe-sp5 >}}ScottPlot.Plot myPlot = new();

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

<hr class='my-5 invisible'>


