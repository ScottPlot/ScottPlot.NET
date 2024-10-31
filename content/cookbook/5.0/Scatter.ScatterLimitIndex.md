---
Title: Limiting Display with Render Indexes - ScottPlot 5.0 Cookbook
Description: Although a scatter plot may contain a very large amount of data, much of it may be unpopulated. The user can define min and max render indexes, and only values within that range will be displayed when the scatter plot is rendered.
URL: /cookbook/5.0/Scatter/ScatterLimitIndex/
BreadcrumbNames: ["ScottPlot 5.0 Cookbook", "Scatter Plot", "Limiting Display with Render Indexes"]
BreadcrumbUrls: ["/cookbook/5.0/", "/cookbook/5.0/Scatter", "/cookbook/5.0/Scatter/ScatterLimitIndex"]
Date: 2024-10-31
Version: ScottPlot 5.0.42
Version: ScottPlot 5.0.42
SearchUrl: "/cookbook/5.0/search/"
ShowEditLink: false
---


<h2 style='border-bottom: 0;'><a href='/cookbook/5.0/Scatter/ScatterLimitIndex'>Limiting Display with Render Indexes</a></h2>

<div class="d-flex mb-2">
<a class="btn btn-sm btn-primary me-1" href="/cookbook/5.0/Scatter/ScatterLimitIndex">Recipe Permalink</a>
<a class="btn btn-sm btn-success me-1" href="/cookbook/5.0/Scatter">Category: Scatter Plot</a>
</div>

Although a scatter plot may contain a very large amount of data, much of it may be unpopulated. The user can define min and max render indexes, and only values within that range will be displayed when the scatter plot is rendered.

[![](/cookbook/5.0/images/ScatterLimitIndex.png?241031194635)](/cookbook/5.0/images/ScatterLimitIndex.png?241031194635)

{{< recipe-sp5 >}}ScottPlot.Plot myPlot = new();

double[] xs = Generate.Consecutive(51);
double[] ys = Generate.Sin(51);

var sp = myPlot.Add.Scatter(xs, ys);
sp.MinRenderIndex = 10;
sp.MaxRenderIndex = 40;

myPlot.SavePng("demo.png", 400, 300);
{{< /recipe-sp5 >}}

<hr class='my-5 invisible'>


