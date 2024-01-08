---
Title: Scatter Plot Styling - ScottPlot 5.0 Cookbook
Description: Scatter plots can be extensively styled by interacting with the object that is returned after a scatter plot is added. Assign text to a scatter plot's Label property to allow it to appear in the legend.
URL: /cookbook/5.0/Scatter/ScatterStyling/
BreadcrumbNames: ["ScottPlot 5.0 Cookbook", "Scatter Plot", "Scatter Plot Styling"]
BreadcrumbUrls: ["/cookbook/5.0/", "/cookbook/5.0/Scatter", "/cookbook/5.0/Scatter/ScatterStyling"]
Date: 2024-01-08
Version: ScottPlot 5.0.11-beta
Version: ScottPlot 5.0.11-beta
SearchUrl: "/cookbook/5.0/search/"
---

# Scatter Plot Styling



<div class='alert alert-warning' role='alert'><h4 class='alert-heading py-0 my-0'>⚠️ ScottPlot 5.0.11-beta is a preview package</h4><hr /><p class='mb-0'><span class='fw-semibold'>This page describes a beta release of ScottPlot.</span> It is available on NuGet as a preview package, but its API is not stable and it is not recommended for production use. See the <a href='https://scottplot.net/versions/'>ScottPlot Versions</a> page for more information. </p></div>



Scatter plots can be extensively styled by interacting with the object that is returned after a scatter plot is added. Assign text to a scatter plot's Label property to allow it to appear in the legend.

[![](/cookbook/5.0/images/ScatterStyling.png)](/cookbook/5.0/images/ScatterStyling.png)

```cs
ScottPlot.Version.ShouldBe(5, 0, 11);
ScottPlot.Plot myPlot = new();

double[] xs = Generate.Consecutive(51);
double[] ys1 = Generate.Sin(51);
double[] ys2 = Generate.Cos(51);

var sp1 = myPlot.Add.Scatter(xs, ys1);
sp1.Label = "Sine";
sp1.LineWidth = 3;
sp1.Color = Colors.Magenta;
sp1.MarkerSize = 15;

var sp2 = myPlot.Add.Scatter(xs, ys2);
sp2.Label = "Cosine";
sp2.LineWidth = 2;
sp2.Color = Colors.Green;
sp2.MarkerSize = 10;

myPlot.ShowLegend();

myPlot.SavePng("demo.png");

```

