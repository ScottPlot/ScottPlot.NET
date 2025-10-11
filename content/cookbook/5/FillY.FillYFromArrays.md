---
Title: FillY From Array Data - ScottPlot 5.0 Cookbook
Description: FillY plots can be created from X, Y1, and Y2 arrays.
URL: /cookbook/5.0/FillY/FillYFromArrays/
BreadcrumbNames: ["ScottPlot 5.0 Cookbook", "FillY plot", "FillY From Array Data"]
BreadcrumbUrls: ["/cookbook/5.0/", "/cookbook/5.0/FillY", "/cookbook/5.0/FillY/FillYFromArrays"]
Date: 2025-01-26
Version: ScottPlot 5.0.55
Version: ScottPlot 5.0.55
SearchUrl: "/cookbook/5.0/search/"
ShowEditLink: false
---


<div class='d-flex align-items-center mt-5'>
<h1 class='me-2 text-dark my-0 border-0'>FillY From Array Data</h1>
</div>

FillY plots can be created from X, Y1, and Y2 arrays.

[![](/cookbook/5.0/images/FillYFromArrays.png?250126165944)](/cookbook/5.0/images/FillYFromArrays.png?250126165944)

{{< recipe-sp5 sourceUrl="https://github.com/ScottPlot/ScottPlot/blob/main/src/ScottPlot5/ScottPlot5%20Cookbook/Recipes/PlotTypes/FillY.cs" imageUrl="/cookbook/5.0/images/FillYFromArrays.png?250126165944" >}}ScottPlot.Plot myPlot = new();

RandomDataGenerator dataGen = new(0);

int count = 20;
double[] xs = Generate.Consecutive(count);
double[] ys1 = dataGen.RandomWalk(count, offset: -5);
double[] ys2 = dataGen.RandomWalk(count, offset: 5);

var fill = myPlot.Add.FillY(xs, ys1, ys2);
fill.FillColor = Colors.Blue.WithAlpha(100);
fill.LineColor = Colors.Blue;
fill.MarkerColor = Colors.Blue;
fill.LineWidth = 2;

myPlot.SavePng("demo.png", 400, 300);
{{< /recipe-sp5 >}}

<div class='my-5 text-center'>This recipe is one of many in the <a href='/cookbook/5.0/FillY'>FillY plot</a> category</div>


