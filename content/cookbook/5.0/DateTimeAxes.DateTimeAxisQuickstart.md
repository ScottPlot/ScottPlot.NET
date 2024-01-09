---
Title: DateTime Axis Quickstart - ScottPlot 5.0 Cookbook
Description: Axis tick labels can be displayed using a time format.
URL: /cookbook/5.0/DateTimeAxes/DateTimeAxisQuickstart/
BreadcrumbNames: ["ScottPlot 5.0 Cookbook", "DateTime Axes", "DateTime Axis Quickstart"]
BreadcrumbUrls: ["/cookbook/5.0/", "/cookbook/5.0/DateTimeAxes", "/cookbook/5.0/DateTimeAxes/DateTimeAxisQuickstart"]
Date: 2024-01-09
Version: ScottPlot 5.0.12-beta
Version: ScottPlot 5.0.12-beta
SearchUrl: "/cookbook/5.0/search/"
ShowEditLink: false
---

# DateTime Axis Quickstart



<div class='alert alert-warning' role='alert'><h4 class='alert-heading py-0 my-0'>⚠️ ScottPlot 5.0.12-beta is a preview package</h4><hr /><p class='mb-0'><span class='fw-semibold'>This page describes a beta release of ScottPlot.</span> It is available on NuGet as a preview package, but its API is not stable and it is not recommended for production use. See the <a href='https://scottplot.net/versions/'>ScottPlot Versions</a> page for more information. </p></div>



Axis tick labels can be displayed using a time format.

[![](/cookbook/5.0/images/DateTimeAxisQuickstart.png)](/cookbook/5.0/images/DateTimeAxisQuickstart.png)

```cs
ScottPlot.Version.ShouldBe(5, 0, 12);
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

<a href='https://github.com/ScottPlot/ScottPlot/blob/main/src/ScottPlot5/ScottPlot5%20Cookbook/Recipes/Axis/DateTimeAxes.cs'><svg xmlns="http://www.w3.org/2000/svg" width="16" height="16" fill="currentColor" class="mb-1 bi bi-github" viewBox="0 0 16 16">
  <path d="M8 0C3.58 0 0 3.58 0 8c0 3.54 2.29 6.53 5.47 7.59.4.07.55-.17.55-.38 0-.19-.01-.82-.01-1.49-2.01.37-2.53-.49-2.69-.94-.09-.23-.48-.94-.82-1.13-.28-.15-.68-.52-.01-.53.63-.01 1.08.58 1.23.82.72 1.21 1.87.87 2.33.66.07-.52.28-.87.51-1.07-1.78-.2-3.64-.89-3.64-3.95 0-.87.31-1.59.82-2.15-.08-.2-.36-1.02.08-2.12 0 0 .67-.21 2.2.82.64-.18 1.32-.27 2-.27s1.36.09 2 .27c1.53-1.04 2.2-.82 2.2-.82.44 1.1.16 1.92.08 2.12.51.56.82 1.27.82 2.15 0 3.07-1.87 3.75-3.65 3.95.29.25.54.73.54 1.48 0 1.07-.01 1.93-.01 2.2 0 .21.15.46.55.38A8.01 8.01 0 0 0 16 8c0-4.42-3.58-8-8-8"/>
</svg> Edit on GitHub</a>

