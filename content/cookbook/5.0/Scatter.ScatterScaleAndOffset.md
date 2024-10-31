---
Title: Scatter Scale and Offset - ScottPlot 5.0 Cookbook
Description: Scatter plot points can be multiplied by custom X and Y scale factors, or shifted horizontally or vertically using X and Y offset values.
URL: /cookbook/5.0/Scatter/ScatterScaleAndOffset/
BreadcrumbNames: ["ScottPlot 5.0 Cookbook", "Scatter Plot", "Scatter Scale and Offset"]
BreadcrumbUrls: ["/cookbook/5.0/", "/cookbook/5.0/Scatter", "/cookbook/5.0/Scatter/ScatterScaleAndOffset"]
Date: 2024-10-31
Version: ScottPlot 5.0.42
Version: ScottPlot 5.0.42
SearchUrl: "/cookbook/5.0/search/"
ShowEditLink: false
---


<h2 style='border-bottom: 0;'><a href='/cookbook/5.0/Scatter/ScatterScaleAndOffset'>Scatter Scale and Offset</a></h2>

<div class="d-flex mb-2">
<a class="btn btn-sm btn-primary me-1" href="/cookbook/5.0/Scatter/ScatterScaleAndOffset">Recipe Permalink</a>
<a class="btn btn-sm btn-success me-1" href="/cookbook/5.0/Scatter">Category: Scatter Plot</a>
</div>

Scatter plot points can be multiplied by custom X and Y scale factors, or shifted horizontally or vertically using X and Y offset values.

[![](/cookbook/5.0/images/ScatterScaleAndOffset.png?241031194635)](/cookbook/5.0/images/ScatterScaleAndOffset.png?241031194635)

{{< recipe-sp5 >}}ScottPlot.Plot myPlot = new();

double[] xs = Generate.Consecutive(51);
double[] ys = Generate.Sin(51);
var sp = myPlot.Add.Scatter(xs, ys);
sp.ScaleX = 100;
sp.ScaleY = 10;
sp.OffsetX = 500;
sp.OffsetY = 5;

myPlot.SavePng("demo.png", 400, 300);
{{< /recipe-sp5 >}}

<hr class='my-5 invisible'>


