---
Title: Signal Plot Performance - ScottPlot 5.0 Cookbook
Description: Signal plots are so performant that they can interactively display millions of data points in real time.
URL: /cookbook/5.0/ScottPlotQuickstart/SignalPerformance/
BreadcrumbNames: ["ScottPlot 5.0 Cookbook", "Quickstart", "Signal Plot Performance"]
BreadcrumbUrls: ["/cookbook/5.0/", "/cookbook/5.0/ScottPlotQuickstart", "/cookbook/5.0/ScottPlotQuickstart/SignalPerformance"]
Date: 2024-10-30
Version: ScottPlot 5.0.42
Version: ScottPlot 5.0.42
SearchUrl: "/cookbook/5.0/search/"
ShowEditLink: false
---


<h2 style='border-bottom: 0;'><a href='/cookbook/5.0/ScottPlotQuickstart/SignalPerformance'>Signal Plot Performance</a></h2>

<div class="d-flex mb-2">
<a class="btn btn-sm btn-primary me-1" href="/cookbook/5.0/ScottPlotQuickstart/SignalPerformance">Recipe Permalink</a>
<a class="btn btn-sm btn-success me-1" href="/cookbook/5.0/ScottPlotQuickstart">Category: Quickstart</a>
</div>

Signal plots are so performant that they can interactively display millions of data points in real time.

[![](/cookbook/5.0/images/SignalPerformance.png?241029205813)](/cookbook/5.0/images/SignalPerformance.png?241029205813)

{{< recipe-sp5 >}}ScottPlot.Plot myPlot = new();

// create sample data with one million points
double[] data = Generate.RandomWalk(1_000_000);

// add a signal plot to the plot
myPlot.Add.Signal(data);

myPlot.SavePng("demo.png", 400, 300);
{{< /recipe-sp5 >}}

<hr class='my-5 invisible'>


