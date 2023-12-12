---
Title: "Fixed Size Bins - ScottPlot 4.1 Cookbook"
Description: "A histogram can be created using fixed size bins."
Date: 12/11/2023 7:52:02 PM
Version: ScottPlot 4.1.69
URL: /cookbook/4.1/recipes/stats_histogram_fixed_bins/
BreadcrumbNames: ["ScottPlot 4.1 Cookbook", "Statistics", "Fixed Size Bins"]
BreadcrumbUrls: ["/cookbook/4.1/", "/cookbook/4.1/category/statistics", "/cookbook/4.1/recipes/stats_histogram_fixed_bins/"]
SearchUrl: "/cookbook/4.1/search/"
OgImage: "/cookbook/4.1/images/stats_histogram_fixed_bins.png"
---

<h2><a href='/cookbook/4.1/recipes/stats_histogram_fixed_bins/'>Fixed Size Bins</a></h2>

A histogram can be created using fixed size bins.

```cs
var plt = new ScottPlot.Plot(600, 400);

// create a histogram with a fixed number of bins
var hist = ScottPlot.Statistics.Histogram.WithFixedBinSize(min: 140, max: 220, binSize: 2);

// add random data to the histogram
Random rand = new(0);
double[] heights = ScottPlot.DataGen.RandomNormal(rand, pointCount: 1234, mean: 178.4, stdDev: 7.6);
hist.AddRange(heights);

// show the histogram counts as a bar plot
var bar = plt.AddBar(values: hist.Counts, positions: hist.Bins);
bar.BarWidth = 2;

// customize the plot style
plt.YAxis.Label("Count (#)");
plt.XAxis.Label("Height (cm)");
plt.SetAxisLimits(yMin: 0);

plt.SaveFig("stats_histogram_fixed_bins.png");
```

<img src='../../images/stats_histogram_fixed_bins.png' class='d-block mx-auto my-5' />


