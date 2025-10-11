---
Title: Lollipop Positions - ScottPlot 5 Cookbook
Description: The position of each lollipop may be defined.
URL: /cookbook/5/Lollipop/LollipopPositions/
BreadcrumbNames: ["ScottPlot 5 Cookbook", "Lollipop Plot", "Lollipop Positions"]
BreadcrumbUrls: ["/cookbook/5/", "/cookbook/5/Lollipop", "/cookbook/5/Lollipop/LollipopPositions"]
Date: 2025-10-11
Version: ScottPlot 5.1.57
Version: ScottPlot 5.1.57
SearchUrl: "/cookbook/5/search/"
ShowEditLink: false
---


<div class='d-flex align-items-center mt-5'>
<h1 class='me-2 text-dark my-0 border-0'>Lollipop Positions</h1>
</div>

The position of each lollipop may be defined.

[![](/cookbook/5/images/LollipopPositions.png?251011113742)](/cookbook/5/images/LollipopPositions.png?251011113742)

{{< recipe-sp5 sourceUrl="https://github.com/ScottPlot/ScottPlot/blob/main/src/ScottPlot5/ScottPlot5%20Cookbook/Recipes/PlotTypes/Lollipop.cs" imageUrl="/cookbook/5/images/LollipopPositions.png?251011113742" >}}ScottPlot.Plot myPlot = new();

double[] xs = Generate.Range(0, 6.28, 0.314);
double[] ys = xs.Select(Math.Sin).ToArray();
var lollipop = myPlot.Add.Lollipop(ys, xs);

myPlot.SavePng("demo.png", 400, 300);
{{< /recipe-sp5 >}}

<div class='my-5 text-center'>This recipe is one of many in the <a href='/cookbook/5/Lollipop'>Lollipop Plot</a> category</div>


