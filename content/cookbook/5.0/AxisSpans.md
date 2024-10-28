---
Title: Axis Spans - ScottPlot 5.0 Cookbook
Description: Axis spans indicate a range of an axis.
URL: /cookbook/5.0/AxisSpans/
BreadcrumbNames: ["ScottPlot 5.0 Cookbook", "Axis Spans"]
BreadcrumbUrls: ["/cookbook/5.0/", "/cookbook/5.0/AxisSpans"]
Date: 2024-10-28
Version: ScottPlot 5.0.41
Version: ScottPlot 5.0.41
SearchUrl: "/cookbook/5.0/search/"
ShowEditLink: false
---

# Axis Spans


<h2><a href='/cookbook/5.0/AxisSpans/AxisSpanQuickstart'>Axis Span Quickstart</a></h2>

Axis spans label a range of an axis. Vertical spans shade the full width of a vertical range, and horizontal spans shade the full height of a horizontal range.

[![](/cookbook/5.0/images/AxisSpanQuickstart.png?241027221943)](/cookbook/5.0/images/AxisSpanQuickstart.png?241027221943)

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


<h2><a href='/cookbook/5.0/AxisSpans/AxisSpanStyling'>Axis Span Styling</a></h2>

Axis spans can be extensively customized.

[![](/cookbook/5.0/images/AxisSpanStyling.png?241027221943)](/cookbook/5.0/images/AxisSpanStyling.png?241027221943)

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

