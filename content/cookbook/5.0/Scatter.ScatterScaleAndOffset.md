---
Title: Scatter Scale and Offset - ScottPlot 5.0 Cookbook
Description: Scatter plot points can be multiplied by custom X and Y scale factors, or shifted horizontally or vertically using X and Y offset values.
URL: /cookbook/5.0/Scatter/ScatterScaleAndOffset/
BreadcrumbNames: ["ScottPlot 5.0 Cookbook", "Scatter Plot", "Scatter Scale and Offset"]
BreadcrumbUrls: ["/cookbook/5.0/", "/cookbook/5.0/Scatter", "/cookbook/5.0/Scatter/ScatterScaleAndOffset"]
Date: 2025-01-05
Version: ScottPlot 5.0.48
Version: ScottPlot 5.0.48
SearchUrl: "/cookbook/5.0/search/"
ShowEditLink: false
---


<div class='d-flex align-items-center mt-5'>
<h1 class='me-2 text-dark my-0 border-0'>Scatter Scale and Offset</h1>
</div>

Scatter plot points can be multiplied by custom X and Y scale factors, or shifted horizontally or vertically using X and Y offset values.

[![](/cookbook/5.0/images/ScatterScaleAndOffset.png?250105183901)](/cookbook/5.0/images/ScatterScaleAndOffset.png?250105183901)

{{< recipe-sp5 sourceUrl="https://github.com/ScottPlot/ScottPlot/blob/main/src/ScottPlot5/ScottPlot5%20Cookbook/Recipes/PlotTypes/Scatter.cs" imageUrl="/cookbook/5.0/images/ScatterScaleAndOffset.png?250105183901" >}}ScottPlot.Plot myPlot = new();

double[] xs = Generate.Consecutive(51);
double[] ys = Generate.Sin(51);
var sp = myPlot.Add.Scatter(xs, ys);
sp.ScaleX = 100;
sp.ScaleY = 10;
sp.OffsetX = 500;
sp.OffsetY = 5;

myPlot.SavePng("demo.png", 400, 300);
{{< /recipe-sp5 >}}

<div class='my-5 text-center'>This recipe is one of many in the <a href='/cookbook/5.0/Scatter'>Scatter Plot</a> category</div>


