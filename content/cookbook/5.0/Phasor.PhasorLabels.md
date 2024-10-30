---
Title: Phasor Plot with Labels - ScottPlot 5.0 Cookbook
Description: Text labels may be applied to individual arrows of a phasor plot.
URL: /cookbook/5.0/Phasor/PhasorLabels/
BreadcrumbNames: ["ScottPlot 5.0 Cookbook", "Phasor Plot", "Phasor Plot with Labels"]
BreadcrumbUrls: ["/cookbook/5.0/", "/cookbook/5.0/Phasor", "/cookbook/5.0/Phasor/PhasorLabels"]
Date: 2024-10-30
Version: ScottPlot 5.0.42
Version: ScottPlot 5.0.42
SearchUrl: "/cookbook/5.0/search/"
ShowEditLink: false
---


<h2 style='border-bottom: 0;'><a href='/cookbook/5.0/Phasor/PhasorLabels'>Phasor Plot with Labels</a></h2>

<div class="d-flex mb-2">
<a class="btn btn-sm btn-primary me-1" href="/cookbook/5.0/Phasor/PhasorLabels">Recipe Permalink</a>
<a class="btn btn-sm btn-success me-1" href="/cookbook/5.0/Phasor">Category: Phasor Plot</a>
</div>

Text labels may be applied to individual arrows of a phasor plot.

[![](/cookbook/5.0/images/PhasorLabels.png?241029205813)](/cookbook/5.0/images/PhasorLabels.png?241029205813)

{{< recipe-sp5 >}}ScottPlot.Plot myPlot = new();

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
{{< /recipe-sp5 >}}

<hr class='my-5 invisible'>


