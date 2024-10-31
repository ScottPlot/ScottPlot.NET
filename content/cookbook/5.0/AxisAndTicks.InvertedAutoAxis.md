---
Title: Inverted Auto-Axis - ScottPlot 5.0 Cookbook
Description: Customize the logic for the automatic axis scaler to ensure that axis limits for a particular axis are always inverted when autoscaled.
URL: /cookbook/5.0/AxisAndTicks/InvertedAutoAxis/
BreadcrumbNames: ["ScottPlot 5.0 Cookbook", "Axis and Ticks", "Inverted Auto-Axis"]
BreadcrumbUrls: ["/cookbook/5.0/", "/cookbook/5.0/AxisAndTicks", "/cookbook/5.0/AxisAndTicks/InvertedAutoAxis"]
Date: 2024-10-31
Version: ScottPlot 5.0.42
Version: ScottPlot 5.0.42
SearchUrl: "/cookbook/5.0/search/"
ShowEditLink: false
---


<h2 style='border-bottom: 0;'><a href='/cookbook/5.0/AxisAndTicks/InvertedAutoAxis'>Inverted Auto-Axis</a></h2>

<div class="d-flex mb-2">
<a class="btn btn-sm btn-primary me-1" href="/cookbook/5.0/AxisAndTicks/InvertedAutoAxis">Recipe Permalink</a>
<a class="btn btn-sm btn-success me-1" href="/cookbook/5.0/AxisAndTicks">Category: Axis and Ticks</a>
</div>

Customize the logic for the automatic axis scaler to ensure that axis limits for a particular axis are always inverted when autoscaled.

[![](/cookbook/5.0/images/InvertedAutoAxis.png?241031194635)](/cookbook/5.0/images/InvertedAutoAxis.png?241031194635)

{{< recipe-sp5 >}}ScottPlot.Plot myPlot = new();

myPlot.Add.Signal(Generate.Sin());
myPlot.Add.Signal(Generate.Cos());

myPlot.Axes.AutoScaler.InvertedY = true;

myPlot.SavePng("demo.png", 400, 300);
{{< /recipe-sp5 >}}

<hr class='my-5 invisible'>


