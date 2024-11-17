---
Title: Axis Line In Legend - ScottPlot 5.0 Cookbook
Description: Axis lines will be added to the legend if their Text property is set unless their ExcludeFromLegend property is true.
URL: /cookbook/5.0/AxisLines/AxisLineInLegend/
BreadcrumbNames: ["ScottPlot 5.0 Cookbook", "Axis Lines", "Axis Line In Legend"]
BreadcrumbUrls: ["/cookbook/5.0/", "/cookbook/5.0/AxisLines", "/cookbook/5.0/AxisLines/AxisLineInLegend"]
Date: 2024-11-17
Version: ScottPlot 5.0.46
Version: ScottPlot 5.0.46
SearchUrl: "/cookbook/5.0/search/"
ShowEditLink: false
---


<div class='d-flex align-items-center mt-5'>
<h1 class='me-2 text-dark my-0 border-0'>Axis Line In Legend</h1>
</div>

Axis lines will be added to the legend if their Text property is set unless their ExcludeFromLegend property is true.

[![](/cookbook/5.0/images/AxisLineInLegend.png?241117162641)](/cookbook/5.0/images/AxisLineInLegend.png?241117162641)

{{< recipe-sp5 sourceUrl="https://github.com/ScottPlot/ScottPlot/blob/main/src/ScottPlot5/ScottPlot5%20Cookbook/Recipes/PlotTypes/AxisLines.cs" imageUrl="/cookbook/5.0/images/AxisLineInLegend.png?241117162641" >}}ScottPlot.Plot myPlot = new();

myPlot.Add.Signal(Generate.Sin());
myPlot.Add.Signal(Generate.Cos());

var axLine1 = myPlot.Add.VerticalLine(24);
axLine1.Text = "Line 1";

var axLine2 = myPlot.Add.HorizontalLine(0.75);

var axLine3 = myPlot.Add.VerticalLine(37);
axLine3.Text = "Line 3";
axLine3.ExcludeFromLegend = true;

var axLine4 = myPlot.Add.HorizontalLine(0.25);
axLine4.Text = "Line 4";

var axLine5 = myPlot.Add.HorizontalLine(-.75);
axLine5.Text = "Line 5";
axLine5.ExcludeFromLegend = true;

myPlot.ShowLegend();

myPlot.SavePng("demo.png", 400, 300);
{{< /recipe-sp5 >}}

<div class='my-5 text-center'>This recipe is one of many in the <a href='/cookbook/5.0/AxisLines'>Axis Lines</a> category</div>


