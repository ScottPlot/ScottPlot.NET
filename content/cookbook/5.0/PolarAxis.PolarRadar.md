---
Title: Polar Radar Plot - ScottPlot 5.0 Cookbook
Description: Combining a polar axis with polygons is an alternative strategy for building radar plots.
URL: /cookbook/5.0/PolarAxis/PolarRadar/
BreadcrumbNames: ["ScottPlot 5.0 Cookbook", "Polar Axis", "Polar Radar Plot"]
BreadcrumbUrls: ["/cookbook/5.0/", "/cookbook/5.0/PolarAxis", "/cookbook/5.0/PolarAxis/PolarRadar"]
Date: 2024-11-02
Version: ScottPlot 5.0.42
Version: ScottPlot 5.0.42
SearchUrl: "/cookbook/5.0/search/"
ShowEditLink: false
---


<div class='d-flex align-items-center mt-5'>
<h1 class='me-2 text-dark my-0 border-0'>Polar Radar Plot</h1>
</div>

Combining a polar axis with polygons is an alternative strategy for building radar plots.

[![](/cookbook/5.0/images/PolarRadar.png?241102170938)](/cookbook/5.0/images/PolarRadar.png?241102170938)

{{< recipe-sp5 sourceUrl="https://github.com/ScottPlot/ScottPlot/blob/main/src/ScottPlot5/ScottPlot5%20Cookbook/Recipes/PlotTypes/PolarAxis.cs" imageUrl="/cookbook/5.0/images/PolarRadar.png?241102170938" >}}ScottPlot.Plot myPlot = new();

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

<div class='my-5 text-center'>This recipe is one of many in the <a href='/cookbook/5.0/PolarAxis'>Polar Axis</a> category</div>


