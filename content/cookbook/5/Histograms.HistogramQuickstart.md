---
Title: Histogram Quickstart - ScottPlot 5 Cookbook
Description: A histogram can be created from a collection of values.
URL: /cookbook/5/Histograms/HistogramQuickstart/
BreadcrumbNames: ["ScottPlot 5 Cookbook", "Histogram", "Histogram Quickstart"]
BreadcrumbUrls: ["/cookbook/5/", "/cookbook/5/Histograms", "/cookbook/5/Histograms/HistogramQuickstart"]
Date: 2025-10-11
Version: ScottPlot 5.1.57
Version: ScottPlot 5.1.57
SearchUrl: "/cookbook/5/search/"
ShowEditLink: false
---


<div class='d-flex align-items-center mt-5'>
<h1 class='me-2 text-dark my-0 border-0'>Histogram Quickstart</h1>
</div>

A histogram can be created from a collection of values.

[![](/cookbook/5/images/HistogramQuickstart.png?251011113742)](/cookbook/5/images/HistogramQuickstart.png?251011113742)

{{< recipe-sp5 sourceUrl="https://github.com/ScottPlot/ScottPlot/blob/main/src/ScottPlot5/ScottPlot5%20Cookbook/Recipes/Miscellaneous/Histograms.cs" imageUrl="/cookbook/5/images/HistogramQuickstart.png?251011113742" >}}ScottPlot.Plot myPlot = new();

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

<div class='my-5 text-center'>This recipe is one of many in the <a href='/cookbook/5/Histograms'>Histogram</a> category</div>


