---
Title: Vertical SignalXY - ScottPlot 5.0 Cookbook
Description: Although SignalXY plots typically display data left-to-right, it is possible to use this plot type to display data bottom-to-top.
URL: /cookbook/5.0/SignalXY/VerticalSignalXY/
BreadcrumbNames: ["ScottPlot 5.0 Cookbook", "SignalXY Plot", "Vertical SignalXY"]
BreadcrumbUrls: ["/cookbook/5.0/", "/cookbook/5.0/SignalXY", "/cookbook/5.0/SignalXY/VerticalSignalXY"]
Date: 2024-10-31
Version: ScottPlot 5.0.42
Version: ScottPlot 5.0.42
SearchUrl: "/cookbook/5.0/search/"
ShowEditLink: false
---


<h2 style='border-bottom: 0;'><a href='/cookbook/5.0/SignalXY/VerticalSignalXY'>Vertical SignalXY</a></h2>

<div class="d-flex mb-2">
<a class="btn btn-sm btn-primary me-1" href="/cookbook/5.0/SignalXY/VerticalSignalXY">Recipe Permalink</a>
<a class="btn btn-sm btn-success me-1" href="/cookbook/5.0/SignalXY">Category: SignalXY Plot</a>
</div>

Although SignalXY plots typically display data left-to-right, it is possible to use this plot type to display data bottom-to-top.

[![](/cookbook/5.0/images/VerticalSignalXY.png?241031194635)](/cookbook/5.0/images/VerticalSignalXY.png?241031194635)

{{< recipe-sp5 >}}ScottPlot.Plot myPlot = new();

double[] xs = Generate.Consecutive(1000);
double[] ys = Generate.RandomWalk(1000);

var sig1 = myPlot.Add.SignalXY(xs, ys);
sig1.Data.Rotated = true;

myPlot.SavePng("demo.png", 400, 300);
{{< /recipe-sp5 >}}

<hr class='my-5 invisible'>


