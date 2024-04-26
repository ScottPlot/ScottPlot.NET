---
Title: Heatmap - ScottPlot 5.0 Cookbook
Description: Heatmaps display values from 2D data as an image with cells of different intensities
URL: /cookbook/5.0/Heatmap/
BreadcrumbNames: ["ScottPlot 5.0 Cookbook", "Heatmap"]
BreadcrumbUrls: ["/cookbook/5.0/", "/cookbook/5.0/Heatmap"]
Date: 2024-04-26
Version: ScottPlot 5.0.29
Version: ScottPlot 5.0.29
SearchUrl: "/cookbook/5.0/search/"
ShowEditLink: false
---

# Heatmap


<h2><a href='/cookbook/5.0/Heatmap/HeatmapQuickstart'>Heatmap Quickstart</a></h2>

Heatmaps can be created from 2D arrays

[![](/cookbook/5.0/images/HeatmapQuickstart.png?240426090552)](/cookbook/5.0/images/HeatmapQuickstart.png?240426090552)

{{< code-sp5 >}}

```cs
ScottPlot.Plot myPlot = new();

double[,] data = SampleData.MonaLisa();
myPlot.Add.Heatmap(data);

myPlot.SavePng("demo.png", 400, 300);

```

{{< /code-sp5 >}}

<hr class='my-5 invisible'>


<h2><a href='/cookbook/5.0/Heatmap/HeatmapInverted'>Inverted Heatmap</a></h2>

Heatmaps can be inverted by reversing the order of colors in the colormap

[![](/cookbook/5.0/images/HeatmapInverted.png?240426090552)](/cookbook/5.0/images/HeatmapInverted.png?240426090552)

{{< code-sp5 >}}

```cs
ScottPlot.Plot myPlot = new();

double[,] data = SampleData.MonaLisa();

var hm1 = myPlot.Add.Heatmap(data);
hm1.Colormap = new ScottPlot.Colormaps.Viridis();
hm1.Position = new(0, 65, 0, 100);

var hm2 = myPlot.Add.Heatmap(data);
hm2.Colormap = new ScottPlot.Colormaps.Viridis().Reversed();
hm2.Position = new(100, 165, 0, 100);

myPlot.SavePng("demo.png", 400, 300);

```

{{< /code-sp5 >}}

<hr class='my-5 invisible'>


<h2><a href='/cookbook/5.0/Heatmap/HeatmapColormap'>Heatmap with custom Colormap</a></h2>

A heatmap's Colormap is the logic used to convert from cell value to cell color and they can set by the user. ScottPlot comes with many common colormaps, but users may implement IColormap and apply their own. A colorbar can be added to indicate which colors map to which values.

[![](/cookbook/5.0/images/HeatmapColormap.png?240426090552)](/cookbook/5.0/images/HeatmapColormap.png?240426090552)

{{< code-sp5 >}}

```cs
ScottPlot.Plot myPlot = new();

double[,] data = SampleData.MonaLisa();

var hm1 = myPlot.Add.Heatmap(data);
hm1.Colormap = new ScottPlot.Colormaps.Turbo();

myPlot.Add.ColorBar(hm1);

myPlot.SavePng("demo.png", 400, 300);

```

{{< /code-sp5 >}}

<hr class='my-5 invisible'>


<h2><a href='/cookbook/5.0/Heatmap/HeatmapMultipleColorbar'>Multiple Colorbars</a></h2>

Multiple colorbars may be added to plots.

[![](/cookbook/5.0/images/HeatmapMultipleColorbar.png?240426090552)](/cookbook/5.0/images/HeatmapMultipleColorbar.png?240426090552)

{{< code-sp5 >}}

