---
Title: Customizing Grids - ScottPlot 5.0 Cookbook
Description: Advanced customization of grid lines
URL: /cookbook/5.0/CustomizingGrids/
BreadcrumbNames: ["ScottPlot 5.0 Cookbook", "Customizing Grids"]
BreadcrumbUrls: ["/cookbook/5.0/", "/cookbook/5.0/CustomizingGrids"]
Date: 2024-04-27
Version: ScottPlot 5.0.31
Version: ScottPlot 5.0.31
SearchUrl: "/cookbook/5.0/search/"
ShowEditLink: false
---

# Customizing Grids


<h2><a href='/cookbook/5.0/CustomizingGrids/HideGrid'>Hide Grid</a></h2>

Grid lines can be hidden.

[![](/cookbook/5.0/images/HideGrid.png?240427161103)](/cookbook/5.0/images/HideGrid.png?240427161103)

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

[![](/cookbook/5.0/images/GridCustom.png?240427161103)](/cookbook/5.0/images/GridCustom.png?240427161103)

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

[![](/cookbook/5.0/images/GridCustomAxis.png?240427161103)](/cookbook/5.0/images/GridCustomAxis.png?240427161103)

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

[![](/cookbook/5.0/images/GridAbove.png?240427161103)](/cookbook/5.0/images/GridAbove.png?240427161103)

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

[![](/cookbook/5.0/images/GridWithTopAxis.png?240427161103)](/cookbook/5.0/images/GridWithTopAxis.png?240427161103)

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

