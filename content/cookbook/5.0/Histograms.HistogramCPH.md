---
Title: Cumulative Probability Histogram - ScottPlot 5.0 Cookbook
Description: A cumulative probability histogram represents the cumulative sum of probabilities or relative frequencies up to each bin, providing a running total of the probability distribution. It is especially useful for evaluating and comparing the distribution of multiple populations.
URL: /cookbook/5.0/Histograms/HistogramCPH/
BreadcrumbNames: ["ScottPlot 5.0 Cookbook", "Histogram", "Cumulative Probability Histogram"]
BreadcrumbUrls: ["/cookbook/5.0/", "/cookbook/5.0/Histograms", "/cookbook/5.0/Histograms/HistogramCPH"]
Date: 2024-10-31
Version: ScottPlot 5.0.42
Version: ScottPlot 5.0.42
SearchUrl: "/cookbook/5.0/search/"
ShowEditLink: false
---


<h2 style='border-bottom: 0;'><a href='/cookbook/5.0/Histograms/HistogramCPH'>Cumulative Probability Histogram</a></h2>

<div class="d-flex mb-2">
<a class="btn btn-sm btn-primary me-1" href="/cookbook/5.0/Histograms/HistogramCPH">Recipe Permalink</a>
<a class="btn btn-sm btn-success me-1" href="/cookbook/5.0/Histograms">Category: Histogram</a>
</div>

A cumulative probability histogram represents the cumulative sum of probabilities or relative frequencies up to each bin, providing a running total of the probability distribution. It is especially useful for evaluating and comparing the distribution of multiple populations.

[![](/cookbook/5.0/images/HistogramCPH.png?241031194635)](/cookbook/5.0/images/HistogramCPH.png?241031194635)

{{< recipe-sp5 >}}ScottPlot.Plot myPlot = new();

// Create a histogram from a collection of values
double[][] heightsByGroup = { SampleData.MaleHeights(100), SampleData.FemaleHeights(100) };
string[] groupNames = { "Male", "Female" };
Color[] groupColors = { Colors.Blue, Colors.Red };

for (int i = 0; i < 2; i++)
{
    var hist = ScottPlot.Statistics.Histogram.WithBinSize(1, firstBin: 140, lastBin: 200);
    hist.AddRange(heightsByGroup[i]);

    var curve = myPlot.Add.ScatterLine(hist.Bins, hist.GetCumulativeProbability(100));
    curve.LineWidth = 1.5f;
    curve.LineColor = groupColors[i];
    curve.LegendText = groupNames[i];
    curve.ConnectStyle = ConnectStyle.StepVertical;
}

// Customize plot style
myPlot.Legend.Alignment = Alignment.LowerRight;
myPlot.YLabel("Cumulative Probability (%)");
myPlot.XLabel("Height (cm)");

myPlot.SavePng("demo.png", 400, 300);
{{< /recipe-sp5 >}}

<hr class='my-5 invisible'>


