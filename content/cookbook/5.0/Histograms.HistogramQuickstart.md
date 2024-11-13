---
Title: Histogram Quickstart - ScottPlot 5.0 Cookbook
Description: A histogram can be created from a collection of values.
URL: /cookbook/5.0/Histograms/HistogramQuickstart/
BreadcrumbNames: ["ScottPlot 5.0 Cookbook", "Histogram", "Histogram Quickstart"]
BreadcrumbUrls: ["/cookbook/5.0/", "/cookbook/5.0/Histograms", "/cookbook/5.0/Histograms/HistogramQuickstart"]
Date: 2024-11-13
Version: ScottPlot 5.0.45
Version: ScottPlot 5.0.45
SearchUrl: "/cookbook/5.0/search/"
ShowEditLink: false
---


<div class='d-flex align-items-center mt-5'>
<h1 class='me-2 text-dark my-0 border-0'>Histogram Quickstart</h1>
</div>

A histogram can be created from a collection of values.

[![](/cookbook/5.0/images/HistogramQuickstart.png?241112193154)](/cookbook/5.0/images/HistogramQuickstart.png?241112193154)

{{< recipe-sp5 sourceUrl="https://github.com/ScottPlot/ScottPlot/blob/main/src/ScottPlot5/ScottPlot5%20Cookbook/Recipes/Miscellaneous/Histograms.cs" imageUrl="/cookbook/5.0/images/HistogramQuickstart.png?241112193154" >}}ScottPlot.Plot myPlot = new();

// Create a histogram from a collection of values
double[] heights = SampleData.MaleHeights();
var hist = ScottPlot.Statistics.Histogram.WithBinCount(10, heights);

// Display the histogram as a bar plot
var barPlot = myPlot.Add.Bars(hist.Bins, hist.Counts);

// Size each bar slightly less than the width of a bin
foreach (var bar in barPlot.Bars)
{
    bar.Size = hist.FirstBinSize * .8;
}

// Customize plot style
myPlot.Axes.Margins(bottom: 0);
myPlot.YLabel("Number of People");
myPlot.XLabel("Height (cm)");

myPlot.SavePng("demo.png", 400, 300);
{{< /recipe-sp5 >}}

<div class='my-5 text-center'>This recipe is one of many in the <a href='/cookbook/5.0/Histograms'>Histogram</a> category</div>


