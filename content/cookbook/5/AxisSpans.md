---
Title: Axis Spans - ScottPlot 5.0 Cookbook
Description: Axis spans indicate a range of an axis.
URL: /cookbook/5.0/AxisSpans/
BreadcrumbNames: ["ScottPlot 5.0 Cookbook", "Axis Spans"]
BreadcrumbUrls: ["/cookbook/5.0/", "/cookbook/5.0/AxisSpans"]
Date: 2025-01-26
Version: ScottPlot 5.0.55
Version: ScottPlot 5.0.55
SearchUrl: "/cookbook/5.0/search/"
ShowEditLink: false
---

<h1>Axis Spans</h1>


<div class='d-flex align-items-center mt-5'>
<h1 class='me-2 text-dark my-0 border-0'>Axis Span Quickstart</h1>
<a href='/cookbook/5.0/AxisSpans/AxisSpanQuickstart' target='_blank'>
<img src='/images/icons/new-window.svg' style='height: 2rem;' class='new-window-icon'>
</a>
</div>

Axis spans label a range of an axis. Vertical spans shade the full width of a vertical range, and horizontal spans shade the full height of a horizontal range.

[![](/cookbook/5.0/images/AxisSpanQuickstart.png?250126165944)](/cookbook/5.0/images/AxisSpanQuickstart.png?250126165944)

{{< recipe-sp5 sourceUrl="https://github.com/ScottPlot/ScottPlot/blob/main/src/ScottPlot5/ScottPlot5%20Cookbook/Recipes/PlotTypes/AxisSpans.cs" imageUrl="/cookbook/5.0/images/AxisSpanQuickstart.png?250126165944" >}}ScottPlot.Plot myPlot = new();

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



<div class='d-flex align-items-center mt-5'>
<h1 class='me-2 text-dark my-0 border-0'>Axis Span Styling</h1>
<a href='/cookbook/5.0/AxisSpans/AxisSpanStyling' target='_blank'>
<img src='/images/icons/new-window.svg' style='height: 2rem;' class='new-window-icon'>
</a>
</div>

Axis spans can be extensively customized.

[![](/cookbook/5.0/images/AxisSpanStyling.png?250126165944)](/cookbook/5.0/images/AxisSpanStyling.png?250126165944)

{{< recipe-sp5 sourceUrl="https://github.com/ScottPlot/ScottPlot/blob/main/src/ScottPlot5/ScottPlot5%20Cookbook/Recipes/PlotTypes/AxisSpans.cs" imageUrl="/cookbook/5.0/images/AxisSpanStyling.png?250126165944" >}}ScottPlot.Plot myPlot = new();

myPlot.Add.Signal(Generate.Sin());
myPlot.Add.Signal(Generate.Cos());

var hs = myPlot.Add.HorizontalSpan(10, 20);
hs.LegendText = "Hello";
hs.LineStyle.Width = 2;
hs.LineStyle.Color = Colors.Magenta;
hs.LineStyle.Pattern = LinePattern.Dashed;
hs.FillStyle.Color = Colors.Magenta.WithAlpha(.2);

myPlot.SavePng("demo.png", 400, 300);
{{< /recipe-sp5 >}}

<hr class='my-5 invisible'>


