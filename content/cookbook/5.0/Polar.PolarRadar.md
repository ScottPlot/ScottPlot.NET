---
Title: Polar Radar Plot - ScottPlot 5.0 Cookbook
Description: Combining a polar axis with polygons is an alternative strategy for building radar plots.
URL: /cookbook/5.0/Polar/PolarRadar/
BreadcrumbNames: ["ScottPlot 5.0 Cookbook", "Polar Axis", "Polar Radar Plot"]
BreadcrumbUrls: ["/cookbook/5.0/", "/cookbook/5.0/Polar", "/cookbook/5.0/Polar/PolarRadar"]
Date: 2024-10-30
Version: ScottPlot 5.0.42
Version: ScottPlot 5.0.42
SearchUrl: "/cookbook/5.0/search/"
ShowEditLink: false
---


<h2 style='border-bottom: 0;'><a href='/cookbook/5.0/Polar/PolarRadar'>Polar Radar Plot</a></h2>

<div class="d-flex mb-2">
<a class="btn btn-sm btn-primary me-1" href="/cookbook/5.0/Polar/PolarRadar">Recipe Permalink</a>
<a class="btn btn-sm btn-success me-1" href="/cookbook/5.0/Polar">Category: Polar Axis</a>
</div>

Combining a polar axis with polygons is an alternative strategy for building radar plots.

[![](/cookbook/5.0/images/PolarRadar.png?241029205813)](/cookbook/5.0/images/PolarRadar.png?241029205813)

{{< recipe-sp5 >}}ScottPlot.Plot myPlot = new();

var polarAxis = myPlot.Add.PolarAxis();
polarAxis.Rotation = Angle.FromDegrees(-90);

// add labeled spokes
string[] labels = { "Alpha", "Beta", "Gamma", "Delta", "Epsilon" };
polarAxis.SetSpokes(labels, length: 5.5);

// add defined ticks
double[] ticks = { 1, 2, 3, 4, 5 };
polarAxis.SetCircles(ticks);

// convert radar values to coordinates
double[] values1 = { 5, 4, 5, 2, 3 };
double[] values2 = { 2, 3, 2, 4, 2 };
Coordinates[] cs1 = polarAxis.GetCoordinates(values1);
Coordinates[] cs2 = polarAxis.GetCoordinates(values2);

// add polygons for each dataset
var poly1 = myPlot.Add.Polygon(cs1);
poly1.FillColor = Colors.Green.WithAlpha(.5);
poly1.LineColor = Colors.Black;

var poly2 = myPlot.Add.Polygon(cs2);
poly2.FillColor = Colors.Blue.WithAlpha(.5);
poly2.LineColor = Colors.Black;

myPlot.SavePng("demo.png", 400, 300);
{{< /recipe-sp5 >}}

<hr class='my-5 invisible'>


