---
Title: Vertical SignalXY with Inverted Y Axis - ScottPlot 5.0 Cookbook
Description: Demonstrates how to display a rotated SignalXY plot on an inverted vertical axis so data goes from top to bottom.
URL: /cookbook/5.0/SignalXY/SignalXYVerticalInvertedY/
BreadcrumbNames: ["ScottPlot 5.0 Cookbook", "SignalXY Plot", "Vertical SignalXY with Inverted Y Axis"]
BreadcrumbUrls: ["/cookbook/5.0/", "/cookbook/5.0/SignalXY", "/cookbook/5.0/SignalXY/SignalXYVerticalInvertedY"]
Date: 2025-01-26
Version: ScottPlot 5.0.55
Version: ScottPlot 5.0.55
SearchUrl: "/cookbook/5.0/search/"
ShowEditLink: false
---


<div class='d-flex align-items-center mt-5'>
<h1 class='me-2 text-dark my-0 border-0'>Vertical SignalXY with Inverted Y Axis</h1>
</div>

Demonstrates how to display a rotated SignalXY plot on an inverted vertical axis so data goes from top to bottom.

[![](/cookbook/5.0/images/SignalXYVerticalInvertedY.png?250126165944)](/cookbook/5.0/images/SignalXYVerticalInvertedY.png?250126165944)

{{< recipe-sp5 sourceUrl="https://github.com/ScottPlot/ScottPlot/blob/main/src/ScottPlot5/ScottPlot5%20Cookbook/Recipes/PlotTypes/SignalXY.cs" imageUrl="/cookbook/5.0/images/SignalXYVerticalInvertedY.png?250126165944" >}}ScottPlot.Plot myPlot = new();

// add a signal plot
double[] xs = Generate.Consecutive(5_000);
double[] ys = Generate.Sin(count: xs.Length, oscillations: 4);

// rotate it so it is vertical
var signal = myPlot.Add.SignalXY(xs, ys);
signal.Data.Rotated = true;

// invert the vertical axis
myPlot.Axes.SetLimitsY(5000, 0);

myPlot.SavePng("demo.png", 400, 300);
{{< /recipe-sp5 >}}

<div class='my-5 text-center'>This recipe is one of many in the <a href='/cookbook/5.0/SignalXY'>SignalXY Plot</a> category</div>


