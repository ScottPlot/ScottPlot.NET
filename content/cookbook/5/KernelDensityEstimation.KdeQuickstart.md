---
Title: Density Plot - ScottPlot 5 Cookbook
Description: Density Plots use KDE to estimate a PDF.
URL: /cookbook/5/KernelDensityEstimation/KdeQuickstart/
BreadcrumbNames: ["ScottPlot 5 Cookbook", "Kernel Density Estimation", "Density Plot"]
BreadcrumbUrls: ["/cookbook/5/", "/cookbook/5/KernelDensityEstimation", "/cookbook/5/KernelDensityEstimation/KdeQuickstart"]
Date: 2026-03-29
Version: ScottPlot 5.1.58
Version: ScottPlot 5.1.58
SearchUrl: "/cookbook/5/search/"
ShowEditLink: false
---


<div class='d-flex align-items-center mt-5'>
<h1 class='me-2 text-dark my-0 border-0'>Density Plot</h1>
</div>

Density Plots use KDE to estimate a PDF.

[![](/cookbook/5/images/KdeQuickstart.png?260329072039)](/cookbook/5/images/KdeQuickstart.png?260329072039)

{{< recipe-sp5 sourceUrl="https://github.com/ScottPlot/ScottPlot/blob/main/src/ScottPlot5/ScottPlot5%20Cookbook/Recipes/Miscellaneous/KernelDensityEstimation.cs" imageUrl="/cookbook/5/images/KdeQuickstart.png?260329072039" >}}ScottPlot.Plot myPlot = new();

var ys = SampleData.Faithful;

var hist = Histogram.WithBinCount(80, ys);

var histPlot = myPlot.Add.Histogram(hist);
histPlot.BarWidthFraction = 0.8;

var densityEstimate = hist.Bins.Select((x, i) =&gt; KernelDensity.Estimate(x, ys)).ToArray();
double scale = ys.Length;

var rescaledDensityEstimate = densityEstimate.Select(x =&gt; x * scale).ToArray();

var scat = myPlot.Add.Scatter(hist.Bins, rescaledDensityEstimate, Colors.Red);
scat.MarkerSize = 0;

myPlot.SavePng("demo.png", 400, 300);
{{< /recipe-sp5 >}}

<div class='my-5 text-center'>This recipe is one of many in the <a href='/cookbook/5/KernelDensityEstimation'>Kernel Density Estimation</a> category</div>


