---
Title: Scatter Plot with Gradient Fill - ScottPlot 5 Cookbook
Description: The area beneath a scatter plot can be filled with a custom gradient of colors.
URL: /cookbook/5/Scatter/ScatterFillGradient/
BreadcrumbNames: ["ScottPlot 5 Cookbook", "Scatter Plot", "Scatter Plot with Gradient Fill"]
BreadcrumbUrls: ["/cookbook/5/", "/cookbook/5/Scatter", "/cookbook/5/Scatter/ScatterFillGradient"]
Date: 2026-03-29
Version: ScottPlot 5.1.58
Version: ScottPlot 5.1.58
SearchUrl: "/cookbook/5/search/"
ShowEditLink: false
---


<div class='d-flex align-items-center mt-5'>
<h1 class='me-2 text-dark my-0 border-0'>Scatter Plot with Gradient Fill</h1>
</div>

The area beneath a scatter plot can be filled with a custom gradient of colors.

[![](/cookbook/5/images/ScatterFillGradient.png?260329072039)](/cookbook/5/images/ScatterFillGradient.png?260329072039)

{{< recipe-sp5 sourceUrl="https://github.com/ScottPlot/ScottPlot/blob/main/src/ScottPlot5/ScottPlot5%20Cookbook/Recipes/PlotTypes/Scatter.cs" imageUrl="/cookbook/5/images/ScatterFillGradient.png?260329072039" >}}ScottPlot.Plot myPlot = new();

double[] xs = Generate.Consecutive(51);
double[] ys = Generate.Sin(51);

var poly = myPlot.Add.ScatterLine(xs, ys);
poly.FillY = true;

// colors are placed at specific positions on the X axis
poly.AxisGradientDirection = AxisGradientDirection.Horizontal;
poly.ColorPositions.Add(new(Colors.Red, 0));
poly.ColorPositions.Add(new(Colors.Orange, 10));
poly.ColorPositions.Add(new(Colors.Yellow, 20));
poly.ColorPositions.Add(new(Colors.Green, 30));
poly.ColorPositions.Add(new(Colors.Blue, 40));
poly.ColorPositions.Add(new(Colors.Violet, 50));

myPlot.SavePng("demo.png", 400, 300);
{{< /recipe-sp5 >}}

<div class='my-5 text-center'>This recipe is one of many in the <a href='/cookbook/5/Scatter'>Scatter Plot</a> category</div>


