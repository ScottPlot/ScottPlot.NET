---
Title: Filled Histogram - ScottPlot 5.0 Cookbook
Description: A filled histogram (one with no visible gaps between bars) can be achieved by setting the bar width to the bin size. However, anti-aliasing artifacts may cause white lines to appear between bars. Disable anti-aliasing for each bar to improve appearance of such plots.
URL: /cookbook/5.0/Histograms/HistogramFilled/
BreadcrumbNames: ["ScottPlot 5.0 Cookbook", "Histogram", "Filled Histogram"]
BreadcrumbUrls: ["/cookbook/5.0/", "/cookbook/5.0/Histograms", "/cookbook/5.0/Histograms/HistogramFilled"]
Date: 2024-10-31
Version: ScottPlot 5.0.42
Version: ScottPlot 5.0.42
SearchUrl: "/cookbook/5.0/search/"
ShowEditLink: false
---


<h2 style='border-bottom: 0;'><a href='/cookbook/5.0/Histograms/HistogramFilled'>Filled Histogram</a></h2>

<div class="d-flex mb-2">
<a class="btn btn-sm btn-primary me-1" href="/cookbook/5.0/Histograms/HistogramFilled">Recipe Permalink</a>
<a class="btn btn-sm btn-success me-1" href="/cookbook/5.0/Histograms">Category: Histogram</a>
</div>

A filled histogram (one with no visible gaps between bars) can be achieved by setting the bar width to the bin size. However, anti-aliasing artifacts may cause white lines to appear between bars. Disable anti-aliasing for each bar to improve appearance of such plots.

[![](/cookbook/5.0/images/HistogramFilled.png?241031194635)](/cookbook/5.0/images/HistogramFilled.png?241031194635)

{{< recipe-sp5 >}}ScottPlot.Plot myPlot = new();

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

<hr class='my-5 invisible'>


