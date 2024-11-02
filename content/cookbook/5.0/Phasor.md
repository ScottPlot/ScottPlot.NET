---
Title: Phasor Plot - ScottPlot 5.0 Cookbook
Description: Phasor plots display vectors on a radial axis centered at the origin
URL: /cookbook/5.0/Phasor/
BreadcrumbNames: ["ScottPlot 5.0 Cookbook", "Phasor Plot"]
BreadcrumbUrls: ["/cookbook/5.0/", "/cookbook/5.0/Phasor"]
Date: 2024-11-02
Version: ScottPlot 5.0.42
Version: ScottPlot 5.0.42
SearchUrl: "/cookbook/5.0/search/"
ShowEditLink: false
---

<h1>Phasor Plot</h1>


<div class='d-flex align-items-center mt-5'>
<h1 class='me-2 text-dark my-0 border-0'>Phasor Line Plot</h1>
<a href='/cookbook/5.0/Phasor/PhasorQuickstart' target='_blank'>
<img src='/images/icons/new-window.svg' style='height: 2rem;' class='new-window-icon'>
</a>
</div>

A phasor line plot contains a collection of polar coordinates which are rendered as arrows.

[![](/cookbook/5.0/images/PhasorQuickstart.png?241102170938)](/cookbook/5.0/images/PhasorQuickstart.png?241102170938)

{{< recipe-sp5 sourceUrl="https://github.com/ScottPlot/ScottPlot/blob/main/src/ScottPlot5/ScottPlot5%20Cookbook/Recipes/PlotTypes/Phasor.cs" imageUrl="/cookbook/5.0/images/PhasorQuickstart.png?241102170938" >}}ScottPlot.Plot myPlot = new();

// Start by placing a polar axis system on the plot
var polarAxis = myPlot.Add.PolarAxis(30);
polarAxis.Circles.ForEach(x => x.LinePattern = LinePattern.Dotted);
polarAxis.Spokes.ForEach(x => x.LinePattern = LinePattern.Dotted);

// A Phasor may be added with predefined points
PolarCoordinates[] points1 = [
    new(10, Angle.FromDegrees(15)),
    new(20, Angle.FromDegrees(120)),
    new(30, Angle.FromDegrees(240)),
];
myPlot.Add.Phasor(points1);

// Points on a Phasor may be added or modified after it is created
var phaser2 = myPlot.Add.Phasor();
phaser2.Points.Add(new PolarCoordinates(20, Angle.FromDegrees(35)));
phaser2.Points.Add(new PolarCoordinates(25, Angle.FromDegrees(140)));
phaser2.Points.Add(new PolarCoordinates(20, Angle.FromDegrees(260)));

myPlot.SavePng("demo.png", 400, 300);
{{< /recipe-sp5 >}}

<hr class='my-5 invisible'>



<div class='d-flex align-items-center mt-5'>
<h1 class='me-2 text-dark my-0 border-0'>Phasor Plot with Labels</h1>
<a href='/cookbook/5.0/Phasor/PhasorLabels' target='_blank'>
<img src='/images/icons/new-window.svg' style='height: 2rem;' class='new-window-icon'>
</a>
</div>

Text labels may be applied to individual arrows of a phasor plot.

[![](/cookbook/5.0/images/PhasorLabels.png?241102170938)](/cookbook/5.0/images/PhasorLabels.png?241102170938)

{{< recipe-sp5 sourceUrl="https://github.com/ScottPlot/ScottPlot/blob/main/src/ScottPlot5/ScottPlot5%20Cookbook/Recipes/PlotTypes/Phasor.cs" imageUrl="/cookbook/5.0/images/PhasorLabels.png?241102170938" >}}ScottPlot.Plot myPlot = new();

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


