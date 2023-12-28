---
Title: "Log Scale Tick Density - ScottPlot 4.1 Cookbook"
Description: "Numer of minor ticks between major ticks can be customized."
Date: 2023-12-28
Version: ScottPlot 4.1.70
URL: /cookbook/4.1/recipes/asis_logtickdensity/
BreadcrumbNames: ["ScottPlot 4.1 Cookbook", "Advanced Axis Features", "Log Scale Tick Density"]
BreadcrumbUrls: ["/cookbook/4.1/", "/cookbook/4.1/category/advanced-axis-features", "/cookbook/4.1/recipes/asis_logtickdensity/"]
SearchUrl: "/cookbook/4.1/search/"
OgImage: "/cookbook/4.1/images/asis_logtickdensity.png"
---

<h2><a id='log-scale-tick-density' href='/cookbook/4.1/recipes/asis_logtickdensity/'>Log Scale Tick Density</a></h2>

Numer of minor ticks between major ticks can be customized.

```cs
var plt = new ScottPlot.Plot(600, 400);

double[] ys = ScottPlot.DataGen.Range(100, 10_000, 100, true);
double[] xs = ScottPlot.DataGen.Consecutive(ys.Length);
double[] logYs = ys.Select(y => Math.Log10(y)).ToArray();

var scatter = plt.AddScatter(xs, logYs);

static string logTickLabels(double y) => Math.Pow(10, y).ToString("N0");
plt.YAxis.TickLabelFormat(logTickLabels);

// set the number of minor ticks per major tick here
plt.YAxis.MinorLogScale(true, minorTickCount: 20);

// darken grid line colors
plt.YAxis.MinorGrid(true);
plt.YAxis.MinorGrid(true, Color.FromArgb(20, Color.Black));
plt.YAxis.MajorGrid(true, Color.FromArgb(80, Color.Black));
plt.XAxis.MajorGrid(true, Color.FromArgb(80, Color.Black));

plt.SaveFig("asis_logTickDensity.png");
```

<img src='../../images/asis_logtickdensity.png' class='d-block mx-auto my-5' />


