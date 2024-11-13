---
Title: Scatter Plot with Points Only - ScottPlot 5.0 Cookbook
Description: The `ScatterPoints()` method can be used to create a scatter plot with markers only (line width is set to 0).
URL: /cookbook/5.0/Scatter/ScatterPoints/
BreadcrumbNames: ["ScottPlot 5.0 Cookbook", "Scatter Plot", "Scatter Plot with Points Only"]
BreadcrumbUrls: ["/cookbook/5.0/", "/cookbook/5.0/Scatter", "/cookbook/5.0/Scatter/ScatterPoints"]
Date: 2024-11-13
Version: ScottPlot 5.0.45
Version: ScottPlot 5.0.45
SearchUrl: "/cookbook/5.0/search/"
ShowEditLink: false
---


<div class='d-flex align-items-center mt-5'>
<h1 class='me-2 text-dark my-0 border-0'>Scatter Plot with Points Only</h1>
</div>

The `ScatterPoints()` method can be used to create a scatter plot with markers only (line width is set to 0).

[![](/cookbook/5.0/images/ScatterPoints.png?241112193154)](/cookbook/5.0/images/ScatterPoints.png?241112193154)

{{< recipe-sp5 sourceUrl="https://github.com/ScottPlot/ScottPlot/blob/main/src/ScottPlot5/ScottPlot5%20Cookbook/Recipes/PlotTypes/Scatter.cs" imageUrl="/cookbook/5.0/images/ScatterPoints.png?241112193154" >}}ScottPlot.Plot myPlot = new();

double[] xs = Generate.Consecutive(51);
double[] sin = Generate.Sin(51);
double[] cos = Generate.Cos(51);

myPlot.Add.ScatterPoints(xs, sin);
myPlot.Add.ScatterPoints(xs, cos);

myPlot.SavePng("demo.png", 400, 300);
{{< /recipe-sp5 >}}

<div class='my-5 text-center'>This recipe is one of many in the <a href='/cookbook/5.0/Scatter'>Scatter Plot</a> category</div>


