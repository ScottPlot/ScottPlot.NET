---
Title: Function Limit X - ScottPlot 5.0 Cookbook
Description: A function can be limited to a range of X values.
URL: /cookbook/5.0/Function/FunctionLimitX/
BreadcrumbNames: ["ScottPlot 5.0 Cookbook", "Function", "Function Limit X"]
BreadcrumbUrls: ["/cookbook/5.0/", "/cookbook/5.0/Function", "/cookbook/5.0/Function/FunctionLimitX"]
Date: 2024-10-31
Version: ScottPlot 5.0.42
Version: ScottPlot 5.0.42
SearchUrl: "/cookbook/5.0/search/"
ShowEditLink: false
---


<h2 style='border-bottom: 0;'><a href='/cookbook/5.0/Function/FunctionLimitX'>Function Limit X</a></h2>

<div class="d-flex mb-2">
<a class="btn btn-sm btn-primary me-1" href="/cookbook/5.0/Function/FunctionLimitX">Recipe Permalink</a>
<a class="btn btn-sm btn-success me-1" href="/cookbook/5.0/Function">Category: Function</a>
</div>

A function can be limited to a range of X values.

[![](/cookbook/5.0/images/FunctionLimitX.png?241031194635)](/cookbook/5.0/images/FunctionLimitX.png?241031194635)

{{< recipe-sp5 >}}ScottPlot.Plot myPlot = new();

var func = new Func<double, double>((x) => Math.Sin(x) * Math.Sin(x / 2));

var f = myPlot.Add.Function(func);
f.MinX = -3;
f.MaxX = 3;

myPlot.Axes.SetLimits(-5, 5, -.2, 1.0);

myPlot.SavePng("demo.png", 400, 300);
{{< /recipe-sp5 >}}

<hr class='my-5 invisible'>


