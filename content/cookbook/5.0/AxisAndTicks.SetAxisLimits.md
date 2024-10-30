---
Title: Set Axis Limits - ScottPlot 5.0 Cookbook
Description: Axis Limits can be set by the user.
URL: /cookbook/5.0/AxisAndTicks/SetAxisLimits/
BreadcrumbNames: ["ScottPlot 5.0 Cookbook", "Axis and Ticks", "Set Axis Limits"]
BreadcrumbUrls: ["/cookbook/5.0/", "/cookbook/5.0/AxisAndTicks", "/cookbook/5.0/AxisAndTicks/SetAxisLimits"]
Date: 2024-10-30
Version: ScottPlot 5.0.42
Version: ScottPlot 5.0.42
SearchUrl: "/cookbook/5.0/search/"
ShowEditLink: false
---


<h2 style='border-bottom: 0;'><a href='/cookbook/5.0/AxisAndTicks/SetAxisLimits'>Set Axis Limits</a></h2>

<div class="d-flex mb-2">
<a class="btn btn-sm btn-primary me-1" href="/cookbook/5.0/AxisAndTicks/SetAxisLimits">Recipe Permalink</a>
<a class="btn btn-sm btn-success me-1" href="/cookbook/5.0/AxisAndTicks">Category: Axis and Ticks</a>
</div>

Axis Limits can be set by the user.

[![](/cookbook/5.0/images/SetAxisLimits.png?241029205813)](/cookbook/5.0/images/SetAxisLimits.png?241029205813)

{{< recipe-sp5 >}}ScottPlot.Plot myPlot = new();

myPlot.Add.Signal(Generate.Sin(51));
myPlot.Add.Signal(Generate.Cos(51));

myPlot.Axes.SetLimits(-100, 150, -5, 5);

myPlot.SavePng("demo.png", 400, 300);
{{< /recipe-sp5 >}}

<hr class='my-5 invisible'>


