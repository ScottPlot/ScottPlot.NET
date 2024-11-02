---
Title: Histogram with Probability Curve - ScottPlot 5.0 Cookbook
Description: A probability curve may be generated for a Gaussian distributed sample.
URL: /cookbook/5.0/Histograms/HistogramProbabilityCurve/
BreadcrumbNames: ["ScottPlot 5.0 Cookbook", "Histogram", "Histogram with Probability Curve"]
BreadcrumbUrls: ["/cookbook/5.0/", "/cookbook/5.0/Histograms", "/cookbook/5.0/Histograms/HistogramProbabilityCurve"]
Date: 2024-11-02
Version: ScottPlot 5.0.42
Version: ScottPlot 5.0.42
SearchUrl: "/cookbook/5.0/search/"
ShowEditLink: false
---


<div class='d-flex align-items-center mt-5'>
<h1 class='me-2 text-dark my-0 border-0'>Histogram with Probability Curve</h1>
</div>

A probability curve may be generated for a Gaussian distributed sample.

[![](/cookbook/5.0/images/HistogramProbabilityCurve.png?241102170938)](/cookbook/5.0/images/HistogramProbabilityCurve.png?241102170938)

{{< recipe-sp5 sourceUrl="https://github.com/ScottPlot/ScottPlot/blob/main/src/ScottPlot5/ScottPlot5%20Cookbook/Recipes/Miscellaneous/Histograms.cs" imageUrl="/cookbook/5.0/images/HistogramProbabilityCurve.png?241102170938" >}}ScottPlot.Plot myPlot = new();

// Create a histogram from a collection of values
double[] heights = SampleData.MaleHeights();
var hist = ScottPlot.Statistics.Histogram.WithBinCount(100, heights);

// Display the histogram as a bar plot
var barPlot = myPlot.Add.Bars(hist.Bins, hist.GetProbability());

// Customize the style of each bar
foreach (var bar in barPlot.Bars)
{
    bar.Size = hist.FirstBinSize;
    bar.LineWidth = 0;
    bar.FillStyle.AntiAlias = false;
    bar.FillColor = Colors.C0.Lighten(.3);
}

// Plot the probability curve on top the histogram
ScottPlot.Statistics.ProbabilityDensity pd = new(heights);
double[] xs = Generate.Range(heights.Min(), heights.Max(), 1);
double sumBins = hist.Bins.Select(x => pd.GetY(x)).Sum();
double[] ys = pd.GetYs(xs, 1.0 / sumBins);

var curve = myPlot.Add.ScatterLine(xs, ys);
curve.LineWidth = 2;
curve.LineColor = Colors.Black;
curve.LinePattern = LinePattern.DenselyDashed;

// Customize plot style
myPlot.Axes.Margins(bottom: 0);
myPlot.YLabel("Probability (%)");
myPlot.XLabel("Height (cm)");

myPlot.SavePng("demo.png", 400, 300);
{{< /recipe-sp5 >}}

<div class='my-5 text-center'>This recipe is one of many in the <a href='/cookbook/5.0/Histograms'>Histogram</a> category</div>


