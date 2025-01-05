---
Title: Contour Lines with Heatmap - ScottPlot 5.0 Cookbook
Description: Contour lines may be placed on top of heatmaps.
URL: /cookbook/5.0/Contour/ContourHeatmap/
BreadcrumbNames: ["ScottPlot 5.0 Cookbook", "Contour Plot", "Contour Lines with Heatmap"]
BreadcrumbUrls: ["/cookbook/5.0/", "/cookbook/5.0/Contour", "/cookbook/5.0/Contour/ContourHeatmap"]
Date: 2025-01-05
Version: ScottPlot 5.0.48
Version: ScottPlot 5.0.48
SearchUrl: "/cookbook/5.0/search/"
ShowEditLink: false
---


<div class='d-flex align-items-center mt-5'>
<h1 class='me-2 text-dark my-0 border-0'>Contour Lines with Heatmap</h1>
</div>

Contour lines may be placed on top of heatmaps.

[![](/cookbook/5.0/images/ContourHeatmap.png?250105183901)](/cookbook/5.0/images/ContourHeatmap.png?250105183901)

{{< recipe-sp5 sourceUrl="https://github.com/ScottPlot/ScottPlot/blob/main/src/ScottPlot5/ScottPlot5%20Cookbook/Recipes/PlotTypes/Contour.cs" imageUrl="/cookbook/5.0/images/ContourHeatmap.png?250105183901" >}}ScottPlot.Plot myPlot = new();

Coordinates3d[,] cs = new Coordinates3d[50, 50];
for (int y = 0; y &lt; cs.GetLength(0); y++)
{
    for (int x = 0; x &lt; cs.GetLength(1); x++)
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

<div class='my-5 text-center'>This recipe is one of many in the <a href='/cookbook/5.0/Contour'>Contour Plot</a> category</div>


