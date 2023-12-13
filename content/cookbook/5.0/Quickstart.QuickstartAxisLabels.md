---
Title: Axis Labels - ScottPlot 5.0 Cookbook
Description: Axis labels can be extensively customized.
URL: /cookbook/5.0/Quickstart/QuickstartAxisLabels
BreadcrumbNames: ["ScottPlot 5.0 Cookbook", "ScottPlot 5 Quickstart", "Axis Labels"]
BreadcrumbUrls: ["/cookbook/5.0/", "/cookbook/5.0/Quickstart", "/cookbook/5.0/Quickstart/QuickstartAxisLabels"]
Date: 12/13/2023 2:24:04 PM
Version: ScottPlot 5.0.10-beta
---

# Axis Labels



<div class='alert alert-warning' role='alert'><h4 class='alert-heading py-0 my-0'>⚠️ ScottPlot 5.0.10-beta is a preview package</h4><hr /><p class='mb-0'><span class='fw-semibold'>This page describes a beta release of ScottPlot.</span> It is available on NuGet as a preview package, but its API is not stable and it is not recommended for production use. See the <a href='https://scottplot.net/versions/'>ScottPlot Versions</a> page for more information. </p></div>



Axis labels can be extensively customized.

[![](/cookbook/5.0/images/QuickstartAxisLabels.png)](/cookbook/5.0/images/QuickstartAxisLabels.png)

```cs
ScottPlot.Plot myPlot = new();

myPlot.Add.Signal(Generate.Sin(51));
myPlot.Add.Signal(Generate.Cos(51));

myPlot.XAxis.Label.Text = "Horizonal Axis";
myPlot.YAxis.Label.Text = "Vertical Axis";
myPlot.TitlePanel.Label.Text = "Plot Title";

myPlot.SavePng("demo.png");

```

