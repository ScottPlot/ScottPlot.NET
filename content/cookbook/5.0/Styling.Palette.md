---
Title: Palettes - ScottPlot 5.0 Cookbook
Description: A palette is a set of colors, and the Plot's palette defines the default colors to use when adding new plottables. ScottPlot comes with many standard palettes, but users may also create their own.
URL: /cookbook/5.0/Styling/Palette
BreadcrumbNames: ["ScottPlot 5.0 Cookbook", "Styling Plots", "Palettes"]
BreadcrumbUrls: ["/cookbook/5.0/", "/cookbook/5.0/Styling", "/cookbook/5.0/Styling/Palette"]
Date: 2023-12-24
Version: ScottPlot 5.0.11-beta
Version: ScottPlot 5.0.11-beta
SearchUrl: "/cookbook/5.0/search/"
---

# Palettes



<div class='alert alert-warning' role='alert'><h4 class='alert-heading py-0 my-0'>⚠️ ScottPlot 5.0.11-beta is a preview package</h4><hr /><p class='mb-0'><span class='fw-semibold'>This page describes a beta release of ScottPlot.</span> It is available on NuGet as a preview package, but its API is not stable and it is not recommended for production use. See the <a href='https://scottplot.net/versions/'>ScottPlot Versions</a> page for more information. </p></div>



A palette is a set of colors, and the Plot's palette defines the default colors to use when adding new plottables. ScottPlot comes with many standard palettes, but users may also create their own.

[![](/cookbook/5.0/images/Palette.png)](/cookbook/5.0/images/Palette.png)

```cs
ScottPlot.Plot myPlot = new();

myPlot.Palette = new ScottPlot.Palettes.Nord();

for (int i = 0; i < 5; i++)
{
    double[] data = ScottPlot.Generate.Sin(100, phase: -i / 20.0f);
    var sig = myPlot.Add.Signal(data);
    sig.LineStyle.Width = 3;
}

myPlot.SavePng("demo.png");

```

