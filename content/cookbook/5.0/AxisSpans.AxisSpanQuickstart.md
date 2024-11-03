---
Title: Axis Span Quickstart - ScottPlot 5.0 Cookbook
Description: Axis spans label a range of an axis. Vertical spans shade the full width of a vertical range, and horizontal spans shade the full height of a horizontal range.
URL: /cookbook/5.0/AxisSpans/AxisSpanQuickstart/
BreadcrumbNames: ["ScottPlot 5.0 Cookbook", "Axis Spans", "Axis Span Quickstart"]
BreadcrumbUrls: ["/cookbook/5.0/", "/cookbook/5.0/AxisSpans", "/cookbook/5.0/AxisSpans/AxisSpanQuickstart"]
Date: 2024-11-03
Version: ScottPlot 5.0.43
Version: ScottPlot 5.0.43
SearchUrl: "/cookbook/5.0/search/"
ShowEditLink: false
---


<div class='d-flex align-items-center mt-5'>
<h1 class='me-2 text-dark my-0 border-0'>Axis Span Quickstart</h1>
</div>

Axis spans label a range of an axis. Vertical spans shade the full width of a vertical range, and horizontal spans shade the full height of a horizontal range.

[![](/cookbook/5.0/images/AxisSpanQuickstart.png?241103171511)](/cookbook/5.0/images/AxisSpanQuickstart.png?241103171511)

{{< recipe-sp5 sourceUrl="https://github.com/ScottPlot/ScottPlot/blob/main/src/ScottPlot5/ScottPlot5%20Cookbook/Recipes/PlotTypes/AxisSpans.cs" imageUrl="/cookbook/5.0/images/AxisSpanQuickstart.png?241103171511" >}}ScottPlot.Plot myPlot = new();

myPlot.Add.Signal(Generate.Sin());
myPlot.Add.Signal(Generate.Cos());

var hSpan = myPlot.Add.HorizontalSpan(10, 20);
var vSpan = myPlot.Add.VerticalSpan(0.25, 0.75);

hSpan.LegendText = "Horizontal Span";
vSpan.LegendText = "Vertical Span";
myPlot.ShowLegend();

myPlot.SavePng("demo.png", 400, 300);
{{< /recipe-sp5 >}}

<div class='my-5 text-center'>This recipe is one of many in the <a href='/cookbook/5.0/AxisSpans'>Axis Spans</a> category</div>


