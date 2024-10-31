---
Title: Phasor Line Plot - ScottPlot 5.0 Cookbook
Description: A phasor line plot contains a collection of polar coordinates which are rendered as arrows.
URL: /cookbook/5.0/Phasor/PhasorQuickstart/
BreadcrumbNames: ["ScottPlot 5.0 Cookbook", "Phasor Plot", "Phasor Line Plot"]
BreadcrumbUrls: ["/cookbook/5.0/", "/cookbook/5.0/Phasor", "/cookbook/5.0/Phasor/PhasorQuickstart"]
Date: 2024-10-31
Version: ScottPlot 5.0.42
Version: ScottPlot 5.0.42
SearchUrl: "/cookbook/5.0/search/"
ShowEditLink: false
---


<h2 style='border-bottom: 0;'><a href='/cookbook/5.0/Phasor/PhasorQuickstart'>Phasor Line Plot</a></h2>

<div class="d-flex mb-2">
<a class="btn btn-sm btn-primary me-1" href="/cookbook/5.0/Phasor/PhasorQuickstart">Recipe Permalink</a>
<a class="btn btn-sm btn-success me-1" href="/cookbook/5.0/Phasor">Category: Phasor Plot</a>
</div>

A phasor line plot contains a collection of polar coordinates which are rendered as arrows.

[![](/cookbook/5.0/images/PhasorQuickstart.png?241031194635)](/cookbook/5.0/images/PhasorQuickstart.png?241031194635)

{{< recipe-sp5 >}}ScottPlot.Plot myPlot = new();

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


