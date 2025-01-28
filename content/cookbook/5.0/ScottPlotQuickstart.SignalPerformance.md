---
Title: Signal Plot Performance - ScottPlot 5.0 Cookbook
Description: Signal plots are so performant that they can interactively display millions of data points in real time.
URL: /cookbook/5.0/ScottPlotQuickstart/SignalPerformance/
BreadcrumbNames: ["ScottPlot 5.0 Cookbook", "Quickstart", "Signal Plot Performance"]
BreadcrumbUrls: ["/cookbook/5.0/", "/cookbook/5.0/ScottPlotQuickstart", "/cookbook/5.0/ScottPlotQuickstart/SignalPerformance"]
Date: 2025-01-26
Version: ScottPlot 5.0.55
Version: ScottPlot 5.0.55
SearchUrl: "/cookbook/5.0/search/"
ShowEditLink: false
---


<div class='d-flex align-items-center mt-5'>
<h1 class='me-2 text-dark my-0 border-0'>Signal Plot Performance</h1>
</div>

Signal plots are so performant that they can interactively display millions of data points in real time.

[![](/cookbook/5.0/images/SignalPerformance.png?250126165944)](/cookbook/5.0/images/SignalPerformance.png?250126165944)

{{< recipe-sp5 sourceUrl="https://github.com/ScottPlot/ScottPlot/blob/main/src/ScottPlot5/ScottPlot5%20Cookbook/Recipes/General/Quickstart.cs" imageUrl="/cookbook/5.0/images/SignalPerformance.png?250126165944" >}}ScottPlot.Plot myPlot = new();

// create sample data with one million points
double[] data = Generate.RandomWalk(1_000_000);

// add a signal plot to the plot
myPlot.Add.Signal(data);

myPlot.SavePng("demo.png", 400, 300);
{{< /recipe-sp5 >}}

<div class='my-5 text-center'>This recipe is one of many in the <a href='/cookbook/5.0/ScottPlotQuickstart'>Quickstart</a> category</div>


