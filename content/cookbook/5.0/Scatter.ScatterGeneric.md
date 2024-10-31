---
Title: Scatter Generic - ScottPlot 5.0 Cookbook
Description: Scatter plots support generic data types, although double is typically the most performant.
URL: /cookbook/5.0/Scatter/ScatterGeneric/
BreadcrumbNames: ["ScottPlot 5.0 Cookbook", "Scatter Plot", "Scatter Generic"]
BreadcrumbUrls: ["/cookbook/5.0/", "/cookbook/5.0/Scatter", "/cookbook/5.0/Scatter/ScatterGeneric"]
Date: 2024-10-31
Version: ScottPlot 5.0.42
Version: ScottPlot 5.0.42
SearchUrl: "/cookbook/5.0/search/"
ShowEditLink: false
---


<h2 style='border-bottom: 0;'><a href='/cookbook/5.0/Scatter/ScatterGeneric'>Scatter Generic</a></h2>

<div class="d-flex mb-2">
<a class="btn btn-sm btn-primary me-1" href="/cookbook/5.0/Scatter/ScatterGeneric">Recipe Permalink</a>
<a class="btn btn-sm btn-success me-1" href="/cookbook/5.0/Scatter">Category: Scatter Plot</a>
</div>

Scatter plots support generic data types, although double is typically the most performant.

[![](/cookbook/5.0/images/ScatterGeneric.png?241031194635)](/cookbook/5.0/images/ScatterGeneric.png?241031194635)

{{< recipe-sp5 >}}ScottPlot.Plot myPlot = new();

int[] xs = { 1, 2, 3, 4, 5 };
float[] ys = { 1, 4, 9, 16, 25 };

myPlot.Add.Scatter(xs, ys);

myPlot.SavePng("demo.png", 400, 300);
{{< /recipe-sp5 >}}

<hr class='my-5 invisible'>


