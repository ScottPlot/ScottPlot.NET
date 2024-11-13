---
Title: ScaleBar Single Dimension - ScottPlot 5.0 Cookbook
Description: Set Width or Height to 0 to cause the ScaleBar to use a single axis only
URL: /cookbook/5.0/ScaleBar/ScaleBarSingleDimension/
BreadcrumbNames: ["ScottPlot 5.0 Cookbook", "Scale Bar", "ScaleBar Single Dimension"]
BreadcrumbUrls: ["/cookbook/5.0/", "/cookbook/5.0/ScaleBar", "/cookbook/5.0/ScaleBar/ScaleBarSingleDimension"]
Date: 2024-11-13
Version: ScottPlot 5.0.45
Version: ScottPlot 5.0.45
SearchUrl: "/cookbook/5.0/search/"
ShowEditLink: false
---


<div class='d-flex align-items-center mt-5'>
<h1 class='me-2 text-dark my-0 border-0'>ScaleBar Single Dimension</h1>
</div>

Set Width or Height to 0 to cause the ScaleBar to use a single axis only

[![](/cookbook/5.0/images/ScaleBarSingleDimension.png?241112193154)](/cookbook/5.0/images/ScaleBarSingleDimension.png?241112193154)

{{< recipe-sp5 sourceUrl="https://github.com/ScottPlot/ScottPlot/blob/main/src/ScottPlot5/ScottPlot5%20Cookbook/Recipes/PlotTypes/ScaleBar.cs" imageUrl="/cookbook/5.0/images/ScaleBarSingleDimension.png?241112193154" >}}ScottPlot.Plot myPlot = new();

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

<div class='my-5 text-center'>This recipe is one of many in the <a href='/cookbook/5.0/ScaleBar'>Scale Bar</a> category</div>


