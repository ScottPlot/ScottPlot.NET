---
Title: DateTime Axes - ScottPlot 5.0 Cookbook
Description: Plot data values on a DataTime axes
URL: /cookbook/5.0/datetime-axes/
BreadcrumbNames: ["ScottPlot 5.0 Cookbook", "DateTime Axes"]
BreadcrumbUrls: ["/cookbook/5.0/", "/cookbook/5.0/datetime-axes/"]
Date: 12/11/2023 2:09:58 PM
Version: ScottPlot 5.0.10-beta
---

# DateTime Axes



<div class='alert alert-warning' role='alert'><h4 class='alert-heading py-0 my-0'>⚠️ ScottPlot 5.0.10-beta is a preview package</h4><hr /><p class='mb-0'><span class='fw-semibold'>This page describes a beta release of ScottPlot.</span> It is available on NuGet as a preview package, but its API is not stable and it is not recommended for production use. See the <a href='https://scottplot.net/versions/'>ScottPlot Versions</a> page for more information. </p></div>



## DateTime Axis Quickstart

.

[![](datetime-axis-quickstart.png)](datetime-axis-quickstart.png)

```cs
ScottPlot.Plot myPlot = new();

// begin with an array of DateTime values
DateTime[] dates = Generate.DateTime.Days(100);

// convert DateTime to OLE Automation (OADate) format
double[] xs = dates.Select(x => x.ToOADate()).ToArray();
double[] ys = Generate.RandomWalk(xs.Length);
myPlot.Add.Scatter(xs, ys);

// tell the plot to display dates on the bottom axis
myPlot.AxisStyler.DateTimeTicks(Edge.Bottom);

myPlot.SavePng("datetime-axis-quickstart.png");
```

