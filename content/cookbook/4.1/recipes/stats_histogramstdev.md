---
Title: "Histogram Stdev - ScottPlot 4.1 Cookbook"
Description: "This example demonstrates how to display a histogram with labeled mean and standard deviations."
Date: 2023-12-24
Version: ScottPlot 4.1.69
URL: /cookbook/4.1/recipes/stats_histogramstdev/
BreadcrumbNames: ["ScottPlot 4.1 Cookbook", "Statistics", "Histogram Stdev"]
BreadcrumbUrls: ["/cookbook/4.1/", "/cookbook/4.1/category/statistics", "/cookbook/4.1/recipes/stats_histogramstdev/"]
SearchUrl: "/cookbook/4.1/search/"
OgImage: "/cookbook/4.1/images/stats_histogramstdev.png"
---

<h2><a id='histogram-stdev' href='/cookbook/4.1/recipes/stats_histogramstdev/'>Histogram Stdev</a></h2>

This example demonstrates how to display a histogram with labeled mean and standard deviations.

```cs
var plt = new ScottPlot.Plot(600, 400);

// create a histogram with a fixed number of bins
ScottPlot.Statistics.Histogram hist = new(min: 140, max: 220, binCount: 100);

// add random data to the histogram
Random rand = new(0);
double[] heights = ScottPlot.DataGen.RandomNormal(rand, pointCount: 1234, mean: 178.4, stdDev: 7.6);
hist.AddRange(heights);

// display histogram probabability as a bar plot
double[] probabilities = hist.GetProbability();
var bar = plt.AddBar(values: probabilities, positions: hist.Bins);
bar.BarWidth = 1;
bar.FillColor = ColorTranslator.FromHtml("#9bc3eb");
bar.BorderColor = ColorTranslator.FromHtml("#82add9");

// display histogram probability curve as a line plot
plt.AddFunction(hist.GetProbabilityCurve(heights, true), Color.Magenta, 2, LineStyle.Dash);

// display vertical lines at points of interest
var stats = new ScottPlot.Statistics.BasicStats(heights);
plt.AddVerticalLine(stats.Mean, Color.Black, 2, LineStyle.Solid, "mean");
plt.AddVerticalLine(stats.Mean - stats.StDev, Color.Black, 2, LineStyle.Dash, "1 SD");
plt.AddVerticalLine(stats.Mean + stats.StDev, Color.Black, 2, LineStyle.Dash);
plt.AddVerticalLine(stats.Mean - stats.StDev * 2, Color.Black, 2, LineStyle.Dot, "2 SD");
plt.AddVerticalLine(stats.Mean + stats.StDev * 2, Color.Black, 2, LineStyle.Dot);
plt.AddVerticalLine(stats.Min, Color.Gray, 1, LineStyle.Dash, "min/max");
plt.AddVerticalLine(stats.Max, Color.Gray, 1, LineStyle.Dash);
plt.Legend(location: Alignment.UpperRight);

// customize the plot style
plt.Title("Adult Male Height");
plt.YAxis.Label("Probability");
plt.XAxis.Label("Height (cm)");
plt.SetAxisLimits(yMin: 0);

plt.SaveFig("stats_histogramStdev.png");
```

<img src='../../images/stats_histogramstdev.png' class='d-block mx-auto my-5' />


