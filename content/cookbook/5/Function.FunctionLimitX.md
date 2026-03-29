---
Title: Function Limit X - ScottPlot 5 Cookbook
Description: A function can be limited to a range of X values.
URL: /cookbook/5/Function/FunctionLimitX/
BreadcrumbNames: ["ScottPlot 5 Cookbook", "Function", "Function Limit X"]
BreadcrumbUrls: ["/cookbook/5/", "/cookbook/5/Function", "/cookbook/5/Function/FunctionLimitX"]
Date: 2026-03-29
Version: ScottPlot 5.1.58
Version: ScottPlot 5.1.58
SearchUrl: "/cookbook/5/search/"
ShowEditLink: false
---


<div class='d-flex align-items-center mt-5'>
<h1 class='me-2 text-dark my-0 border-0'>Function Limit X</h1>
</div>

A function can be limited to a range of X values.

[![](/cookbook/5/images/FunctionLimitX.png?260329072039)](/cookbook/5/images/FunctionLimitX.png?260329072039)

{{< recipe-sp5 sourceUrl="https://github.com/ScottPlot/ScottPlot/blob/main/src/ScottPlot5/ScottPlot5%20Cookbook/Recipes/PlotTypes/Function.cs" imageUrl="/cookbook/5/images/FunctionLimitX.png?260329072039" >}}ScottPlot.Plot myPlot = new();

static double func1(double x) =&gt; (Math.Sin(x) * Math.Sin(x / 2));

var f = myPlot.Add.Function(func1);
f.MinX = -3;
f.MaxX = 3;

myPlot.Axes.SetLimits(-5, 5, -.2, 1.0);

myPlot.SavePng("demo.png", 400, 300);
{{< /recipe-sp5 >}}

<div class='my-5 text-center'>This recipe is one of many in the <a href='/cookbook/5/Function'>Function</a> category</div>


