---
Title: Histogram with Second Axis Probability - ScottPlot 5.0 Cookbook
Description: A probability curve may be placed on a secondary axis to allow counts to be displayed alongside probabilities with percent units
URL: /cookbook/5.0/Histograms/HistogramProbabilityCurveSecondAxis/
BreadcrumbNames: ["ScottPlot 5.0 Cookbook", "Histogram", "Histogram with Second Axis Probability"]
BreadcrumbUrls: ["/cookbook/5.0/", "/cookbook/5.0/Histograms", "/cookbook/5.0/Histograms/HistogramProbabilityCurveSecondAxis"]
Date: 2024-11-24
Version: ScottPlot 5.0.47
Version: ScottPlot 5.0.47
SearchUrl: "/cookbook/5.0/search/"
ShowEditLink: false
---


<div class='d-flex align-items-center mt-5'>
<h1 class='me-2 text-dark my-0 border-0'>Histogram with Second Axis Probability</h1>
</div>

A probability curve may be placed on a secondary axis to allow counts to be displayed alongside probabilities with percent units

[![](/cookbook/5.0/images/HistogramProbabilityCurveSecondAxis.png?241124170640)](/cookbook/5.0/images/HistogramProbabilityCurveSecondAxis.png?241124170640)

{{< recipe-sp5 sourceUrl="https://github.com/ScottPlot/ScottPlot/blob/main/src/ScottPlot5/ScottPlot5%20Cookbook/Recipes/Miscellaneous/Histograms.cs" imageUrl="/cookbook/5.0/images/HistogramProbabilityCurveSecondAxis.png?241124170640" >}}ScottPlot.Plot myPlot = new();

// Create a histogram from a collection of values
double[] heights = SampleData.MaleHeights();
var hist = ScottPlot.Statistics.Histogram.WithBinCount(100, heights);

// Display the histogram as a bar plot
var barPlot = myPlot.Add.Bars(hist.Bins, hist.Counts);

// Customize the style of each bar
foreach (var bar in barPlot.Bars)
{
    bar.Size = hist.FirstBinSize;
    bar.LineWidth = 0;
    bar.FillStyle.AntiAlias = false;
}

// Add a probability curve to a secondary axis
ScottPlot.Statistics.ProbabilityDensity pd = new(heights);
double[] xs = Generate.Range(heights.Min(), heights.Max(), 1);
double[] ys = pd.GetYs(xs, 100);

var curve = myPlot.Add.ScatterLine(xs, ys);
curve.Axes.YAxis = myPlot.Axes.Right;
curve.LineWidth = 2;
curve.LineColor = Colors.Black;
curve.LinePattern = LinePattern.DenselyDashed;

// Customize plot style
myPlot.Axes.Margins(bottom: 0);
myPlot.YLabel("Number of People");
myPlot.XLabel("Height (cm)");
myPlot.Axes.Right.Label.Text = "Probability (%)";

myPlot.SavePng("demo.png", 400, 300);
{{< /recipe-sp5 >}}

<div class='my-5 text-center'>This recipe is one of many in the <a href='/cookbook/5.0/Histograms'>Histogram</a> category</div>


