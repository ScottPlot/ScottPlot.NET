---
Title: Pie Chart from Slices - ScottPlot 5.0 Cookbook
Description: A pie chart can be created from a collection of slices.
URL: /cookbook/5.0/Pie/PieSlices/
BreadcrumbNames: ["ScottPlot 5.0 Cookbook", "Pie", "Pie Chart from Slices"]
BreadcrumbUrls: ["/cookbook/5.0/", "/cookbook/5.0/Pie", "/cookbook/5.0/Pie/PieSlices"]
Date: 2024-11-06
Version: ScottPlot 5.0.43
Version: ScottPlot 5.0.43
SearchUrl: "/cookbook/5.0/search/"
ShowEditLink: false
---


<div class='d-flex align-items-center mt-5'>
<h1 class='me-2 text-dark my-0 border-0'>Pie Chart from Slices</h1>
</div>

A pie chart can be created from a collection of slices.

[![](/cookbook/5.0/images/PieSlices.png?241105214550)](/cookbook/5.0/images/PieSlices.png?241105214550)

{{< recipe-sp5 sourceUrl="https://github.com/ScottPlot/ScottPlot/blob/main/src/ScottPlot5/ScottPlot5%20Cookbook/Recipes/PlotTypes/Pie.cs" imageUrl="/cookbook/5.0/images/PieSlices.png?241105214550" >}}ScottPlot.Plot myPlot = new();

List&lt;PieSlice&gt; slices =
[
    new PieSlice() { Value = 5, FillColor = Colors.Red, Label = "Red", LegendText = "R" },
    new PieSlice() { Value = 2, FillColor = Colors.Orange, Label = "Orange" },
    new PieSlice() { Value = 8, FillColor = Colors.Gold, Label = "Yellow" },
    new PieSlice() { Value = 4, FillColor = Colors.Green, Label = "Green", LegendText = "G" },
    new PieSlice() { Value = 8, FillColor = Colors.Blue, Label = "Blue", LegendText = "B" },
];

var pie = myPlot.Add.Pie(slices);
pie.ExplodeFraction = .1;
pie.SliceLabelDistance = 1.4;

myPlot.ShowLegend();

// hide unnecessary plot components
myPlot.Axes.Frameless();
myPlot.HideGrid();

myPlot.SavePng("demo.png", 400, 300);
{{< /recipe-sp5 >}}

<div class='my-5 text-center'>This recipe is one of many in the <a href='/cookbook/5.0/Pie'>Pie</a> category</div>


