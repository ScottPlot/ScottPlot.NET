---
Title: Styling Plots - ScottPlot 5.0 Cookbook
Description: How to customize plots
URL: /cookbook/5.0/Styling/index.html
BreadcrumbNames: ["ScottPlot 5.0 Cookbook", "Styling Plots"]
BreadcrumbUrls: ["/cookbook/5.0/", "/cookbook/5.0/Styling"]
Date: 2023-12-14
Version: ScottPlot 5.0.10-beta
---

# Styling Plots



<div class='alert alert-warning' role='alert'><h4 class='alert-heading py-0 my-0'>⚠️ ScottPlot 5.0.10-beta is a preview package</h4><hr /><p class='mb-0'><span class='fw-semibold'>This page describes a beta release of ScottPlot.</span> It is available on NuGet as a preview package, but its API is not stable and it is not recommended for production use. See the <a href='https://scottplot.net/versions/'>ScottPlot Versions</a> page for more information. </p></div>



## Style Helper Functions

Plots contain many objects which can be customized individually by assigining to their public properties, but helper methods exist in the Plot's Style object that make it easier to customzie many items at once using a simpler API.

[![](/cookbook/5.0/images/StyleClass.png)](/cookbook/5.0/images/StyleClass.png)

```cs
ScottPlot.Plot myPlot = new();

myPlot.Add.Signal(ScottPlot.Generate.Sin(51));
myPlot.Add.Signal(ScottPlot.Generate.Cos(51));

// visible items have public properties that can be customized
myPlot.XAxis.Label.Text = "Horizontal Axis";
myPlot.YAxis.Label.Text = "Vertical Axis";
myPlot.TitlePanel.Label.Text = "Plot Title";

// the Style object contains helper methods to easily style many items at once
myPlot.Style.Background(figure: Color.FromHex("#07263b"), data: Color.FromHex("#0b3049"));
myPlot.Style.ColorAxes(Color.FromHex("#a0acb5"));
myPlot.Style.ColorGrids(Color.FromHex("#0e3d54"));

myPlot.SavePng("demo.png");

```


## Axis Customization

Axis labels, tick marks, and frame can all be customized.

[![](/cookbook/5.0/images/AxisCustom.png)](/cookbook/5.0/images/AxisCustom.png)

```cs
ScottPlot.Plot myPlot = new();

myPlot.Add.Signal(ScottPlot.Generate.Sin(51));
myPlot.Add.Signal(ScottPlot.Generate.Cos(51));

myPlot.TitlePanel.Label.Text = "Plot Title";
myPlot.TitlePanel.Label.Font.Color = Colors.RebeccaPurple;
myPlot.TitlePanel.Label.Font.Size = 32;
myPlot.TitlePanel.Label.Font.Name = Fonts.Serif;
myPlot.TitlePanel.Label.Rotation = -5;
myPlot.TitlePanel.Label.Font.Bold = false;

myPlot.YAxis.Label.Text = "Vertical Axis";
myPlot.YAxis.Label.Font.Color = Colors.Magenta;
myPlot.YAxis.Label.Font.Italic = true;

myPlot.XAxis.Label.Text = "Horizontal Axis";
myPlot.XAxis.Label.Font.Bold = false;
myPlot.XAxis.Label.Font.Name = Fonts.Monospace;

myPlot.XAxis.MajorTickLength = 10;
myPlot.XAxis.MajorTickWidth = 3;
myPlot.XAxis.MajorTickColor = Colors.Magenta;
myPlot.XAxis.MinorTickLength = 5;
myPlot.XAxis.MinorTickWidth = 0.5f;
myPlot.XAxis.MinorTickColor = Colors.Green;
myPlot.XAxis.FrameLineStyle.Color = Colors.LightBlue;

myPlot.SavePng("demo.png");

```


## Grid Customization

Grid lines can be customized. Custom grid systems can be created to give developers full control of grid rendering, but the default grid can be interacted with to customize its appearance.

[![](/cookbook/5.0/images/GridCustom.png)](/cookbook/5.0/images/GridCustom.png)

```cs
ScottPlot.Plot myPlot = new();

myPlot.Add.Signal(ScottPlot.Generate.Sin(51));
myPlot.Add.Signal(ScottPlot.Generate.Cos(51));

ScottPlot.Grids.DefaultGrid grid = myPlot.GetDefaultGrid();

grid.MajorLineStyle.Color = Colors.Green.WithOpacity(.5);
grid.MinorLineStyle.Color = Colors.Green.WithOpacity(.1);
grid.MinorLineStyle.Width = 1;

myPlot.SavePng("demo.png");

```


## Grid Above Data

Grid lines are typically drawn beneath data, but grids can be configured to render on top of plottables too.

[![](/cookbook/5.0/images/GridAbove.png)](/cookbook/5.0/images/GridAbove.png)

```cs
ScottPlot.Plot myPlot = new();

var sig = myPlot.Add.Signal(ScottPlot.Generate.Sin(51));
sig.LineStyle.Width = 10;

ScottPlot.Grids.DefaultGrid grid = myPlot.GetDefaultGrid();
grid.MajorLineStyle.Width = 3;
grid.MajorLineStyle.Color = Colors.WhiteSmoke;
grid.IsBeneathPlottables = false;

myPlot.SavePng("demo.png");

```


## Palettes

A palette is a set of colors, and the Plot's palette defines the default colors to use when adding new plottables. ScottPlot comes with many standard palettes, but users may also create their own.

[![](/cookbook/5.0/images/Palette.png)](/cookbook/5.0/images/Palette.png)

```cs
ScottPlot.Plot myPlot = new();

myPlot.Palette = new ScottPlot.Palettes.Nord();

for (int i = 0; i < 5; i++)
{
    double[] data = ScottPlot.Generate.Sin(100, phase: -i / 20.0f);
    var sig = myPlot.Add.Signal(data);
    sig.LineStyle.Width = 3;
}

myPlot.SavePng("demo.png");

```


## Markers

Many plot types have a MarkerStyle which can be customized.

[![](/cookbook/5.0/images/Markers.png)](/cookbook/5.0/images/Markers.png)

```cs
ScottPlot.Plot myPlot = new();

int count = 21;
double[] xs = ScottPlot.Generate.Consecutive(count);
double[] ys = ScottPlot.Generate.Sin(count);

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

myPlot.Legend.IsVisible = true;

myPlot.SavePng("demo.png");

```


## Line Styles

Many plot types have a LineStyle which can be customized.

[![](/cookbook/5.0/images/LineStyles.png)](/cookbook/5.0/images/LineStyles.png)

```cs
ScottPlot.Plot myPlot = new();

int count = 21;
double[] xs = ScottPlot.Generate.Consecutive(count);
double[] ys = ScottPlot.Generate.Sin(count);

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

myPlot.Legend.IsVisible = true;

myPlot.SavePng("demo.png");

```


## Scaling

All components of an image can be scaled up or down in size by adjusting the ScaleFactor property. This is very useful for creating images that look nice on high DPI displays with display scaling enabled.

[![](/cookbook/5.0/images/Scaling.png)](/cookbook/5.0/images/Scaling.png)

```cs
ScottPlot.Plot myPlot = new();

myPlot.ScaleFactor = 2;
myPlot.Add.Signal(ScottPlot.Generate.Sin());
myPlot.Add.Signal(ScottPlot.Generate.Cos());

myPlot.SavePng("demo.png");

```

