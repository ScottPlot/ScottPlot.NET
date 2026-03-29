---
Title: Histogram of Probabilities - ScottPlot 5 Cookbook
Description: Histograms may be displayed as the probability for each value falling inside a bin
URL: /cookbook/5/Histograms/HistogramProbability/
BreadcrumbNames: ["ScottPlot 5 Cookbook", "Histogram", "Histogram of Probabilities"]
BreadcrumbUrls: ["/cookbook/5/", "/cookbook/5/Histograms", "/cookbook/5/Histograms/HistogramProbability"]
Date: 2026-03-29
Version: ScottPlot 5.1.58
Version: ScottPlot 5.1.58
SearchUrl: "/cookbook/5/search/"
ShowEditLink: false
---


<div class='d-flex align-items-center mt-5'>
<h1 class='me-2 text-dark my-0 border-0'>Histogram of Probabilities</h1>
</div>

Histograms may be displayed as the probability for each value falling inside a bin

[![](/cookbook/5/images/HistogramProbability.png?260329072039)](/cookbook/5/images/HistogramProbability.png?260329072039)

{{< recipe-sp5 sourceUrl="https://github.com/ScottPlot/ScottPlot/blob/main/src/ScottPlot5/ScottPlot5%20Cookbook/Recipes/Miscellaneous/Histograms.cs" imageUrl="/cookbook/5/images/HistogramProbability.png?260329072039" >}}ScottPlot.Plot myPlot = new();

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

<div class='my-5 text-center'>This recipe is one of many in the <a href='/cookbook/5/Histograms'>Histogram</a> category</div>


