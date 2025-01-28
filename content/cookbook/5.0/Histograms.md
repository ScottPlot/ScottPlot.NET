---
Title: Histogram - ScottPlot 5.0 Cookbook
Description: Histograms graphically represent the distribution of numerical data by grouping values into ranges (bins) and displaying the frequency or count of points in each bin.
URL: /cookbook/5.0/Histograms/
BreadcrumbNames: ["ScottPlot 5.0 Cookbook", "Histogram"]
BreadcrumbUrls: ["/cookbook/5.0/", "/cookbook/5.0/Histograms"]
Date: 2025-01-26
Version: ScottPlot 5.0.55
Version: ScottPlot 5.0.55
SearchUrl: "/cookbook/5.0/search/"
ShowEditLink: false
---

<h1>Histogram</h1>


<div class='d-flex align-items-center mt-5'>
<h1 class='me-2 text-dark my-0 border-0'>Histogram Quickstart</h1>
<a href='/cookbook/5.0/Histograms/HistogramQuickstart' target='_blank'>
<img src='/images/icons/new-window.svg' style='height: 2rem;' class='new-window-icon'>
</a>
</div>

A histogram can be created from a collection of values.

[![](/cookbook/5.0/images/HistogramQuickstart.png?250126165944)](/cookbook/5.0/images/HistogramQuickstart.png?250126165944)

{{< recipe-sp5 sourceUrl="https://github.com/ScottPlot/ScottPlot/blob/main/src/ScottPlot5/ScottPlot5%20Cookbook/Recipes/Miscellaneous/Histograms.cs" imageUrl="/cookbook/5.0/images/HistogramQuickstart.png?250126165944" >}}ScottPlot.Plot myPlot = new();

// Create a histogram from a collection of values
double[] heights = SampleData.MaleHeights();
var hist = ScottPlot.Statistics.Histogram.WithBinCount(10, heights);

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

<hr class='my-5 invisible'>



<div class='d-flex align-items-center mt-5'>
<h1 class='me-2 text-dark my-0 border-0'>Histogram with Fixed Size Bins</h1>
<a href='/cookbook/5.0/Histograms/HistogramFixedSizeBins' target='_blank'>
<img src='/images/icons/new-window.svg' style='height: 2rem;' class='new-window-icon'>
</a>
</div>

A histogram can be created using manually defined bin sizes.

[![](/cookbook/5.0/images/HistogramFixedSizeBins.png?250126165944)](/cookbook/5.0/images/HistogramFixedSizeBins.png?250126165944)

{{< recipe-sp5 sourceUrl="https://github.com/ScottPlot/ScottPlot/blob/main/src/ScottPlot5/ScottPlot5%20Cookbook/Recipes/Miscellaneous/Histograms.cs" imageUrl="/cookbook/5.0/images/HistogramFixedSizeBins.png?250126165944" >}}ScottPlot.Plot myPlot = new();

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

<hr class='my-5 invisible'>



<div class='d-flex align-items-center mt-5'>
<h1 class='me-2 text-dark my-0 border-0'>Filled Histogram</h1>
<a href='/cookbook/5.0/Histograms/HistogramFilled' target='_blank'>
<img src='/images/icons/new-window.svg' style='height: 2rem;' class='new-window-icon'>
</a>
</div>

A filled histogram (one with no visible gaps between bars) can be achieved by setting the bar width to the bin size. However, anti-aliasing artifacts may cause white lines to appear between bars. Disable anti-aliasing for each bar to improve appearance of such plots.

[![](/cookbook/5.0/images/HistogramFilled.png?250126165944)](/cookbook/5.0/images/HistogramFilled.png?250126165944)

{{< recipe-sp5 sourceUrl="https://github.com/ScottPlot/ScottPlot/blob/main/src/ScottPlot5/ScottPlot5%20Cookbook/Recipes/Miscellaneous/Histograms.cs" imageUrl="/cookbook/5.0/images/HistogramFilled.png?250126165944" >}}ScottPlot.Plot myPlot = new();

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



<div class='d-flex align-items-center mt-5'>
<h1 class='me-2 text-dark my-0 border-0'>Histogram Bars</h1>
<a href='/cookbook/5.0/Histograms/HistogramBars' target='_blank'>
<img src='/images/icons/new-window.svg' style='height: 2rem;' class='new-window-icon'>
</a>
</div>

A helper method and plot type has been created to simplify creating a bar plot that displays histogram counts. Note that updates the histogram may appear in real time and the plot will automatically update to display the latest data.

[![](/cookbook/5.0/images/HistogramBars.png?250126165944)](/cookbook/5.0/images/HistogramBars.png?250126165944)

{{< recipe-sp5 sourceUrl="https://github.com/ScottPlot/ScottPlot/blob/main/src/ScottPlot5/ScottPlot5%20Cookbook/Recipes/Miscellaneous/Histograms.cs" imageUrl="/cookbook/5.0/images/HistogramBars.png?250126165944" >}}ScottPlot.Plot myPlot = new();

// create an empty histogram and display it as a bar plot
var hist = ScottPlot.Statistics.Histogram.WithBinCount(count: 20, minValue: 140, maxValue: 220);
var histPlot = myPlot.Add.Histogram(hist);
histPlot.BarWidthFraction = 0.8;

// histogram counts are updated automatically as new data is added
double[] newData = SampleData.MaleHeights();
hist.AddRange(newData);

myPlot.SavePng("demo.png", 400, 300);
{{< /recipe-sp5 >}}

<hr class='my-5 invisible'>



<div class='d-flex align-items-center mt-5'>
<h1 class='me-2 text-dark my-0 border-0'>Histogram of Probabilities</h1>
<a href='/cookbook/5.0/Histograms/HistogramProbability' target='_blank'>
<img src='/images/icons/new-window.svg' style='height: 2rem;' class='new-window-icon'>
</a>
</div>

