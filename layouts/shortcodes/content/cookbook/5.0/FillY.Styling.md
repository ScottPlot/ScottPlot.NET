---
Title: FillY Plot Styling - ScottPlot 5.0 Cookbook
Description: FillY plots can be customized using public properties.
URL: /cookbook/5.0/FillY/Styling/
BreadcrumbNames: ["ScottPlot 5.0 Cookbook", "FillY plot", "FillY Plot Styling"]
BreadcrumbUrls: ["/cookbook/5.0/", "/cookbook/5.0/FillY", "/cookbook/5.0/FillY/Styling"]
Date: 2025-03-22
Version: ScottPlot 5.0.55
Version: ScottPlot 5.0.55
SearchUrl: "/cookbook/5.0/search/"
ShowEditLink: false
---


<div class='d-flex align-items-center mt-5'>
<h1 class='me-2 text-dark my-0 border-0'>FillY Plot Styling</h1>
</div>

FillY plots can be customized using public properties.

[![](/cookbook/5.0/images/Styling.png?250322130304)](/cookbook/5.0/images/Styling.png?250322130304)

{{< recipe-sp5 sourceUrl="https://github.com/ScottPlot/ScottPlot/blob/main/src/ScottPlot5/ScottPlot5%20Cookbook/Recipes/PlotTypes/FillY.cs" imageUrl="/cookbook/5.0/images/Styling.png?250322130304" >}}ScottPlot.Plot myPlot = new();

int count = 20;
double[] xs = Generate.Consecutive(count);
double[] ys1 = Generate.RandomWalk(count, offset: -5);
double[] ys2 = Generate.RandomWalk(count, offset: 5);

var fill = myPlot.Add.FillY(xs, ys1, ys2);
fill.MarkerShape = MarkerShape.FilledDiamond;
fill.MarkerSize = 15;
fill.MarkerColor = Colors.Blue;
fill.LineColor = Colors.Blue;
fill.LinePattern = LinePattern.Dotted;
fill.LineWidth = 2;
fill.FillColor = Colors.Blue.WithAlpha(.2);
fill.FillHatch = new ScottPlot.Hatches.Striped(ScottPlot.Hatches.StripeDirection.DiagonalUp);
fill.FillHatchColor = Colors.Blue.WithAlpha(.4);
fill.LegendText = "Filled Area";

myPlot.ShowLegend();

myPlot.SavePng("demo.png", 400, 300);
{{< /recipe-sp5 >}}

<div class='my-5 text-center'>This recipe is one of many in the <a href='/cookbook/5.0/FillY'>FillY plot</a> category</div>


