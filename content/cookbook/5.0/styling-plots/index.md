---
title: Styling Plots - ScottPlot 5.0 Cookbook
description: How to customize plots
url: /cookbook/5.0/styling-plots/
date: 2/9/2023 11:56:12 PM
---

This page is part of the [ScottPlot 5.0 Cookbook](../)


<div class='alert alert-warning' role='alert'><h4 class='alert-heading py-0 my-0'>⚠️ ScottPlot 5.0.1-beta is a preview package</h4><hr /><p class='mb-0'><span class='fw-semibold'>This page describes a beta release of ScottPlot.</span> It is available on NuGet as a preview package, but its API is not stable and it is not recommended for production use. See the <a href='https://scottplot.net/versions/'>ScottPlot Versions</a> page for more information. </p></div>



## Style Helper Functions

Plots contain many objects which can be customized individually by assigining to their public properties, but helper methods exist in the Plot's Style object that make it easier to customzie many items at once using a simpler API.

[![](style-helper-functions.png)](style-helper-functions.png)

```cs
ScottPlot.Plot myPlot = new();

myPlot.Add.Signal(Generate.Sin(51));
myPlot.Add.Signal(Generate.Cos(51));

// visible items have public properties that can be customized
myPlot.XAxis.Label.Text = "Horizontal Axis";
myPlot.YAxis.Label.Text = "Vertical Axis";
myPlot.Title.Label.Text = "Plot Title";

// the Style object contains helper methods to easily style many items at once
myPlot.Style.Background(figure: Color.FromHex("#07263b"), data: Color.FromHex("#0b3049"));
myPlot.Style.ColorAxes(Color.FromHex("#a0acb5"));
myPlot.Style.ColorGrids(Color.FromHex("#0e3d54"));

myPlot.SavePng("style-helper-functions.png");
```


## Axis Customization

Axis labels, tick marks, and frame can all be customized.

[![](axis-customization.png)](axis-customization.png)

```cs
ScottPlot.Plot myPlot = new();

myPlot.Add.Signal(Generate.Sin(51));
myPlot.Add.Signal(Generate.Cos(51));

myPlot.Title.Label.Text = "Plot Title";
myPlot.Title.Label.Font.Color = Colors.RebeccaPurple;
myPlot.Title.Label.Font.Size = 32;
myPlot.Title.Label.Font.Name = FontService.SerifFontName;
myPlot.Title.Label.Rotation = -5;
myPlot.Title.Label.Font.Bold = false;

myPlot.YAxis.Label.Text = "Vertical Axis";
myPlot.YAxis.Label.Font.Color = Colors.Magenta;
myPlot.YAxis.Label.Font.Italic = true;

myPlot.XAxis.Label.Text = "Horizontal Axis";
myPlot.XAxis.Label.Font.Bold = false;
myPlot.XAxis.Label.Font.Name = FontService.MonospaceFontName;

myPlot.XAxis.MajorTickLength = 10;
myPlot.XAxis.MajorTickWidth = 3;
myPlot.XAxis.MajorTickColor = Colors.Magenta;
myPlot.XAxis.MinorTickLength = 5;
myPlot.XAxis.MinorTickWidth = 0.5f;
myPlot.XAxis.MinorTickColor = Colors.Green;
myPlot.XAxis.FrameLineStyle.Color = Colors.LightBlue;

myPlot.SavePng("axis-customization.png");
```


## Grid Customization

Grid lines can be customized. Custom grid systems can be created to give developers full control of grid rendering, but the default grid can be interacted with to customize its appearance.

[![](grid-customization.png)](grid-customization.png)

```cs
ScottPlot.Plot myPlot = new();

myPlot.Add.Signal(Generate.Sin(51));
myPlot.Add.Signal(Generate.Cos(51));

ScottPlot.Grids.DefaultGrid grid = myPlot.GetDefaultGrid();

grid.MajorLineStyle.Color = Colors.Green.WithOpacity(.5);
grid.MinorLineStyle.Color = Colors.Green.WithOpacity(.1);
grid.MinorLineStyle.Width = 1;

myPlot.SavePng("grid-customization.png");
```


## Grid Above Data

Grid lines are typically drawn beneath data, but grids can be configured to render on top of plottables too.

[![](grid-above-data.png)](grid-above-data.png)

```cs
ScottPlot.Plot myPlot = new();

var sig = myPlot.Add.Signal(Generate.Sin(51));
sig.LineStyle.Width = 10;

ScottPlot.Grids.DefaultGrid grid = myPlot.GetDefaultGrid();
grid.MajorLineStyle.Width = 3;
grid.MajorLineStyle.Color = Colors.WhiteSmoke;
grid.IsBeneathPlottables = false;

myPlot.SavePng("grid-above-data.png");
```


## Palettes

A palette is a set of colors, and the Plot's palette defines the default colors to use when adding new plottables. ScottPlot comes with many standard palettes, but users may also create their own.

[![](palettes.png)](palettes.png)

```cs
ScottPlot.Plot myPlot = new();

IPalette palette = new ScottPlot.Palettes.Nord();
myPlot.Palette = palette;

for (int i = 0; i < 5; i++)
{
    double[] data = Generate.Sin(100, phase: -i / 20.0f);
    var sig = myPlot.Add.Signal(data);
    sig.LineStyle.Width = 3;
}

myPlot.SavePng("palettes.png");
```


## Markers

Many plot types have a MarkerStyle which can be customized.

[![](markers.png)](markers.png)

```cs
ScottPlot.Plot myPlot = new();

int count = 21;
double[] xs = Generate.Consecutive(count);
double[] ys = Generate.Sin(count);

MarkerShape[] markerShapes = Enum.GetValues<MarkerShape>().ToArray();

for (int i = 0; i < markerShapes.Length; i++)
{
    double[] data = ys.Select(y => markerShapes.Length - y + i).ToArray();

    var scatter = myPlot.Add.Scatter(xs, data);

    scatter.Label = markerShapes[i].ToString();

    scatter.MarkerStyle = new MarkerStyle(
        shape: markerShapes[i],
        size: 10,
        color: scatter.LineStyle.Color);
}

myPlot.SavePng("markers.png");
```


## Line Styles

Many plot types have a LineStyle which can be customized.

[![](line-styles.png)](line-styles.png)

```cs
ScottPlot.Plot myPlot = new();

int count = 21;
double[] xs = Generate.Consecutive(count);
double[] ys = Generate.Sin(count);

LinePattern[] linePatterns = Enum.GetValues<LinePattern>().ToArray();

for (int i = 0; i < linePatterns.Length; i++)
{
    double[] data = ys.Select(y => linePatterns.Length - y + i).ToArray();

    var scatter = myPlot.Add.Scatter(xs, data);

    scatter.Label = linePatterns[i].ToString();
    scatter.LineStyle.Width = 2;
    scatter.LineStyle.Pattern = linePatterns[i];
    scatter.MarkerStyle = MarkerStyle.None;
}

myPlot.SavePng("line-styles.png");
```

