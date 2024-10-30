---
Title: Scatter Plot with Smooth Lines - ScottPlot 5.0 Cookbook
Description: Scatter plots draw straight lines between points by default, but setting the Smooth property allows the scatter plot to connect points with smooth lines. Lines are smoothed using cubic spline interpolation.
URL: /cookbook/5.0/Scatter/ScatterSmooth/
BreadcrumbNames: ["ScottPlot 5.0 Cookbook", "Scatter Plot", "Scatter Plot with Smooth Lines"]
BreadcrumbUrls: ["/cookbook/5.0/", "/cookbook/5.0/Scatter", "/cookbook/5.0/Scatter/ScatterSmooth"]
Date: 2024-10-30
Version: ScottPlot 5.0.42
Version: ScottPlot 5.0.42
SearchUrl: "/cookbook/5.0/search/"
ShowEditLink: false
---


<h2 style='border-bottom: 0;'><a href='/cookbook/5.0/Scatter/ScatterSmooth'>Scatter Plot with Smooth Lines</a></h2>

<div class="d-flex mb-2">
<a class="btn btn-sm btn-primary me-1" href="/cookbook/5.0/Scatter/ScatterSmooth">Recipe Permalink</a>
<a class="btn btn-sm btn-success me-1" href="/cookbook/5.0/Scatter">Category: Scatter Plot</a>
</div>

Scatter plots draw straight lines between points by default, but setting the Smooth property allows the scatter plot to connect points with smooth lines. Lines are smoothed using cubic spline interpolation.

[![](/cookbook/5.0/images/ScatterSmooth.png?241029205813)](/cookbook/5.0/images/ScatterSmooth.png?241029205813)

{{< recipe-sp5 >}}ScottPlot.Plot myPlot = new();

double[] xs = Generate.Consecutive(10);
double[] ys = Generate.RandomSample(10, 5, 15);

var sp = myPlot.Add.Scatter(xs, ys);
sp.Smooth = true;
sp.LegendText = "Smooth";
sp.LineWidth = 2;
sp.MarkerSize = 10;

myPlot.SavePng("demo.png", 400, 300);
{{< /recipe-sp5 >}}

<hr class='my-5 invisible'>


