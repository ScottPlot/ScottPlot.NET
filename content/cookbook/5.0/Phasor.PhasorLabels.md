---
Title: Phasor Plot with Labels - ScottPlot 5.0 Cookbook
Description: Text labels may be applied to individual arrows of a phasor plot.
URL: /cookbook/5.0/Phasor/PhasorLabels/
BreadcrumbNames: ["ScottPlot 5.0 Cookbook", "Phasor Plot", "Phasor Plot with Labels"]
BreadcrumbUrls: ["/cookbook/5.0/", "/cookbook/5.0/Phasor", "/cookbook/5.0/Phasor/PhasorLabels"]
Date: 2024-09-09
Version: ScottPlot 5.0.39
Version: ScottPlot 5.0.39
SearchUrl: "/cookbook/5.0/search/"
ShowEditLink: false
---

# Phasor Plot with Labels


Text labels may be applied to individual arrows of a phasor plot.

[![](/cookbook/5.0/images/PhasorLabels.png?240908210824)](/cookbook/5.0/images/PhasorLabels.png?240908210824)

{{< code-sp5 >}}

```cs
ScottPlot.Plot myPlot = new();

// setup the polar axis
var polarAxis = myPlot.Add.PolarAxis(30);
polarAxis.Circles.ForEach(x => x.LinePattern = LinePattern.Dotted);
polarAxis.Spokes.ForEach(x => x.LinePattern = LinePattern.Dotted);

// create a phasor plot and points in coordinate space
var phaser = myPlot.Add.Phasor();
phaser.Points.Add(new PolarCoordinates(20, Angle.FromDegrees(35)));
phaser.Points.Add(new PolarCoordinates(25, Angle.FromDegrees(140)));
phaser.Points.Add(new PolarCoordinates(20, Angle.FromDegrees(260)));

// add labels for points
phaser.Labels.Add("Alpha");
phaser.Labels.Add("Beta");
phaser.Labels.Add("Gamma");

// style the labels
phaser.LabelStyle.FontSize = 24;
phaser.LabelStyle.ForeColor = Colors.Black;
phaser.LabelStyle.FontName = Fonts.Monospace;
phaser.LabelStyle.Bold = true;

myPlot.SavePng("demo.png", 400, 300);

```

{{< /code-sp5 >}}

<a href='https://github.com/ScottPlot/ScottPlot/blob/main/src/ScottPlot5/ScottPlot5%20Cookbook/Recipes/PlotTypes/Phasor.cs'><svg xmlns="http://www.w3.org/2000/svg" width="16" height="16" fill="currentColor" class="mb-1 bi bi-github" viewBox="0 0 16 16">
  <path d="M8 0C3.58 0 0 3.58 0 8c0 3.54 2.29 6.53 5.47 7.59.4.07.55-.17.55-.38 0-.19-.01-.82-.01-1.49-2.01.37-2.53-.49-2.69-.94-.09-.23-.48-.94-.82-1.13-.28-.15-.68-.52-.01-.53.63-.01 1.08.58 1.23.82.72 1.21 1.87.87 2.33.66.07-.52.28-.87.51-1.07-1.78-.2-3.64-.89-3.64-3.95 0-.87.31-1.59.82-2.15-.08-.2-.36-1.02.08-2.12 0 0 .67-.21 2.2.82.64-.18 1.32-.27 2-.27s1.36.09 2 .27c1.53-1.04 2.2-.82 2.2-.82.44 1.1.16 1.92.08 2.12.51.56.82 1.27.82 2.15 0 3.07-1.87 3.75-3.65 3.95.29.25.54.73.54 1.48 0 1.07-.01 1.93-.01 2.2 0 .21.15.46.55.38A8.01 8.01 0 0 0 16 8c0-4.42-3.58-8-8-8"/>
</svg> Edit on GitHub</a>

