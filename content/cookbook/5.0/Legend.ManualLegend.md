---
Title: Manual Legend - ScottPlot 5.0 Cookbook
Description: Legends may be constructed manually.
URL: /cookbook/5.0/Legend/ManualLegend/
BreadcrumbNames: ["ScottPlot 5.0 Cookbook", "Configuring Legends", "Manual Legend"]
BreadcrumbUrls: ["/cookbook/5.0/", "/cookbook/5.0/Legend", "/cookbook/5.0/Legend/ManualLegend"]
Date: 2023-12-28
Version: ScottPlot 5.0.11-beta
Version: ScottPlot 5.0.11-beta
SearchUrl: "/cookbook/5.0/search/"
---

# Manual Legend



<div class='alert alert-warning' role='alert'><h4 class='alert-heading py-0 my-0'>⚠️ ScottPlot 5.0.11-beta is a preview package</h4><hr /><p class='mb-0'><span class='fw-semibold'>This page describes a beta release of ScottPlot.</span> It is available on NuGet as a preview package, but its API is not stable and it is not recommended for production use. See the <a href='https://scottplot.net/versions/'>ScottPlot Versions</a> page for more information. </p></div>



Legends may be constructed manually.

[![](/cookbook/5.0/images/ManualLegend.png)](/cookbook/5.0/images/ManualLegend.png)

```cs
ScottPlot.Plot myPlot = new();

myPlot.Add.Signal(ScottPlot.Generate.Sin(51));
myPlot.Add.Signal(ScottPlot.Generate.Cos(51));

myPlot.Legend.IsVisible = true;

myPlot.Legend.ManualItems.Add(new LegendItem()
{
    LineColor = Colors.Magenta,
    LineWidth = 2,
    Label = "Alpha"
});

myPlot.Legend.ManualItems.Add(new LegendItem()
{
    LineColor = Colors.Green,
    LineWidth = 4,
    Label = "Beta"
});

myPlot.SavePng("demo.png");

```