```cs
ScottPlot.Plot myPlot = new();

double[,] data = SampleData.MonaLisa();

var hm1 = myPlot.Add.Heatmap(data);
hm1.Extent = new(0, 1, 0, 1);
hm1.Colormap = new ScottPlot.Colormaps.Turbo();
myPlot.Add.ColorBar(hm1);

var hm2 = myPlot.Add.Heatmap(data);
hm2.Extent = new(1.5, 2.5, 0, 1);
hm2.Colormap = new ScottPlot.Colormaps.Viridis();
myPlot.Add.ColorBar(hm2);

myPlot.SavePng("demo.png", 400, 300);

```

{{< /code-sp5 >}}

<hr class='my-5 invisible'>


<h2><a href='/cookbook/5.0/Heatmap/ColorbarTitle'>Colorbar Title</a></h2>

A colorbar displays a colormap on an edge of the plot, and it has an optional label which can be customized to display a title.

[![](/cookbook/5.0/images/ColorbarTitle.png?240426090552)](/cookbook/5.0/images/ColorbarTitle.png?240426090552)

{{< code-sp5 >}}

```cs
ScottPlot.Plot myPlot = new();

double[,] data = SampleData.MonaLisa();

var hm = myPlot.Add.Heatmap(data);
hm.Colormap = new ScottPlot.Colormaps.Turbo();

var cb = myPlot.Add.ColorBar(hm);
cb.Label = "Intensity";
cb.LabelStyle.FontSize = 24;

myPlot.SavePng("demo.png", 400, 300);

```

{{< /code-sp5 >}}

<hr class='my-5 invisible'>


<h2><a href='/cookbook/5.0/Heatmap/HeatmapFlip'>Flipped Heatmap</a></h2>

Heatmaps can be flipped horizontally and/or vertically

[![](/cookbook/5.0/images/HeatmapFlip.png?240426090552)](/cookbook/5.0/images/HeatmapFlip.png?240426090552)

{{< code-sp5 >}}

```cs
ScottPlot.Plot myPlot = new();

double[,] data = SampleData.MonaLisa();

myPlot.Add.Text("default", 0, 1.5);
var hm1 = myPlot.Add.Heatmap(data);
hm1.Position = new CoordinateRect(0, 1, 0, 1);

myPlot.Add.Text("flip X", 2, 1.5);
var hm2 = myPlot.Add.Heatmap(data);
hm2.Position = new CoordinateRect(2, 3, 0, 1);
hm2.FlipHorizontally = true;

myPlot.Add.Text("flip Y", 4, 1.5);
var hm3 = myPlot.Add.Heatmap(data);
hm3.Position = new CoordinateRect(4, 5, 0, 1);
hm3.FlipVertically = true;

myPlot.Add.Text("flip X&Y", 6, 1.5);
var hm4 = myPlot.Add.Heatmap(data);
hm4.Position = new CoordinateRect(6, 7, 0, 1);
hm4.FlipHorizontally = true;
hm4.FlipVertically = true;

myPlot.Axes.SetLimits(-.5, 7.5, -1, 2);

myPlot.SavePng("demo.png", 400, 300);

```

{{< /code-sp5 >}}

<hr class='my-5 invisible'>


<h2><a href='/cookbook/5.0/Heatmap/HeatmapSmooth'>Smooth Heatmap</a></h2>

Enable the `Smooth` property for anti-aliased rendering

[![](/cookbook/5.0/images/HeatmapSmooth.png?240426090552)](/cookbook/5.0/images/HeatmapSmooth.png?240426090552)

{{< code-sp5 >}}

```cs
ScottPlot.Plot myPlot = new();

double[,] data = SampleData.MonaLisa();

myPlot.Add.Text("Smooth = false", 0, 1.1);
var hm1 = myPlot.Add.Heatmap(data);
hm1.Position = new CoordinateRect(0, 1, 0, 1);

myPlot.Add.Text("Smooth = true", 1.1, 1.1);
var hm2 = myPlot.Add.Heatmap(data);
hm2.Position = new CoordinateRect(1.1, 2.1, 0, 1);
hm2.Smooth = true;

myPlot.SavePng("demo.png", 400, 300);

```

