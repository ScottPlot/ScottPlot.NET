---
Title: Axis Line Label Positioning - ScottPlot 5.0 Cookbook
Description: Axis line labels can have custom positioning, including rotation and alignment.
URL: /cookbook/5.0/AxisLines/AxisLineLabelPositioning/
BreadcrumbNames: ["ScottPlot 5.0 Cookbook", "Axis Lines", "Axis Line Label Positioning"]
BreadcrumbUrls: ["/cookbook/5.0/", "/cookbook/5.0/AxisLines", "/cookbook/5.0/AxisLines/AxisLineLabelPositioning"]
Date: 2025-08-23
Version: ScottPlot 5.0.56
Version: ScottPlot 5.0.56
SearchUrl: "/cookbook/5.0/search/"
ShowEditLink: false
---


<div class='d-flex align-items-center mt-5'>
<h1 class='me-2 text-dark my-0 border-0'>Axis Line Label Positioning</h1>
</div>

Axis line labels can have custom positioning, including rotation and alignment.

[![](/cookbook/5.0/images/AxisLineLabelPositioning.png?250822231048)](/cookbook/5.0/images/AxisLineLabelPositioning.png?250822231048)

{{< recipe-sp5 sourceUrl="https://github.com/ScottPlot/ScottPlot/blob/main/src/ScottPlot5/ScottPlot5%20Cookbook/Recipes/PlotTypes/AxisLines.cs" imageUrl="/cookbook/5.0/images/AxisLineLabelPositioning.png?250822231048" >}}ScottPlot.Plot myPlot = new();

myPlot.Add.Signal(Generate.Sin());
myPlot.Add.Signal(Generate.Cos());

var axLine1 = myPlot.Add.VerticalLine(42);
axLine1.Text = "Line 1";
axLine1.LabelRotation = -90;
axLine1.LabelAlignment = Alignment.MiddleRight;

var axLine2 = myPlot.Add.HorizontalLine(0.75);
axLine2.Text = "Line 2";
axLine2.LabelRotation = 0;
axLine2.LabelAlignment = Alignment.MiddleRight;

var axLine3 = myPlot.Add.VerticalLine(20);
axLine3.Text = "Line 3";
axLine3.LabelRotation = -45;
axLine3.LabelAlignment = Alignment.UpperRight;

// extra padding on the bottom and left for the rotated labels
myPlot.Axes.Bottom.MinimumSize = 60;
myPlot.Axes.Left.MinimumSize = 60;

myPlot.SavePng("demo.png", 400, 300);
{{< /recipe-sp5 >}}

<div class='my-5 text-center'>This recipe is one of many in the <a href='/cookbook/5.0/AxisLines'>Axis Lines</a> category</div>


