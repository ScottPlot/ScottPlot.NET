---
Title: SignalXY Offset - ScottPlot 5.0 Cookbook
Description: A fixed offset can be applied to SignalXY plots.
URL: /cookbook/5.0/SignalXY/SignalXYOffset/
BreadcrumbNames: ["ScottPlot 5.0 Cookbook", "SignalXY Plot", "SignalXY Offset"]
BreadcrumbUrls: ["/cookbook/5.0/", "/cookbook/5.0/SignalXY", "/cookbook/5.0/SignalXY/SignalXYOffset"]
Date: 2024-10-30
Version: ScottPlot 5.0.42
Version: ScottPlot 5.0.42
SearchUrl: "/cookbook/5.0/search/"
ShowEditLink: false
---


<h2 style='border-bottom: 0;'><a href='/cookbook/5.0/SignalXY/SignalXYOffset'>SignalXY Offset</a></h2>

<div class="d-flex mb-2">
<a class="btn btn-sm btn-primary me-1" href="/cookbook/5.0/SignalXY/SignalXYOffset">Recipe Permalink</a>
<a class="btn btn-sm btn-success me-1" href="/cookbook/5.0/SignalXY">Category: SignalXY Plot</a>
</div>

A fixed offset can be applied to SignalXY plots.

[![](/cookbook/5.0/images/SignalXYOffset.png?241029205813)](/cookbook/5.0/images/SignalXYOffset.png?241029205813)

{{< recipe-sp5 >}}ScottPlot.Plot myPlot = new();

double[] xs = Generate.Consecutive(1000);
double[] ys = Generate.Sin(1000);

var sig1 = myPlot.Add.SignalXY(xs, ys);

var sig2 = myPlot.Add.SignalXY(xs, ys);
sig2.Data.XOffset = 250;
sig2.Data.YOffset = .5;

myPlot.SavePng("demo.png", 400, 300);
{{< /recipe-sp5 >}}

<hr class='my-5 invisible'>


