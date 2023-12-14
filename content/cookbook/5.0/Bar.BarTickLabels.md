---
Title: Bars with Labeled Ticks - ScottPlot 5.0 Cookbook
Description: Bars can be labeled by manually specifying axis tick mark positions and labels.
URL: /cookbook/5.0/Bar/BarTickLabels/index.html
BreadcrumbNames: ["ScottPlot 5.0 Cookbook", "Bar Plot", "Bars with Labeled Ticks"]
BreadcrumbUrls: ["/cookbook/5.0/", "/cookbook/5.0/Bar", "/cookbook/5.0/Bar/BarTickLabels"]
Date: 2023-12-14
Version: ScottPlot 5.0.10-beta
Version: ScottPlot 5.0.10-beta
SearchUrl: "/cookbook/5.0/search/"
---

# Bars with Labeled Ticks



<div class='alert alert-warning' role='alert'><h4 class='alert-heading py-0 my-0'>⚠️ ScottPlot 5.0.10-beta is a preview package</h4><hr /><p class='mb-0'><span class='fw-semibold'>This page describes a beta release of ScottPlot.</span> It is available on NuGet as a preview package, but its API is not stable and it is not recommended for production use. See the <a href='https://scottplot.net/versions/'>ScottPlot Versions</a> page for more information. </p></div>



Bars can be labeled by manually specifying axis tick mark positions and labels.

[![](/cookbook/5.0/images/BarTickLabels.png)](/cookbook/5.0/images/BarTickLabels.png)

```cs
ScottPlot.Plot myPlot = new();

myPlot.Add.Bar(position: 1, value: 5, error: 1);
myPlot.Add.Bar(position: 2, value: 7, error: 2);
myPlot.Add.Bar(position: 3, value: 6, error: 1);
myPlot.Add.Bar(position: 4, value: 8, error: 2);

Tick[] ticks =
{
    new(1, "Apple"),
    new(2, "Orange"),
    new(3, "Pear"),
    new(4, "Banana"),
};

myPlot.BottomAxis.TickGenerator = new ScottPlot.TickGenerators.NumericManual(ticks);
myPlot.BottomAxis.MajorTickLength = 0;
myPlot.DisableGrid();

myPlot.SavePng("demo.png");

```

