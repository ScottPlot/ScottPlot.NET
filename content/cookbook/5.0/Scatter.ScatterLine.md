---
Title: Scatter Plot with Lines Only - ScottPlot 5.0 Cookbook
Description: The `ScatterLine()` method can be used to create a scatter plot with a line only (marker size is set to 0).
URL: /cookbook/5.0/Scatter/ScatterLine/
BreadcrumbNames: ["ScottPlot 5.0 Cookbook", "Scatter Plot", "Scatter Plot with Lines Only"]
BreadcrumbUrls: ["/cookbook/5.0/", "/cookbook/5.0/Scatter", "/cookbook/5.0/Scatter/ScatterLine"]
Date: 2024-10-31
Version: ScottPlot 5.0.42
Version: ScottPlot 5.0.42
SearchUrl: "/cookbook/5.0/search/"
ShowEditLink: false
---


<h2 style='border-bottom: 0;'><a href='/cookbook/5.0/Scatter/ScatterLine'>Scatter Plot with Lines Only</a></h2>

<div class="d-flex mb-2">
<a class="btn btn-sm btn-primary me-1" href="/cookbook/5.0/Scatter/ScatterLine">Recipe Permalink</a>
<a class="btn btn-sm btn-success me-1" href="/cookbook/5.0/Scatter">Category: Scatter Plot</a>
</div>

The `ScatterLine()` method can be used to create a scatter plot with a line only (marker size is set to 0).

[![](/cookbook/5.0/images/ScatterLine.png?241031194635)](/cookbook/5.0/images/ScatterLine.png?241031194635)

{{< recipe-sp5 >}}ScottPlot.Plot myPlot = new();

double[] xs = Generate.Consecutive(51);
double[] sin = Generate.Sin(51);
double[] cos = Generate.Cos(51);

myPlot.Add.ScatterLine(xs, sin);
myPlot.Add.ScatterLine(xs, cos);

myPlot.SavePng("demo.png", 400, 300);
{{< /recipe-sp5 >}}

<hr class='my-5 invisible'>


