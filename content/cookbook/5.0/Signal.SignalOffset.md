---
Title: Signal Offset - ScottPlot 5.0 Cookbook
Description: Signal plots can be offset by a given X and Y value.
URL: /cookbook/5.0/Signal/SignalOffset/
BreadcrumbNames: ["ScottPlot 5.0 Cookbook", "Signal Plot", "Signal Offset"]
BreadcrumbUrls: ["/cookbook/5.0/", "/cookbook/5.0/Signal", "/cookbook/5.0/Signal/SignalOffset"]
Date: 2024-11-13
Version: ScottPlot 5.0.45
Version: ScottPlot 5.0.45
SearchUrl: "/cookbook/5.0/search/"
ShowEditLink: false
---


<div class='d-flex align-items-center mt-5'>
<h1 class='me-2 text-dark my-0 border-0'>Signal Offset</h1>
</div>

Signal plots can be offset by a given X and Y value.

[![](/cookbook/5.0/images/SignalOffset.png?241112193154)](/cookbook/5.0/images/SignalOffset.png?241112193154)

{{< recipe-sp5 sourceUrl="https://github.com/ScottPlot/ScottPlot/blob/main/src/ScottPlot5/ScottPlot5%20Cookbook/Recipes/PlotTypes/Signal.cs" imageUrl="/cookbook/5.0/images/SignalOffset.png?241112193154" >}}ScottPlot.Plot myPlot = new();

double[] values = ScottPlot.Generate.Sin(51);

var sig1 = myPlot.Add.Signal(values);
sig1.LegendText = "Default";

var sig2 = myPlot.Add.Signal(values);
sig2.Data.XOffset = 10;
sig2.Data.YOffset = .25;
sig2.LegendText = "Offset";

myPlot.Legend.IsVisible = true;

myPlot.SavePng("demo.png", 400, 300);
{{< /recipe-sp5 >}}

<div class='my-5 text-center'>This recipe is one of many in the <a href='/cookbook/5.0/Signal'>Signal Plot</a> category</div>


