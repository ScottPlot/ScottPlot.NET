---
Title: Customizing Grids - ScottPlot 5.0 Cookbook
Description: Advanced customization of grid lines
URL: /cookbook/5.0/CustomizingGrids/
BreadcrumbNames: ["ScottPlot 5.0 Cookbook", "Customizing Grids"]
BreadcrumbUrls: ["/cookbook/5.0/", "/cookbook/5.0/CustomizingGrids"]
Date: 2024-09-02
Version: ScottPlot 5.0.38
Version: ScottPlot 5.0.38
SearchUrl: "/cookbook/5.0/search/"
ShowEditLink: false
---

# Customizing Grids


<h2><a href='/cookbook/5.0/CustomizingGrids/HideGrid'>Hide Grid</a></h2>

Grid lines can be hidden.

[![](/cookbook/5.0/images/HideGrid.png?240902145058)](/cookbook/5.0/images/HideGrid.png?240902145058)

{{< code-sp5 >}}

```cs
ScottPlot.Plot myPlot = new();

myPlot.Add.Signal(Generate.Sin(51));
myPlot.Add.Signal(Generate.Cos(51));

myPlot.HideGrid();

myPlot.SavePng("demo.png", 400, 300);

```

{{< /code-sp5 >}}

<hr class='my-5 invisible'>


<h2><a href='/cookbook/5.0/CustomizingGrids/GridCustom'>Grid Customization</a></h2>

Grid lines can be customized. Custom grid systems can be created to give developers full control of grid rendering, but the default grid can be interacted with to customize its appearance.

[![](/cookbook/5.0/images/GridCustom.png?240902145058)](/cookbook/5.0/images/GridCustom.png?240902145058)

{{< code-sp5 >}}

```cs
ScottPlot.Plot myPlot = new();

myPlot.Add.Signal(Generate.Sin(51));
myPlot.Add.Signal(Generate.Cos(51));

myPlot.Grid.MajorLineColor = Colors.Green.WithOpacity(.3);
myPlot.Grid.MajorLineWidth = 2;

myPlot.Grid.MinorLineColor = Colors.Gray.WithOpacity(.1);
myPlot.Grid.MinorLineWidth = 1;

myPlot.SavePng("demo.png", 400, 300);

```

{{< /code-sp5 >}}

<hr class='my-5 invisible'>


<h2><a href='/cookbook/5.0/CustomizingGrids/GridCustomAxis'>Axis Specific Grid Customization</a></h2>

Axis-specific styling properties are available for extensive axis-specific customization of grid line styling.

[![](/cookbook/5.0/images/GridCustomAxis.png?240902145058)](/cookbook/5.0/images/GridCustomAxis.png?240902145058)

{{< code-sp5 >}}

```cs
ScottPlot.Plot myPlot = new();

myPlot.Add.Signal(Generate.Sin(51));
myPlot.Add.Signal(Generate.Cos(51));

myPlot.Grid.XAxisStyle.MajorLineStyle.Color = Colors.Magenta.WithAlpha(.1);
myPlot.Grid.XAxisStyle.MajorLineStyle.Width = 5;

myPlot.Grid.YAxisStyle.MajorLineStyle.Color = Colors.Green.WithAlpha(.3);
myPlot.Grid.YAxisStyle.MajorLineStyle.Width = 2;

myPlot.SavePng("demo.png", 400, 300);

```

{{< /code-sp5 >}}

<hr class='my-5 invisible'>


<h2><a href='/cookbook/5.0/CustomizingGrids/GridAbove'>Grid Above Data</a></h2>

Grid lines are typically drawn beneath data, but grids can be configured to render on top of plottables too.

[![](/cookbook/5.0/images/GridAbove.png?240902145058)](/cookbook/5.0/images/GridAbove.png?240902145058)

{{< code-sp5 >}}

```cs
ScottPlot.Plot myPlot = new();

var sig = myPlot.Add.Signal(ScottPlot.Generate.Sin());
sig.LineWidth = 10;

myPlot.Grid.MajorLineWidth = 3;
myPlot.Grid.MajorLineColor = Colors.Black.WithAlpha(.2);
myPlot.Grid.IsBeneathPlottables = false;

myPlot.SavePng("demo.png", 400, 300);

```

