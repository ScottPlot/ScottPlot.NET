---
Title: Cumulative Probability Histogram - ScottPlot 5.0 Cookbook
Description: A cumulative probability histogram represents the cumulative sum of probabilities or relative frequencies up to each bin, providing a running total of the probability distribution. It is especially useful for evaluating and comparing the distribution of multiple populations.
URL: /cookbook/5.0/Histograms/HistogramCPH/
BreadcrumbNames: ["ScottPlot 5.0 Cookbook", "Histogram", "Cumulative Probability Histogram"]
BreadcrumbUrls: ["/cookbook/5.0/", "/cookbook/5.0/Histograms", "/cookbook/5.0/Histograms/HistogramCPH"]
Date: 2024-11-13
Version: ScottPlot 5.0.45
Version: ScottPlot 5.0.45
SearchUrl: "/cookbook/5.0/search/"
ShowEditLink: false
---


<div class='d-flex align-items-center mt-5'>
<h1 class='me-2 text-dark my-0 border-0'>Cumulative Probability Histogram</h1>
</div>

A cumulative probability histogram represents the cumulative sum of probabilities or relative frequencies up to each bin, providing a running total of the probability distribution. It is especially useful for evaluating and comparing the distribution of multiple populations.

[![](/cookbook/5.0/images/HistogramCPH.png?241112193154)](/cookbook/5.0/images/HistogramCPH.png?241112193154)

{{< recipe-sp5 sourceUrl="https://github.com/ScottPlot/ScottPlot/blob/main/src/ScottPlot5/ScottPlot5%20Cookbook/Recipes/Miscellaneous/Histograms.cs" imageUrl="/cookbook/5.0/images/HistogramCPH.png?241112193154" >}}ScottPlot.Plot myPlot = new();

// Create a histogram from a collection of values
double[][] heightsByGroup = { SampleData.MaleHeights(100), SampleData.FemaleHeights(100) };
string[] groupNames = { "Male", "Female" };
Color[] groupColors = { Colors.Blue, Colors.Red };

for (int i = 0; i &lt; 2; i++)
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

<div class='my-5 text-center'>This recipe is one of many in the <a href='/cookbook/5.0/Histograms'>Histogram</a> category</div>