Histograms may be displayed as the probability for each value falling inside a bin

[![](/cookbook/5.0/images/HistogramProbability.png?250126165944)](/cookbook/5.0/images/HistogramProbability.png?250126165944)

{{< recipe-sp5 sourceUrl="https://github.com/ScottPlot/ScottPlot/blob/main/src/ScottPlot5/ScottPlot5%20Cookbook/Recipes/Miscellaneous/Histograms.cs" imageUrl="/cookbook/5.0/images/HistogramProbability.png?250126165944" >}}ScottPlot.Plot myPlot = new();

// Create a histogram from a collection of values
double[] heights = SampleData.MaleHeights();
var hist = ScottPlot.Statistics.Histogram.WithBinCount(10, heights);

// Display the histogram as a bar plot
var barPlot = myPlot.Add.Bars(hist.Bins, hist.GetProbability(100));

// Customize the style of each bar
foreach (var bar in barPlot.Bars)
{
    bar.Size = hist.FirstBinSize * 0.8;
}

// Customize plot style
myPlot.Axes.Margins(bottom: 0);
myPlot.YLabel("Probability (%)");
myPlot.XLabel("Height (cm)");

myPlot.SavePng("demo.png", 400, 300);
{{< /recipe-sp5 >}}

<hr class='my-5 invisible'>



<div class='d-flex align-items-center mt-5'>
<h1 class='me-2 text-dark my-0 border-0'>Histogram with Probability Curve</h1>
<a href='/cookbook/5.0/Histograms/HistogramProbabilityCurve' target='_blank'>
<img src='/images/icons/new-window.svg' style='height: 2rem;' class='new-window-icon'>
</a>
</div>

A probability curve may be generated for a Gaussian distributed sample.

[![](/cookbook/5.0/images/HistogramProbabilityCurve.png?250126165944)](/cookbook/5.0/images/HistogramProbabilityCurve.png?250126165944)

{{< recipe-sp5 sourceUrl="https://github.com/ScottPlot/ScottPlot/blob/main/src/ScottPlot5/ScottPlot5%20Cookbook/Recipes/Miscellaneous/Histograms.cs" imageUrl="/cookbook/5.0/images/HistogramProbabilityCurve.png?250126165944" >}}ScottPlot.Plot myPlot = new();

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
double sumBins = hist.Bins.Select(x =&gt; pd.GetY(x)).Sum();
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

<hr class='my-5 invisible'>



<div class='d-flex align-items-center mt-5'>
<h1 class='me-2 text-dark my-0 border-0'>Histogram with Second Axis Probability</h1>
<a href='/cookbook/5.0/Histograms/HistogramProbabilityCurveSecondAxis' target='_blank'>
<img src='/images/icons/new-window.svg' style='height: 2rem;' class='new-window-icon'>
</a>
</div>

A probability curve may be placed on a secondary axis to allow counts to be displayed alongside probabilities with percent units

[![](/cookbook/5.0/images/HistogramProbabilityCurveSecondAxis.png?250126165944)](/cookbook/5.0/images/HistogramProbabilityCurveSecondAxis.png?250126165944)

{{< recipe-sp5 sourceUrl="https://github.com/ScottPlot/ScottPlot/blob/main/src/ScottPlot5/ScottPlot5%20Cookbook/Recipes/Miscellaneous/Histograms.cs" imageUrl="/cookbook/5.0/images/HistogramProbabilityCurveSecondAxis.png?250126165944" >}}ScottPlot.Plot myPlot = new();

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

<hr class='my-5 invisible'>



<div class='d-flex align-items-center mt-5'>
<h1 class='me-2 text-dark my-0 border-0'>Multiple Histograms</h1>
<a href='/cookbook/5.0/Histograms/HistogramMultiple' target='_blank'>
<img src='/images/icons/new-window.svg' style='height: 2rem;' class='new-window-icon'>
</a>
</div>

Demonstrates how to use semitransparent bars to display histograms from overlapping datasets

[![](/cookbook/5.0/images/HistogramMultiple.png?250126165944)](/cookbook/5.0/images/HistogramMultiple.png?250126165944)

{{< recipe-sp5 sourceUrl="https://github.com/ScottPlot/ScottPlot/blob/main/src/ScottPlot5/ScottPlot5%20Cookbook/Recipes/Miscellaneous/Histograms.cs" imageUrl="/cookbook/5.0/images/HistogramMultiple.png?250126165944" >}}ScottPlot.Plot myPlot = new();

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

<hr class='my-5 invisible'>



<div class='d-flex align-items-center mt-5'>
<h1 class='me-2 text-dark my-0 border-0'>Cumulative Probability Histogram</h1>
<a href='/cookbook/5.0/Histograms/HistogramCPH' target='_blank'>
<img src='/images/icons/new-window.svg' style='height: 2rem;' class='new-window-icon'>
</a>
</div>

A cumulative probability histogram represents the cumulative sum of probabilities or relative frequencies up to each bin, providing a running total of the probability distribution. It is especially useful for evaluating and comparing the distribution of multiple populations.

[![](/cookbook/5.0/images/HistogramCPH.png?250126165944)](/cookbook/5.0/images/HistogramCPH.png?250126165944)

{{< recipe-sp5 sourceUrl="https://github.com/ScottPlot/ScottPlot/blob/main/src/ScottPlot5/ScottPlot5%20Cookbook/Recipes/Miscellaneous/Histograms.cs" imageUrl="/cookbook/5.0/images/HistogramCPH.png?250126165944" >}}ScottPlot.Plot myPlot = new();

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

<hr class='my-5 invisible'>


