---
Title: DateTime Axes - ScottPlot 5.0 Cookbook
Description: Plot data values on a DataTime axes
URL: /cookbook/5.0/DateTimeAxes/
BreadcrumbNames: ["ScottPlot 5.0 Cookbook", "DateTime Axes"]
BreadcrumbUrls: ["/cookbook/5.0/", "/cookbook/5.0/DateTimeAxes"]
Date: 2024-01-14
Version: ScottPlot 5.0.15
Version: ScottPlot 5.0.15
SearchUrl: "/cookbook/5.0/search/"
ShowEditLink: false
---

# DateTime Axes



<div class='alert alert-warning' role='alert'><h4 class='alert-heading py-0 my-0'>⚠️ ScottPlot 5.0.15 is a preview package</h4><hr /><p class='mb-0'><span class='fw-semibold'>This page describes a beta release of ScottPlot.</span> It is available on NuGet as a preview package, but its API is not stable and it is not recommended for production use. See the <a href='https://scottplot.net/versions/'>ScottPlot Versions</a> page for more information. </p></div>



<h2><a href='/cookbook/5.0/DateTimeAxes/DateTimeAxisQuickstart'>DateTime Axis Quickstart</a></h2>

Axis tick labels can be displayed using a time format.

[![](/cookbook/5.0/images/DateTimeAxisQuickstart.png)](/cookbook/5.0/images/DateTimeAxisQuickstart.png)

```cs
ScottPlot.Version.ShouldBe(5, 0, 15);
ScottPlot.Plot myPlot = new();

// begin with an array of DateTime values
DateTime[] dates = ScottPlot.Generate.DateTime.Days(100);

// convert DateTime to OLE Automation (OADate) format
double[] xs = dates.Select(x => x.ToOADate()).ToArray();
double[] ys = ScottPlot.Generate.RandomWalk(xs.Length);
myPlot.Add.Scatter(xs, ys);

// tell the plot to display dates on the bottom axis
myPlot.Axes.DateTimeTicks(Edge.Bottom);

myPlot.SavePng("demo.png");

```

<hr class='my-5 invisible'>

