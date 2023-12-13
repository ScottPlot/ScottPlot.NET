---
Title: Line Styles - ScottPlot 5.0 Cookbook
Description: Many plot types have a LineStyle which can be customized.
URL: /cookbook/5.0/Styling/LineStyles
BreadcrumbNames: ["ScottPlot 5.0 Cookbook", "Styling Plots", "Line Styles"]
BreadcrumbUrls: ["/cookbook/5.0/", "/cookbook/5.0/Styling", "/cookbook/5.0/Styling/LineStyles"]
Date: 2023-12-13
Version: ScottPlot 5.0.10-beta
---

# Line Styles



<div class='alert alert-warning' role='alert'><h4 class='alert-heading py-0 my-0'>⚠️ ScottPlot 5.0.10-beta is a preview package</h4><hr /><p class='mb-0'><span class='fw-semibold'>This page describes a beta release of ScottPlot.</span> It is available on NuGet as a preview package, but its API is not stable and it is not recommended for production use. See the <a href='https://scottplot.net/versions/'>ScottPlot Versions</a> page for more information. </p></div>



Many plot types have a LineStyle which can be customized.

[![](/cookbook/5.0/images/LineStyles.png)](/cookbook/5.0/images/LineStyles.png)

```cs
ScottPlot.Plot myPlot = new();

int count = 21;
double[] xs = ScottPlot.Generate.Consecutive(count);
double[] ys = ScottPlot.Generate.Sin(count);

LinePattern[] linePatterns = Enum.GetValues<LinePattern>().ToArray();

for (int i = 0; i < linePatterns.Length; i++)
{
    double[] data = ys.Select(y => linePatterns.Length - y + i).ToArray();

    var scatter = myPlot.Add.Scatter(xs, data);

    scatter.Label = linePatterns[i].ToString();
    scatter.LineStyle.Width = 2;
    scatter.LineStyle.Pattern = linePatterns[i];
    scatter.MarkerStyle = MarkerStyle.None;
}

myPlot.Legend.IsVisible = true;

myPlot.SavePng("demo.png");

```

