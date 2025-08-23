---
Title: Kernel Density Estimation - ScottPlot 5.0 Cookbook
Description: Kernel Density Estimation (KDE) can be used to estimate a PDF for a histogram, allowing the creation of density plots
URL: /cookbook/5.0/KernelDensityEstimation/
BreadcrumbNames: ["ScottPlot 5.0 Cookbook", "Kernel Density Estimation"]
BreadcrumbUrls: ["/cookbook/5.0/", "/cookbook/5.0/KernelDensityEstimation"]
Date: 2025-08-23
Version: ScottPlot 5.0.56
Version: ScottPlot 5.0.56
SearchUrl: "/cookbook/5.0/search/"
ShowEditLink: false
---

<h1>Kernel Density Estimation</h1>


<div class='d-flex align-items-center mt-5'>
<h1 class='me-2 text-dark my-0 border-0'>Density Plot</h1>
<a href='/cookbook/5.0/KernelDensityEstimation/KdeQuickstart' target='_blank'>
<img src='/images/icons/new-window.svg' style='height: 2rem;' class='new-window-icon'>
</a>
</div>

Density Plots use KDE to estimate a PDF.

[![](/cookbook/5.0/images/KdeQuickstart.png?250822231048)](/cookbook/5.0/images/KdeQuickstart.png?250822231048)

{{< recipe-sp5 sourceUrl="https://github.com/ScottPlot/ScottPlot/blob/main/src/ScottPlot5/ScottPlot5%20Cookbook/Recipes/Miscellaneous/KernelDensityEstimation.cs" imageUrl="/cookbook/5.0/images/KdeQuickstart.png?250822231048" >}}ScottPlot.Plot myPlot = new();

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

<hr class='my-5 invisible'>



<div class='d-flex align-items-center mt-5'>
<h1 class='me-2 text-dark my-0 border-0'>Density Plot Kernels</h1>
<a href='/cookbook/5.0/KernelDensityEstimation/KdeKernelOptions' target='_blank'>
<img src='/images/icons/new-window.svg' style='height: 2rem;' class='new-window-icon'>
</a>
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

<hr class='my-5 invisible'>


