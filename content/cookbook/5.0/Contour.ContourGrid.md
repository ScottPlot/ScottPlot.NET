---
Title: Rectangular Contour Plot - ScottPlot 5.0 Cookbook
Description: A rectangular contour plot with evenly spaced points can be created from a 2D array of 3D points.
URL: /cookbook/5.0/Contour/ContourGrid/
BreadcrumbNames: ["ScottPlot 5.0 Cookbook", "Contour Plot", "Rectangular Contour Plot"]
BreadcrumbUrls: ["/cookbook/5.0/", "/cookbook/5.0/Contour", "/cookbook/5.0/Contour/ContourGrid"]
Date: 2024-11-06
Version: ScottPlot 5.0.43
Version: ScottPlot 5.0.43
SearchUrl: "/cookbook/5.0/search/"
ShowEditLink: false
---


<div class='d-flex align-items-center mt-5'>
<h1 class='me-2 text-dark my-0 border-0'>Rectangular Contour Plot</h1>
</div>

A rectangular contour plot with evenly spaced points can be created from a 2D array of 3D points.

[![](/cookbook/5.0/images/ContourGrid.png?241105214550)](/cookbook/5.0/images/ContourGrid.png?241105214550)

{{< recipe-sp5 sourceUrl="https://github.com/ScottPlot/ScottPlot/blob/main/src/ScottPlot5/ScottPlot5%20Cookbook/Recipes/PlotTypes/Contour.cs" imageUrl="/cookbook/5.0/images/ContourGrid.png?241105214550" >}}ScottPlot.Plot myPlot = new();

Coordinates3d[,] cs = new Coordinates3d[50, 50];
for (int y = 0; y &lt; cs.GetLength(0); y++)
{
    for (int x = 0; x &lt; cs.GetLength(1); x++)
    {
        double z = Math.Sin(x * .1) + Math.Cos(y * .1);
        cs[y, x] = new(x, y, z);
    }
}

var contour = myPlot.Add.ContourLines(cs);
contour.LineColor = Colors.Black.WithAlpha(.5);
contour.LinePattern = LinePattern.Dotted;

myPlot.Axes.TightMargins();
myPlot.HideGrid();

myPlot.SavePng("demo.png", 400, 300);
{{< /recipe-sp5 >}}

<div class='my-5 text-center'>This recipe is one of many in the <a href='/cookbook/5.0/Contour'>Contour Plot</a> category</div>


