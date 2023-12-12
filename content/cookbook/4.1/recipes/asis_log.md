---
Title: "Log Scale - ScottPlot 4.1 Cookbook"
Description: "ScottPlot is designed to display 2D data on linear X and Y axes, but you can log-transform data before plotting it and customize the ticks and grid to give the appearance of logarithmic scales."
Date: 12/11/2023 8:13:09 PM
Version: ScottPlot 4.1.69
URL: /cookbook/4.1/recipes/asis_log/
BreadcrumbNames: ["ScottPlot 4.1 Cookbook", "Advanced Axis Features", "Log Scale"]
BreadcrumbUrls: ["/cookbook/4.1/", "/cookbook/4.1/category/advanced-axis-features", "/cookbook/4.1/recipes/asis_log/"]
SearchUrl: "/cookbook/4.1/search/"
OgImage: "/cookbook/4.1/images/asis_log.png"
---

<h2><a id='log-scale' href='/cookbook/4.1/recipes/asis_log/'>Log Scale</a></h2>

ScottPlot is designed to display 2D data on linear X and Y axes, but you can log-transform data before plotting it and customize the ticks and grid to give the appearance of logarithmic scales.

```cs
var plt = new ScottPlot.Plot(600, 400);

// These are the dat we will plot with a linear X scale but log Y scale
double[] xs = { 1, 2, 3, 4, 5 };
double[] ys = { 10, 2_000, 50_000, 1_000_000, 1_500_000 };

// Plot the Log10 of all the Y values
double[] logYs = ys.Select(y => Math.Log10(y)).ToArray();
var scatter = plt.AddScatter(xs, logYs, lineWidth: 2, markerSize: 10);

// Use a custom formatter to control the label for each tick mark
static string logTickLabels(double y) => Math.Pow(10, y).ToString("N0");
plt.YAxis.TickLabelFormat(logTickLabels);

// Use log-spaced minor tick marks and grid lines to make it more convincing
plt.YAxis.MinorLogScale(true);
plt.YAxis.MajorGrid(true, Color.FromArgb(80, Color.Black));
plt.YAxis.MinorGrid(true, Color.FromArgb(20, Color.Black));
plt.XAxis.MajorGrid(true, Color.FromArgb(80, Color.Black));

// Set the axis limits manually to ensure edges terminate at desirable locations
plt.SetAxisLimits(0, 6, 0, Math.Log10(10_000_000));

plt.SaveFig("asis_log.png");
```

<img src='../../images/asis_log.png' class='d-block mx-auto my-5' />


