---
Title: SignalXY DateTime Axis - ScottPlot 5.0 Cookbook
Description: SignalXY plots can display unevenly spaced time series data using a DateTime horizontal axis.
URL: /cookbook/5.0/SignalXY/SignalXYDateTime/
BreadcrumbNames: ["ScottPlot 5.0 Cookbook", "SignalXY Plot", "SignalXY DateTime Axis"]
BreadcrumbUrls: ["/cookbook/5.0/", "/cookbook/5.0/SignalXY", "/cookbook/5.0/SignalXY/SignalXYDateTime"]
Date: 2024-10-31
Version: ScottPlot 5.0.42
Version: ScottPlot 5.0.42
SearchUrl: "/cookbook/5.0/search/"
ShowEditLink: false
---


<h2 style='border-bottom: 0;'><a href='/cookbook/5.0/SignalXY/SignalXYDateTime'>SignalXY DateTime Axis</a></h2>

<div class="d-flex mb-2">
<a class="btn btn-sm btn-primary me-1" href="/cookbook/5.0/SignalXY/SignalXYDateTime">Recipe Permalink</a>
<a class="btn btn-sm btn-success me-1" href="/cookbook/5.0/SignalXY">Category: SignalXY Plot</a>
</div>

SignalXY plots can display unevenly spaced time series data using a DateTime horizontal axis.

[![](/cookbook/5.0/images/SignalXYDateTime.png?241031194635)](/cookbook/5.0/images/SignalXYDateTime.png?241031194635)

{{< recipe-sp5 >}}ScottPlot.Plot myPlot = new();

DateTime start = new(2024, 01, 01);
DateTime[] xs = Generate.ConsecutiveDays(100, start);

double[] ys = Generate.RandomWalk(100);

myPlot.Add.SignalXY(xs, ys);
myPlot.Axes.DateTimeTicksBottom();

myPlot.SavePng("demo.png", 400, 300);
{{< /recipe-sp5 >}}

<hr class='my-5 invisible'>


