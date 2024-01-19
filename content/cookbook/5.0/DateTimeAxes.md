---
Title: DateTime Axes - ScottPlot 5.0 Cookbook
Description: Plot data values on a DataTime axes
URL: /cookbook/5.0/DateTimeAxes/
BreadcrumbNames: ["ScottPlot 5.0 Cookbook", "DateTime Axes"]
BreadcrumbUrls: ["/cookbook/5.0/", "/cookbook/5.0/DateTimeAxes"]
Date: 2024-01-19
Version: ScottPlot 5.0.19
Version: ScottPlot 5.0.19
SearchUrl: "/cookbook/5.0/search/"
ShowEditLink: false
---

# DateTime Axes


<h2><a href='/cookbook/5.0/DateTimeAxes/DateTimeAxisQuickstart'>DateTime Axis Quickstart</a></h2>

Axis tick labels can be displayed using a time format.

[![](/cookbook/5.0/images/DateTimeAxisQuickstart.png)](/cookbook/5.0/images/DateTimeAxisQuickstart.png)

{{< code-sp5 >}}

```cs
ScottPlot.Plot myPlot = new();

// begin with an array of DateTime values
DateTime[] dates = ScottPlot.Generate.DateTime.Days(100);

// convert DateTime to OLE Automation (OADate) format
double[] xs = dates.Select(x => x.ToOADate()).ToArray();
double[] ys = ScottPlot.Generate.RandomWalk(xs.Length);
myPlot.Add.Scatter(xs, ys);

// tell the plot to display dates on the bottom axis
myPlot.Axes.DateTimeTicks(Edge.Bottom);

myPlot.SavePng("demo.png", 400, 300);

```

{{< /code-sp5 >}}

<hr class='my-5 invisible'>

