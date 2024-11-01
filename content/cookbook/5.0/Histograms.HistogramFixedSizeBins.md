---
Title: Histogram with Fixed Size Bins - ScottPlot 5.0 Cookbook
Description: A histogram can be created using manually defined bin sizes.
URL: /cookbook/5.0/Histograms/HistogramFixedSizeBins/
BreadcrumbNames: ["ScottPlot 5.0 Cookbook", "Histogram", "Histogram with Fixed Size Bins"]
BreadcrumbUrls: ["/cookbook/5.0/", "/cookbook/5.0/Histograms", "/cookbook/5.0/Histograms/HistogramFixedSizeBins"]
Date: 2024-11-01
Version: ScottPlot 5.0.42
Version: ScottPlot 5.0.42
SearchUrl: "/cookbook/5.0/search/"
ShowEditLink: false
---


<div class='d-flex align-items-center mt-5'>
<h1 class='me-2 text-dark my-0 border-0'>Histogram with Fixed Size Bins</h1>
</div>

A histogram can be created using manually defined bin sizes.

[![](/cookbook/5.0/images/HistogramFixedSizeBins.png?241101192719)](/cookbook/5.0/images/HistogramFixedSizeBins.png?241101192719)

{{< recipe-sp5 >}}ScottPlot.Plot myPlot = new();

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

<div class='my-5 text-center'>This recipe is one of many in the <a href='/cookbook/5.0/Histograms'>Histogram</a> category</div>


