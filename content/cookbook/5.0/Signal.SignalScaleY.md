---
Title: Signal Scaling - ScottPlot 5.0 Cookbook
Description: Signal plots can be scaled vertically according to a user-defined amount.
URL: /cookbook/5.0/Signal/SignalScaleY/
BreadcrumbNames: ["ScottPlot 5.0 Cookbook", "Signal Plot", "Signal Scaling"]
BreadcrumbUrls: ["/cookbook/5.0/", "/cookbook/5.0/Signal", "/cookbook/5.0/Signal/SignalScaleY"]
Date: 2024-11-13
Version: ScottPlot 5.0.45
Version: ScottPlot 5.0.45
SearchUrl: "/cookbook/5.0/search/"
ShowEditLink: false
---


<div class='d-flex align-items-center mt-5'>
<h1 class='me-2 text-dark my-0 border-0'>Signal Scaling</h1>
</div>

Signal plots can be scaled vertically according to a user-defined amount.

[![](/cookbook/5.0/images/SignalScaleY.png?241112193154)](/cookbook/5.0/images/SignalScaleY.png?241112193154)

{{< recipe-sp5 sourceUrl="https://github.com/ScottPlot/ScottPlot/blob/main/src/ScottPlot5/ScottPlot5%20Cookbook/Recipes/PlotTypes/Signal.cs" imageUrl="/cookbook/5.0/images/SignalScaleY.png?241112193154" >}}ScottPlot.Plot myPlot = new();

// plot values between -1 and 1
double[] values = ScottPlot.Generate.Sin(51);
var signal = myPlot.Add.Signal(values);

// increase the vertical scaling
signal.Data.YScale = 500;

myPlot.SavePng("demo.png", 400, 300);
{{< /recipe-sp5 >}}

<div class='my-5 text-center'>This recipe is one of many in the <a href='/cookbook/5.0/Signal'>Signal Plot</a> category</div>


