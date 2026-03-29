---
Title: Smooth Line Tension - ScottPlot 5 Cookbook
Description: Tension of smooth lines can be adjusted for some smoothing strategies. Low tensions lead to 'overshoot' and high tensions produce curveswhich appear more like straight lines.
URL: /cookbook/5/Scatter/ScatterSmoothTension/
BreadcrumbNames: ["ScottPlot 5 Cookbook", "Scatter Plot", "Smooth Line Tension"]
BreadcrumbUrls: ["/cookbook/5/", "/cookbook/5/Scatter", "/cookbook/5/Scatter/ScatterSmoothTension"]
Date: 2026-03-29
Version: ScottPlot 5.1.58
Version: ScottPlot 5.1.58
SearchUrl: "/cookbook/5/search/"
ShowEditLink: false
---


<div class='d-flex align-items-center mt-5'>
<h1 class='me-2 text-dark my-0 border-0'>Smooth Line Tension</h1>
</div>

Tension of smooth lines can be adjusted for some smoothing strategies. Low tensions lead to 'overshoot' and high tensions produce curveswhich appear more like straight lines.

[![](/cookbook/5/images/ScatterSmoothTension.png?260329072039)](/cookbook/5/images/ScatterSmoothTension.png?260329072039)

{{< recipe-sp5 sourceUrl="https://github.com/ScottPlot/ScottPlot/blob/main/src/ScottPlot5/ScottPlot5%20Cookbook/Recipes/PlotTypes/Scatter.cs" imageUrl="/cookbook/5/images/ScatterSmoothTension.png?260329072039" >}}ScottPlot.Plot myPlot = new();

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

<div class='my-5 text-center'>This recipe is one of many in the <a href='/cookbook/5/Scatter'>Scatter Plot</a> category</div>


