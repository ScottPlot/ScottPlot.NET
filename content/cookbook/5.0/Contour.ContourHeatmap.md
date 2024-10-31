---
Title: Contour Lines with Heatmap - ScottPlot 5.0 Cookbook
Description: Contour lines may be placed on top of heatmaps.
URL: /cookbook/5.0/Contour/ContourHeatmap/
BreadcrumbNames: ["ScottPlot 5.0 Cookbook", "Contour Plot", "Contour Lines with Heatmap"]
BreadcrumbUrls: ["/cookbook/5.0/", "/cookbook/5.0/Contour", "/cookbook/5.0/Contour/ContourHeatmap"]
Date: 2024-10-31
Version: ScottPlot 5.0.42
Version: ScottPlot 5.0.42
SearchUrl: "/cookbook/5.0/search/"
ShowEditLink: false
---


<h2 style='border-bottom: 0;'><a href='/cookbook/5.0/Contour/ContourHeatmap'>Contour Lines with Heatmap</a></h2>

<div class="d-flex mb-2">
<a class="btn btn-sm btn-primary me-1" href="/cookbook/5.0/Contour/ContourHeatmap">Recipe Permalink</a>
<a class="btn btn-sm btn-success me-1" href="/cookbook/5.0/Contour">Category: Contour Plot</a>
</div>

Contour lines may be placed on top of heatmaps.

[![](/cookbook/5.0/images/ContourHeatmap.png?241031194635)](/cookbook/5.0/images/ContourHeatmap.png?241031194635)

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

var heatmap = myPlot.Add.Heatmap(cs);
heatmap.FlipVertically = true;
heatmap.Colormap = new ScottPlot.Colormaps.MellowRainbow();

var contour = myPlot.Add.ContourLines(cs);
contour.LabelStyle.Bold = true;
contour.LinePattern = LinePattern.DenselyDashed;
contour.LineColor = Colors.Black.WithAlpha(.5);

myPlot.Axes.TightMargins();
myPlot.HideGrid();

myPlot.SavePng("demo.png", 400, 300);
{{< /recipe-sp5 >}}

<hr class='my-5 invisible'>


