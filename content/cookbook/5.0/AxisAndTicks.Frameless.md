---
Title: Frameless Plot - ScottPlot 5.0 Cookbook
Description: How to create a plot containig only the data area and no axes.
URL: /cookbook/5.0/AxisAndTicks/Frameless
BreadcrumbNames: ["ScottPlot 5.0 Cookbook", "Axis and Ticks", "Frameless Plot"]
BreadcrumbUrls: ["/cookbook/5.0/", "/cookbook/5.0/AxisAndTicks", "/cookbook/5.0/AxisAndTicks/Frameless"]
Date: 2023-12-24
Version: ScottPlot 5.0.11-beta
Version: ScottPlot 5.0.11-beta
SearchUrl: "/cookbook/5.0/search/"
---

# Frameless Plot



<div class='alert alert-warning' role='alert'><h4 class='alert-heading py-0 my-0'>⚠️ ScottPlot 5.0.11-beta is a preview package</h4><hr /><p class='mb-0'><span class='fw-semibold'>This page describes a beta release of ScottPlot.</span> It is available on NuGet as a preview package, but its API is not stable and it is not recommended for production use. See the <a href='https://scottplot.net/versions/'>ScottPlot Versions</a> page for more information. </p></div>



How to create a plot containig only the data area and no axes.

[![](/cookbook/5.0/images/Frameless.png)](/cookbook/5.0/images/Frameless.png)

```cs
ScottPlot.Plot myPlot = new();

myPlot.FigureBackground = Colors.Magenta; // should not be seen
myPlot.DataBackground = Colors.WhiteSmoke;

myPlot.Add.Signal(ScottPlot.Generate.Sin(51));
myPlot.Add.Signal(ScottPlot.Generate.Cos(51));

myPlot.XAxes.ForEach(x => x.IsVisible = false);
myPlot.YAxes.ForEach(x => x.IsVisible = false);
myPlot.TitlePanel.IsVisible = false;

myPlot.SavePng("demo.png");

```

