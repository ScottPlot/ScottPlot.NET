---
Title: FillY From Array Data - ScottPlot 5.0 Cookbook
Description: FillY plots can be created from X, Y1, and Y2 arrays.
URL: /cookbook/5.0/FillY/FillYFromArrays/
BreadcrumbNames: ["ScottPlot 5.0 Cookbook", "FillY plot", "FillY From Array Data"]
BreadcrumbUrls: ["/cookbook/5.0/", "/cookbook/5.0/FillY", "/cookbook/5.0/FillY/FillYFromArrays"]
Date: 2024-10-31
Version: ScottPlot 5.0.42
Version: ScottPlot 5.0.42
SearchUrl: "/cookbook/5.0/search/"
ShowEditLink: false
---


<h2 style='border-bottom: 0;'><a href='/cookbook/5.0/FillY/FillYFromArrays'>FillY From Array Data</a></h2>

<div class="d-flex mb-2">
<a class="btn btn-sm btn-primary me-1" href="/cookbook/5.0/FillY/FillYFromArrays">Recipe Permalink</a>
<a class="btn btn-sm btn-success me-1" href="/cookbook/5.0/FillY">Category: FillY plot</a>
</div>

FillY plots can be created from X, Y1, and Y2 arrays.

[![](/cookbook/5.0/images/FillYFromArrays.png?241031194635)](/cookbook/5.0/images/FillYFromArrays.png?241031194635)

{{< recipe-sp5 >}}ScottPlot.Plot myPlot = new();

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

<hr class='my-5 invisible'>


