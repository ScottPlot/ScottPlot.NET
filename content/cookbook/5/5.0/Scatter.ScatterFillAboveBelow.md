---
Title: Scatter Plot Filled Above and Below - ScottPlot 5.0 Cookbook
Description: Filled areas above and below the FillY value can be individually customized
URL: /cookbook/5.0/Scatter/ScatterFillAboveBelow/
BreadcrumbNames: ["ScottPlot 5.0 Cookbook", "Scatter Plot", "Scatter Plot Filled Above and Below"]
BreadcrumbUrls: ["/cookbook/5.0/", "/cookbook/5.0/Scatter", "/cookbook/5.0/Scatter/ScatterFillAboveBelow"]
Date: 2025-01-26
Version: ScottPlot 5.0.55
Version: ScottPlot 5.0.55
SearchUrl: "/cookbook/5.0/search/"
ShowEditLink: false
---


<div class='d-flex align-items-center mt-5'>
<h1 class='me-2 text-dark my-0 border-0'>Scatter Plot Filled Above and Below</h1>
</div>

Filled areas above and below the FillY value can be individually customized

[![](/cookbook/5.0/images/ScatterFillAboveBelow.png?250126165944)](/cookbook/5.0/images/ScatterFillAboveBelow.png?250126165944)

{{< recipe-sp5 sourceUrl="https://github.com/ScottPlot/ScottPlot/blob/main/src/ScottPlot5/ScottPlot5%20Cookbook/Recipes/PlotTypes/Scatter.cs" imageUrl="/cookbook/5.0/images/ScatterFillAboveBelow.png?250126165944" >}}ScottPlot.Plot myPlot = new();

double[] xs = Generate.Consecutive(51);
double[] ys = Generate.Sin(51);

var sp = myPlot.Add.Scatter(xs, ys);
sp.FillY = true;
sp.FillYValue = 0;
sp.FillYAboveColor = Colors.Green.WithAlpha(.2);
sp.FillYBelowColor = Colors.Red.WithAlpha(.2);

myPlot.SavePng("demo.png", 400, 300);
{{< /recipe-sp5 >}}

<div class='my-5 text-center'>This recipe is one of many in the <a href='/cookbook/5.0/Scatter'>Scatter Plot</a> category</div>


