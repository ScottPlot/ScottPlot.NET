---
Title: Axis Line Label Positioning - ScottPlot 5.0 Cookbook
Description: Axis line labels can have custom positioning, including rotation and alignment.
URL: /cookbook/5.0/AxisLines/AxisLineLabelPositioning/
BreadcrumbNames: ["ScottPlot 5.0 Cookbook", "Axis Lines", "Axis Line Label Positioning"]
BreadcrumbUrls: ["/cookbook/5.0/", "/cookbook/5.0/AxisLines", "/cookbook/5.0/AxisLines/AxisLineLabelPositioning"]
Date: 2024-10-31
Version: ScottPlot 5.0.42
Version: ScottPlot 5.0.42
SearchUrl: "/cookbook/5.0/search/"
ShowEditLink: false
---


<h2 style='border-bottom: 0;'><a href='/cookbook/5.0/AxisLines/AxisLineLabelPositioning'>Axis Line Label Positioning</a></h2>

<div class="d-flex mb-2">
<a class="btn btn-sm btn-primary me-1" href="/cookbook/5.0/AxisLines/AxisLineLabelPositioning">Recipe Permalink</a>
<a class="btn btn-sm btn-success me-1" href="/cookbook/5.0/AxisLines">Category: Axis Lines</a>
</div>

Axis line labels can have custom positioning, including rotation and alignment.

[![](/cookbook/5.0/images/AxisLineLabelPositioning.png?241031194635)](/cookbook/5.0/images/AxisLineLabelPositioning.png?241031194635)

{{< recipe-sp5 >}}ScottPlot.Plot myPlot = new();

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

<hr class='my-5 invisible'>


