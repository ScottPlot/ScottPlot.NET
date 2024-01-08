---
Title: Customizing Plottables - ScottPlot 5.0 Cookbook
Description: Functions that add things to plots return the plottables they create. Interact with the properties of plottables to customize their styling and behavior.
URL: /cookbook/5.0/Quickstart/CustomizingPlottables/
BreadcrumbNames: ["ScottPlot 5.0 Cookbook", "ScottPlot 5 Quickstart", "Customizing Plottables"]
BreadcrumbUrls: ["/cookbook/5.0/", "/cookbook/5.0/Quickstart", "/cookbook/5.0/Quickstart/CustomizingPlottables"]
Date: 2024-01-08
Version: ScottPlot 5.0.11-beta
Version: ScottPlot 5.0.11-beta
SearchUrl: "/cookbook/5.0/search/"
---

# Customizing Plottables



<div class='alert alert-warning' role='alert'><h4 class='alert-heading py-0 my-0'>⚠️ ScottPlot 5.0.11-beta is a preview package</h4><hr /><p class='mb-0'><span class='fw-semibold'>This page describes a beta release of ScottPlot.</span> It is available on NuGet as a preview package, but its API is not stable and it is not recommended for production use. See the <a href='https://scottplot.net/versions/'>ScottPlot Versions</a> page for more information. </p></div>



Functions that add things to plots return the plottables they create. Interact with the properties of plottables to customize their styling and behavior.

[![](/cookbook/5.0/images/CustomizingPlottables.png)](/cookbook/5.0/images/CustomizingPlottables.png)

```cs
ScottPlot.Version.ShouldBe(5, 0, 11);
ScottPlot.Plot myPlot = new();

double[] dataX = { 1, 2, 3, 4, 5 };
double[] dataY = { 1, 4, 9, 16, 25 };
var myScatter = myPlot.Add.Scatter(dataX, dataY);
myScatter.LineStyle.Width = 5;
myScatter.LineStyle.Color = Colors.Green.WithOpacity(.2);
myScatter.MarkerStyle.Fill.Color = Colors.Magenta;
myScatter.MarkerStyle.Size = 15;

myPlot.SavePng("demo.png");

```

