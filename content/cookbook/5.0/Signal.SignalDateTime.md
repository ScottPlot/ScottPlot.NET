---
Title: Signal DateTime - ScottPlot 5.0 Cookbook
Description: A signal plot may use DateTime units but be sure to setup the respective axis to display using DateTime format.
URL: /cookbook/5.0/Signal/SignalDateTime/
BreadcrumbNames: ["ScottPlot 5.0 Cookbook", "Signal Plot", "Signal DateTime"]
BreadcrumbUrls: ["/cookbook/5.0/", "/cookbook/5.0/Signal", "/cookbook/5.0/Signal/SignalDateTime"]
Date: 2024-10-30
Version: ScottPlot 5.0.42
Version: ScottPlot 5.0.42
SearchUrl: "/cookbook/5.0/search/"
ShowEditLink: false
---


<h2 style='border-bottom: 0;'><a href='/cookbook/5.0/Signal/SignalDateTime'>Signal DateTime</a></h2>

<div class="d-flex mb-2">
<a class="btn btn-sm btn-primary me-1" href="/cookbook/5.0/Signal/SignalDateTime">Recipe Permalink</a>
<a class="btn btn-sm btn-success me-1" href="/cookbook/5.0/Signal">Category: Signal Plot</a>
</div>

A signal plot may use DateTime units but be sure to setup the respective axis to display using DateTime format.

[![](/cookbook/5.0/images/SignalDateTime.png?241029205813)](/cookbook/5.0/images/SignalDateTime.png?241029205813)

{{< recipe-sp5 >}}ScottPlot.Plot myPlot = new();

DateTime start = new(2024, 1, 1);
double[] ys = Generate.RandomWalk(200);

var sig = myPlot.Add.Signal(ys);
sig.Data.XOffset = start.ToOADate();
sig.Data.Period = 1.0; // one day between each point

myPlot.Axes.DateTimeTicksBottom();

myPlot.SavePng("demo.png", 400, 300);
{{< /recipe-sp5 >}}

<hr class='my-5 invisible'>


