---
Title: "Histogram - ScottPlot 4.1 Cookbook"
Description: "The Histogram class provides an easy way to count the number of data values in binned ranges."
Date: 2023-12-28
Version: ScottPlot 4.1.70
URL: /cookbook/4.1/recipes/stats_histogram/
BreadcrumbNames: ["ScottPlot 4.1 Cookbook", "Statistics", "Histogram"]
BreadcrumbUrls: ["/cookbook/4.1/", "/cookbook/4.1/category/statistics", "/cookbook/4.1/recipes/stats_histogram/"]
SearchUrl: "/cookbook/4.1/search/"
OgImage: "/cookbook/4.1/images/stats_histogram.png"
---

<h2><a id='histogram' href='/cookbook/4.1/recipes/stats_histogram/'>Histogram</a></h2>

The Histogram class provides an easy way to count the number of data values in binned ranges.

```cs
var plt = new ScottPlot.Plot(600, 400);

// create a histogram with a fixed number of bins
ScottPlot.Statistics.Histogram hist = new(min: 140, max: 220, binCount: 100);

// add random data to the histogram
Random rand = new(0);
double[] heights = ScottPlot.DataGen.RandomNormal(rand, pointCount: 1234, mean: 178.4, stdDev: 7.6);
hist.AddRange(heights);

// show the histogram counts as a bar plot
plt.AddBar(values: hist.Counts, positions: hist.Bins);

// customize the plot style
plt.YAxis.Label("Count (#)");
plt.XAxis.Label("Height (cm)");
plt.SetAxisLimits(yMin: 0);

plt.SaveFig("stats_histogram.png");
```

<img src='../../images/stats_histogram.png' class='d-block mx-auto my-5' />


