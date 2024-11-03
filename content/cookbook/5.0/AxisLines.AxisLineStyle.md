---
Title: Axis Line Style - ScottPlot 5.0 Cookbook
Description: Axis lines have extensive customization options.
URL: /cookbook/5.0/AxisLines/AxisLineStyle/
BreadcrumbNames: ["ScottPlot 5.0 Cookbook", "Axis Lines", "Axis Line Style"]
BreadcrumbUrls: ["/cookbook/5.0/", "/cookbook/5.0/AxisLines", "/cookbook/5.0/AxisLines/AxisLineStyle"]
Date: 2024-11-03
Version: ScottPlot 5.0.43
Version: ScottPlot 5.0.43
SearchUrl: "/cookbook/5.0/search/"
ShowEditLink: false
---


<div class='d-flex align-items-center mt-5'>
<h1 class='me-2 text-dark my-0 border-0'>Axis Line Style</h1>
</div>

Axis lines have extensive customization options.

[![](/cookbook/5.0/images/AxisLineStyle.png?241103171511)](/cookbook/5.0/images/AxisLineStyle.png?241103171511)

{{< recipe-sp5 sourceUrl="https://github.com/ScottPlot/ScottPlot/blob/main/src/ScottPlot5/ScottPlot5%20Cookbook/Recipes/PlotTypes/AxisLines.cs" imageUrl="/cookbook/5.0/images/AxisLineStyle.png?241103171511" >}}ScottPlot.Plot myPlot = new();

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

<div class='my-5 text-center'>This recipe is one of many in the <a href='/cookbook/5.0/AxisLines'>Axis Lines</a> category</div>


