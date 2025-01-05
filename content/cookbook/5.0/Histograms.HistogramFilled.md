---
Title: Filled Histogram - ScottPlot 5.0 Cookbook
Description: A filled histogram (one with no visible gaps between bars) can be achieved by setting the bar width to the bin size. However, anti-aliasing artifacts may cause white lines to appear between bars. Disable anti-aliasing for each bar to improve appearance of such plots.
URL: /cookbook/5.0/Histograms/HistogramFilled/
BreadcrumbNames: ["ScottPlot 5.0 Cookbook", "Histogram", "Filled Histogram"]
BreadcrumbUrls: ["/cookbook/5.0/", "/cookbook/5.0/Histograms", "/cookbook/5.0/Histograms/HistogramFilled"]
Date: 2025-01-05
Version: ScottPlot 5.0.48
Version: ScottPlot 5.0.48
SearchUrl: "/cookbook/5.0/search/"
ShowEditLink: false
---


<div class='d-flex align-items-center mt-5'>
<h1 class='me-2 text-dark my-0 border-0'>Filled Histogram</h1>
</div>

A filled histogram (one with no visible gaps between bars) can be achieved by setting the bar width to the bin size. However, anti-aliasing artifacts may cause white lines to appear between bars. Disable anti-aliasing for each bar to improve appearance of such plots.

[![](/cookbook/5.0/images/HistogramFilled.png?250105183901)](/cookbook/5.0/images/HistogramFilled.png?250105183901)

{{< recipe-sp5 sourceUrl="https://github.com/ScottPlot/ScottPlot/blob/main/src/ScottPlot5/ScottPlot5%20Cookbook/Recipes/Miscellaneous/Histograms.cs" imageUrl="/cookbook/5.0/images/HistogramFilled.png?250105183901" >}}ScottPlot.Plot myPlot = new();

// Create a histogram from a collection of values
double[] heights = SampleData.MaleHeights();
var hist = ScottPlot.Statistics.Histogram.WithBinSize(1, heights);

// Display the histogram as a bar plot
var barPlot = myPlot.Add.Bars(hist.Bins, hist.Counts);

// Customize the style of each bar
foreach (var bar in barPlot.Bars)
{
    bar.Size = hist.FirstBinSize;
    bar.LineWidth = 0;
    bar.FillStyle.AntiAlias = false;
}

// Customize plot style
myPlot.Axes.Margins(bottom: 0);
myPlot.YLabel("Number of People");
myPlot.XLabel("Height (cm)");

myPlot.SavePng("demo.png", 400, 300);
{{< /recipe-sp5 >}}

<div class='my-5 text-center'>This recipe is one of many in the <a href='/cookbook/5.0/Histograms'>Histogram</a> category</div>


