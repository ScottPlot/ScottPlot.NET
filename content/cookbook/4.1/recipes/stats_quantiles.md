---
Title: "Quantiles - ScottPlot 4.1 Cookbook"
Description: "A q-Quantile is a generalization of quartiles and percentiles to any number of buckets."
Date: 12/11/2023 8:13:09 PM
Version: ScottPlot 4.1.69
URL: /cookbook/4.1/recipes/stats_quantiles/
BreadcrumbNames: ["ScottPlot 4.1 Cookbook", "Statistics", "Quantiles"]
BreadcrumbUrls: ["/cookbook/4.1/", "/cookbook/4.1/category/statistics", "/cookbook/4.1/recipes/stats_quantiles/"]
SearchUrl: "/cookbook/4.1/search/"
OgImage: "/cookbook/4.1/images/stats_quantiles.png"
---

<h2><a id='quantiles' href='/cookbook/4.1/recipes/stats_quantiles/'>Quantiles</a></h2>

A q-Quantile is a generalization of quartiles and percentiles to any number of buckets.

```cs
var plt = new ScottPlot.Plot(600, 400);

Random rand = new Random(0);
int pointCount = 500;
double[] xs = DataGen.Consecutive(pointCount);
double[] ys = DataGen.Random(rand, pointCount);

// A septile is a 7-quantile
double secondSeptile = Statistics.Common.Quantile(ys, 2, 7);

plt.Title("Second Septile");
plt.AddScatter(xs, ys, lineWidth: 0, markerShape: MarkerShape.openCircle);
plt.AddHorizontalLine(secondSeptile, width: 3, style: LineStyle.Dash);

plt.SaveFig("stats_quantiles.png");
```

<img src='../../images/stats_quantiles.png' class='d-block mx-auto my-5' />


