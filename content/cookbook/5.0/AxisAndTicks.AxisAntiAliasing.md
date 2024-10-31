---
Title: Axis AntiAliasing - ScottPlot 5.0 Cookbook
Description: To improve crispness of straight vertical and horizontal lines, Anti-aliasing is disabled by default for axis frames, tick marks, and grid lines. Anti-aliasing can be enabled for all these objects by calling the AntiAlias helper method.
URL: /cookbook/5.0/AxisAndTicks/AxisAntiAliasing/
BreadcrumbNames: ["ScottPlot 5.0 Cookbook", "Axis and Ticks", "Axis AntiAliasing"]
BreadcrumbUrls: ["/cookbook/5.0/", "/cookbook/5.0/AxisAndTicks", "/cookbook/5.0/AxisAndTicks/AxisAntiAliasing"]
Date: 2024-10-31
Version: ScottPlot 5.0.42
Version: ScottPlot 5.0.42
SearchUrl: "/cookbook/5.0/search/"
ShowEditLink: false
---


<h2 style='border-bottom: 0;'><a href='/cookbook/5.0/AxisAndTicks/AxisAntiAliasing'>Axis AntiAliasing</a></h2>

<div class="d-flex mb-2">
<a class="btn btn-sm btn-primary me-1" href="/cookbook/5.0/AxisAndTicks/AxisAntiAliasing">Recipe Permalink</a>
<a class="btn btn-sm btn-success me-1" href="/cookbook/5.0/AxisAndTicks">Category: Axis and Ticks</a>
</div>

To improve crispness of straight vertical and horizontal lines, Anti-aliasing is disabled by default for axis frames, tick marks, and grid lines. Anti-aliasing can be enabled for all these objects by calling the AntiAlias helper method.

[![](/cookbook/5.0/images/AxisAntiAliasing.png?241031194635)](/cookbook/5.0/images/AxisAntiAliasing.png?241031194635)

{{< recipe-sp5 >}}ScottPlot.Plot myPlot = new();

double[] dataX = { 1, 2, 3, 4, 5 };
double[] dataY = { 1, 4, 9, 16, 25 };
myPlot.Add.Scatter(dataX, dataY);

myPlot.Axes.AntiAlias(true);

myPlot.SavePng("demo.png", 400, 300);
{{< /recipe-sp5 >}}

<hr class='my-5 invisible'>


