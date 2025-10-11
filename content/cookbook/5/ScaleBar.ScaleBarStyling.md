---
Title: ScaleBar Styling - ScottPlot 5.0 Cookbook
Description: The ScaleBar has many properties which may be customized 
URL: /cookbook/5.0/ScaleBar/ScaleBarStyling/
BreadcrumbNames: ["ScottPlot 5.0 Cookbook", "Scale Bar", "ScaleBar Styling"]
BreadcrumbUrls: ["/cookbook/5.0/", "/cookbook/5.0/ScaleBar", "/cookbook/5.0/ScaleBar/ScaleBarStyling"]
Date: 2025-01-26
Version: ScottPlot 5.0.55
Version: ScottPlot 5.0.55
SearchUrl: "/cookbook/5.0/search/"
ShowEditLink: false
---


<div class='d-flex align-items-center mt-5'>
<h1 class='me-2 text-dark my-0 border-0'>ScaleBar Styling</h1>
</div>

The ScaleBar has many properties which may be customized 

[![](/cookbook/5.0/images/ScaleBarStyling.png?250126165944)](/cookbook/5.0/images/ScaleBarStyling.png?250126165944)

{{< recipe-sp5 sourceUrl="https://github.com/ScottPlot/ScottPlot/blob/main/src/ScottPlot5/ScottPlot5%20Cookbook/Recipes/PlotTypes/ScaleBar.cs" imageUrl="/cookbook/5.0/images/ScaleBarStyling.png?250126165944" >}}ScottPlot.Plot myPlot = new();

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

<div class='my-5 text-center'>This recipe is one of many in the <a href='/cookbook/5.0/ScaleBar'>Scale Bar</a> category</div>


