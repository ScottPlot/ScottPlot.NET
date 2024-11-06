---
Title: Signal Plot - ScottPlot 5.0 Cookbook
Description: Signal plots display Y values at evenly spaced X positions. Signal plots should be used instead of Scatter plots whenever possible.
URL: /cookbook/5.0/ScottPlotQuickstart/QuickstartSignal/
BreadcrumbNames: ["ScottPlot 5.0 Cookbook", "Quickstart", "Signal Plot"]
BreadcrumbUrls: ["/cookbook/5.0/", "/cookbook/5.0/ScottPlotQuickstart", "/cookbook/5.0/ScottPlotQuickstart/QuickstartSignal"]
Date: 2024-11-06
Version: ScottPlot 5.0.43
Version: ScottPlot 5.0.43
SearchUrl: "/cookbook/5.0/search/"
ShowEditLink: false
---


<div class='d-flex align-items-center mt-5'>
<h1 class='me-2 text-dark my-0 border-0'>Signal Plot</h1>
</div>

Signal plots display Y values at evenly spaced X positions. Signal plots should be used instead of Scatter plots whenever possible.

[![](/cookbook/5.0/images/QuickstartSignal.png?241105214550)](/cookbook/5.0/images/QuickstartSignal.png?241105214550)

{{< recipe-sp5 sourceUrl="https://github.com/ScottPlot/ScottPlot/blob/main/src/ScottPlot5/ScottPlot5%20Cookbook/Recipes/General/Quickstart.cs" imageUrl="/cookbook/5.0/images/QuickstartSignal.png?241105214550" >}}ScottPlot.Plot myPlot = new();

// create sample data
double[] sin = Generate.Sin(51);

// add a signal plot to the plot
myPlot.Add.Signal(sin);

myPlot.SavePng("demo.png", 400, 300);
{{< /recipe-sp5 >}}

<div class='my-5 text-center'>This recipe is one of many in the <a href='/cookbook/5.0/ScottPlotQuickstart'>Quickstart</a> category</div>


