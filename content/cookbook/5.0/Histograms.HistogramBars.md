---
Title: Histogram Bars - ScottPlot 5.0 Cookbook
Description: A helper method and plot type has been created to simplify creating a bar plot that displays histogram counts. Note that updates the histogram may appear in real time and the plot will automatically update to display the latest data.
URL: /cookbook/5.0/Histograms/HistogramBars/
BreadcrumbNames: ["ScottPlot 5.0 Cookbook", "Histogram", "Histogram Bars"]
BreadcrumbUrls: ["/cookbook/5.0/", "/cookbook/5.0/Histograms", "/cookbook/5.0/Histograms/HistogramBars"]
Date: 2024-11-24
Version: ScottPlot 5.0.47
Version: ScottPlot 5.0.47
SearchUrl: "/cookbook/5.0/search/"
ShowEditLink: false
---


<div class='d-flex align-items-center mt-5'>
<h1 class='me-2 text-dark my-0 border-0'>Histogram Bars</h1>
</div>

A helper method and plot type has been created to simplify creating a bar plot that displays histogram counts. Note that updates the histogram may appear in real time and the plot will automatically update to display the latest data.

[![](/cookbook/5.0/images/HistogramBars.png?241124170640)](/cookbook/5.0/images/HistogramBars.png?241124170640)

{{< recipe-sp5 sourceUrl="https://github.com/ScottPlot/ScottPlot/blob/main/src/ScottPlot5/ScottPlot5%20Cookbook/Recipes/Miscellaneous/Histograms.cs" imageUrl="/cookbook/5.0/images/HistogramBars.png?241124170640" >}}ScottPlot.Plot myPlot = new();

// create an empty histogram and display it as a bar plot
var hist = ScottPlot.Statistics.Histogram.WithBinCount(count: 20, minValue: 140, maxValue: 220);
var histPlot = myPlot.Add.Histogram(hist);
histPlot.BarWidthFraction = 0.8;

// histogram counts are updated automatically as new data is added
double[] newData = SampleData.MaleHeights();
hist.AddRange(newData);

myPlot.SavePng("demo.png", 400, 300);
{{< /recipe-sp5 >}}

<div class='my-5 text-center'>This recipe is one of many in the <a href='/cookbook/5.0/Histograms'>Histogram</a> category</div>


