---
Title: Scatter Plot with Gradient Fill - ScottPlot 5.0 Cookbook
Description: The area beneath a scatter plot can be filled with a custom gradient of colors.
URL: /cookbook/5.0/Scatter/ScatterFillGradient/
BreadcrumbNames: ["ScottPlot 5.0 Cookbook", "Scatter Plot", "Scatter Plot with Gradient Fill"]
BreadcrumbUrls: ["/cookbook/5.0/", "/cookbook/5.0/Scatter", "/cookbook/5.0/Scatter/ScatterFillGradient"]
Date: 2024-10-31
Version: ScottPlot 5.0.42
Version: ScottPlot 5.0.42
SearchUrl: "/cookbook/5.0/search/"
ShowEditLink: false
---


<h2 style='border-bottom: 0;'><a href='/cookbook/5.0/Scatter/ScatterFillGradient'>Scatter Plot with Gradient Fill</a></h2>

<div class="d-flex mb-2">
<a class="btn btn-sm btn-primary me-1" href="/cookbook/5.0/Scatter/ScatterFillGradient">Recipe Permalink</a>
<a class="btn btn-sm btn-success me-1" href="/cookbook/5.0/Scatter">Category: Scatter Plot</a>
</div>

The area beneath a scatter plot can be filled with a custom gradient of colors.

[![](/cookbook/5.0/images/ScatterFillGradient.png?241031194635)](/cookbook/5.0/images/ScatterFillGradient.png?241031194635)

{{< recipe-sp5 >}}ScottPlot.Plot myPlot = new();

double[] xs = Generate.Consecutive(51);
double[] ys = Generate.Sin(51);

var poly = myPlot.Add.ScatterLine(xs, ys);

poly.FillY = true;
poly.ColorPositions.Add(new(Colors.Red, 0));
poly.ColorPositions.Add(new(Colors.Orange, 10));
poly.ColorPositions.Add(new(Colors.Yellow, 20));
poly.ColorPositions.Add(new(Colors.Green, 30));
poly.ColorPositions.Add(new(Colors.Blue, 40));
poly.ColorPositions.Add(new(Colors.Violet, 50));

myPlot.SavePng("demo.png", 400, 300);
{{< /recipe-sp5 >}}

<hr class='my-5 invisible'>


