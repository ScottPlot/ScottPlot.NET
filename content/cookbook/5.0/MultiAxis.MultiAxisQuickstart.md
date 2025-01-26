---
Title: Multi-Axis - ScottPlot 5.0 Cookbook
Description: Additional axes may be added to plots. Plottables are displayed using the coordinate system of the primary axes by default, but any plottable can be displayed using any X and Y axis.
URL: /cookbook/5.0/MultiAxis/MultiAxisQuickstart/
BreadcrumbNames: ["ScottPlot 5.0 Cookbook", "Multiple Axes", "Multi-Axis"]
BreadcrumbUrls: ["/cookbook/5.0/", "/cookbook/5.0/MultiAxis", "/cookbook/5.0/MultiAxis/MultiAxisQuickstart"]
Date: 2025-01-26
Version: ScottPlot 5.0.55
Version: ScottPlot 5.0.55
SearchUrl: "/cookbook/5.0/search/"
ShowEditLink: false
---


<div class='d-flex align-items-center mt-5'>
<h1 class='me-2 text-dark my-0 border-0'>Multi-Axis</h1>
</div>

Additional axes may be added to plots. Plottables are displayed using the coordinate system of the primary axes by default, but any plottable can be displayed using any X and Y axis.

[![](/cookbook/5.0/images/MultiAxisQuickstart.png?250126165944)](/cookbook/5.0/images/MultiAxisQuickstart.png?250126165944)

{{< recipe-sp5 sourceUrl="https://github.com/ScottPlot/ScottPlot/blob/main/src/ScottPlot5/ScottPlot5%20Cookbook/Recipes/General/MultiAxis.cs" imageUrl="/cookbook/5.0/images/MultiAxisQuickstart.png?250126165944" >}}ScottPlot.Plot myPlot = new();

// plottables use the standard X and Y axes by default
var sig1 = myPlot.Add.Signal(Generate.Sin(51, mult: 0.01));
sig1.Axes.XAxis = myPlot.Axes.Bottom; // standard X axis
sig1.Axes.YAxis = myPlot.Axes.Left; // standard Y axis
myPlot.Axes.Left.Label.Text = "Primary Y Axis";

// create a second axis and add it to the plot
var yAxis2 = myPlot.Axes.AddLeftAxis();

// add a new plottable and tell it to use the custom Y axis
var sig2 = myPlot.Add.Signal(Generate.Cos(51, mult: 100));
sig2.Axes.XAxis = myPlot.Axes.Bottom; // standard X axis
sig2.Axes.YAxis = yAxis2; // custom Y axis
yAxis2.LabelText = "Secondary Y Axis";

myPlot.SavePng("demo.png", 400, 300);
{{< /recipe-sp5 >}}

<div class='my-5 text-center'>This recipe is one of many in the <a href='/cookbook/5.0/MultiAxis'>Multiple Axes</a> category</div>


