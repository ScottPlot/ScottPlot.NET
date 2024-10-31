---
Title: Scatter DateTime - ScottPlot 5.0 Cookbook
Description: A scatter plot may use DateTime units but be sure to setup the respective axis to display using DateTime format.
URL: /cookbook/5.0/Scatter/ScatterDateTime/
BreadcrumbNames: ["ScottPlot 5.0 Cookbook", "Scatter Plot", "Scatter DateTime"]
BreadcrumbUrls: ["/cookbook/5.0/", "/cookbook/5.0/Scatter", "/cookbook/5.0/Scatter/ScatterDateTime"]
Date: 2024-10-31
Version: ScottPlot 5.0.42
Version: ScottPlot 5.0.42
SearchUrl: "/cookbook/5.0/search/"
ShowEditLink: false
---


<h2 style='border-bottom: 0;'><a href='/cookbook/5.0/Scatter/ScatterDateTime'>Scatter DateTime</a></h2>

<div class="d-flex mb-2">
<a class="btn btn-sm btn-primary me-1" href="/cookbook/5.0/Scatter/ScatterDateTime">Recipe Permalink</a>
<a class="btn btn-sm btn-success me-1" href="/cookbook/5.0/Scatter">Category: Scatter Plot</a>
</div>

A scatter plot may use DateTime units but be sure to setup the respective axis to display using DateTime format.

[![](/cookbook/5.0/images/ScatterDateTime.png?241031194635)](/cookbook/5.0/images/ScatterDateTime.png?241031194635)

{{< recipe-sp5 >}}ScottPlot.Plot myPlot = new();

DateTime[] xs = Generate.ConsecutiveDays(100);
double[] ys = Generate.RandomWalk(xs.Length);

myPlot.Add.Scatter(xs, ys);
myPlot.Axes.DateTimeTicksBottom();

myPlot.SavePng("demo.png", 400, 300);
{{< /recipe-sp5 >}}

<hr class='my-5 invisible'>


