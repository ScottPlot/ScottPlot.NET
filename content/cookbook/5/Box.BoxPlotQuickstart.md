---
Title: Box Plot Quickstart - ScottPlot 5 Cookbook
Description: Box plots can be created individually and added to the plot.
URL: /cookbook/5/Box/BoxPlotQuickstart/
BreadcrumbNames: ["ScottPlot 5 Cookbook", "Box Plot", "Box Plot Quickstart"]
BreadcrumbUrls: ["/cookbook/5/", "/cookbook/5/Box", "/cookbook/5/Box/BoxPlotQuickstart"]
Date: 2026-03-29
Version: ScottPlot 5.1.58
Version: ScottPlot 5.1.58
SearchUrl: "/cookbook/5/search/"
ShowEditLink: false
---


<div class='d-flex align-items-center mt-5'>
<h1 class='me-2 text-dark my-0 border-0'>Box Plot Quickstart</h1>
</div>

Box plots can be created individually and added to the plot.

[![](/cookbook/5/images/BoxPlotQuickstart.png?260329072039)](/cookbook/5/images/BoxPlotQuickstart.png?260329072039)

{{< recipe-sp5 sourceUrl="https://github.com/ScottPlot/ScottPlot/blob/main/src/ScottPlot5/ScottPlot5%20Cookbook/Recipes/PlotTypes/Box.cs" imageUrl="/cookbook/5/images/BoxPlotQuickstart.png?260329072039" >}}ScottPlot.Plot myPlot = new();

ScottPlot.Box box = new()
{
    Position = 5,
    BoxMin = 81,
    BoxMax = 93,
    WhiskerMin = 76,
    WhiskerMax = 107,
    BoxMiddle = 84,
};

myPlot.Add.Box(box);

myPlot.Axes.SetLimits(0, 10, 70, 110);

myPlot.SavePng("demo.png", 400, 300);
{{< /recipe-sp5 >}}

<div class='my-5 text-center'>This recipe is one of many in the <a href='/cookbook/5/Box'>Box Plot</a> category</div>


