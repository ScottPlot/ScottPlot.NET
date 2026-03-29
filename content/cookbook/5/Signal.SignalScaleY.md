---
Title: Signal Scaling - ScottPlot 5 Cookbook
Description: Signal plots can be scaled vertically according to a user-defined amount.
URL: /cookbook/5/Signal/SignalScaleY/
BreadcrumbNames: ["ScottPlot 5 Cookbook", "Signal Plot", "Signal Scaling"]
BreadcrumbUrls: ["/cookbook/5/", "/cookbook/5/Signal", "/cookbook/5/Signal/SignalScaleY"]
Date: 2026-03-29
Version: ScottPlot 5.1.58
Version: ScottPlot 5.1.58
SearchUrl: "/cookbook/5/search/"
ShowEditLink: false
---


<div class='d-flex align-items-center mt-5'>
<h1 class='me-2 text-dark my-0 border-0'>Signal Scaling</h1>
</div>

Signal plots can be scaled vertically according to a user-defined amount.

[![](/cookbook/5/images/SignalScaleY.png?260329072039)](/cookbook/5/images/SignalScaleY.png?260329072039)

{{< recipe-sp5 sourceUrl="https://github.com/ScottPlot/ScottPlot/blob/main/src/ScottPlot5/ScottPlot5%20Cookbook/Recipes/PlotTypes/Signal.cs" imageUrl="/cookbook/5/images/SignalScaleY.png?260329072039" >}}ScottPlot.Plot myPlot = new();

// plot values between -1 and 1
double[] values = ScottPlot.Generate.Sin(51);
var signal = myPlot.Add.Signal(values);

// increase the vertical scaling
signal.Data.YScale = 500;

myPlot.SavePng("demo.png", 400, 300);
{{< /recipe-sp5 >}}

<div class='my-5 text-center'>This recipe is one of many in the <a href='/cookbook/5/Signal'>Signal Plot</a> category</div>


