---
Title: Partial Signal Rendering - ScottPlot 5.0 Cookbook
Description: Even if a signal plot references a large array of data, rendering can be limited to a range of values. If set,only the range of data between the minimum and maximum render indexes will be displayed.
URL: /cookbook/5.0/Signal/SignalRenderIndexes/
BreadcrumbNames: ["ScottPlot 5.0 Cookbook", "Signal Plot", "Partial Signal Rendering"]
BreadcrumbUrls: ["/cookbook/5.0/", "/cookbook/5.0/Signal", "/cookbook/5.0/Signal/SignalRenderIndexes"]
Date: 2024-10-31
Version: ScottPlot 5.0.42
Version: ScottPlot 5.0.42
SearchUrl: "/cookbook/5.0/search/"
ShowEditLink: false
---


<h2 style='border-bottom: 0;'><a href='/cookbook/5.0/Signal/SignalRenderIndexes'>Partial Signal Rendering</a></h2>

<div class="d-flex mb-2">
<a class="btn btn-sm btn-primary me-1" href="/cookbook/5.0/Signal/SignalRenderIndexes">Recipe Permalink</a>
<a class="btn btn-sm btn-success me-1" href="/cookbook/5.0/Signal">Category: Signal Plot</a>
</div>

Even if a signal plot references a large array of data, rendering can be limited to a range of values. If set,only the range of data between the minimum and maximum render indexes will be displayed.

[![](/cookbook/5.0/images/SignalRenderIndexes.png?241031194635)](/cookbook/5.0/images/SignalRenderIndexes.png?241031194635)

{{< recipe-sp5 >}}ScottPlot.Plot myPlot = new();

double[] values = Generate.RandomWalk(1000);

var sigAll = myPlot.Add.Signal(values);
sigAll.LegendText = "Full";
sigAll.Data.YOffset = 80;

var sigLeft = myPlot.Add.Signal(values);
sigLeft.LegendText = "Left";
sigLeft.Data.YOffset = 60;
sigLeft.Data.MaximumIndex = 700;

var sigRight = myPlot.Add.Signal(values);
sigRight.LegendText = "Right";
sigRight.Data.YOffset = 40;
sigRight.Data.MinimumIndex = 300;

var sigMid = myPlot.Add.Signal(values);
sigMid.LegendText = "Mid";
sigMid.Data.YOffset = 20;
sigMid.Data.MinimumIndex = 300;
sigMid.Data.MaximumIndex = 700;

myPlot.ShowLegend(Alignment.UpperRight);
myPlot.Axes.Margins(top: .5);

myPlot.SavePng("demo.png", 400, 300);
{{< /recipe-sp5 >}}

<hr class='my-5 invisible'>


