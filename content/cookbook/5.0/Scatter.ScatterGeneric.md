---
Title: Scatter Generic - ScottPlot 5.0 Cookbook
Description: Scatter plots support generic data types, although double is typically the most performant.
URL: /cookbook/5.0/Scatter/ScatterGeneric/
BreadcrumbNames: ["ScottPlot 5.0 Cookbook", "Scatter Plot", "Scatter Generic"]
BreadcrumbUrls: ["/cookbook/5.0/", "/cookbook/5.0/Scatter", "/cookbook/5.0/Scatter/ScatterGeneric"]
Date: 2025-01-26
Version: ScottPlot 5.0.55
Version: ScottPlot 5.0.55
SearchUrl: "/cookbook/5.0/search/"
ShowEditLink: false
---


<div class='d-flex align-items-center mt-5'>
<h1 class='me-2 text-dark my-0 border-0'>Scatter Generic</h1>
</div>

Scatter plots support generic data types, although double is typically the most performant.

[![](/cookbook/5.0/images/ScatterGeneric.png?250126165944)](/cookbook/5.0/images/ScatterGeneric.png?250126165944)

{{< recipe-sp5 sourceUrl="https://github.com/ScottPlot/ScottPlot/blob/main/src/ScottPlot5/ScottPlot5%20Cookbook/Recipes/PlotTypes/Scatter.cs" imageUrl="/cookbook/5.0/images/ScatterGeneric.png?250126165944" >}}ScottPlot.Plot myPlot = new();

int[] xs = { 1, 2, 3, 4, 5 };
float[] ys = { 1, 4, 9, 16, 25 };

myPlot.Add.Scatter(xs, ys);

myPlot.SavePng("demo.png", 400, 300);
{{< /recipe-sp5 >}}

<div class='my-5 text-center'>This recipe is one of many in the <a href='/cookbook/5.0/Scatter'>Scatter Plot</a> category</div>


