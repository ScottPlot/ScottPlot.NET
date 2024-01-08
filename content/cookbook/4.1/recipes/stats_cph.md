---
Title: "CPH - ScottPlot 4.1 Cookbook"
Description: "This example demonstrates how to plot a cumulative probability histogram (CPH) to compare the distribution of two datasets."
Date: 2024-01-07
Version: ScottPlot 4.1.70
URL: /cookbook/4.1/recipes/stats_cph/
BreadcrumbNames: ["ScottPlot 4.1 Cookbook", "Statistics", "CPH"]
BreadcrumbUrls: ["/cookbook/4.1/", "/cookbook/4.1/category/statistics", "/cookbook/4.1/recipes/stats_cph/"]
SearchUrl: "/cookbook/4.1/search/"
OgImage: "/cookbook/4.1/images/stats_cph.png"
---

<h2><a id='cph' href='/cookbook/4.1/recipes/stats_cph/'>CPH</a></h2>

This example demonstrates how to plot a cumulative probability histogram (CPH) to compare the distribution of two datasets.

```cs
ScottPlot.Version.ShouldBe(4, 1, 70);
var plt = new ScottPlot.Plot(600, 400);

// create two histogram with fixed bin sizes
ScottPlot.Statistics.Histogram hist1 = new(min: 0, max: 100, binCount: 100);
ScottPlot.Statistics.Histogram hist2 = new(min: 0, max: 100, binCount: 100);

// create sample data for two datasets
Random rand = new Random(0);
hist1.AddRange(DataGen.RandomNormal(rand, pointCount: 1000, mean: 50, stdDev: 20));
hist2.AddRange(DataGen.RandomNormal(rand, pointCount: 1000, mean: 45, stdDev: 25));

// display datasets as step plots
plt.AddScatterStep(xs: hist1.Bins, ys: hist1.GetCumulativeProbability(), label: "Sample A");
plt.AddScatterStep(xs: hist2.Bins, ys: hist2.GetCumulativeProbability(), label: "Sample B");

// decorate the plot
plt.Legend();
plt.SetAxisLimits(yMin: 0, yMax: 1);
plt.Title("Cumulative Probability Histogram");
plt.XAxis.Label("Probability (fraction)");
plt.YAxis.Label("Value (units)");

plt.SaveFig("stats_cph.png");
```

<img src='../../images/stats_cph.png' class='d-block mx-auto my-5' />


