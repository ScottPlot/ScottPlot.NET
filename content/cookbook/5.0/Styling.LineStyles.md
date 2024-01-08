---
Title: Line Styles - ScottPlot 5.0 Cookbook
Description: Many plot types have a LineStyle which can be customized.
URL: /cookbook/5.0/Styling/LineStyles/
BreadcrumbNames: ["ScottPlot 5.0 Cookbook", "Styling Plots", "Line Styles"]
BreadcrumbUrls: ["/cookbook/5.0/", "/cookbook/5.0/Styling", "/cookbook/5.0/Styling/LineStyles"]
Date: 2024-01-08
Version: ScottPlot 5.0.11-beta
Version: ScottPlot 5.0.11-beta
SearchUrl: "/cookbook/5.0/search/"
---

# Line Styles



<div class='alert alert-warning' role='alert'><h4 class='alert-heading py-0 my-0'>⚠️ ScottPlot 5.0.11-beta is a preview package</h4><hr /><p class='mb-0'><span class='fw-semibold'>This page describes a beta release of ScottPlot.</span> It is available on NuGet as a preview package, but its API is not stable and it is not recommended for production use. See the <a href='https://scottplot.net/versions/'>ScottPlot Versions</a> page for more information. </p></div>



Many plot types have a LineStyle which can be customized.

[![](/cookbook/5.0/images/LineStyles.png)](/cookbook/5.0/images/LineStyles.png)

```cs
ScottPlot.Version.ShouldBe(5, 0, 11);
ScottPlot.Plot myPlot = new();

LinePattern[] linePatterns = Enum.GetValues<LinePattern>().ToArray();

for (int i = 0; i < linePatterns.Length; i++)
{
    LinePattern pattern = linePatterns[i];

    var line = myPlot.Add.Line(0, -i, 1, -i);
    line.Pattern = pattern;
    line.Width = 2;
    line.Color = Colors.Black;

    var txt = myPlot.Add.Text(pattern.ToString(), 1.1, -i);
    txt.Size = 18;
    txt.Bold = true;
    txt.Color = Colors.Black;
    txt.Label.Alignment = Alignment.MiddleLeft;
}

myPlot.Axes.Margins(right: 1);
myPlot.HideGrid();
myPlot.Layout.Frameless();

myPlot.ShowLegend();

myPlot.SavePng("demo.png");

```

