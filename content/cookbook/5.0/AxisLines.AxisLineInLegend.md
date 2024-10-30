---
Title: Axis Line In Legend - ScottPlot 5.0 Cookbook
Description: Axis lines will be added to the legend if their Text property is set unless their ExcludeFromLegend property is true.
URL: /cookbook/5.0/AxisLines/AxisLineInLegend/
BreadcrumbNames: ["ScottPlot 5.0 Cookbook", "Axis Lines", "Axis Line In Legend"]
BreadcrumbUrls: ["/cookbook/5.0/", "/cookbook/5.0/AxisLines", "/cookbook/5.0/AxisLines/AxisLineInLegend"]
Date: 2024-10-30
Version: ScottPlot 5.0.42
Version: ScottPlot 5.0.42
SearchUrl: "/cookbook/5.0/search/"
ShowEditLink: false
---


<h2 style='border-bottom: 0;'><a href='/cookbook/5.0/AxisLines/AxisLineInLegend'>Axis Line In Legend</a></h2>

<div class="d-flex mb-2">
<a class="btn btn-sm btn-primary me-1" href="/cookbook/5.0/AxisLines/AxisLineInLegend">Recipe Permalink</a>
<a class="btn btn-sm btn-success me-1" href="/cookbook/5.0/AxisLines">Category: Axis Lines</a>
</div>

Axis lines will be added to the legend if their Text property is set unless their ExcludeFromLegend property is true.

[![](/cookbook/5.0/images/AxisLineInLegend.png?241029205813)](/cookbook/5.0/images/AxisLineInLegend.png?241029205813)

{{< recipe-sp5 >}}ScottPlot.Plot myPlot = new();

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

<hr class='my-5 invisible'>


