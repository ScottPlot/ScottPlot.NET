---
Title: "Multiple Histograms - ScottPlot 4.1 Cookbook"
Description: "This example demonstrates two histograms on the same plot. Note the use of fractional units on the vertical axis, allowing easy comparison of datasets with different numbers of points. Unlike the previous example, this one does not use multiple axes."
Date: 2024-01-07
Version: ScottPlot 4.1.70
URL: /cookbook/4.1/recipes/stats_histogram2/
BreadcrumbNames: ["ScottPlot 4.1 Cookbook", "Statistics", "Multiple Histograms"]
BreadcrumbUrls: ["/cookbook/4.1/", "/cookbook/4.1/category/statistics", "/cookbook/4.1/recipes/stats_histogram2/"]
SearchUrl: "/cookbook/4.1/search/"
OgImage: "/cookbook/4.1/images/stats_histogram2.png"
---

<h2><a id='multiple-histograms' href='/cookbook/4.1/recipes/stats_histogram2/'>Multiple Histograms</a></h2>

This example demonstrates two histograms on the same plot. Note the use of fractional units on the vertical axis, allowing easy comparison of datasets with different numbers of points. Unlike the previous example, this one does not use multiple axes.

```cs
ScottPlot.Version.ShouldBe(4, 1, 70);
var plt = new ScottPlot.Plot(600, 400);

// create a histograms with a fixed number of bins
ScottPlot.Statistics.Histogram histMale = new(min: 140, max: 210, binCount: 70);
ScottPlot.Statistics.Histogram histFemale = new(min: 140, max: 210, binCount: 70);

// add random data to the histogram
Random rand = new(0);
double[] maleHeights = ScottPlot.DataGen.RandomNormal(rand, pointCount: 2345, mean: 178.4, stdDev: 7.6);
double[] femaleHeights = ScottPlot.DataGen.RandomNormal(rand, pointCount: 1234, mean: 164.7, stdDev: 7.1);
histMale.AddRange(maleHeights);
histFemale.AddRange(femaleHeights);

// plot histograms
var barMale = plt.AddBar(values: histMale.GetProbability(), positions: histMale.Bins);
barMale.BarWidth = 1;
barMale.FillColor = Color.FromArgb(50, Color.Blue);
barMale.BorderLineWidth = 0;

var barFemale = plt.AddBar(values: histFemale.GetProbability(), positions: histFemale.Bins);
barFemale.BarWidth = 1;
barFemale.FillColor = Color.FromArgb(50, Color.Red);
barFemale.BorderLineWidth = 0;

// plot probability curves
var maleCurve = plt.AddFunction(histMale.GetProbabilityCurve(maleHeights, true), Color.Blue, 2, LineStyle.Solid);
var femaleCurve = plt.AddFunction(histFemale.GetProbabilityCurve(femaleHeights, true), Color.Red, 2, LineStyle.Solid);

// setup legend
maleCurve.Label = $"Male (n={maleHeights.Length:N0})";
femaleCurve.Label = $"Female (n={femaleHeights.Length:N0})";
plt.Legend(location: ScottPlot.Alignment.UpperRight);

// customize styling
plt.Title("Human Height by Sex");
plt.YLabel("Probability (%)");
plt.XLabel("Height (cm)");
plt.SetAxisLimits(yMin: 0);

plt.SaveFig("stats_histogram2.png");
```

<img src='../../images/stats_histogram2.png' class='d-block mx-auto my-5' />


