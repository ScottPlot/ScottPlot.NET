---
Title: Scatter Generic - ScottPlot 5 Cookbook
Description: Scatter plots support generic data types, although double is typically the most performant.
URL: /cookbook/5/Scatter/ScatterGeneric/
BreadcrumbNames: ["ScottPlot 5 Cookbook", "Scatter Plot", "Scatter Generic"]
BreadcrumbUrls: ["/cookbook/5/", "/cookbook/5/Scatter", "/cookbook/5/Scatter/ScatterGeneric"]
Date: 2026-03-29
Version: ScottPlot 5.1.58
Version: ScottPlot 5.1.58
SearchUrl: "/cookbook/5/search/"
ShowEditLink: false
---


<div class='d-flex align-items-center mt-5'>
<h1 class='me-2 text-dark my-0 border-0'>Scatter Generic</h1>
</div>

Scatter plots support generic data types, although double is typically the most performant.

[![](/cookbook/5/images/ScatterGeneric.png?260329072039)](/cookbook/5/images/ScatterGeneric.png?260329072039)

{{< recipe-sp5 sourceUrl="https://github.com/ScottPlot/ScottPlot/blob/main/src/ScottPlot5/ScottPlot5%20Cookbook/Recipes/PlotTypes/Scatter.cs" imageUrl="/cookbook/5/images/ScatterGeneric.png?260329072039" >}}ScottPlot.Plot myPlot = new();

int[] xs = { 1, 2, 3, 4, 5 };
float[] ys = { 1, 4, 9, 16, 25 };

myPlot.Add.Scatter(xs, ys);

myPlot.SavePng("demo.png", 400, 300);
{{< /recipe-sp5 >}}

<div class='my-5 text-center'>This recipe is one of many in the <a href='/cookbook/5/Scatter'>Scatter Plot</a> category</div>


