---
Title: ScaleBar Styling - ScottPlot 5 Cookbook
Description: The ScaleBar has many properties which may be customized 
URL: /cookbook/5/ScaleBar/ScaleBarStyling/
BreadcrumbNames: ["ScottPlot 5 Cookbook", "Scale Bar", "ScaleBar Styling"]
BreadcrumbUrls: ["/cookbook/5/", "/cookbook/5/ScaleBar", "/cookbook/5/ScaleBar/ScaleBarStyling"]
Date: 2025-10-11
Version: ScottPlot 5.1.57
Version: ScottPlot 5.1.57
SearchUrl: "/cookbook/5/search/"
ShowEditLink: false
---


<div class='d-flex align-items-center mt-5'>
<h1 class='me-2 text-dark my-0 border-0'>ScaleBar Styling</h1>
</div>

The ScaleBar has many properties which may be customized 

[![](/cookbook/5/images/ScaleBarStyling.png?251011113742)](/cookbook/5/images/ScaleBarStyling.png?251011113742)

{{< recipe-sp5 sourceUrl="https://github.com/ScottPlot/ScottPlot/blob/main/src/ScottPlot5/ScottPlot5%20Cookbook/Recipes/PlotTypes/ScaleBar.cs" imageUrl="/cookbook/5/images/ScaleBarStyling.png?251011113742" >}}ScottPlot.Plot myPlot = new();

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

<div class='my-5 text-center'>This recipe is one of many in the <a href='/cookbook/5/ScaleBar'>Scale Bar</a> category</div>


