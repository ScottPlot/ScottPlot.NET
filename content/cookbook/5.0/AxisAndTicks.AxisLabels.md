---
Title: Adding Axis Labels - ScottPlot 5.0 Cookbook
Description: Axis labels are the text labels centered on each axis. The text inside these labels can be changed, and the style of the text can be extensively customized.
URL: /cookbook/5.0/AxisAndTicks/AxisLabels
BreadcrumbNames: ["ScottPlot 5.0 Cookbook", "Axis and Ticks", "Adding Axis Labels"]
BreadcrumbUrls: ["/cookbook/5.0/", "/cookbook/5.0/AxisAndTicks", "/cookbook/5.0/AxisAndTicks/AxisLabels"]
Date: 12/13/2023 2:24:04 PM
Version: ScottPlot 5.0.10-beta
---

# Adding Axis Labels



<div class='alert alert-warning' role='alert'><h4 class='alert-heading py-0 my-0'>⚠️ ScottPlot 5.0.10-beta is a preview package</h4><hr /><p class='mb-0'><span class='fw-semibold'>This page describes a beta release of ScottPlot.</span> It is available on NuGet as a preview package, but its API is not stable and it is not recommended for production use. See the <a href='https://scottplot.net/versions/'>ScottPlot Versions</a> page for more information. </p></div>



Axis labels are the text labels centered on each axis. The text inside these labels can be changed, and the style of the text can be extensively customized.

[![](/cookbook/5.0/images/AxisLabels.png)](/cookbook/5.0/images/AxisLabels.png)

```cs
ScottPlot.Plot myPlot = new();

myPlot.Add.Signal(ScottPlot.Generate.Sin(51));
myPlot.Add.Signal(ScottPlot.Generate.Cos(51));

myPlot.XAxis.Label.Text = "Horizontal Axis";
myPlot.YAxis.Label.Text = "Vertical Axis";

myPlot.SavePng("demo.png");

```

