---
Title: Limiting Display with Render Indexes - ScottPlot 5.0 Cookbook
Description: Although a scatter plot may contain a very large amount of data, much of it may be unpopulated. The user can define min and max render indexes, and only values within that range will be displayed when the scatter plot is rendered.
URL: /cookbook/5.0/Scatter/ScatterLimitIndex/
BreadcrumbNames: ["ScottPlot 5.0 Cookbook", "Scatter Plot", "Limiting Display with Render Indexes"]
BreadcrumbUrls: ["/cookbook/5.0/", "/cookbook/5.0/Scatter", "/cookbook/5.0/Scatter/ScatterLimitIndex"]
Date: 2024-11-17
Version: ScottPlot 5.0.46
Version: ScottPlot 5.0.46
SearchUrl: "/cookbook/5.0/search/"
ShowEditLink: false
---


<div class='d-flex align-items-center mt-5'>
<h1 class='me-2 text-dark my-0 border-0'>Limiting Display with Render Indexes</h1>
</div>

Although a scatter plot may contain a very large amount of data, much of it may be unpopulated. The user can define min and max render indexes, and only values within that range will be displayed when the scatter plot is rendered.

[![](/cookbook/5.0/images/ScatterLimitIndex.png?241117162641)](/cookbook/5.0/images/ScatterLimitIndex.png?241117162641)

{{< recipe-sp5 sourceUrl="https://github.com/ScottPlot/ScottPlot/blob/main/src/ScottPlot5/ScottPlot5%20Cookbook/Recipes/PlotTypes/Scatter.cs" imageUrl="/cookbook/5.0/images/ScatterLimitIndex.png?241117162641" >}}ScottPlot.Plot myPlot = new();

double[] xs = Generate.Consecutive(51);
double[] ys = Generate.Sin(51);

var sp = myPlot.Add.Scatter(xs, ys);
sp.MinRenderIndex = 10;
sp.MaxRenderIndex = 40;

myPlot.SavePng("demo.png", 400, 300);
{{< /recipe-sp5 >}}

<div class='my-5 text-center'>This recipe is one of many in the <a href='/cookbook/5.0/Scatter'>Scatter Plot</a> category</div>


