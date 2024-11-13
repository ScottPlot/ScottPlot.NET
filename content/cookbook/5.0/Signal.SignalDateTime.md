---
Title: Signal DateTime - ScottPlot 5.0 Cookbook
Description: A signal plot may use DateTime units but be sure to setup the respective axis to display using DateTime format.
URL: /cookbook/5.0/Signal/SignalDateTime/
BreadcrumbNames: ["ScottPlot 5.0 Cookbook", "Signal Plot", "Signal DateTime"]
BreadcrumbUrls: ["/cookbook/5.0/", "/cookbook/5.0/Signal", "/cookbook/5.0/Signal/SignalDateTime"]
Date: 2024-11-13
Version: ScottPlot 5.0.45
Version: ScottPlot 5.0.45
SearchUrl: "/cookbook/5.0/search/"
ShowEditLink: false
---


<div class='d-flex align-items-center mt-5'>
<h1 class='me-2 text-dark my-0 border-0'>Signal DateTime</h1>
</div>

A signal plot may use DateTime units but be sure to setup the respective axis to display using DateTime format.

[![](/cookbook/5.0/images/SignalDateTime.png?241112193154)](/cookbook/5.0/images/SignalDateTime.png?241112193154)

{{< recipe-sp5 sourceUrl="https://github.com/ScottPlot/ScottPlot/blob/main/src/ScottPlot5/ScottPlot5%20Cookbook/Recipes/PlotTypes/Signal.cs" imageUrl="/cookbook/5.0/images/SignalDateTime.png?241112193154" >}}ScottPlot.Plot myPlot = new();

DateTime start = new(2024, 1, 1);
double[] ys = Generate.RandomWalk(200);

var sig = myPlot.Add.Signal(ys);
sig.Data.XOffset = start.ToOADate();
sig.Data.Period = 1.0; // one day between each point

myPlot.Axes.DateTimeTicksBottom();

myPlot.SavePng("demo.png", 400, 300);
{{< /recipe-sp5 >}}

<div class='my-5 text-center'>This recipe is one of many in the <a href='/cookbook/5.0/Signal'>Signal Plot</a> category</div>


