---
Title: Scatter Plot of List Data - ScottPlot 5.0 Cookbook
Description: Scatter plots can be created from Lists, but be very cafeful not to add or remove items while a render is occurring or you may throw an index exception. See documentation about the Render Lock system for details.
URL: /cookbook/5.0/Scatter/ScatterList/
BreadcrumbNames: ["ScottPlot 5.0 Cookbook", "Scatter Plot", "Scatter Plot of List Data"]
BreadcrumbUrls: ["/cookbook/5.0/", "/cookbook/5.0/Scatter", "/cookbook/5.0/Scatter/ScatterList"]
Date: 2024-10-31
Version: ScottPlot 5.0.42
Version: ScottPlot 5.0.42
SearchUrl: "/cookbook/5.0/search/"
ShowEditLink: false
---


<h2 style='border-bottom: 0;'><a href='/cookbook/5.0/Scatter/ScatterList'>Scatter Plot of List Data</a></h2>

<div class="d-flex mb-2">
<a class="btn btn-sm btn-primary me-1" href="/cookbook/5.0/Scatter/ScatterList">Recipe Permalink</a>
<a class="btn btn-sm btn-success me-1" href="/cookbook/5.0/Scatter">Category: Scatter Plot</a>
</div>

Scatter plots can be created from Lists, but be very cafeful not to add or remove items while a render is occurring or you may throw an index exception. See documentation about the Render Lock system for details.

[![](/cookbook/5.0/images/ScatterList.png?241031194635)](/cookbook/5.0/images/ScatterList.png?241031194635)

{{< recipe-sp5 >}}ScottPlot.Plot myPlot = new();

List<double> xs = new() { 1, 2, 3, 4, 5 };
List<double> ys = new() { 1, 4, 9, 16, 25 };

myPlot.Add.Scatter(xs, ys);

myPlot.SavePng("demo.png", 400, 300);
{{< /recipe-sp5 >}}

<hr class='my-5 invisible'>


