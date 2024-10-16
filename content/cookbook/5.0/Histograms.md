---
Title: Histogram - ScottPlot 5.0 Cookbook
Description: Histograms graphically represent the distribution of numerical data by grouping values into ranges (bins) and displaying the frequency or count of points in each bin.
URL: /cookbook/5.0/Histograms/
BreadcrumbNames: ["ScottPlot 5.0 Cookbook", "Histogram"]
BreadcrumbUrls: ["/cookbook/5.0/", "/cookbook/5.0/Histograms"]
Date: 2024-10-16
Version: ScottPlot 5.0.40
Version: ScottPlot 5.0.40
SearchUrl: "/cookbook/5.0/search/"
ShowEditLink: false
---

# Histogram


<h2><a href='/cookbook/5.0/Histograms/HistogramQuickstart'>Histogram Quickstart</a></h2>

A histogram can be created from a collection of values.

[![](/cookbook/5.0/images/HistogramQuickstart.png?241016194708)](/cookbook/5.0/images/HistogramQuickstart.png?241016194708)

{{< code-sp5 >}}

```cs
ScottPlot.Plot myPlot = new();

// Create a histogram from a collection of values
double[] heights = Generate.RandomNormal(count: 1000, mean: 160, stdDev: 20);
ScottPlot.Statistics.Histogram hist = new(heights, 20);

// Display the histogram as a bar plot
var barPlot = myPlot.Add.Bars(hist.Bins, hist.Counts);

// Size each bar slightly less than the width of a bin
foreach (var bar in barPlot.Bars)
{
    bar.Size = hist.BinSize * .8;
}

// Customize plot style
myPlot.Axes.Margins(bottom: 0);
myPlot.YLabel("Number of People");
myPlot.XLabel("Height (cm)");

myPlot.SavePng("demo.png", 400, 300);

```

{{< /code-sp5 >}}

<hr class='my-5 invisible'>

