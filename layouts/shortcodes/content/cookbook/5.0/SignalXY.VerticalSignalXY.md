---
Title: Vertical SignalXY - ScottPlot 5.0 Cookbook
Description: Although SignalXY plots typically display data left-to-right, it is possible to use this plot type to display data bottom-to-top.
URL: /cookbook/5.0/SignalXY/VerticalSignalXY/
BreadcrumbNames: ["ScottPlot 5.0 Cookbook", "SignalXY Plot", "Vertical SignalXY"]
BreadcrumbUrls: ["/cookbook/5.0/", "/cookbook/5.0/SignalXY", "/cookbook/5.0/SignalXY/VerticalSignalXY"]
Date: 2025-03-22
Version: ScottPlot 5.0.55
Version: ScottPlot 5.0.55
SearchUrl: "/cookbook/5.0/search/"
ShowEditLink: false
---


<div class='d-flex align-items-center mt-5'>
<h1 class='me-2 text-dark my-0 border-0'>Vertical SignalXY</h1>
</div>

Although SignalXY plots typically display data left-to-right, it is possible to use this plot type to display data bottom-to-top.

[![](/cookbook/5.0/images/VerticalSignalXY.png?250322130304)](/cookbook/5.0/images/VerticalSignalXY.png?250322130304)

{{< recipe-sp5 sourceUrl="https://github.com/ScottPlot/ScottPlot/blob/main/src/ScottPlot5/ScottPlot5%20Cookbook/Recipes/PlotTypes/SignalXY.cs" imageUrl="/cookbook/5.0/images/VerticalSignalXY.png?250322130304" >}}ScottPlot.Plot myPlot = new();

double[] xs = Generate.Consecutive(1000);
double[] ys = Generate.RandomWalk(1000);

var sig1 = myPlot.Add.SignalXY(xs, ys);
sig1.Data.Rotated = true;

myPlot.SavePng("demo.png", 400, 300);
{{< /recipe-sp5 >}}

<div class='my-5 text-center'>This recipe is one of many in the <a href='/cookbook/5.0/SignalXY'>SignalXY Plot</a> category</div>


