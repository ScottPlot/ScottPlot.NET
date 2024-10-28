---
Title: Contour Plot - ScottPlot 5.0 Cookbook
Description: A contour plot is a graphical representation that shows the three-dimensional surface of a function on a two-dimensional plane by connecting points of equal value with contour lines
URL: /cookbook/5.0/Contour/
BreadcrumbNames: ["ScottPlot 5.0 Cookbook", "Contour Plot"]
BreadcrumbUrls: ["/cookbook/5.0/", "/cookbook/5.0/Contour"]
Date: 2024-10-28
Version: ScottPlot 5.0.41
Version: ScottPlot 5.0.41
SearchUrl: "/cookbook/5.0/search/"
ShowEditLink: false
---

# Contour Plot


<h2><a href='/cookbook/5.0/Contour/ContourGrid'>Rectangular Contour Plot</a></h2>

A rectangular contour plot with evenly spaced points can be created from a 2D array of 3D points.

[![](/cookbook/5.0/images/ContourGrid.png?241027220842)](/cookbook/5.0/images/ContourGrid.png?241027220842)

{{< recipe-sp5 >}}

```cs
ScottPlot.Plot myPlot = new();

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

```

{{< /recipe-sp5 >}}

<hr class='my-5 invisible'>


<h2><a href='/cookbook/5.0/Contour/IrregularContour'>Irregular Contour Plot</a></h2>

A contour plot can be created from a collection of 3D data points placed arbitrarily in X/Y plane.

[![](/cookbook/5.0/images/IrregularContour.png?241027220842)](/cookbook/5.0/images/IrregularContour.png?241027220842)

{{< recipe-sp5 >}}

```cs
ScottPlot.Plot myPlot = new();

// generate irregularly spaced X/Y/Z data points
Coordinates3d[] cs = new Coordinates3d[1000];
for (int i = 0; i < cs.Length; i++)
{
    double x = Generate.RandomNumber(0, Math.PI * 2);
    double y = Generate.RandomNumber(0, Math.PI * 2);
    double z = Math.Sin(x) + Math.Cos(y);
    cs[i] = new(x, y, z);
}

// place markers at each data point
double minZ = cs.Select(x => x.Z).Min();
double maxZ = cs.Select(x => x.Z).Max();
double spanZ = maxZ - minZ;
IColormap cmap = new ScottPlot.Colormaps.MellowRainbow();
for (int i = 0; i < cs.Length; i++)
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

```

{{< /recipe-sp5 >}}

<hr class='my-5 invisible'>


<h2><a href='/cookbook/5.0/Contour/ContourHeatmap'>Contour Lines with Heatmap</a></h2>

Contour lines may be placed on top of heatmaps.

[![](/cookbook/5.0/images/ContourHeatmap.png?241027220842)](/cookbook/5.0/images/ContourHeatmap.png?241027220842)

{{< recipe-sp5 >}}

```cs
ScottPlot.Plot myPlot = new();

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

```

{{< /recipe-sp5 >}}

<hr class='my-5 invisible'>


<h2><a href='/cookbook/5.0/Contour/ContourColormap'>Contour Lines with Colormap</a></h2>

If a colormap is provided it will be used to color each line in the colormap according to its value.

[![](/cookbook/5.0/images/ContourColormap.png?241027220842)](/cookbook/5.0/images/ContourColormap.png?241027220842)

{{< recipe-sp5 >}}

```cs
ScottPlot.Plot myPlot = new();

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

```

{{< /recipe-sp5 >}}

<hr class='my-5 invisible'>

