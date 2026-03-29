---
Title: Vertical SignalXY with Inverted X Axis - ScottPlot 5 Cookbook
Description: Demonstrates how to display a rotated SignalXY plot (so it goes from bottom to top) which is also displayed on an inverted horizontal axis (where positive values are on the left).
URL: /cookbook/5/SignalXY/SignalXYVerticalInvertedX/
BreadcrumbNames: ["ScottPlot 5 Cookbook", "SignalXY Plot", "Vertical SignalXY with Inverted X Axis"]
BreadcrumbUrls: ["/cookbook/5/", "/cookbook/5/SignalXY", "/cookbook/5/SignalXY/SignalXYVerticalInvertedX"]
Date: 2026-03-29
Version: ScottPlot 5.1.58
Version: ScottPlot 5.1.58
SearchUrl: "/cookbook/5/search/"
ShowEditLink: false
---


<div class='d-flex align-items-center mt-5'>
<h1 class='me-2 text-dark my-0 border-0'>Vertical SignalXY with Inverted X Axis</h1>
</div>

Demonstrates how to display a rotated SignalXY plot (so it goes from bottom to top) which is also displayed on an inverted horizontal axis (where positive values are on the left).

[![](/cookbook/5/images/SignalXYVerticalInvertedX.png?260329072039)](/cookbook/5/images/SignalXYVerticalInvertedX.png?260329072039)

{{< recipe-sp5 sourceUrl="https://github.com/ScottPlot/ScottPlot/blob/main/src/ScottPlot5/ScottPlot5%20Cookbook/Recipes/PlotTypes/SignalXY.cs" imageUrl="/cookbook/5/images/SignalXYVerticalInvertedX.png?260329072039" >}}ScottPlot.Plot myPlot = new();

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

<div class='my-5 text-center'>This recipe is one of many in the <a href='/cookbook/5/SignalXY'>SignalXY Plot</a> category</div>


