---
Title: Scatter Plot with Points Only - ScottPlot 5.0 Cookbook
Description: The `ScatterPoints()` method can be used to create a scatter plot with markers only (line width is set to 0).
URL: /cookbook/5.0/Scatter/ScatterPoints/
BreadcrumbNames: ["ScottPlot 5.0 Cookbook", "Scatter Plot", "Scatter Plot with Points Only"]
BreadcrumbUrls: ["/cookbook/5.0/", "/cookbook/5.0/Scatter", "/cookbook/5.0/Scatter/ScatterPoints"]
Date: 2024-10-30
Version: ScottPlot 5.0.42
Version: ScottPlot 5.0.42
SearchUrl: "/cookbook/5.0/search/"
ShowEditLink: false
---


<h2 style='border-bottom: 0;'><a href='/cookbook/5.0/Scatter/ScatterPoints'>Scatter Plot with Points Only</a></h2>

<div class="d-flex mb-2">
<a class="btn btn-sm btn-primary me-1" href="/cookbook/5.0/Scatter/ScatterPoints">Recipe Permalink</a>
<a class="btn btn-sm btn-success me-1" href="/cookbook/5.0/Scatter">Category: Scatter Plot</a>
</div>

The `ScatterPoints()` method can be used to create a scatter plot with markers only (line width is set to 0).

[![](/cookbook/5.0/images/ScatterPoints.png?241029205813)](/cookbook/5.0/images/ScatterPoints.png?241029205813)

{{< recipe-sp5 >}}ScottPlot.Plot myPlot = new();

double[] xs = Generate.Consecutive(51);
double[] sin = Generate.Sin(51);
double[] cos = Generate.Cos(51);

myPlot.Add.ScatterPoints(xs, sin);
myPlot.Add.ScatterPoints(xs, cos);

myPlot.SavePng("demo.png", 400, 300);
{{< /recipe-sp5 >}}

<hr class='my-5 invisible'>


