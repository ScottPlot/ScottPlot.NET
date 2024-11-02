---
Title: Lollipop Positions - ScottPlot 5.0 Cookbook
Description: The position of each lollipop may be defined.
URL: /cookbook/5.0/Lollipop/LollipopPositions/
BreadcrumbNames: ["ScottPlot 5.0 Cookbook", "Lollipop Plot", "Lollipop Positions"]
BreadcrumbUrls: ["/cookbook/5.0/", "/cookbook/5.0/Lollipop", "/cookbook/5.0/Lollipop/LollipopPositions"]
Date: 2024-11-02
Version: ScottPlot 5.0.42
Version: ScottPlot 5.0.42
SearchUrl: "/cookbook/5.0/search/"
ShowEditLink: false
---


<div class='d-flex align-items-center mt-5'>
<h1 class='me-2 text-dark my-0 border-0'>Lollipop Positions</h1>
</div>

The position of each lollipop may be defined.

[![](/cookbook/5.0/images/LollipopPositions.png?241102170938)](/cookbook/5.0/images/LollipopPositions.png?241102170938)

{{< recipe-sp5 sourceUrl="https://github.com/ScottPlot/ScottPlot/blob/main/src/ScottPlot5/ScottPlot5%20Cookbook/Recipes/PlotTypes/Lollipop.cs" imageUrl="/cookbook/5.0/images/LollipopPositions.png?241102170938" >}}ScottPlot.Plot myPlot = new();

double[] xs = Generate.Range(0, 6.28, 0.314);
double[] ys = xs.Select(Math.Sin).ToArray();
var lollipop = myPlot.Add.Lollipop(ys, xs);

myPlot.SavePng("demo.png", 400, 300);
{{< /recipe-sp5 >}}

<div class='my-5 text-center'>This recipe is one of many in the <a href='/cookbook/5.0/Lollipop'>Lollipop Plot</a> category</div>


