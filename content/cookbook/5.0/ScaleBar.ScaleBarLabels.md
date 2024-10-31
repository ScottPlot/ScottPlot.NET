---
Title: ScaleBar Labels - ScottPlot 5.0 Cookbook
Description: Text may be added to each dimension of an L shaped scalebar
URL: /cookbook/5.0/ScaleBar/ScaleBarLabels/
BreadcrumbNames: ["ScottPlot 5.0 Cookbook", "Scale Bar", "ScaleBar Labels"]
BreadcrumbUrls: ["/cookbook/5.0/", "/cookbook/5.0/ScaleBar", "/cookbook/5.0/ScaleBar/ScaleBarLabels"]
Date: 2024-10-31
Version: ScottPlot 5.0.42
Version: ScottPlot 5.0.42
SearchUrl: "/cookbook/5.0/search/"
ShowEditLink: false
---


<h2 style='border-bottom: 0;'><a href='/cookbook/5.0/ScaleBar/ScaleBarLabels'>ScaleBar Labels</a></h2>

<div class="d-flex mb-2">
<a class="btn btn-sm btn-primary me-1" href="/cookbook/5.0/ScaleBar/ScaleBarLabels">Recipe Permalink</a>
<a class="btn btn-sm btn-success me-1" href="/cookbook/5.0/ScaleBar">Category: Scale Bar</a>
</div>

Text may be added to each dimension of an L shaped scalebar

[![](/cookbook/5.0/images/ScaleBarLabels.png?241031194635)](/cookbook/5.0/images/ScaleBarLabels.png?241031194635)

{{< recipe-sp5 >}}ScottPlot.Plot myPlot = new();

// plot sample data
myPlot.Add.Signal(Generate.Sin());
myPlot.Add.Signal(Generate.Cos());

// add a scale bar
var scalebar = myPlot.Add.ScaleBar(5, 0.25);
scalebar.XLabel = "5 mV";
scalebar.YLabel = "1 µF";

// disable the grid and axis labels
myPlot.HideGrid();
myPlot.Axes.Frameless();

myPlot.SavePng("demo.png", 400, 300);
{{< /recipe-sp5 >}}

<hr class='my-5 invisible'>


