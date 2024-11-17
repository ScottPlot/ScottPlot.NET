---
Title: Contour Plot - ScottPlot 5.0 Cookbook
Description: A contour plot is a graphical representation that shows the three-dimensional surface of a function on a two-dimensional plane by connecting points of equal value with contour lines
URL: /cookbook/5.0/Contour/
BreadcrumbNames: ["ScottPlot 5.0 Cookbook", "Contour Plot"]
BreadcrumbUrls: ["/cookbook/5.0/", "/cookbook/5.0/Contour"]
Date: 2024-11-17
Version: ScottPlot 5.0.46
Version: ScottPlot 5.0.46
SearchUrl: "/cookbook/5.0/search/"
ShowEditLink: false
---

<h1>Contour Plot</h1>


<div class='d-flex align-items-center mt-5'>
<h1 class='me-2 text-dark my-0 border-0'>Rectangular Contour Plot</h1>
<a href='/cookbook/5.0/Contour/ContourGrid' target='_blank'>
<img src='/images/icons/new-window.svg' style='height: 2rem;' class='new-window-icon'>
</a>
</div>

A rectangular contour plot with evenly spaced points can be created from a 2D array of 3D points.

[![](/cookbook/5.0/images/ContourGrid.png?241117162641)](/cookbook/5.0/images/ContourGrid.png?241117162641)

{{< recipe-sp5 sourceUrl="https://github.com/ScottPlot/ScottPlot/blob/main/src/ScottPlot5/ScottPlot5%20Cookbook/Recipes/PlotTypes/Contour.cs" imageUrl="/cookbook/5.0/images/ContourGrid.png?241117162641" >}}ScottPlot.Plot myPlot = new();

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

<hr class='my-5 invisible'>



<div class='d-flex align-items-center mt-5'>
<h1 class='me-2 text-dark my-0 border-0'>Irregular Contour Plot</h1>
<a href='/cookbook/5.0/Contour/IrregularContour' target='_blank'>
<img src='/images/icons/new-window.svg' style='height: 2rem;' class='new-window-icon'>
</a>
</div>

A contour plot can be created from a collection of 3D data points placed arbitrarily in X/Y plane.

[![](/cookbook/5.0/images/IrregularContour.png?241117162641)](/cookbook/5.0/images/IrregularContour.png?241117162641)

{{< recipe-sp5 sourceUrl="https://github.com/ScottPlot/ScottPlot/blob/main/src/ScottPlot5/ScottPlot5%20Cookbook/Recipes/PlotTypes/Contour.cs" imageUrl="/cookbook/5.0/images/IrregularContour.png?241117162641" >}}ScottPlot.Plot myPlot = new();

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

<hr class='my-5 invisible'>



<div class='d-flex align-items-center mt-5'>
<h1 class='me-2 text-dark my-0 border-0'>Contour Lines with Heatmap</h1>
<a href='/cookbook/5.0/Contour/ContourHeatmap' target='_blank'>
<img src='/images/icons/new-window.svg' style='height: 2rem;' class='new-window-icon'>
</a>
</div>

Contour lines may be placed on top of heatmaps.

[![](/cookbook/5.0/images/ContourHeatmap.png?241117162641)](/cookbook/5.0/images/ContourHeatmap.png?241117162641)

{{< recipe-sp5 sourceUrl="https://github.com/ScottPlot/ScottPlot/blob/main/src/ScottPlot5/ScottPlot5%20Cookbook/Recipes/PlotTypes/Contour.cs" imageUrl="/cookbook/5.0/images/ContourHeatmap.png?241117162641" >}}ScottPlot.Plot myPlot = new();

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

<hr class='my-5 invisible'>



<div class='d-flex align-items-center mt-5'>
<h1 class='me-2 text-dark my-0 border-0'>Contour Lines with Colormap</h1>
<a href='/cookbook/5.0/Contour/ContourColormap' target='_blank'>
<img src='/images/icons/new-window.svg' style='height: 2rem;' class='new-window-icon'>
</a>
</div>

If a colormap is provided it will be used to color each line in the colormap according to its value.

[![](/cookbook/5.0/images/ContourColormap.png?241117162641)](/cookbook/5.0/images/ContourColormap.png?241117162641)

{{< recipe-sp5 sourceUrl="https://github.com/ScottPlot/ScottPlot/blob/main/src/ScottPlot5/ScottPlot5%20Cookbook/Recipes/PlotTypes/Contour.cs" imageUrl="/cookbook/5.0/images/ContourColormap.png?241117162641" >}}ScottPlot.Plot myPlot = new();

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

<hr class='my-5 invisible'>


