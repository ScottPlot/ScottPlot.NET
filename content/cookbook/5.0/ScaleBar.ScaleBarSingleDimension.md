---
Title: ScaleBar Single Dimension - ScottPlot 5.0 Cookbook
Description: Set Width or Height to 0 to cause the ScaleBar to use a single axis only
URL: /cookbook/5.0/ScaleBar/ScaleBarSingleDimension/
BreadcrumbNames: ["ScottPlot 5.0 Cookbook", "Scale Bar", "ScaleBar Single Dimension"]
BreadcrumbUrls: ["/cookbook/5.0/", "/cookbook/5.0/ScaleBar", "/cookbook/5.0/ScaleBar/ScaleBarSingleDimension"]
Date: 2024-10-31
Version: ScottPlot 5.0.42
Version: ScottPlot 5.0.42
SearchUrl: "/cookbook/5.0/search/"
ShowEditLink: false
---


<h2 style='border-bottom: 0;'><a href='/cookbook/5.0/ScaleBar/ScaleBarSingleDimension'>ScaleBar Single Dimension</a></h2>

<div class="d-flex mb-2">
<a class="btn btn-sm btn-primary me-1" href="/cookbook/5.0/ScaleBar/ScaleBarSingleDimension">Recipe Permalink</a>
<a class="btn btn-sm btn-success me-1" href="/cookbook/5.0/ScaleBar">Category: Scale Bar</a>
</div>

Set Width or Height to 0 to cause the ScaleBar to use a single axis only

[![](/cookbook/5.0/images/ScaleBarSingleDimension.png?241031194635)](/cookbook/5.0/images/ScaleBarSingleDimension.png?241031194635)

{{< recipe-sp5 >}}ScottPlot.Plot myPlot = new();

// plot sample data
myPlot.Add.Signal(Generate.Sin());
myPlot.Add.Signal(Generate.Cos());

// add a scale bar
var scalebar = myPlot.Add.ScaleBar(7, 0);
scalebar.LineWidth = 2;
scalebar.XLabel = "70 ms";
scalebar.XLabelStyle.Bold = true;
scalebar.LabelPadding = new(0);

// disable the grid and axis labels
myPlot.HideGrid();
myPlot.Axes.Frameless();

myPlot.SavePng("demo.png", 400, 300);
{{< /recipe-sp5 >}}

<hr class='my-5 invisible'>


