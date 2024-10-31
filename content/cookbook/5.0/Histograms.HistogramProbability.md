---
Title: Histogram of Probabilities - ScottPlot 5.0 Cookbook
Description: Histograms may be displayed as the probability for each value falling inside a bin
URL: /cookbook/5.0/Histograms/HistogramProbability/
BreadcrumbNames: ["ScottPlot 5.0 Cookbook", "Histogram", "Histogram of Probabilities"]
BreadcrumbUrls: ["/cookbook/5.0/", "/cookbook/5.0/Histograms", "/cookbook/5.0/Histograms/HistogramProbability"]
Date: 2024-10-31
Version: ScottPlot 5.0.42
Version: ScottPlot 5.0.42
SearchUrl: "/cookbook/5.0/search/"
ShowEditLink: false
---


<h2 style='border-bottom: 0;'><a href='/cookbook/5.0/Histograms/HistogramProbability'>Histogram of Probabilities</a></h2>

<div class="d-flex mb-2">
<a class="btn btn-sm btn-primary me-1" href="/cookbook/5.0/Histograms/HistogramProbability">Recipe Permalink</a>
<a class="btn btn-sm btn-success me-1" href="/cookbook/5.0/Histograms">Category: Histogram</a>
</div>

Histograms may be displayed as the probability for each value falling inside a bin

[![](/cookbook/5.0/images/HistogramProbability.png?241031194635)](/cookbook/5.0/images/HistogramProbability.png?241031194635)

{{< recipe-sp5 >}}ScottPlot.Plot myPlot = new();

// Create a histogram from a collection of values
double[] heights = SampleData.MaleHeights();
var hist = ScottPlot.Statistics.Histogram.WithBinCount(10, heights);

// Display the histogram as a bar plot
var barPlot = myPlot.Add.Bars(hist.Bins, hist.GetProbability(100));

// Customize the style of each bar
foreach (var bar in barPlot.Bars)
{
    bar.Size = hist.FirstBinSize * 0.8;
}

// Customize plot style
myPlot.Axes.Margins(bottom: 0);
myPlot.YLabel("Probability (%)");
myPlot.XLabel("Height (cm)");

myPlot.SavePng("demo.png", 400, 300);
{{< /recipe-sp5 >}}

<hr class='my-5 invisible'>


