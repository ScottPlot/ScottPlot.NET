---
Title: Phasor Line Plot - ScottPlot 5.0 Cookbook
Description: A phasor line plot contains a collection of polar coordinates which are rendered as arrows.
URL: /cookbook/5.0/Phasor/PhasorQuickstart/
BreadcrumbNames: ["ScottPlot 5.0 Cookbook", "Phasor Plot", "Phasor Line Plot"]
BreadcrumbUrls: ["/cookbook/5.0/", "/cookbook/5.0/Phasor", "/cookbook/5.0/Phasor/PhasorQuickstart"]
Date: 2024-11-17
Version: ScottPlot 5.0.46
Version: ScottPlot 5.0.46
SearchUrl: "/cookbook/5.0/search/"
ShowEditLink: false
---


<div class='d-flex align-items-center mt-5'>
<h1 class='me-2 text-dark my-0 border-0'>Phasor Line Plot</h1>
</div>

A phasor line plot contains a collection of polar coordinates which are rendered as arrows.

[![](/cookbook/5.0/images/PhasorQuickstart.png?241117162641)](/cookbook/5.0/images/PhasorQuickstart.png?241117162641)

{{< recipe-sp5 sourceUrl="https://github.com/ScottPlot/ScottPlot/blob/main/src/ScottPlot5/ScottPlot5%20Cookbook/Recipes/PlotTypes/Phasor.cs" imageUrl="/cookbook/5.0/images/PhasorQuickstart.png?241117162641" >}}ScottPlot.Plot myPlot = new();

// Start by placing a polar axis system on the plot
var polarAxis = myPlot.Add.PolarAxis(30);
polarAxis.Circles.ForEach(x =&gt; x.LinePattern = LinePattern.Dotted);
polarAxis.Spokes.ForEach(x =&gt; x.LinePattern = LinePattern.Dotted);

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

<div class='my-5 text-center'>This recipe is one of many in the <a href='/cookbook/5.0/Phasor'>Phasor Plot</a> category</div>


