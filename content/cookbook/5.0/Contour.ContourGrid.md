---
Title: Rectangular Contour Plot - ScottPlot 5.0 Cookbook
Description: A rectangular contour plot with evenly spaced points can be created from a 2D array of 3D points.
URL: /cookbook/5.0/Contour/ContourGrid/
BreadcrumbNames: ["ScottPlot 5.0 Cookbook", "Contour Plot", "Rectangular Contour Plot"]
BreadcrumbUrls: ["/cookbook/5.0/", "/cookbook/5.0/Contour", "/cookbook/5.0/Contour/ContourGrid"]
Date: 2024-10-30
Version: ScottPlot 5.0.42
Version: ScottPlot 5.0.42
SearchUrl: "/cookbook/5.0/search/"
ShowEditLink: false
---


<h2 style='border-bottom: 0;'><a href='/cookbook/5.0/Contour/ContourGrid'>Rectangular Contour Plot</a></h2>

<div class="d-flex mb-2">
<a class="btn btn-sm btn-primary me-1" href="/cookbook/5.0/Contour/ContourGrid">Recipe Permalink</a>
<a class="btn btn-sm btn-success me-1" href="/cookbook/5.0/Contour">Category: Contour Plot</a>
</div>

A rectangular contour plot with evenly spaced points can be created from a 2D array of 3D points.

[![](/cookbook/5.0/images/ContourGrid.png?241029205813)](/cookbook/5.0/images/ContourGrid.png?241029205813)

{{< recipe-sp5 >}}ScottPlot.Plot myPlot = new();

Coordinates3d[,] cs = new Coordinates3d[50, 50];
for (int y = 0; y < cs.GetLength(0); y++)
{
    for (int x = 0; x < cs.GetLength(1); x++)
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

<hr class='my-5 invisible'>


