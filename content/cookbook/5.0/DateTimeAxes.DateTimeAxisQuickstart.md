---
Title: DateTime Axis Quickstart - ScottPlot 5.0 Cookbook
Description: Axis tick labels can be displayed using a time format.
URL: /cookbook/5.0/DateTimeAxes/DateTimeAxisQuickstart
BreadcrumbNames: ["ScottPlot 5.0 Cookbook", "DateTime Axes", "DateTime Axis Quickstart"]
BreadcrumbUrls: ["/cookbook/5.0/", "/cookbook/5.0/DateTimeAxes", "/cookbook/5.0/DateTimeAxes/DateTimeAxisQuickstart"]
Date: 2023-12-13
Version: ScottPlot 5.0.10-beta
---

# DateTime Axis Quickstart



<div class='alert alert-warning' role='alert'><h4 class='alert-heading py-0 my-0'>⚠️ ScottPlot 5.0.10-beta is a preview package</h4><hr /><p class='mb-0'><span class='fw-semibold'>This page describes a beta release of ScottPlot.</span> It is available on NuGet as a preview package, but its API is not stable and it is not recommended for production use. See the <a href='https://scottplot.net/versions/'>ScottPlot Versions</a> page for more information. </p></div>



Axis tick labels can be displayed using a time format.

[![](/cookbook/5.0/images/DateTimeAxisQuickstart.png)](/cookbook/5.0/images/DateTimeAxisQuickstart.png)

```cs
ScottPlot.Plot myPlot = new();

// begin with an array of DateTime values
DateTime[] dates = ScottPlot.Generate.DateTime.Days(100);

// convert DateTime to OLE Automation (OADate) format
double[] xs = dates.Select(x => x.ToOADate()).ToArray();
double[] ys = ScottPlot.Generate.RandomWalk(xs.Length);
myPlot.Add.Scatter(xs, ys);

// tell the plot to display dates on the bottom axis
myPlot.AxisStyler.DateTimeTicks(Edge.Bottom);

myPlot.SavePng("demo.png");

```