{{< /code-sp5 >}}

<hr class='my-5 invisible'>


<h2><a href='/cookbook/5.0/Heatmap/HeatmapTransparentCells'>Transparent Cells</a></h2>

Assign double.NaN to a heatmap cell to make it transparent.

[![](/cookbook/5.0/images/HeatmapTransparentCells.png?240426090552)](/cookbook/5.0/images/HeatmapTransparentCells.png?240426090552)

{{< code-sp5 >}}

```cs
ScottPlot.Plot myPlot = new();

// start with 2D data and set some cells to NaN
double[,] data = SampleData.MonaLisa();
for (int y = 20; y < 80; y++)
{
    for (int x = 20; x < 60; x++)
    {
        data[y, x] = double.NaN;
    }
}

// create a line chart
myPlot.Add.Signal(Generate.Sin());
myPlot.Add.Signal(Generate.Cos());

// plot the heatmap on top of the line chart
var hm1 = myPlot.Add.Heatmap(data);
hm1.Position = new(10, 35, -1.5, .5);

// the NaN transparency color can be customized
var hm2 = myPlot.Add.Heatmap(data);
hm2.Position = new(40, 55, -.5, .75);
hm2.NaNCellColor = Colors.Magenta.WithAlpha(.4);

myPlot.SavePng("demo.png", 400, 300);

```

{{< /code-sp5 >}}

<hr class='my-5 invisible'>


<h2><a href='/cookbook/5.0/Heatmap/HeatmapGlobalTransparency'>Global Transparency</a></h2>

The transparency of the entire heatmap can be adjusted.

[![](/cookbook/5.0/images/HeatmapGlobalTransparency.png?240426090552)](/cookbook/5.0/images/HeatmapGlobalTransparency.png?240426090552)

{{< code-sp5 >}}

```cs
ScottPlot.Plot myPlot = new();

double[,] data = SampleData.MonaLisa();

// create a line chart
myPlot.Add.Signal(Generate.Sin());
myPlot.Add.Signal(Generate.Cos());

// plot the heatmap on top of the line chart
var hm = myPlot.Add.Heatmap(data);
hm.Position = new(10, 35, -1.5, .5);
hm.Opacity = 0.5;

myPlot.SavePng("demo.png", 400, 300);

```

{{< /code-sp5 >}}

<hr class='my-5 invisible'>


<h2><a href='/cookbook/5.0/Heatmap/HeatmapAlphaMap'>Alpha Map</a></h2>

An alpha map (a 2d array of byte values) can be used to apply custom transparency to each cell of a heatmap.

[![](/cookbook/5.0/images/HeatmapAlphaMap.png?240426090552)](/cookbook/5.0/images/HeatmapAlphaMap.png?240426090552)

{{< code-sp5 >}}

```cs
ScottPlot.Plot myPlot = new();

// data values are translated to color based on the heatmap's colormap
double[,] data = SampleData.MonaLisa();

// an alpha map controls transparency of each cell
byte[,] alphaMap = new byte[data.GetLength(0), data.GetLength(1)];

// fill the alpha map with values from 0 (transparent) to 255 (opaque)
for (int y = 0; y < alphaMap.GetLength(0); y++)
{
    for (int x = 0; x < alphaMap.GetLength(1); x++)
    {
        double fractionAcross = (double)x / alphaMap.GetLength(1);
        alphaMap[y, x] = (byte)(fractionAcross * 255);
    }
}

// create a line chart
myPlot.Add.Signal(Generate.Sin());
myPlot.Add.Signal(Generate.Cos());

// plot the heatmap on top of the line chart
var hm = myPlot.Add.Heatmap(data);
hm.Position = new(10, 35, -1.5, .5);
hm.AlphaMap = alphaMap;

myPlot.SavePng("demo.png", 400, 300);

```

{{< /code-sp5 >}}

<hr class='my-5 invisible'>

