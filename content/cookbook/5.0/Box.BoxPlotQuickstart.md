---
Title: Box Plot Quickstart - ScottPlot 5.0 Cookbook
Description: Box plots can be created individually and added to the plot.
URL: /cookbook/5.0/Box/BoxPlotQuickstart/
BreadcrumbNames: ["ScottPlot 5.0 Cookbook", "Box Plot", "Box Plot Quickstart"]
BreadcrumbUrls: ["/cookbook/5.0/", "/cookbook/5.0/Box", "/cookbook/5.0/Box/BoxPlotQuickstart"]
Date: 2024-01-08
Version: ScottPlot 5.0.11-beta
Version: ScottPlot 5.0.11-beta
SearchUrl: "/cookbook/5.0/search/"
---

# Box Plot Quickstart



<div class='alert alert-warning' role='alert'><h4 class='alert-heading py-0 my-0'>⚠️ ScottPlot 5.0.11-beta is a preview package</h4><hr /><p class='mb-0'><span class='fw-semibold'>This page describes a beta release of ScottPlot.</span> It is available on NuGet as a preview package, but its API is not stable and it is not recommended for production use. See the <a href='https://scottplot.net/versions/'>ScottPlot Versions</a> page for more information. </p></div>



Box plots can be created individually and added to the plot.

[![](/cookbook/5.0/images/BoxPlotQuickstart.png)](/cookbook/5.0/images/BoxPlotQuickstart.png)

```cs
ScottPlot.Version.ShouldBe(5, 0, 11);
ScottPlot.Plot myPlot = new();

ScottPlot.Box box = new()
{
    Position = 5,
    BoxMin = 81,
    BoxMax = 93,
    WhiskerMin = 76,
    WhiskerMax = 107,
    BoxMiddle = 84,
};

myPlot.Add.Box(box);

myPlot.Axes.SetLimits(0, 10, 70, 110);

myPlot.SavePng("demo.png");

```

