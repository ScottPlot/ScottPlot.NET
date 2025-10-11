---
Title: Axis Span Styling - ScottPlot 5 Cookbook
Description: Axis spans can be extensively customized.
URL: /cookbook/5/AxisSpans/AxisSpanStyling/
BreadcrumbNames: ["ScottPlot 5 Cookbook", "Axis Spans", "Axis Span Styling"]
BreadcrumbUrls: ["/cookbook/5/", "/cookbook/5/AxisSpans", "/cookbook/5/AxisSpans/AxisSpanStyling"]
Date: 2025-10-11
Version: ScottPlot 5.1.57
Version: ScottPlot 5.1.57
SearchUrl: "/cookbook/5/search/"
ShowEditLink: false
---


<div class='d-flex align-items-center mt-5'>
<h1 class='me-2 text-dark my-0 border-0'>Axis Span Styling</h1>
</div>

Axis spans can be extensively customized.

[![](/cookbook/5/images/AxisSpanStyling.png?251011113742)](/cookbook/5/images/AxisSpanStyling.png?251011113742)

{{< recipe-sp5 sourceUrl="https://github.com/ScottPlot/ScottPlot/blob/main/src/ScottPlot5/ScottPlot5%20Cookbook/Recipes/PlotTypes/AxisSpans.cs" imageUrl="/cookbook/5/images/AxisSpanStyling.png?251011113742" >}}ScottPlot.Plot myPlot = new();

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

<div class='my-5 text-center'>This recipe is one of many in the <a href='/cookbook/5/AxisSpans'>Axis Spans</a> category</div>


