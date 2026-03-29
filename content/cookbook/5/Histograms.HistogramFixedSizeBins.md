---
Title: Histogram with Fixed Size Bins - ScottPlot 5 Cookbook
Description: A histogram can be created using manually defined bin sizes.
URL: /cookbook/5/Histograms/HistogramFixedSizeBins/
BreadcrumbNames: ["ScottPlot 5 Cookbook", "Histogram", "Histogram with Fixed Size Bins"]
BreadcrumbUrls: ["/cookbook/5/", "/cookbook/5/Histograms", "/cookbook/5/Histograms/HistogramFixedSizeBins"]
Date: 2026-03-29
Version: ScottPlot 5.1.58
Version: ScottPlot 5.1.58
SearchUrl: "/cookbook/5/search/"
ShowEditLink: false
---


<div class='d-flex align-items-center mt-5'>
<h1 class='me-2 text-dark my-0 border-0'>Histogram with Fixed Size Bins</h1>
</div>

A histogram can be created using manually defined bin sizes.

[![](/cookbook/5/images/HistogramFixedSizeBins.png?260329072039)](/cookbook/5/images/HistogramFixedSizeBins.png?260329072039)

{{< recipe-sp5 sourceUrl="https://github.com/ScottPlot/ScottPlot/blob/main/src/ScottPlot5/ScottPlot5%20Cookbook/Recipes/Miscellaneous/Histograms.cs" imageUrl="/cookbook/5/images/HistogramFixedSizeBins.png?260329072039" >}}ScottPlot.Plot myPlot = new();

// Create a histogram from a collection of values
double[] heights = SampleData.MaleHeights();
var hist = ScottPlot.Statistics.Histogram.WithBinSize(2, heights);

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


