---
Title: Signal Plot Quickstart - ScottPlot 5 Cookbook
Description: Signal plots are best for extremely large datasets. They use render using special optimizations that allow highspeed interactivity with plots containing millions of data points.
URL: /cookbook/5/Signal/SignalQuickstart/
BreadcrumbNames: ["ScottPlot 5 Cookbook", "Signal Plot", "Signal Plot Quickstart"]
BreadcrumbUrls: ["/cookbook/5/", "/cookbook/5/Signal", "/cookbook/5/Signal/SignalQuickstart"]
Date: 2025-10-11
Version: ScottPlot 5.1.57
Version: ScottPlot 5.1.57
SearchUrl: "/cookbook/5/search/"
ShowEditLink: false
---


<div class='d-flex align-items-center mt-5'>
<h1 class='me-2 text-dark my-0 border-0'>Signal Plot Quickstart</h1>
</div>

Signal plots are best for extremely large datasets. They use render using special optimizations that allow highspeed interactivity with plots containing millions of data points.

[![](/cookbook/5/images/SignalQuickstart.png?251011113742)](/cookbook/5/images/SignalQuickstart.png?251011113742)

{{< recipe-sp5 sourceUrl="https://github.com/ScottPlot/ScottPlot/blob/main/src/ScottPlot5/ScottPlot5%20Cookbook/Recipes/PlotTypes/Signal.cs" imageUrl="/cookbook/5/images/SignalQuickstart.png?251011113742" >}}ScottPlot.Plot myPlot = new();

double[] values = Generate.RandomWalk(1_000_000);

myPlot.Add.Signal(values);

myPlot.Title("Signal Plot with 1 Million Points");

myPlot.SavePng("demo.png", 400, 300);
{{< /recipe-sp5 >}}

<div class='my-5 text-center'>This recipe is one of many in the <a href='/cookbook/5/Signal'>Signal Plot</a> category</div>


