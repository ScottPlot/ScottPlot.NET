---
Title: Irregular Contour Plot - ScottPlot 5.0 Cookbook
Description: A contour plot can be created from a collection of 3D data points placed arbitrarily in X/Y plane.
URL: /cookbook/5.0/Contour/IrregularContour/
BreadcrumbNames: ["ScottPlot 5.0 Cookbook", "Contour Plot", "Irregular Contour Plot"]
BreadcrumbUrls: ["/cookbook/5.0/", "/cookbook/5.0/Contour", "/cookbook/5.0/Contour/IrregularContour"]
Date: 2025-01-26
Version: ScottPlot 5.0.55
Version: ScottPlot 5.0.55
SearchUrl: "/cookbook/5.0/search/"
ShowEditLink: false
---


<div class='d-flex align-items-center mt-5'>
<h1 class='me-2 text-dark my-0 border-0'>Irregular Contour Plot</h1>
</div>

A contour plot can be created from a collection of 3D data points placed arbitrarily in X/Y plane.

[![](/cookbook/5.0/images/IrregularContour.png?250126165944)](/cookbook/5.0/images/IrregularContour.png?250126165944)

{{< recipe-sp5 sourceUrl="https://github.com/ScottPlot/ScottPlot/blob/main/src/ScottPlot5/ScottPlot5%20Cookbook/Recipes/PlotTypes/Contour.cs" imageUrl="/cookbook/5.0/images/IrregularContour.png?250126165944" >}}ScottPlot.Plot myPlot = new();

// generate irregularly spaced X/Y/Z data points
Coordinates3d[] cs = new Coordinates3d[1000];
for (int i = 0; i &lt; cs.Length; i++)
{
    double x = Generate.RandomNumber(0, Math.PI * 2);
    double y = Generate.RandomNumber(0, Math.PI * 2);
    double z = Math.Sin(x) + Math.Cos(y);
    cs[i] = new(x, y, z);
}

// place markers at each data point
double minZ = cs.Select(x =&gt; x.Z).Min();
double maxZ = cs.Select(x =&gt; x.Z).Max();
double spanZ = maxZ - minZ;
IColormap cmap = new ScottPlot.Colormaps.MellowRainbow();
for (int i = 0; i &lt; cs.Length; i++)
{
    double fraction = (cs[i].Z - minZ) / (spanZ);
    var marker = myPlot.Add.Marker(cs[i].X, cs[i].Y);
    marker.Color = cmap.GetColor(fraction).WithAlpha(.8);
    marker.Size = 5;
}

// show contour lines
var contour = myPlot.Add.ContourLines(cs);

// style the plot
myPlot.Axes.TightMargins();
myPlot.HideGrid();

myPlot.SavePng("demo.png", 400, 300);
{{< /recipe-sp5 >}}

<div class='my-5 text-center'>This recipe is one of many in the <a href='/cookbook/5.0/Contour'>Contour Plot</a> category</div>


