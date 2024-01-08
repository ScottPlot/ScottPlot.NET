---
Title: Scatter Line Patterns - ScottPlot 5.0 Cookbook
Description: Several line patterns are available
URL: /cookbook/5.0/Scatter/ScatterLinePatterns/
BreadcrumbNames: ["ScottPlot 5.0 Cookbook", "Scatter Plot", "Scatter Line Patterns"]
BreadcrumbUrls: ["/cookbook/5.0/", "/cookbook/5.0/Scatter", "/cookbook/5.0/Scatter/ScatterLinePatterns"]
Date: 2024-01-08
Version: ScottPlot 5.0.11-beta
Version: ScottPlot 5.0.11-beta
SearchUrl: "/cookbook/5.0/search/"
---

# Scatter Line Patterns



<div class='alert alert-warning' role='alert'><h4 class='alert-heading py-0 my-0'>⚠️ ScottPlot 5.0.11-beta is a preview package</h4><hr /><p class='mb-0'><span class='fw-semibold'>This page describes a beta release of ScottPlot.</span> It is available on NuGet as a preview package, but its API is not stable and it is not recommended for production use. See the <a href='https://scottplot.net/versions/'>ScottPlot Versions</a> page for more information. </p></div>



Several line patterns are available

[![](/cookbook/5.0/images/ScatterLinePatterns.png)](/cookbook/5.0/images/ScatterLinePatterns.png)

```cs
ScottPlot.Version.ShouldBe(5, 0, 11);
ScottPlot.Plot myPlot = new();

LinePattern[] patterns = Enum.GetValues<LinePattern>();
ScottPlot.Palettes.ColorblindFriendly palette = new();

for (int i = 0; i < patterns.Length; i++)
{
    double yOffset = patterns.Length - i;
    double[] xs = Generate.Consecutive(51);
    double[] ys = Generate.Sin(51, offset: yOffset);

    var sp = myPlot.Add.Scatter(xs, ys);
    sp.LineWidth = 2;
    sp.MarkerSize = 0;
    sp.LineStyle.Pattern = patterns[i];
    sp.Color = palette.GetColor(i);

    var txt = myPlot.Add.Text(patterns[i].ToString(), 51, yOffset);
    txt.Label.ForeColor = sp.Color;
    txt.Label.FontSize = 22;
    txt.Label.Bold = true;
    txt.Label.Alignment = Alignment.MiddleLeft;
}

myPlot.Axes.Margins(.05, .5, .05, .05);

myPlot.SavePng("demo.png");

```

