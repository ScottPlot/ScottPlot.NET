---
Title: Box Plot Groups - ScottPlot 5 Cookbook
Description: Each collection of boxes added to the plot gets styled the same and appears as a single item in the legend. Add multiple bar series plots with defined X positions to give the appearance of grouped data.
URL: /cookbook/5/Box/BoxPlotGroups/
BreadcrumbNames: ["ScottPlot 5 Cookbook", "Box Plot", "Box Plot Groups"]
BreadcrumbUrls: ["/cookbook/5/", "/cookbook/5/Box", "/cookbook/5/Box/BoxPlotGroups"]
Date: 2026-03-29
Version: ScottPlot 5.1.58
Version: ScottPlot 5.1.58
SearchUrl: "/cookbook/5/search/"
ShowEditLink: false
---


<div class='d-flex align-items-center mt-5'>
<h1 class='me-2 text-dark my-0 border-0'>Box Plot Groups</h1>
</div>

Each collection of boxes added to the plot gets styled the same and appears as a single item in the legend. Add multiple bar series plots with defined X positions to give the appearance of grouped data.

[![](/cookbook/5/images/BoxPlotGroups.png?260329072039)](/cookbook/5/images/BoxPlotGroups.png?260329072039)

{{< recipe-sp5 sourceUrl="https://github.com/ScottPlot/ScottPlot/blob/main/src/ScottPlot5/ScottPlot5%20Cookbook/Recipes/PlotTypes/Box.cs" imageUrl="/cookbook/5/images/BoxPlotGroups.png?260329072039" >}}ScottPlot.Plot myPlot = new();

List&lt;ScottPlot.Box&gt; boxes1 = new() {
    Generate.RandomBox(1),
    Generate.RandomBox(2),
    Generate.RandomBox(3),
};

List&lt;ScottPlot.Box&gt; boxes2 = new() {
    Generate.RandomBox(5),
    Generate.RandomBox(6),
    Generate.RandomBox(7),
};

var bp1 = myPlot.Add.Boxes(boxes1);
bp1.LegendText = "Group 1";

var bp2 = myPlot.Add.Boxes(boxes2);
bp2.LegendText = "Group 2";

myPlot.ShowLegend(Alignment.UpperRight);

myPlot.SavePng("demo.png", 400, 300);
{{< /recipe-sp5 >}}

<div class='my-5 text-center'>This recipe is one of many in the <a href='/cookbook/5/Box'>Box Plot</a> category</div>


