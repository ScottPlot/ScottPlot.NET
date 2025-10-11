---
Title: Signal Plot - ScottPlot 5 Cookbook
Description: Signal plots display Y values at evenly spaced X positions. Signal plots should be used instead of Scatter plots whenever possible.
URL: /cookbook/5/ScottPlotQuickstart/QuickstartSignal/
BreadcrumbNames: ["ScottPlot 5 Cookbook", "Quickstart", "Signal Plot"]
BreadcrumbUrls: ["/cookbook/5/", "/cookbook/5/ScottPlotQuickstart", "/cookbook/5/ScottPlotQuickstart/QuickstartSignal"]
Date: 2025-10-11
Version: ScottPlot 5.1.57
Version: ScottPlot 5.1.57
SearchUrl: "/cookbook/5/search/"
ShowEditLink: false
---


<div class='d-flex align-items-center mt-5'>
<h1 class='me-2 text-dark my-0 border-0'>Signal Plot</h1>
</div>

Signal plots display Y values at evenly spaced X positions. Signal plots should be used instead of Scatter plots whenever possible.

[![](/cookbook/5/images/QuickstartSignal.png?251011113742)](/cookbook/5/images/QuickstartSignal.png?251011113742)

{{< recipe-sp5 sourceUrl="https://github.com/ScottPlot/ScottPlot/blob/main/src/ScottPlot5/ScottPlot5%20Cookbook/Recipes/General/Quickstart.cs" imageUrl="/cookbook/5/images/QuickstartSignal.png?251011113742" >}}ScottPlot.Plot myPlot = new();

// create sample data
double[] sin = Generate.Sin(51);

// add a signal plot to the plot
myPlot.Add.Signal(sin);

myPlot.SavePng("demo.png", 400, 300);
{{< /recipe-sp5 >}}

<div class='my-5 text-center'>This recipe is one of many in the <a href='/cookbook/5/ScottPlotQuickstart'>Quickstart</a> category</div>


