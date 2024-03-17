---
Title: Heatmap - ScottPlot 5.0 Cookbook
Description: Heatmaps display values from 2D data as an image with cells of different intensities
URL: /cookbook/5.0/Heatmap/
BreadcrumbNames: ["ScottPlot 5.0 Cookbook", "Heatmap"]
BreadcrumbUrls: ["/cookbook/5.0/", "/cookbook/5.0/Heatmap"]
Date: 2024-03-17
Version: ScottPlot 5.0.22
Version: ScottPlot 5.0.22
SearchUrl: "/cookbook/5.0/search/"
ShowEditLink: false
---

# Heatmap


<h2><a href='/cookbook/5.0/Heatmap/HeatmapQuickstart'>Heatmap Quickstart</a></h2>

Heatmaps can be created from 2D arrays

[![](/cookbook/5.0/images/HeatmapQuickstart.png?240316204900)](/cookbook/5.0/images/HeatmapQuickstart.png?240316204900)

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

[![](/cookbook/5.0/images/HeatmapInverted.png?240316204900)](/cookbook/5.0/images/HeatmapInverted.png?240316204900)

{{< code-sp5 >}}

```cs
ScottPlot.Plot myPlot = new();

double[,] data = SampleData.MonaLisa();

var hm1 = myPlot.Add.Heatmap(data);
hm1.Colormap = new ScottPlot.Colormaps.Viridis();
hm1.Extent = new(0, 65, 0, 100);

var hm2 = myPlot.Add.Heatmap(data);
hm2.Colormap = new ScottPlot.Colormaps.Viridis().Reversed();
hm2.Extent = new(100, 165, 0, 100);

myPlot.SavePng("demo.png", 400, 300);

```

{{< /code-sp5 >}}

<hr class='my-5 invisible'>


<h2><a href='/cookbook/5.0/Heatmap/HeatmapColormap'>Heatmap with custom Colormap</a></h2>

A heatmap's Colormap is the logic used to convert from cell value to cell color and they can set by the user. ScottPlot comes with many common colormaps, but users may implement IColormap and apply their own. A colorbar can be added to indicate which colors map to which values.

[![](/cookbook/5.0/images/HeatmapColormap.png?240316204900)](/cookbook/5.0/images/HeatmapColormap.png?240316204900)

{{< code-sp5 >}}

```cs
ScottPlot.Plot myPlot = new();

double[,] data = SampleData.MonaLisa();

var hm1 = myPlot.Add.Heatmap(data);
hm1.Colormap = new ScottPlot.Colormaps.Turbo();

// TODO: this isn't working quite right yet...
myPlot.Add.ColorBar(hm1);

myPlot.SavePng("demo.png", 400, 300);

```

{{< /code-sp5 >}}

<hr class='my-5 invisible'>


<h2><a href='/cookbook/5.0/Heatmap/HeatmapFlip'>Flipped Heatmap</a></h2>

Heatmaps can be flipped horizontally and/or vertically

[![](/cookbook/5.0/images/HeatmapFlip.png?240316204900)](/cookbook/5.0/images/HeatmapFlip.png?240316204900)

{{< code-sp5 >}}

```cs
ScottPlot.Plot myPlot = new();

double[,] data = SampleData.MonaLisa();

myPlot.Add.Text("default", 0, 1.5);
var hm1 = myPlot.Add.Heatmap(data);
hm1.Extent = new CoordinateRect(0, 1, 0, 1);

myPlot.Add.Text("flip X", 2, 1.5);
var hm2 = myPlot.Add.Heatmap(data);
hm2.Extent = new CoordinateRect(2, 3, 0, 1);
hm2.FlipHorizontally = true;

myPlot.Add.Text("flip Y", 4, 1.5);
var hm3 = myPlot.Add.Heatmap(data);
hm3.Extent = new CoordinateRect(4, 5, 0, 1);
hm3.FlipVertically = true;

myPlot.Add.Text("flip X&Y", 6, 1.5);
var hm4 = myPlot.Add.Heatmap(data);
hm4.Extent = new CoordinateRect(6, 7, 0, 1);
hm4.FlipHorizontally = true;
hm4.FlipVertically = true;

myPlot.Axes.SetLimits(-.5, 7.5, -1, 2);

myPlot.SavePng("demo.png", 400, 300);

```

{{< /code-sp5 >}}

<hr class='my-5 invisible'>


<h2><a href='/cookbook/5.0/Heatmap/HeatmapSmooth'>Smooth Heatmap</a></h2>

Enable the `Smooth` property for anti-aliased rendering

[![](/cookbook/5.0/images/HeatmapSmooth.png?240316204900)](/cookbook/5.0/images/HeatmapSmooth.png?240316204900)

{{< code-sp5 >}}

```cs
ScottPlot.Plot myPlot = new();

double[,] data = SampleData.MonaLisa();

myPlot.Add.Text("Smooth = false", 0, 1.1);
var hm1 = myPlot.Add.Heatmap(data);
hm1.Extent = new CoordinateRect(0, 1, 0, 1);

myPlot.Add.Text("Smooth = true", 1.1, 1.1);
var hm2 = myPlot.Add.Heatmap(data);
hm2.Extent = new CoordinateRect(1.1, 2.1, 0, 1);
hm2.Smooth = true;

myPlot.SavePng("demo.png", 400, 300);

```

{{< /code-sp5 >}}

<hr class='my-5 invisible'>

