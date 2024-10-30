---
Title: Axis Span Styling - ScottPlot 5.0 Cookbook
Description: Axis spans can be extensively customized.
URL: /cookbook/5.0/AxisSpans/AxisSpanStyling/
BreadcrumbNames: ["ScottPlot 5.0 Cookbook", "Axis Spans", "Axis Span Styling"]
BreadcrumbUrls: ["/cookbook/5.0/", "/cookbook/5.0/AxisSpans", "/cookbook/5.0/AxisSpans/AxisSpanStyling"]
Date: 2024-10-30
Version: ScottPlot 5.0.42
Version: ScottPlot 5.0.42
SearchUrl: "/cookbook/5.0/search/"
ShowEditLink: false
---


<h2 style='border-bottom: 0;'><a href='/cookbook/5.0/AxisSpans/AxisSpanStyling'>Axis Span Styling</a></h2>

<div class="d-flex mb-2">
<a class="btn btn-sm btn-primary me-1" href="/cookbook/5.0/AxisSpans/AxisSpanStyling">Recipe Permalink</a>
<a class="btn btn-sm btn-success me-1" href="/cookbook/5.0/AxisSpans">Category: Axis Spans</a>
</div>

Axis spans can be extensively customized.

[![](/cookbook/5.0/images/AxisSpanStyling.png?241029205813)](/cookbook/5.0/images/AxisSpanStyling.png?241029205813)

{{< recipe-sp5 >}}ScottPlot.Plot myPlot = new();

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


