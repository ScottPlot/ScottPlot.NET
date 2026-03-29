---
Title: Signal Plot Performance - ScottPlot 5 Cookbook
Description: Signal plots are so performant that they can interactively display millions of data points in real time.
URL: /cookbook/5/ScottPlotQuickstart/SignalPerformance/
BreadcrumbNames: ["ScottPlot 5 Cookbook", "Quickstart", "Signal Plot Performance"]
BreadcrumbUrls: ["/cookbook/5/", "/cookbook/5/ScottPlotQuickstart", "/cookbook/5/ScottPlotQuickstart/SignalPerformance"]
Date: 2026-03-29
Version: ScottPlot 5.1.58
Version: ScottPlot 5.1.58
SearchUrl: "/cookbook/5/search/"
ShowEditLink: false
---


<div class='d-flex align-items-center mt-5'>
<h1 class='me-2 text-dark my-0 border-0'>Signal Plot Performance</h1>
</div>

Signal plots are so performant that they can interactively display millions of data points in real time.

[![](/cookbook/5/images/SignalPerformance.png?260329072039)](/cookbook/5/images/SignalPerformance.png?260329072039)

{{< recipe-sp5 sourceUrl="https://github.com/ScottPlot/ScottPlot/blob/main/src/ScottPlot5/ScottPlot5%20Cookbook/Recipes/General/Quickstart.cs" imageUrl="/cookbook/5/images/SignalPerformance.png?260329072039" >}}ScottPlot.Plot myPlot = new();

// create sample data with one million points
double[] data = Generate.RandomWalk(1_000_000);

// add a signal plot to the plot
myPlot.Add.Signal(data);

myPlot.SavePng("demo.png", 400, 300);
{{< /recipe-sp5 >}}

<div class='my-5 text-center'>This recipe is one of many in the <a href='/cookbook/5/ScottPlotQuickstart'>Quickstart</a> category</div>


