---
Title: Stacked Filled Line Plot - ScottPlot 5.0 Cookbook
Description: A stacked filled line plot effect can be achieved by overlapping ScatterLines that fill area.
URL: /cookbook/5.0/Scatter/StackedFilledLinePlot/
BreadcrumbNames: ["ScottPlot 5.0 Cookbook", "Scatter Plot", "Stacked Filled Line Plot"]
BreadcrumbUrls: ["/cookbook/5.0/", "/cookbook/5.0/Scatter", "/cookbook/5.0/Scatter/StackedFilledLinePlot"]
Date: 2024-10-28
Version: ScottPlot 5.0.41
Version: ScottPlot 5.0.41
SearchUrl: "/cookbook/5.0/search/"
ShowEditLink: false
---

# Stacked Filled Line Plot


A stacked filled line plot effect can be achieved by overlapping ScatterLines that fill area.

[![](/cookbook/5.0/images/StackedFilledLinePlot.png?241027220842)](/cookbook/5.0/images/StackedFilledLinePlot.png?241027220842)

{{< recipe-sp5 >}}

```cs
ScottPlot.Plot myPlot = new();

// create sample data
double[] xs = { 1, 2, 3, 4 };
double[] ys1 = { 1, 3, 1, 2 };
double[] ys2 = { 3, 7, 3, 1 };
double[] ys3 = { 5, 2, 5, 6 };

// shift each plot vertically by the sum of all plots before it
ys2 = Enumerable.Range(0, ys2.Length).Select(x => ys2[x] + ys1[x]).ToArray();
ys3 = Enumerable.Range(0, ys2.Length).Select(x => ys3[x] + ys2[x]).ToArray();

// plot the padded data points as ScatterLine
var sp3 = myPlot.Add.ScatterLine(xs, ys3, Colors.Black);
var sp2 = myPlot.Add.ScatterLine(xs, ys2, Colors.Black);
var sp1 = myPlot.Add.ScatterLine(xs, ys1, Colors.Black);

// set plot style
sp1.LineWidth = 2;
sp2.LineWidth = 2;
sp3.LineWidth = 2;
sp1.FillY = true;
sp2.FillY = true;
sp3.FillY = true;
sp1.FillYColor = Colors.Green;
sp2.FillYColor = Colors.Orange;
sp3.FillYColor = Colors.Blue;

// use tight margins so data goes to the edge of the plot
myPlot.Axes.Margins(0, 0, 0, 0.1);

myPlot.SavePng("demo.png", 400, 300);

```

{{< /recipe-sp5 >}}

<a href='https://github.com/ScottPlot/ScottPlot/blob/main/src/ScottPlot5/ScottPlot5%20Cookbook/Recipes/PlotTypes/Scatter.cs'><svg xmlns="http://www.w3.org/2000/svg" width="16" height="16" fill="currentColor" class="mb-1 bi bi-github" viewBox="0 0 16 16">
  <path d="M8 0C3.58 0 0 3.58 0 8c0 3.54 2.29 6.53 5.47 7.59.4.07.55-.17.55-.38 0-.19-.01-.82-.01-1.49-2.01.37-2.53-.49-2.69-.94-.09-.23-.48-.94-.82-1.13-.28-.15-.68-.52-.01-.53.63-.01 1.08.58 1.23.82.72 1.21 1.87.87 2.33.66.07-.52.28-.87.51-1.07-1.78-.2-3.64-.89-3.64-3.95 0-.87.31-1.59.82-2.15-.08-.2-.36-1.02.08-2.12 0 0 .67-.21 2.2.82.64-.18 1.32-.27 2-.27s1.36.09 2 .27c1.53-1.04 2.2-.82 2.2-.82.44 1.1.16 1.92.08 2.12.51.56.82 1.27.82 2.15 0 3.07-1.87 3.75-3.65 3.95.29.25.54.73.54 1.48 0 1.07-.01 1.93-.01 2.2 0 .21.15.46.55.38A8.01 8.01 0 0 0 16 8c0-4.42-3.58-8-8-8"/>
</svg> Edit on GitHub</a>

