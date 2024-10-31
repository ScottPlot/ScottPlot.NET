---
Title: ScaleBar Styling - ScottPlot 5.0 Cookbook
Description: The ScaleBar has many properties which may be customized 
URL: /cookbook/5.0/ScaleBar/ScaleBarStyling/
BreadcrumbNames: ["ScottPlot 5.0 Cookbook", "Scale Bar", "ScaleBar Styling"]
BreadcrumbUrls: ["/cookbook/5.0/", "/cookbook/5.0/ScaleBar", "/cookbook/5.0/ScaleBar/ScaleBarStyling"]
Date: 2024-10-31
Version: ScottPlot 5.0.42
Version: ScottPlot 5.0.42
SearchUrl: "/cookbook/5.0/search/"
ShowEditLink: false
---


<h2 style='border-bottom: 0;'><a href='/cookbook/5.0/ScaleBar/ScaleBarStyling'>ScaleBar Styling</a></h2>

<div class="d-flex mb-2">
<a class="btn btn-sm btn-primary me-1" href="/cookbook/5.0/ScaleBar/ScaleBarStyling">Recipe Permalink</a>
<a class="btn btn-sm btn-success me-1" href="/cookbook/5.0/ScaleBar">Category: Scale Bar</a>
</div>

The ScaleBar has many properties which may be customized 

[![](/cookbook/5.0/images/ScaleBarStyling.png?241031194635)](/cookbook/5.0/images/ScaleBarStyling.png?241031194635)

{{< recipe-sp5 >}}ScottPlot.Plot myPlot = new();

// plot sample data
myPlot.Add.Signal(Generate.Sin());
myPlot.Add.Signal(Generate.Cos());

// add a scale bar
var scalebar = myPlot.Add.ScaleBar(5, 0.25);
scalebar.LineWidth = 5;
scalebar.LineColor = Colors.Magenta;

// disable the grid and axis labels
myPlot.HideGrid();
myPlot.Axes.Frameless();

myPlot.SavePng("demo.png", 400, 300);
{{< /recipe-sp5 >}}

<hr class='my-5 invisible'>


