---
Title: Cumulative Probability Histogram - ScottPlot 5.0 Cookbook
Description: A cumulative probability histogram represents the cumulative sum of probabilities or relative frequencies up to each bin, providing a running total of the probability distribution. It is especially useful for evaluating and comparing the distribution of multiple populations.
URL: /cookbook/5.0/Histograms/HistogramCPH/
BreadcrumbNames: ["ScottPlot 5.0 Cookbook", "Histogram", "Cumulative Probability Histogram"]
BreadcrumbUrls: ["/cookbook/5.0/", "/cookbook/5.0/Histograms", "/cookbook/5.0/Histograms/HistogramCPH"]
Date: 2024-10-28
Version: ScottPlot 5.0.41
Version: ScottPlot 5.0.41
SearchUrl: "/cookbook/5.0/search/"
ShowEditLink: false
---

# Cumulative Probability Histogram


A cumulative probability histogram represents the cumulative sum of probabilities or relative frequencies up to each bin, providing a running total of the probability distribution. It is especially useful for evaluating and comparing the distribution of multiple populations.

[![](/cookbook/5.0/images/HistogramCPH.png?241027220842)](/cookbook/5.0/images/HistogramCPH.png?241027220842)

{{< recipe-sp5 >}}

```cs
ScottPlot.Plot myPlot = new();

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

```

{{< /recipe-sp5 >}}

<a href='https://github.com/ScottPlot/ScottPlot/blob/main/src/ScottPlot5/ScottPlot5%20Cookbook/Recipes/Miscellaneous/Histograms.cs'><svg xmlns="http://www.w3.org/2000/svg" width="16" height="16" fill="currentColor" class="mb-1 bi bi-github" viewBox="0 0 16 16">
  <path d="M8 0C3.58 0 0 3.58 0 8c0 3.54 2.29 6.53 5.47 7.59.4.07.55-.17.55-.38 0-.19-.01-.82-.01-1.49-2.01.37-2.53-.49-2.69-.94-.09-.23-.48-.94-.82-1.13-.28-.15-.68-.52-.01-.53.63-.01 1.08.58 1.23.82.72 1.21 1.87.87 2.33.66.07-.52.28-.87.51-1.07-1.78-.2-3.64-.89-3.64-3.95 0-.87.31-1.59.82-2.15-.08-.2-.36-1.02.08-2.12 0 0 .67-.21 2.2.82.64-.18 1.32-.27 2-.27s1.36.09 2 .27c1.53-1.04 2.2-.82 2.2-.82.44 1.1.16 1.92.08 2.12.51.56.82 1.27.82 2.15 0 3.07-1.87 3.75-3.65 3.95.29.25.54.73.54 1.48 0 1.07-.01 1.93-.01 2.2 0 .21.15.46.55.38A8.01 8.01 0 0 0 16 8c0-4.42-3.58-8-8-8"/>
</svg> Edit on GitHub</a>

