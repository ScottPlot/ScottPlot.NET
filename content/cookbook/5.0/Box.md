---
Title: Box Plot - ScottPlot 5.0 Cookbook
Description: Box plots show a distribution at a glance
URL: /cookbook/5.0/Box/
BreadcrumbNames: ["ScottPlot 5.0 Cookbook", "Box Plot"]
BreadcrumbUrls: ["/cookbook/5.0/", "/cookbook/5.0/Box"]
Date: 2024-11-24
Version: ScottPlot 5.0.47
Version: ScottPlot 5.0.47
SearchUrl: "/cookbook/5.0/search/"
ShowEditLink: false
---

<h1>Box Plot</h1>


<div class='d-flex align-items-center mt-5'>
<h1 class='me-2 text-dark my-0 border-0'>Box Plot Quickstart</h1>
<a href='/cookbook/5.0/Box/BoxPlotQuickstart' target='_blank'>
<img src='/images/icons/new-window.svg' style='height: 2rem;' class='new-window-icon'>
</a>
</div>

Box plots can be created individually and added to the plot.

[![](/cookbook/5.0/images/BoxPlotQuickstart.png?241124170640)](/cookbook/5.0/images/BoxPlotQuickstart.png?241124170640)

{{< recipe-sp5 sourceUrl="https://github.com/ScottPlot/ScottPlot/blob/main/src/ScottPlot5/ScottPlot5%20Cookbook/Recipes/PlotTypes/Box.cs" imageUrl="/cookbook/5.0/images/BoxPlotQuickstart.png?241124170640" >}}ScottPlot.Plot myPlot = new();

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

<hr class='my-5 invisible'>



<div class='d-flex align-items-center mt-5'>
<h1 class='me-2 text-dark my-0 border-0'>Box Plot Groups</h1>
<a href='/cookbook/5.0/Box/BoxPlotGroups' target='_blank'>
<img src='/images/icons/new-window.svg' style='height: 2rem;' class='new-window-icon'>
</a>
</div>

Each collection of boxes added to the plot gets styled the same and appears as a single item in the legend. Add multiple bar series plots with defined X positions to give the appearance of grouped data.

[![](/cookbook/5.0/images/BoxPlotGroups.png?241124170640)](/cookbook/5.0/images/BoxPlotGroups.png?241124170640)

{{< recipe-sp5 sourceUrl="https://github.com/ScottPlot/ScottPlot/blob/main/src/ScottPlot5/ScottPlot5%20Cookbook/Recipes/PlotTypes/Box.cs" imageUrl="/cookbook/5.0/images/BoxPlotGroups.png?241124170640" >}}ScottPlot.Plot myPlot = new();

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

<hr class='my-5 invisible'>


