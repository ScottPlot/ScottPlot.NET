---
Title: "Histogram Multi-Axis - ScottPlot 4.1 Cookbook"
Description: "This example demonstrates how to display a histogram counts on the primary Y axis and the probability curve on the secondary Y axis."
Date: 2024-01-21
Version: ScottPlot 4.1.71
URL: /cookbook/4.1/recipes/stats_histogrammultiaxis/
BreadcrumbNames: ["ScottPlot 4.1 Cookbook", "Statistics", "Histogram Multi-Axis"]
BreadcrumbUrls: ["/cookbook/4.1/", "/cookbook/4.1/category/statistics", "/cookbook/4.1/recipes/stats_histogrammultiaxis/"]
SearchUrl: "/cookbook/4.1/search/"
OgImage: "/cookbook/4.1/images/stats_histogrammultiaxis.png"
---

<h2><a id='histogram-multi-axis' href='/cookbook/4.1/recipes/stats_histogrammultiaxis/'>Histogram Multi-Axis</a></h2>

This example demonstrates how to display a histogram counts on the primary Y axis and the probability curve on the secondary Y axis.

{{< code-sp4 >}}

```cs
ScottPlot.Version.ShouldBe(4, 1, 71);
var plt = new ScottPlot.Plot(600, 400);

// create a histogram with a fixed number of bins
ScottPlot.Statistics.Histogram hist = new(min: 140, max: 220, binCount: 100);

// add random data to the histogram
Random rand = new(0);
double[] heights = ScottPlot.DataGen.RandomNormal(rand, pointCount: 1234, mean: 178.4, stdDev: 7.6);
hist.AddRange(heights);

// display histogram probabability as a bar plot
var bar = plt.AddBar(values: hist.Counts, positions: hist.Bins);
bar.BarWidth = 1;
bar.FillColor = ColorTranslator.FromHtml("#9bc3eb");
bar.BorderColor = ColorTranslator.FromHtml("#82add9");

// display histogram probability curve as a line plot
var funcPlot = plt.AddFunction(hist.GetProbabilityCurve(heights), Color.Black, 2, LineStyle.Dash);
funcPlot.YAxisIndex = 1;

// customize the plot style
plt.Title("Adult Male Height");
plt.YAxis.Label("Count (#)");
plt.YAxis2.Label("Probability");
plt.YAxis2.Ticks(true);
plt.XAxis.Label("Height (cm)");
plt.SetAxisLimits(yMin: 0);
plt.SetAxisLimits(yMin: 0, yMax: 1.1, yAxisIndex: 1);

plt.SaveFig("stats_histogramMultiAxis.png");
```

{{< /code-sp4 >}}

<img src='../../images/stats_histogrammultiaxis.png' class='d-block mx-auto my-5' />


