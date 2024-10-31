---
Title: Lollipop Positions - ScottPlot 5.0 Cookbook
Description: The position of each lollipop may be defined.
URL: /cookbook/5.0/Lollipop/LollipopPositions/
BreadcrumbNames: ["ScottPlot 5.0 Cookbook", "Lollipop Plot", "Lollipop Positions"]
BreadcrumbUrls: ["/cookbook/5.0/", "/cookbook/5.0/Lollipop", "/cookbook/5.0/Lollipop/LollipopPositions"]
Date: 2024-10-31
Version: ScottPlot 5.0.42
Version: ScottPlot 5.0.42
SearchUrl: "/cookbook/5.0/search/"
ShowEditLink: false
---


<h2 style='border-bottom: 0;'><a href='/cookbook/5.0/Lollipop/LollipopPositions'>Lollipop Positions</a></h2>

<div class="d-flex mb-2">
<a class="btn btn-sm btn-primary me-1" href="/cookbook/5.0/Lollipop/LollipopPositions">Recipe Permalink</a>
<a class="btn btn-sm btn-success me-1" href="/cookbook/5.0/Lollipop">Category: Lollipop Plot</a>
</div>

The position of each lollipop may be defined.

[![](/cookbook/5.0/images/LollipopPositions.png?241031194635)](/cookbook/5.0/images/LollipopPositions.png?241031194635)

{{< recipe-sp5 >}}ScottPlot.Plot myPlot = new();

double[] xs = Generate.Range(0, 6.28, 0.314);
double[] ys = xs.Select(Math.Sin).ToArray();
var lollipop = myPlot.Add.Lollipop(ys, xs);

myPlot.SavePng("demo.png", 400, 300);
{{< /recipe-sp5 >}}

<hr class='my-5 invisible'>


