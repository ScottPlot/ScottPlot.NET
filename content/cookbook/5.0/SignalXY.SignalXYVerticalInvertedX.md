---
Title: Vertical SignalXY with Inverted X Axis - ScottPlot 5.0 Cookbook
Description: Demonstrates how to display a rotated SignalXY plot (so it goes from bottom to top) which is also displayed on an inverted horizontal axis (where positive values are on the left).
URL: /cookbook/5.0/SignalXY/SignalXYVerticalInvertedX/
BreadcrumbNames: ["ScottPlot 5.0 Cookbook", "SignalXY Plot", "Vertical SignalXY with Inverted X Axis"]
BreadcrumbUrls: ["/cookbook/5.0/", "/cookbook/5.0/SignalXY", "/cookbook/5.0/SignalXY/SignalXYVerticalInvertedX"]
Date: 2024-10-31
Version: ScottPlot 5.0.42
Version: ScottPlot 5.0.42
SearchUrl: "/cookbook/5.0/search/"
ShowEditLink: false
---


<h2 style='border-bottom: 0;'><a href='/cookbook/5.0/SignalXY/SignalXYVerticalInvertedX'>Vertical SignalXY with Inverted X Axis</a></h2>

<div class="d-flex mb-2">
<a class="btn btn-sm btn-primary me-1" href="/cookbook/5.0/SignalXY/SignalXYVerticalInvertedX">Recipe Permalink</a>
<a class="btn btn-sm btn-success me-1" href="/cookbook/5.0/SignalXY">Category: SignalXY Plot</a>
</div>

Demonstrates how to display a rotated SignalXY plot (so it goes from bottom to top) which is also displayed on an inverted horizontal axis (where positive values are on the left).

[![](/cookbook/5.0/images/SignalXYVerticalInvertedX.png?241031194635)](/cookbook/5.0/images/SignalXYVerticalInvertedX.png?241031194635)

{{< recipe-sp5 >}}ScottPlot.Plot myPlot = new();

// add a signal plot
double[] xs = Generate.Consecutive(5_000);
double[] ys = Generate.Sin(count: xs.Length, oscillations: 4);

// rotate it so it is vertical
var signal = myPlot.Add.SignalXY(xs, ys);
signal.Data.Rotated = true;

// invert the horizontal axis
myPlot.Axes.SetLimitsX(1, -1);

myPlot.SavePng("demo.png", 400, 300);
{{< /recipe-sp5 >}}

<hr class='my-5 invisible'>


