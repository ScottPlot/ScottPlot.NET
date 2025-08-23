---
Title: Density Plot Kernels - ScottPlot 5.0 Cookbook
Description: Several choices of kernels are available.
URL: /cookbook/5.0/KernelDensityEstimation/KdeKernelOptions/
BreadcrumbNames: ["ScottPlot 5.0 Cookbook", "Kernel Density Estimation", "Density Plot Kernels"]
BreadcrumbUrls: ["/cookbook/5.0/", "/cookbook/5.0/KernelDensityEstimation", "/cookbook/5.0/KernelDensityEstimation/KdeKernelOptions"]
Date: 2025-08-23
Version: ScottPlot 5.0.56
Version: ScottPlot 5.0.56
SearchUrl: "/cookbook/5.0/search/"
ShowEditLink: false
---


<div class='d-flex align-items-center mt-5'>
<h1 class='me-2 text-dark my-0 border-0'>Density Plot Kernels</h1>
</div>

Several choices of kernels are available.

[![](/cookbook/5.0/images/KdeKernelOptions.png?250822231048)](/cookbook/5.0/images/KdeKernelOptions.png?250822231048)

{{< recipe-sp5 sourceUrl="https://github.com/ScottPlot/ScottPlot/blob/main/src/ScottPlot5/ScottPlot5%20Cookbook/Recipes/Miscellaneous/KernelDensityEstimation.cs" imageUrl="/cookbook/5.0/images/KdeKernelOptions.png?250822231048" >}}ScottPlot.Plot myPlot = new();

var ys = SampleData.Faithful;

var hist = Histogram.WithBinCount(80, ys);

var histPlot = myPlot.Add.Histogram(hist);
histPlot.BarWidthFraction = 0.8;
foreach (var bar in histPlot.Bars)
{
    bar.FillColor = Colors.LightBlue;
}

foreach (var kernel in Enum.GetValues&lt;KdeKernel&gt;())
{
    var densityEstimate = hist.Bins.Select((x, i) =&gt; KernelDensity.Estimate(x, ys, kernel)).ToArray();
    double scale = ys.Length;

    var rescaledDensityEstimate = densityEstimate.Select(x =&gt; x * scale).ToArray();

    var scat = myPlot.Add.Scatter(hist.Bins, rescaledDensityEstimate);
    scat.MarkerSize = 0;
    scat.LegendText = kernel.ToString();
}

myPlot.SavePng("demo.png", 400, 300);
{{< /recipe-sp5 >}}

<div class='my-5 text-center'>This recipe is one of many in the <a href='/cookbook/5.0/KernelDensityEstimation'>Kernel Density Estimation</a> category</div>


