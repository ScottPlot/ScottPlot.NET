---
Title: Scatter Plot Filled Above and Below - ScottPlot 5.0 Cookbook
Description: Filled areas above and below the FillY value can be individually customized
URL: /cookbook/5.0/Scatter/ScatterFillAboveBelow/
BreadcrumbNames: ["ScottPlot 5.0 Cookbook", "Scatter Plot", "Scatter Plot Filled Above and Below"]
BreadcrumbUrls: ["/cookbook/5.0/", "/cookbook/5.0/Scatter", "/cookbook/5.0/Scatter/ScatterFillAboveBelow"]
Date: 2024-10-30
Version: ScottPlot 5.0.42
Version: ScottPlot 5.0.42
SearchUrl: "/cookbook/5.0/search/"
ShowEditLink: false
---


<h2 style='border-bottom: 0;'><a href='/cookbook/5.0/Scatter/ScatterFillAboveBelow'>Scatter Plot Filled Above and Below</a></h2>

<div class="d-flex mb-2">
<a class="btn btn-sm btn-primary me-1" href="/cookbook/5.0/Scatter/ScatterFillAboveBelow">Recipe Permalink</a>
<a class="btn btn-sm btn-success me-1" href="/cookbook/5.0/Scatter">Category: Scatter Plot</a>
</div>

Filled areas above and below the FillY value can be individually customized

[![](/cookbook/5.0/images/ScatterFillAboveBelow.png?241029205813)](/cookbook/5.0/images/ScatterFillAboveBelow.png?241029205813)

{{< recipe-sp5 >}}ScottPlot.Plot myPlot = new();

double[] xs = Generate.Consecutive(51);
double[] ys = Generate.Sin(51);

var sp = myPlot.Add.Scatter(xs, ys);
sp.FillY = true;
sp.FillYValue = 0;
sp.FillYAboveColor = Colors.Green.WithAlpha(.2);
sp.FillYBelowColor = Colors.Red.WithAlpha(.2);

myPlot.SavePng("demo.png", 400, 300);
{{< /recipe-sp5 >}}

<hr class='my-5 invisible'>


