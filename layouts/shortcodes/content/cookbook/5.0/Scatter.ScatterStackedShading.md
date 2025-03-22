---
Title: Stacked Scatter with Shading - ScottPlot 5.0 Cookbook
Description: Demonstrates how to combine filled scatter plots with vertical and horizontal offsets to achieve an interesting visual effect.
URL: /cookbook/5.0/Scatter/ScatterStackedShading/
BreadcrumbNames: ["ScottPlot 5.0 Cookbook", "Scatter Plot", "Stacked Scatter with Shading"]
BreadcrumbUrls: ["/cookbook/5.0/", "/cookbook/5.0/Scatter", "/cookbook/5.0/Scatter/ScatterStackedShading"]
Date: 2025-03-22
Version: ScottPlot 5.0.55
Version: ScottPlot 5.0.55
SearchUrl: "/cookbook/5.0/search/"
ShowEditLink: false
---


<div class='d-flex align-items-center mt-5'>
<h1 class='me-2 text-dark my-0 border-0'>Stacked Scatter with Shading</h1>
</div>

Demonstrates how to combine filled scatter plots with vertical and horizontal offsets to achieve an interesting visual effect.

[![](/cookbook/5.0/images/ScatterStackedShading.png?250322130304)](/cookbook/5.0/images/ScatterStackedShading.png?250322130304)

{{< recipe-sp5 sourceUrl="https://github.com/ScottPlot/ScottPlot/blob/main/src/ScottPlot5/ScottPlot5%20Cookbook/Recipes/PlotTypes/Scatter.cs" imageUrl="/cookbook/5.0/images/ScatterStackedShading.png?250322130304" >}}ScottPlot.Plot myPlot = new();

double[] xs = ScottPlot.Generate.Consecutive(100);
ScottPlot.Colormaps.MellowRainbow cmap = new();

for (int i = 0; i &lt; 10; i++)
{
    double yOffset = 9 - i * 0.5;
    double[] ys = Generate.Sigmoidal(xs.Length)
        .Select(y =&gt; y + yOffset)
        .ToArray();

    Generate.AddNoiseInPlace(ys, 0.1);

    var sig = myPlot.Add.ScatterLine(xs, ys);
    sig.LineColor = Colors.Black;
    sig.LineWidth = 1.5f;
    sig.FillY = true;
    sig.FillYValue = yOffset;
    sig.FillYAboveColor = cmap.GetColor(i, 10);
}

myPlot.HideGrid();
myPlot.Axes.MarginsX(0);

myPlot.SavePng("demo.png", 400, 300);
{{< /recipe-sp5 >}}

<div class='my-5 text-center'>This recipe is one of many in the <a href='/cookbook/5.0/Scatter'>Scatter Plot</a> category</div>


