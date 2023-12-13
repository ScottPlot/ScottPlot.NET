---
Title: "Probability Histogram - ScottPlot 4.1 Cookbook"
Description: "Histograms can be displayed as binned probability instead of binned counts. The ideal probability curve can also be plotted."
Date: 2023-12-13
Version: ScottPlot 4.1.69
URL: /cookbook/4.1/recipes/stats_histogramprobability/
BreadcrumbNames: ["ScottPlot 4.1 Cookbook", "Statistics", "Probability Histogram"]
BreadcrumbUrls: ["/cookbook/4.1/", "/cookbook/4.1/category/statistics", "/cookbook/4.1/recipes/stats_histogramprobability/"]
SearchUrl: "/cookbook/4.1/search/"
OgImage: "/cookbook/4.1/images/stats_histogramprobability.png"
---

<h2><a id='probability-histogram' href='/cookbook/4.1/recipes/stats_histogramprobability/'>Probability Histogram</a></h2>

Histograms can be displayed as binned probability instead of binned counts. The ideal probability curve can also be plotted.

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
plt.AddFunction(hist.GetProbabilityCurve(heights, true), Color.Black, 2, LineStyle.Dash);

// customize the plot style
plt.Title("Adult Male Height");
plt.YAxis.Label("Probability");
plt.XAxis.Label("Height (cm)");
plt.SetAxisLimits(yMin: 0);

plt.SaveFig("stats_histogramProbability.png");
```

<img src='../../images/stats_histogramprobability.png' class='d-block mx-auto my-5' />


