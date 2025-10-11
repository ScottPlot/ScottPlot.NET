---
Title: Axis Line In Legend - ScottPlot 5 Cookbook
Description: Axis lines will be added to the legend if their Text property is set unless their ExcludeFromLegend property is true.
URL: /cookbook/5/AxisLines/AxisLineInLegend/
BreadcrumbNames: ["ScottPlot 5 Cookbook", "Axis Lines", "Axis Line In Legend"]
BreadcrumbUrls: ["/cookbook/5/", "/cookbook/5/AxisLines", "/cookbook/5/AxisLines/AxisLineInLegend"]
Date: 2025-10-11
Version: ScottPlot 5.1.57
Version: ScottPlot 5.1.57
SearchUrl: "/cookbook/5/search/"
ShowEditLink: false
---


<div class='d-flex align-items-center mt-5'>
<h1 class='me-2 text-dark my-0 border-0'>Axis Line In Legend</h1>
</div>

Axis lines will be added to the legend if their Text property is set unless their ExcludeFromLegend property is true.

[![](/cookbook/5/images/AxisLineInLegend.png?251011113742)](/cookbook/5/images/AxisLineInLegend.png?251011113742)

{{< recipe-sp5 sourceUrl="https://github.com/ScottPlot/ScottPlot/blob/main/src/ScottPlot5/ScottPlot5%20Cookbook/Recipes/PlotTypes/AxisLines.cs" imageUrl="/cookbook/5/images/AxisLineInLegend.png?251011113742" >}}ScottPlot.Plot myPlot = new();

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

<div class='my-5 text-center'>This recipe is one of many in the <a href='/cookbook/5/AxisLines'>Axis Lines</a> category</div>


