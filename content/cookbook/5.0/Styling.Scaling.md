---
Title: Scaling - ScottPlot 5.0 Cookbook
Description: All components of an image can be scaled up or down in size by adjusting the ScaleFactor property. This is very useful for creating images that look nice on high DPI displays with display scaling enabled.
URL: /cookbook/5.0/Styling/Scaling/
BreadcrumbNames: ["ScottPlot 5.0 Cookbook", "Styling Plots", "Scaling"]
BreadcrumbUrls: ["/cookbook/5.0/", "/cookbook/5.0/Styling", "/cookbook/5.0/Styling/Scaling"]
Date: 2024-01-08
Version: ScottPlot 5.0.11-beta
Version: ScottPlot 5.0.11-beta
SearchUrl: "/cookbook/5.0/search/"
---

# Scaling



<div class='alert alert-warning' role='alert'><h4 class='alert-heading py-0 my-0'>⚠️ ScottPlot 5.0.11-beta is a preview package</h4><hr /><p class='mb-0'><span class='fw-semibold'>This page describes a beta release of ScottPlot.</span> It is available on NuGet as a preview package, but its API is not stable and it is not recommended for production use. See the <a href='https://scottplot.net/versions/'>ScottPlot Versions</a> page for more information. </p></div>



All components of an image can be scaled up or down in size by adjusting the ScaleFactor property. This is very useful for creating images that look nice on high DPI displays with display scaling enabled.

[![](/cookbook/5.0/images/Scaling.png)](/cookbook/5.0/images/Scaling.png)

```cs
ScottPlot.Version.ShouldBe(5, 0, 11);
ScottPlot.Plot myPlot = new();

myPlot.ScaleFactor = 2;
myPlot.Add.Signal(Generate.Sin());
myPlot.Add.Signal(Generate.Cos());

myPlot.SavePng("demo.png");

```

