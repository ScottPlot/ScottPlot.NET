---
Title: ScaleBar Quickstart - ScottPlot 5.0 Cookbook
Description: A ScaleBar can be added to a plot to convey scale information allowing axis frames, ticks, and labels to be hidden.
URL: /cookbook/5.0/ScaleBar/ScaleBarQuickstart/
BreadcrumbNames: ["ScottPlot 5.0 Cookbook", "Scale Bar", "ScaleBar Quickstart"]
BreadcrumbUrls: ["/cookbook/5.0/", "/cookbook/5.0/ScaleBar", "/cookbook/5.0/ScaleBar/ScaleBarQuickstart"]
Date: 2024-10-30
Version: ScottPlot 5.0.42
Version: ScottPlot 5.0.42
SearchUrl: "/cookbook/5.0/search/"
ShowEditLink: false
---


<h2 style='border-bottom: 0;'><a href='/cookbook/5.0/ScaleBar/ScaleBarQuickstart'>ScaleBar Quickstart</a></h2>

<div class="d-flex mb-2">
<a class="btn btn-sm btn-primary me-1" href="/cookbook/5.0/ScaleBar/ScaleBarQuickstart">Recipe Permalink</a>
<a class="btn btn-sm btn-success me-1" href="/cookbook/5.0/ScaleBar">Category: Scale Bar</a>
</div>

A ScaleBar can be added to a plot to convey scale information allowing axis frames, ticks, and labels to be hidden.

[![](/cookbook/5.0/images/ScaleBarQuickstart.png?241029205813)](/cookbook/5.0/images/ScaleBarQuickstart.png?241029205813)

{{< recipe-sp5 >}}ScottPlot.Plot myPlot = new();

// plot sample data
myPlot.Add.Signal(Generate.Sin());
myPlot.Add.Signal(Generate.Cos());

// add a scale bar
myPlot.Add.ScaleBar(5, 0.25);

// disable the grid and axis labels
myPlot.HideGrid();
myPlot.Axes.Frameless();

myPlot.SavePng("demo.png", 400, 300);
{{< /recipe-sp5 >}}

<hr class='my-5 invisible'>


