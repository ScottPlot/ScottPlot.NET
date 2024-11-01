---
Title: Box Plot Groups - ScottPlot 5.0 Cookbook
Description: Each collection of boxes added to the plot gets styled the same and appears as a single item in the legend. Add multiple bar series plots with defined X positions to give the appearance of grouped data.
URL: /cookbook/5.0/Box/BoxPlotGroups/
BreadcrumbNames: ["ScottPlot 5.0 Cookbook", "Box Plot", "Box Plot Groups"]
BreadcrumbUrls: ["/cookbook/5.0/", "/cookbook/5.0/Box", "/cookbook/5.0/Box/BoxPlotGroups"]
Date: 2024-11-01
Version: ScottPlot 5.0.42
Version: ScottPlot 5.0.42
SearchUrl: "/cookbook/5.0/search/"
ShowEditLink: false
---


<div class='d-flex align-items-center mt-5'>
<h1 class='me-2 text-dark my-0 border-0'>Box Plot Groups</h1>
</div>

Each collection of boxes added to the plot gets styled the same and appears as a single item in the legend. Add multiple bar series plots with defined X positions to give the appearance of grouped data.

[![](/cookbook/5.0/images/BoxPlotGroups.png?241101192719)](/cookbook/5.0/images/BoxPlotGroups.png?241101192719)

{{< recipe-sp5 >}}ScottPlot.Plot myPlot = new();

List<ScottPlot.Box> boxes1 = new() {
    Generate.RandomBox(1),
    Generate.RandomBox(2),
    Generate.RandomBox(3),
};

List<ScottPlot.Box> boxes2 = new() {
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

<div class='my-5 text-center'>This recipe is one of many in the <a href='/cookbook/5.0/Box'>Box Plot</a> category</div>


