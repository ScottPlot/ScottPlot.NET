---
Title: "DateTime Axis Label - ScottPlot 4.1 Cookbook"
Description: "Crosshair labels display numeric labels by default, but a public field makes it possible to convert positions to DateTime (FromOATime) when generating their axis labels."
Date: 2023-12-28
Version: ScottPlot 4.1.70
URL: /cookbook/4.1/recipes/crosshair_formatting/
BreadcrumbNames: ["ScottPlot 4.1 Cookbook", "Crosshair", "DateTime Axis Label"]
BreadcrumbUrls: ["/cookbook/4.1/", "/cookbook/4.1/category/plottable-crosshair", "/cookbook/4.1/recipes/crosshair_formatting/"]
SearchUrl: "/cookbook/4.1/search/"
OgImage: "/cookbook/4.1/images/crosshair_formatting.png"
---

<h2><a id='datetime-axis-label' href='/cookbook/4.1/recipes/crosshair_formatting/'>DateTime Axis Label</a></h2>

Crosshair labels display numeric labels by default, but a public field makes it possible to convert positions to DateTime (FromOATime) when generating their axis labels.

```cs
var plt = new ScottPlot.Plot(600, 400);

plt.Title("Crosshair with DateTime Axis");
plt.XLabel("Horizontal Axis");
plt.YLabel("Vertical Axis");

// plot DateTime data
int pointCount = 100;
Random rand = new Random(0);
double[] values = ScottPlot.DataGen.RandomWalk(rand, pointCount);
DateTime[] dates = Enumerable.Range(0, pointCount)
      .Select(x => new DateTime(2016, 06, 27).AddDays(x))
      .ToArray();
double[] xs = dates.Select(x => x.ToOADate()).ToArray();
plt.AddScatter(xs, values);

// add a crosshair
var ch = plt.AddCrosshair(xs[50], values[50]);

// indicaite horizontal axis is DateTime and give a proper DateTime format string
// https://docs.microsoft.com/en-us/dotnet/standard/base-types/custom-date-and-time-format-strings
ch.VerticalLine.PositionFormatter = pos => DateTime.FromOADate(pos).ToString("d");

// use a numeric vertical axis but customize the format string
// https://docs.microsoft.com/en-us/dotnet/standard/base-types/standard-numeric-format-strings
ch.VerticalLine.PositionFormatter = pos => pos.ToString("F4");

plt.SaveFig("crosshair_formatting.png");
```

<img src='../../images/crosshair_formatting.png' class='d-block mx-auto my-5' />


