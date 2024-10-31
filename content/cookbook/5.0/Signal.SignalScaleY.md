---
Title: Signal Scaling - ScottPlot 5.0 Cookbook
Description: Signal plots can be scaled vertically according to a user-defined amount.
URL: /cookbook/5.0/Signal/SignalScaleY/
BreadcrumbNames: ["ScottPlot 5.0 Cookbook", "Signal Plot", "Signal Scaling"]
BreadcrumbUrls: ["/cookbook/5.0/", "/cookbook/5.0/Signal", "/cookbook/5.0/Signal/SignalScaleY"]
Date: 2024-10-31
Version: ScottPlot 5.0.42
Version: ScottPlot 5.0.42
SearchUrl: "/cookbook/5.0/search/"
ShowEditLink: false
---


<h2 style='border-bottom: 0;'><a href='/cookbook/5.0/Signal/SignalScaleY'>Signal Scaling</a></h2>

<div class="d-flex mb-2">
<a class="btn btn-sm btn-primary me-1" href="/cookbook/5.0/Signal/SignalScaleY">Recipe Permalink</a>
<a class="btn btn-sm btn-success me-1" href="/cookbook/5.0/Signal">Category: Signal Plot</a>
</div>

Signal plots can be scaled vertically according to a user-defined amount.

[![](/cookbook/5.0/images/SignalScaleY.png?241031194635)](/cookbook/5.0/images/SignalScaleY.png?241031194635)

{{< recipe-sp5 >}}ScottPlot.Plot myPlot = new();

// plot values between -1 and 1
double[] values = ScottPlot.Generate.Sin(51);
var signal = myPlot.Add.Signal(values);

// increase the vertical scaling
signal.Data.YScale = 500;

myPlot.SavePng("demo.png", 400, 300);
{{< /recipe-sp5 >}}

<hr class='my-5 invisible'>


