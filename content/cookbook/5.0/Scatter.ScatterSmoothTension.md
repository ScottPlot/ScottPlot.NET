---
Title: Smooth Line Tension - ScottPlot 5.0 Cookbook
Description: Tension of smooth lines can be adjusted for some smoothing strategies. Low tensions lead to 'overshoot' and high tensions produce curveswhich appear more like straight lines.
URL: /cookbook/5.0/Scatter/ScatterSmoothTension/
BreadcrumbNames: ["ScottPlot 5.0 Cookbook", "Scatter Plot", "Smooth Line Tension"]
BreadcrumbUrls: ["/cookbook/5.0/", "/cookbook/5.0/Scatter", "/cookbook/5.0/Scatter/ScatterSmoothTension"]
Date: 2024-10-31
Version: ScottPlot 5.0.42
Version: ScottPlot 5.0.42
SearchUrl: "/cookbook/5.0/search/"
ShowEditLink: false
---


<h2 style='border-bottom: 0;'><a href='/cookbook/5.0/Scatter/ScatterSmoothTension'>Smooth Line Tension</a></h2>

<div class="d-flex mb-2">
<a class="btn btn-sm btn-primary me-1" href="/cookbook/5.0/Scatter/ScatterSmoothTension">Recipe Permalink</a>
<a class="btn btn-sm btn-success me-1" href="/cookbook/5.0/Scatter">Category: Scatter Plot</a>
</div>

Tension of smooth lines can be adjusted for some smoothing strategies. Low tensions lead to 'overshoot' and high tensions produce curveswhich appear more like straight lines.

[![](/cookbook/5.0/images/ScatterSmoothTension.png?241031194635)](/cookbook/5.0/images/ScatterSmoothTension.png?241031194635)

{{< recipe-sp5 >}}ScottPlot.Plot myPlot = new();

double[] xs = Generate.RandomWalk(10);
double[] ys = Generate.RandomWalk(10);

var mk = myPlot.Add.Markers(xs, ys);
mk.MarkerShape = MarkerShape.OpenCircle;
mk.Color = Colors.Black;

double[] tensions = { 0.3, 0.5, 1.0, 3.0 };

foreach (double tension in tensions)
{
    var sp = myPlot.Add.ScatterLine(xs, ys);
    sp.Smooth = true;
    sp.SmoothTension = tension;
    sp.LegendText = $"Tension {tension}";
    sp.LineWidth = 2;
}

myPlot.ShowLegend(Alignment.UpperLeft);

myPlot.SavePng("demo.png", 400, 300);
{{< /recipe-sp5 >}}

<hr class='my-5 invisible'>


