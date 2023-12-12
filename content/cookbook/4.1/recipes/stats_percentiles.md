---
Title: "Percentiles - ScottPlot 4.1 Cookbook"
Description: "Percentiles are a good tool to analyze the distribution of your data and filter out extreme values."
Date: 12/11/2023 8:04:06 PM
Version: ScottPlot 4.1.69
URL: /cookbook/4.1/recipes/stats_percentiles/
BreadcrumbNames: ["ScottPlot 4.1 Cookbook", "Statistics", "Percentiles"]
BreadcrumbUrls: ["/cookbook/4.1/", "/cookbook/4.1/category/statistics", "/cookbook/4.1/recipes/stats_percentiles/"]
SearchUrl: "/cookbook/4.1/search/"
OgImage: "/cookbook/4.1/images/stats_percentiles.png"
---

<h2><a href='/cookbook/4.1/recipes/stats_percentiles/'>Percentiles</a></h2>

Percentiles are a good tool to analyze the distribution of your data and filter out extreme values.

```cs
var plt = new ScottPlot.Plot(600, 400);

Random rand = new Random(0);
int pointCount = 500;
double[] xs = DataGen.Consecutive(pointCount);
double[] ys = DataGen.Random(rand, pointCount);

double tenthPercentile = Statistics.Common.Percentile(ys, 10);

plt.Title("10th Percentile");
plt.AddScatter(xs, ys, lineWidth: 0, markerShape: MarkerShape.openCircle);
plt.AddHorizontalLine(tenthPercentile, width: 3, style: LineStyle.Dash);

plt.SaveFig("stats_percentiles.png");
```

<img src='../../images/stats_percentiles.png' class='d-block mx-auto my-5' />


