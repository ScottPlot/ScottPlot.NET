---
Title: Scatter Plot Data Type - ScottPlot 5.0 Cookbook
Description: Scatter plots can be created from any numeric data type, not just double.
URL: /cookbook/5.0/Scatter/ScatterDataType/
BreadcrumbNames: ["ScottPlot 5.0 Cookbook", "Scatter Plot", "Scatter Plot Data Type"]
BreadcrumbUrls: ["/cookbook/5.0/", "/cookbook/5.0/Scatter", "/cookbook/5.0/Scatter/ScatterDataType"]
Date: 2024-10-30
Version: ScottPlot 5.0.42
Version: ScottPlot 5.0.42
SearchUrl: "/cookbook/5.0/search/"
ShowEditLink: false
---


<h2 style='border-bottom: 0;'><a href='/cookbook/5.0/Scatter/ScatterDataType'>Scatter Plot Data Type</a></h2>

<div class="d-flex mb-2">
<a class="btn btn-sm btn-primary me-1" href="/cookbook/5.0/Scatter/ScatterDataType">Recipe Permalink</a>
<a class="btn btn-sm btn-success me-1" href="/cookbook/5.0/Scatter">Category: Scatter Plot</a>
</div>

Scatter plots can be created from any numeric data type, not just double.

[![](/cookbook/5.0/images/ScatterDataType.png?241029205813)](/cookbook/5.0/images/ScatterDataType.png?241029205813)

{{< recipe-sp5 >}}ScottPlot.Plot myPlot = new();

float[] xs = { 1, 2, 3, 4, 5 };
int[] ys = { 1, 4, 9, 16, 25 };

myPlot.Add.Scatter(xs, ys);

myPlot.SavePng("demo.png", 400, 300);
{{< /recipe-sp5 >}}

<hr class='my-5 invisible'>


