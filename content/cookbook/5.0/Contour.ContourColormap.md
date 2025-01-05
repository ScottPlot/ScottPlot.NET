---
Title: Contour Lines with Colormap - ScottPlot 5.0 Cookbook
Description: If a colormap is provided it will be used to color each line in the colormap according to its value.
URL: /cookbook/5.0/Contour/ContourColormap/
BreadcrumbNames: ["ScottPlot 5.0 Cookbook", "Contour Plot", "Contour Lines with Colormap"]
BreadcrumbUrls: ["/cookbook/5.0/", "/cookbook/5.0/Contour", "/cookbook/5.0/Contour/ContourColormap"]
Date: 2025-01-05
Version: ScottPlot 5.0.48
Version: ScottPlot 5.0.48
SearchUrl: "/cookbook/5.0/search/"
ShowEditLink: false
---


<div class='d-flex align-items-center mt-5'>
<h1 class='me-2 text-dark my-0 border-0'>Contour Lines with Colormap</h1>
</div>

If a colormap is provided it will be used to color each line in the colormap according to its value.

[![](/cookbook/5.0/images/ContourColormap.png?250105183901)](/cookbook/5.0/images/ContourColormap.png?250105183901)

{{< recipe-sp5 sourceUrl="https://github.com/ScottPlot/ScottPlot/blob/main/src/ScottPlot5/ScottPlot5%20Cookbook/Recipes/PlotTypes/Contour.cs" imageUrl="/cookbook/5.0/images/ContourColormap.png?250105183901" >}}ScottPlot.Plot myPlot = new();

Coordinates3d[,] cs = new Coordinates3d[50, 50];
for (int y = 0; y &lt; cs.GetLength(0); y++)
{
    for (int x = 0; x &lt; cs.GetLength(1); x++)
    {
        double z = Math.Sin(x * .1) + Math.Cos(y * .1);
        cs[y, x] = new(x, y, z);
    }
}

var cl = myPlot.Add.ContourLines(cs, count: 25);
cl.Colormap = new ScottPlot.Colormaps.MellowRainbow();
cl.LineWidth = 3;
cl.LabelStyle.IsVisible = false;

myPlot.Axes.TightMargins();
myPlot.HideGrid();

myPlot.SavePng("demo.png", 400, 300);
{{< /recipe-sp5 >}}

<div class='my-5 text-center'>This recipe is one of many in the <a href='/cookbook/5.0/Contour'>Contour Plot</a> category</div>


