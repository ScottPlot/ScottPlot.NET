---
Title: Multiple Histograms - ScottPlot 5.0 Cookbook
Description: Demonstrates how to use semitransparent bars to display histograms from overlapping datasets
URL: /cookbook/5.0/Histograms/HistogramMultiple/
BreadcrumbNames: ["ScottPlot 5.0 Cookbook", "Histogram", "Multiple Histograms"]
BreadcrumbUrls: ["/cookbook/5.0/", "/cookbook/5.0/Histograms", "/cookbook/5.0/Histograms/HistogramMultiple"]
Date: 2025-01-05
Version: ScottPlot 5.0.48
Version: ScottPlot 5.0.48
SearchUrl: "/cookbook/5.0/search/"
ShowEditLink: false
---


<div class='d-flex align-items-center mt-5'>
<h1 class='me-2 text-dark my-0 border-0'>Multiple Histograms</h1>
</div>

Demonstrates how to use semitransparent bars to display histograms from overlapping datasets

[![](/cookbook/5.0/images/HistogramMultiple.png?250105183901)](/cookbook/5.0/images/HistogramMultiple.png?250105183901)

{{< recipe-sp5 sourceUrl="https://github.com/ScottPlot/ScottPlot/blob/main/src/ScottPlot5/ScottPlot5%20Cookbook/Recipes/Miscellaneous/Histograms.cs" imageUrl="/cookbook/5.0/images/HistogramMultiple.png?250105183901" >}}ScottPlot.Plot myPlot = new();

// Create a histogram from a collection of values
double[][] heightsByGroup = { SampleData.MaleHeights(), SampleData.FemaleHeights() };
string[] groupNames = { "Male", "Female" };
Color[] groupColors = { Colors.Blue, Colors.Red };

for (int i = 0; i &lt; 2; i++)
{
    double[] heights = heightsByGroup[i];
    var hist = ScottPlot.Statistics.Histogram.WithBinSize(1, heights);

    // Display the histogram as a bar plot
    var barPlot = myPlot.Add.Bars(hist.Bins, hist.GetProbability());

    // Customize the style of each bar
    foreach (var bar in barPlot.Bars)
    {
        bar.Size = hist.FirstBinSize;
        bar.LineWidth = 0;
        bar.FillStyle.AntiAlias = false;
        bar.FillColor = groupColors[i].WithAlpha(.2);
    }

    // Plot the probability curve on top the histogram
    ScottPlot.Statistics.ProbabilityDensity pd = new(heights);
    double[] xs = Generate.Range(heights.Min(), heights.Max(), 1);
    double scale = 1.0 / hist.Bins.Select(x =&gt; pd.GetY(x)).Sum();
    double[] ys = pd.GetYs(xs, scale);

    var curve = myPlot.Add.ScatterLine(xs, ys);
    curve.LineWidth = 2;
    curve.LineColor = groupColors[i];
    curve.LinePattern = LinePattern.DenselyDashed;
    curve.LegendText = groupNames[i];
}

// Customize plot style
myPlot.Legend.Alignment = Alignment.UpperRight;
myPlot.Axes.Margins(bottom: 0);
myPlot.YLabel("Probability (%)");
myPlot.XLabel("Height (cm)");
myPlot.HideGrid();

myPlot.SavePng("demo.png", 400, 300);
{{< /recipe-sp5 >}}

<div class='my-5 text-center'>This recipe is one of many in the <a href='/cookbook/5.0/Histograms'>Histogram</a> category</div>


