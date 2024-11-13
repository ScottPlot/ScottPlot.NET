---
Title: Axis Labels - ScottPlot 5.0 Cookbook
Description: Plots have helper methods for quickly setting axis labels. Refer to other cookbook pages for additional axis customization options.
URL: /cookbook/5.0/ScottPlotQuickstart/QuickstartAxisLabels/
BreadcrumbNames: ["ScottPlot 5.0 Cookbook", "Quickstart", "Axis Labels"]
BreadcrumbUrls: ["/cookbook/5.0/", "/cookbook/5.0/ScottPlotQuickstart", "/cookbook/5.0/ScottPlotQuickstart/QuickstartAxisLabels"]
Date: 2024-11-13
Version: ScottPlot 5.0.45
Version: ScottPlot 5.0.45
SearchUrl: "/cookbook/5.0/search/"
ShowEditLink: false
---


<div class='d-flex align-items-center mt-5'>
<h1 class='me-2 text-dark my-0 border-0'>Axis Labels</h1>
</div>

Plots have helper methods for quickly setting axis labels. Refer to other cookbook pages for additional axis customization options.

[![](/cookbook/5.0/images/QuickstartAxisLabels.png?241112193154)](/cookbook/5.0/images/QuickstartAxisLabels.png?241112193154)

{{< recipe-sp5 sourceUrl="https://github.com/ScottPlot/ScottPlot/blob/main/src/ScottPlot5/ScottPlot5%20Cookbook/Recipes/General/Quickstart.cs" imageUrl="/cookbook/5.0/images/QuickstartAxisLabels.png?241112193154" >}}ScottPlot.Plot myPlot = new();

// plot sample data
myPlot.Add.Signal(Generate.Sin(51));
myPlot.Add.Signal(Generate.Cos(51));

// customize axis labels
myPlot.XLabel("Horizonal Axis");
myPlot.YLabel("Vertical Axis");
myPlot.Title("Plot Title");

myPlot.SavePng("demo.png", 400, 300);
{{< /recipe-sp5 >}}

<div class='my-5 text-center'>This recipe is one of many in the <a href='/cookbook/5.0/ScottPlotQuickstart'>Quickstart</a> category</div>


