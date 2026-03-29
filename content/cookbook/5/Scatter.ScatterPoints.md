---
Title: Scatter Plot with Points Only - ScottPlot 5 Cookbook
Description: The `ScatterPoints()` method can be used to create a scatter plot with markers only (line width is set to 0).
URL: /cookbook/5/Scatter/ScatterPoints/
BreadcrumbNames: ["ScottPlot 5 Cookbook", "Scatter Plot", "Scatter Plot with Points Only"]
BreadcrumbUrls: ["/cookbook/5/", "/cookbook/5/Scatter", "/cookbook/5/Scatter/ScatterPoints"]
Date: 2026-03-29
Version: ScottPlot 5.1.58
Version: ScottPlot 5.1.58
SearchUrl: "/cookbook/5/search/"
ShowEditLink: false
---


<div class='d-flex align-items-center mt-5'>
<h1 class='me-2 text-dark my-0 border-0'>Scatter Plot with Points Only</h1>
</div>

The `ScatterPoints()` method can be used to create a scatter plot with markers only (line width is set to 0).

[![](/cookbook/5/images/ScatterPoints.png?260329072039)](/cookbook/5/images/ScatterPoints.png?260329072039)

{{< recipe-sp5 sourceUrl="https://github.com/ScottPlot/ScottPlot/blob/main/src/ScottPlot5/ScottPlot5%20Cookbook/Recipes/PlotTypes/Scatter.cs" imageUrl="/cookbook/5/images/ScatterPoints.png?260329072039" >}}ScottPlot.Plot myPlot = new();

double[] xs = Generate.Consecutive(51);
double[] sin = Generate.Sin(51);
double[] cos = Generate.Cos(51);

myPlot.Add.ScatterPoints(xs, sin);
myPlot.Add.ScatterPoints(xs, cos);

myPlot.SavePng("demo.png", 400, 300);
{{< /recipe-sp5 >}}

<div class='my-5 text-center'>This recipe is one of many in the <a href='/cookbook/5/Scatter'>Scatter Plot</a> category</div>


