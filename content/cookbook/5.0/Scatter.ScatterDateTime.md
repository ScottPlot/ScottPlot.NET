---
Title: Scatter DateTime - ScottPlot 5.0 Cookbook
Description: A scatter plot may use DateTime units but be sure to setup the respective axis to display using DateTime format.
URL: /cookbook/5.0/Scatter/ScatterDateTime/
BreadcrumbNames: ["ScottPlot 5.0 Cookbook", "Scatter Plot", "Scatter DateTime"]
BreadcrumbUrls: ["/cookbook/5.0/", "/cookbook/5.0/Scatter", "/cookbook/5.0/Scatter/ScatterDateTime"]
Date: 2025-01-26
Version: ScottPlot 5.0.55
Version: ScottPlot 5.0.55
SearchUrl: "/cookbook/5.0/search/"
ShowEditLink: false
---


<div class='d-flex align-items-center mt-5'>
<h1 class='me-2 text-dark my-0 border-0'>Scatter DateTime</h1>
</div>

A scatter plot may use DateTime units but be sure to setup the respective axis to display using DateTime format.

[![](/cookbook/5.0/images/ScatterDateTime.png?250126165944)](/cookbook/5.0/images/ScatterDateTime.png?250126165944)

{{< recipe-sp5 sourceUrl="https://github.com/ScottPlot/ScottPlot/blob/main/src/ScottPlot5/ScottPlot5%20Cookbook/Recipes/PlotTypes/Scatter.cs" imageUrl="/cookbook/5.0/images/ScatterDateTime.png?250126165944" >}}ScottPlot.Plot myPlot = new();

DateTime[] xs = Generate.ConsecutiveDays(100);
double[] ys = Generate.RandomWalk(xs.Length);

myPlot.Add.Scatter(xs, ys);
myPlot.Axes.DateTimeTicksBottom();

myPlot.SavePng("demo.png", 400, 300);
{{< /recipe-sp5 >}}

<div class='my-5 text-center'>This recipe is one of many in the <a href='/cookbook/5.0/Scatter'>Scatter Plot</a> category</div>


