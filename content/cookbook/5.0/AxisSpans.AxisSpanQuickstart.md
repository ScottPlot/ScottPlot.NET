---
Title: Axis Span Quickstart - ScottPlot 5.0 Cookbook
Description: Axis spans label a range of an axis. Vertical spans shade the full width of a vertical range, and horizontal spans shade the full height of a horizontal range.
URL: /cookbook/5.0/AxisSpans/AxisSpanQuickstart/
BreadcrumbNames: ["ScottPlot 5.0 Cookbook", "Axis Spans", "Axis Span Quickstart"]
BreadcrumbUrls: ["/cookbook/5.0/", "/cookbook/5.0/AxisSpans", "/cookbook/5.0/AxisSpans/AxisSpanQuickstart"]
Date: 2024-10-30
Version: ScottPlot 5.0.42
Version: ScottPlot 5.0.42
SearchUrl: "/cookbook/5.0/search/"
ShowEditLink: false
---


<h2 style='border-bottom: 0;'><a href='/cookbook/5.0/AxisSpans/AxisSpanQuickstart'>Axis Span Quickstart</a></h2>

<div class="d-flex mb-2">
<a class="btn btn-sm btn-primary me-1" href="/cookbook/5.0/AxisSpans/AxisSpanQuickstart">Recipe Permalink</a>
<a class="btn btn-sm btn-success me-1" href="/cookbook/5.0/AxisSpans">Category: Axis Spans</a>
</div>

Axis spans label a range of an axis. Vertical spans shade the full width of a vertical range, and horizontal spans shade the full height of a horizontal range.

[![](/cookbook/5.0/images/AxisSpanQuickstart.png?241029205813)](/cookbook/5.0/images/AxisSpanQuickstart.png?241029205813)

{{< recipe-sp5 >}}ScottPlot.Plot myPlot = new();

myPlot.Add.Signal(Generate.Sin());
myPlot.Add.Signal(Generate.Cos());

var hSpan = myPlot.Add.HorizontalSpan(10, 20);
var vSpan = myPlot.Add.VerticalSpan(0.25, 0.75);

hSpan.LegendText = "Horizontal Span";
vSpan.LegendText = "Vertical Span";
myPlot.ShowLegend();

myPlot.SavePng("demo.png", 400, 300);
{{< /recipe-sp5 >}}

<hr class='my-5 invisible'>


