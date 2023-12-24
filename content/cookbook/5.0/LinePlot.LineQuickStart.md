---
Title: Line Plot Quickstart - ScottPlot 5.0 Cookbook
Description: Line plots are placed with a start and end location in coordinate space. Their styles can be customized.
URL: /cookbook/5.0/LinePlot/LineQuickStart/
BreadcrumbNames: ["ScottPlot 5.0 Cookbook", "Line Plot", "Line Plot Quickstart"]
BreadcrumbUrls: ["/cookbook/5.0/", "/cookbook/5.0/LinePlot", "/cookbook/5.0/LinePlot/LineQuickStart"]
Date: 2023-12-24
Version: ScottPlot 5.0.11-beta
Version: ScottPlot 5.0.11-beta
SearchUrl: "/cookbook/5.0/search/"
---

# Line Plot Quickstart



<div class='alert alert-warning' role='alert'><h4 class='alert-heading py-0 my-0'>⚠️ ScottPlot 5.0.11-beta is a preview package</h4><hr /><p class='mb-0'><span class='fw-semibold'>This page describes a beta release of ScottPlot.</span> It is available on NuGet as a preview package, but its API is not stable and it is not recommended for production use. See the <a href='https://scottplot.net/versions/'>ScottPlot Versions</a> page for more information. </p></div>



Line plots are placed with a start and end location in coordinate space. Their styles can be customized.

[![](/cookbook/5.0/images/LineQuickStart.png)](/cookbook/5.0/images/LineQuickStart.png)

```cs
ScottPlot.Plot myPlot = new();

myPlot.Add.Line(1, 12, 12, 0);
myPlot.Add.Line(7, 9, 42, 9);
myPlot.Add.Line(30, 17, 30, 1);

myPlot.SavePng("demo.png");

```

