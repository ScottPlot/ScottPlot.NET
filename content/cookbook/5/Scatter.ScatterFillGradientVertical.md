---
Title: Scatter Plot with Vertical Gradient - ScottPlot 5 Cookbook
Description: Scatter plots may be filled with vertical gradients.
URL: /cookbook/5/Scatter/ScatterFillGradientVertical/
BreadcrumbNames: ["ScottPlot 5 Cookbook", "Scatter Plot", "Scatter Plot with Vertical Gradient"]
BreadcrumbUrls: ["/cookbook/5/", "/cookbook/5/Scatter", "/cookbook/5/Scatter/ScatterFillGradientVertical"]
Date: 2025-10-11
Version: ScottPlot 5.1.57
Version: ScottPlot 5.1.57
SearchUrl: "/cookbook/5/search/"
ShowEditLink: false
---


<div class='d-flex align-items-center mt-5'>
<h1 class='me-2 text-dark my-0 border-0'>Scatter Plot with Vertical Gradient</h1>
</div>

Scatter plots may be filled with vertical gradients.

[![](/cookbook/5/images/ScatterFillGradientVertical.png?251011113742)](/cookbook/5/images/ScatterFillGradientVertical.png?251011113742)

{{< recipe-sp5 sourceUrl="https://github.com/ScottPlot/ScottPlot/blob/main/src/ScottPlot5/ScottPlot5%20Cookbook/Recipes/PlotTypes/Scatter.cs" imageUrl="/cookbook/5/images/ScatterFillGradientVertical.png?251011113742" >}}ScottPlot.Plot myPlot = new();

double[] xs = Generate.Consecutive(51);
double[] ys = Generate.Sin(51);

var poly = myPlot.Add.ScatterLine(xs, ys);
poly.FillY = true;

// colors are placed at specific positions on the Y axis
poly.AxisGradientDirection = AxisGradientDirection.Vertical;
poly.ColorPositions.Add(new(Colors.Red, -1));
poly.ColorPositions.Add(new(Colors.Blue, 0));
poly.ColorPositions.Add(new(Colors.Orange, .5));
poly.ColorPositions.Add(new(Colors.Magenta, 1));

myPlot.SavePng("demo.png", 400, 300);
{{< /recipe-sp5 >}}

<div class='my-5 text-center'>This recipe is one of many in the <a href='/cookbook/5/Scatter'>Scatter Plot</a> category</div>


