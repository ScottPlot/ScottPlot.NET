---
Title: Contour Lines with Colormap - ScottPlot 5.0 Cookbook
Description: If a colormap is provided it will be used to color each line in the colormap according to its value.
URL: /cookbook/5.0/Contour/ContourColormap/
BreadcrumbNames: ["ScottPlot 5.0 Cookbook", "Contour Plot", "Contour Lines with Colormap"]
BreadcrumbUrls: ["/cookbook/5.0/", "/cookbook/5.0/Contour", "/cookbook/5.0/Contour/ContourColormap"]
Date: 2024-10-30
Version: ScottPlot 5.0.42
Version: ScottPlot 5.0.42
SearchUrl: "/cookbook/5.0/search/"
ShowEditLink: false
---


<h2 style='border-bottom: 0;'><a href='/cookbook/5.0/Contour/ContourColormap'>Contour Lines with Colormap</a></h2>

<div class="d-flex mb-2">
<a class="btn btn-sm btn-primary me-1" href="/cookbook/5.0/Contour/ContourColormap">Recipe Permalink</a>
<a class="btn btn-sm btn-success me-1" href="/cookbook/5.0/Contour">Category: Contour Plot</a>
</div>

If a colormap is provided it will be used to color each line in the colormap according to its value.

[![](/cookbook/5.0/images/ContourColormap.png?241029205813)](/cookbook/5.0/images/ContourColormap.png?241029205813)

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

var cl = myPlot.Add.ContourLines(cs, count: 25);
cl.Colormap = new ScottPlot.Colormaps.MellowRainbow();
cl.LineWidth = 3;
cl.LabelStyle.IsVisible = false;

myPlot.Axes.TightMargins();
myPlot.HideGrid();

myPlot.SavePng("demo.png", 400, 300);
{{< /recipe-sp5 >}}

<hr class='my-5 invisible'>


