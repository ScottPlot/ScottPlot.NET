---
Title: Scatter with Gaps - ScottPlot 5.0 Cookbook
Description: NaN values in a scatter plot's data will appear as gaps in the line.
URL: /cookbook/5.0/Scatter/ScatterWithGaps/
BreadcrumbNames: ["ScottPlot 5.0 Cookbook", "Scatter Plot", "Scatter with Gaps"]
BreadcrumbUrls: ["/cookbook/5.0/", "/cookbook/5.0/Scatter", "/cookbook/5.0/Scatter/ScatterWithGaps"]
Date: 2024-10-31
Version: ScottPlot 5.0.42
Version: ScottPlot 5.0.42
SearchUrl: "/cookbook/5.0/search/"
ShowEditLink: false
---


<h2 style='border-bottom: 0;'><a href='/cookbook/5.0/Scatter/ScatterWithGaps'>Scatter with Gaps</a></h2>

<div class="d-flex mb-2">
<a class="btn btn-sm btn-primary me-1" href="/cookbook/5.0/Scatter/ScatterWithGaps">Recipe Permalink</a>
<a class="btn btn-sm btn-success me-1" href="/cookbook/5.0/Scatter">Category: Scatter Plot</a>
</div>

NaN values in a scatter plot's data will appear as gaps in the line.

[![](/cookbook/5.0/images/ScatterWithGaps.png?241031194635)](/cookbook/5.0/images/ScatterWithGaps.png?241031194635)

{{< recipe-sp5 >}}ScottPlot.Plot myPlot = new();

double[] xs = Generate.Consecutive(51);
double[] ys = Generate.Sin(51);

// long stretch of empty data
for (int i = 10; i < 20; i++)
    ys[i] = double.NaN;

// single missing data point
ys[30] = double.NaN;

// single floating data point
for (int i = 35; i < 40; i++)
    ys[i] = double.NaN;
for (int i = 40; i < 45; i++)
    ys[i] = double.NaN;

myPlot.Add.Scatter(xs, ys);

myPlot.SavePng("demo.png", 400, 300);
{{< /recipe-sp5 >}}

<hr class='my-5 invisible'>


