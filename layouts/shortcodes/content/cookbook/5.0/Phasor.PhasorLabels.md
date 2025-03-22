---
Title: Phasor Plot with Labels - ScottPlot 5.0 Cookbook
Description: Text labels may be applied to individual arrows of a phasor plot.
URL: /cookbook/5.0/Phasor/PhasorLabels/
BreadcrumbNames: ["ScottPlot 5.0 Cookbook", "Phasor Plot", "Phasor Plot with Labels"]
BreadcrumbUrls: ["/cookbook/5.0/", "/cookbook/5.0/Phasor", "/cookbook/5.0/Phasor/PhasorLabels"]
Date: 2025-03-22
Version: ScottPlot 5.0.55
Version: ScottPlot 5.0.55
SearchUrl: "/cookbook/5.0/search/"
ShowEditLink: false
---


<div class='d-flex align-items-center mt-5'>
<h1 class='me-2 text-dark my-0 border-0'>Phasor Plot with Labels</h1>
</div>

Text labels may be applied to individual arrows of a phasor plot.

[![](/cookbook/5.0/images/PhasorLabels.png?250322130304)](/cookbook/5.0/images/PhasorLabels.png?250322130304)

{{< recipe-sp5 sourceUrl="https://github.com/ScottPlot/ScottPlot/blob/main/src/ScottPlot5/ScottPlot5%20Cookbook/Recipes/PlotTypes/Phasor.cs" imageUrl="/cookbook/5.0/images/PhasorLabels.png?250322130304" >}}ScottPlot.Plot myPlot = new();

// setup the polar axis
var polarAxis = myPlot.Add.PolarAxis(30);
polarAxis.Circles.ForEach(x =&gt; x.LinePattern = LinePattern.Dotted);
polarAxis.Spokes.ForEach(x =&gt; x.LinePattern = LinePattern.Dotted);

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

<div class='my-5 text-center'>This recipe is one of many in the <a href='/cookbook/5.0/Phasor'>Phasor Plot</a> category</div>


