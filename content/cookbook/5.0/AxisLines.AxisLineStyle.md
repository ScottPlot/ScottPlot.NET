---
Title: Axis Line Style - ScottPlot 5.0 Cookbook
Description: Axis lines have extensive customization options.
URL: /cookbook/5.0/AxisLines/AxisLineStyle/
BreadcrumbNames: ["ScottPlot 5.0 Cookbook", "Axis Lines", "Axis Line Style"]
BreadcrumbUrls: ["/cookbook/5.0/", "/cookbook/5.0/AxisLines", "/cookbook/5.0/AxisLines/AxisLineStyle"]
Date: 2024-10-31
Version: ScottPlot 5.0.42
Version: ScottPlot 5.0.42
SearchUrl: "/cookbook/5.0/search/"
ShowEditLink: false
---


<h2 style='border-bottom: 0;'><a href='/cookbook/5.0/AxisLines/AxisLineStyle'>Axis Line Style</a></h2>

<div class="d-flex mb-2">
<a class="btn btn-sm btn-primary me-1" href="/cookbook/5.0/AxisLines/AxisLineStyle">Recipe Permalink</a>
<a class="btn btn-sm btn-success me-1" href="/cookbook/5.0/AxisLines">Category: Axis Lines</a>
</div>

Axis lines have extensive customization options.

[![](/cookbook/5.0/images/AxisLineStyle.png?241031194635)](/cookbook/5.0/images/AxisLineStyle.png?241031194635)

{{< recipe-sp5 >}}ScottPlot.Plot myPlot = new();

myPlot.Add.Signal(Generate.Sin());
myPlot.Add.Signal(Generate.Cos());

var vl1 = myPlot.Add.VerticalLine(24);
vl1.LineWidth = 3;
vl1.Color = Colors.Magenta;

var hl1 = myPlot.Add.HorizontalLine(0.75);
hl1.LineWidth = 2;
hl1.Color = Colors.Green;
hl1.LinePattern = LinePattern.Dashed;

var hl2 = myPlot.Add.HorizontalLine(-.23);
hl2.LineColor = Colors.Navy;
hl2.LineWidth = 5;
hl2.Text = "Hello";
hl2.LabelFontSize = 24;
hl2.LabelBackgroundColor = Colors.Blue;
hl2.LabelFontColor = Colors.Yellow;
hl2.LinePattern = LinePattern.DenselyDashed;

myPlot.SavePng("demo.png", 400, 300);
{{< /recipe-sp5 >}}

<hr class='my-5 invisible'>


