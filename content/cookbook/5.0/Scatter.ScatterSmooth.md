---
Title: Scatter Plot with Smooth Lines - ScottPlot 5.0 Cookbook
Description: Scatter plots draw straight lines between points by default, but setting the Smooth property allows the scatter plot to connect points with smooth lines. Lines are smoothed using cubic spline interpolation.
URL: /cookbook/5.0/Scatter/ScatterSmooth/
BreadcrumbNames: ["ScottPlot 5.0 Cookbook", "Scatter Plot", "Scatter Plot with Smooth Lines"]
BreadcrumbUrls: ["/cookbook/5.0/", "/cookbook/5.0/Scatter", "/cookbook/5.0/Scatter/ScatterSmooth"]
Date: 2024-11-17
Version: ScottPlot 5.0.46
Version: ScottPlot 5.0.46
SearchUrl: "/cookbook/5.0/search/"
ShowEditLink: false
---


<div class='d-flex align-items-center mt-5'>
<h1 class='me-2 text-dark my-0 border-0'>Scatter Plot with Smooth Lines</h1>
</div>

Scatter plots draw straight lines between points by default, but setting the Smooth property allows the scatter plot to connect points with smooth lines. Lines are smoothed using cubic spline interpolation.

[![](/cookbook/5.0/images/ScatterSmooth.png?241117162641)](/cookbook/5.0/images/ScatterSmooth.png?241117162641)

{{< recipe-sp5 sourceUrl="https://github.com/ScottPlot/ScottPlot/blob/main/src/ScottPlot5/ScottPlot5%20Cookbook/Recipes/PlotTypes/Scatter.cs" imageUrl="/cookbook/5.0/images/ScatterSmooth.png?241117162641" >}}ScottPlot.Plot myPlot = new();

double[] xs = Generate.Consecutive(10);
double[] ys = Generate.RandomSample(10, 5, 15);

var sp = myPlot.Add.Scatter(xs, ys);
sp.Smooth = true;
sp.LegendText = "Smooth";
sp.LineWidth = 2;
sp.MarkerSize = 10;

myPlot.SavePng("demo.png", 400, 300);
{{< /recipe-sp5 >}}

<div class='my-5 text-center'>This recipe is one of many in the <a href='/cookbook/5.0/Scatter'>Scatter Plot</a> category</div>


