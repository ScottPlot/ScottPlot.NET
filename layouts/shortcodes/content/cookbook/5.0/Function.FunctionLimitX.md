---
Title: Function Limit X - ScottPlot 5.0 Cookbook
Description: A function can be limited to a range of X values.
URL: /cookbook/5.0/Function/FunctionLimitX/
BreadcrumbNames: ["ScottPlot 5.0 Cookbook", "Function", "Function Limit X"]
BreadcrumbUrls: ["/cookbook/5.0/", "/cookbook/5.0/Function", "/cookbook/5.0/Function/FunctionLimitX"]
Date: 2025-08-23
Version: ScottPlot 5.0.56
Version: ScottPlot 5.0.56
SearchUrl: "/cookbook/5.0/search/"
ShowEditLink: false
---


<div class='d-flex align-items-center mt-5'>
<h1 class='me-2 text-dark my-0 border-0'>Function Limit X</h1>
</div>

A function can be limited to a range of X values.

[![](/cookbook/5.0/images/FunctionLimitX.png?250822231048)](/cookbook/5.0/images/FunctionLimitX.png?250822231048)

{{< recipe-sp5 sourceUrl="https://github.com/ScottPlot/ScottPlot/blob/main/src/ScottPlot5/ScottPlot5%20Cookbook/Recipes/PlotTypes/Function.cs" imageUrl="/cookbook/5.0/images/FunctionLimitX.png?250822231048" >}}ScottPlot.Plot myPlot = new();

static double func1(double x) =&gt; (Math.Sin(x) * Math.Sin(x / 2));

var f = myPlot.Add.Function(func1);
f.MinX = -3;
f.MaxX = 3;

myPlot.Axes.SetLimits(-5, 5, -.2, 1.0);

myPlot.SavePng("demo.png", 400, 300);
{{< /recipe-sp5 >}}

<div class='my-5 text-center'>This recipe is one of many in the <a href='/cookbook/5.0/Function'>Function</a> category</div>


