---
Title: ScaleBar Labels - ScottPlot 5.0 Cookbook
Description: Text may be added to each dimension of an L shaped scalebar
URL: /cookbook/5.0/ScaleBar/ScaleBarLabels/
BreadcrumbNames: ["ScottPlot 5.0 Cookbook", "Scale Bar", "ScaleBar Labels"]
BreadcrumbUrls: ["/cookbook/5.0/", "/cookbook/5.0/ScaleBar", "/cookbook/5.0/ScaleBar/ScaleBarLabels"]
Date: 2024-11-03
Version: ScottPlot 5.0.43
Version: ScottPlot 5.0.43
SearchUrl: "/cookbook/5.0/search/"
ShowEditLink: false
---


<div class='d-flex align-items-center mt-5'>
<h1 class='me-2 text-dark my-0 border-0'>ScaleBar Labels</h1>
</div>

Text may be added to each dimension of an L shaped scalebar

[![](/cookbook/5.0/images/ScaleBarLabels.png?241103171511)](/cookbook/5.0/images/ScaleBarLabels.png?241103171511)

{{< recipe-sp5 sourceUrl="https://github.com/ScottPlot/ScottPlot/blob/main/src/ScottPlot5/ScottPlot5%20Cookbook/Recipes/PlotTypes/ScaleBar.cs" imageUrl="/cookbook/5.0/images/ScaleBarLabels.png?241103171511" >}}ScottPlot.Plot myPlot = new();

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

<div class='my-5 text-center'>This recipe is one of many in the <a href='/cookbook/5.0/ScaleBar'>Scale Bar</a> category</div>