{{< /code-sp5 >}}

<hr class='my-5 invisible'>


<h2><a href='/cookbook/5.0/CustomizingGrids/GridWithTopAxis'>Grid with Top Axis</a></h2>

Grid lines use the bottom and left axes by default, but this behavior can be customized for plots which use other axes.

[![](/cookbook/5.0/images/GridWithTopAxis.png?240902145058)](/cookbook/5.0/images/GridWithTopAxis.png?240902145058)

{{< code-sp5 >}}

```cs
ScottPlot.Plot myPlot = new();

var sig = myPlot.Add.Signal(ScottPlot.Generate.Sin());
sig.Axes.XAxis = myPlot.Axes.Top;
myPlot.Grid.XAxis = myPlot.Axes.Top;

myPlot.SavePng("demo.png", 400, 300);

```

{{< /code-sp5 >}}

<hr class='my-5 invisible'>


<h2><a href='/cookbook/5.0/CustomizingGrids/GridAlternatingColors'>Grid Fill Colors</a></h2>

Regions between alternating pairs of major grid lines may be filled with a color specified by the user

[![](/cookbook/5.0/images/GridAlternatingColors.png?240902145058)](/cookbook/5.0/images/GridAlternatingColors.png?240902145058)

{{< code-sp5 >}}

```cs
ScottPlot.Plot myPlot = new();

myPlot.Add.Signal(Generate.Sin());
myPlot.Add.Signal(Generate.Cos());

// shade regions between major grid lines
myPlot.Grid.XAxisStyle.FillColor1 = Colors.Gray.WithOpacity(0.1);
myPlot.Grid.XAxisStyle.FillColor2 = Colors.Gray.WithOpacity(0.2);
myPlot.Grid.YAxisStyle.FillColor1 = Colors.Gray.WithOpacity(0.1);
myPlot.Grid.YAxisStyle.FillColor2 = Colors.Gray.WithOpacity(0.2);

// show minor grid lines too
myPlot.Grid.XAxisStyle.MinorLineStyle.Width = 1;
myPlot.Grid.YAxisStyle.MinorLineStyle.Width = 1;

myPlot.SavePng("demo.png", 400, 300);

```

{{< /code-sp5 >}}

<hr class='my-5 invisible'>


<h2><a href='/cookbook/5.0/CustomizingGrids/GridAlternatingDarkMode'>Grid Fill Color in Dark Mode</a></h2>

Grid and plot styling can be customize to achieve a pleasing effect in dark mode

[![](/cookbook/5.0/images/GridAlternatingDarkMode.png?240902145058)](/cookbook/5.0/images/GridAlternatingDarkMode.png?240902145058)

{{< code-sp5 >}}

```cs
ScottPlot.Plot myPlot = new();

// add a green data line
var sig = myPlot.Add.Signal(Generate.SquareWaveFromSines());
sig.LineWidth = 3;
sig.Color = new("#2b9433");
sig.AlwaysUseLowDensityMode = true;

// give the plot a dark background with light text
myPlot.FigureBackground.Color = new("#1c1c1e");
myPlot.Axes.Color(new("#888888"));

// shade regions between major grid lines
myPlot.Grid.XAxisStyle.FillColor1 = new Color("#888888").WithAlpha(10);
myPlot.Grid.YAxisStyle.FillColor1 = new Color("#888888").WithAlpha(10);

// set grid line colors
myPlot.Grid.XAxisStyle.MajorLineStyle.Color = Colors.White.WithAlpha(15);
myPlot.Grid.YAxisStyle.MajorLineStyle.Color = Colors.White.WithAlpha(15);
myPlot.Grid.XAxisStyle.MinorLineStyle.Color = Colors.White.WithAlpha(5);
myPlot.Grid.YAxisStyle.MinorLineStyle.Color = Colors.White.WithAlpha(5);

// enable minor grid lines by defining a positive width
myPlot.Grid.XAxisStyle.MinorLineStyle.Width = 1;
myPlot.Grid.YAxisStyle.MinorLineStyle.Width = 1;

myPlot.SavePng("demo.png", 400, 300);

```

{{< /code-sp5 >}}

<hr class='my-5 invisible'>

