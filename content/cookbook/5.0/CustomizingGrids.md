---
Title: Customizing Grids - ScottPlot 5.0 Cookbook
Description: Advanced customization of grid lines
URL: /cookbook/5.0/CustomizingGrids/
BreadcrumbNames: ["ScottPlot 5.0 Cookbook", "Customizing Grids"]
BreadcrumbUrls: ["/cookbook/5.0/", "/cookbook/5.0/CustomizingGrids"]
Date: 2024-01-29
Version: ScottPlot 5.0.21
Version: ScottPlot 5.0.21
SearchUrl: "/cookbook/5.0/search/"
ShowEditLink: false
---

# Customizing Grids


<h2><a href='/cookbook/5.0/CustomizingGrids/HideGrid'>Hide Grid</a></h2>

Grid lines can be hidden.

[![](/cookbook/5.0/images/HideGrid.png?240128210832)](/cookbook/5.0/images/HideGrid.png?240128210832)

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

[![](/cookbook/5.0/images/GridCustom.png?240128210832)](/cookbook/5.0/images/GridCustom.png?240128210832)

{{< code-sp5 >}}

```cs
ScottPlot.Plot myPlot = new();

myPlot.Add.Signal(ScottPlot.Generate.Sin(51));
myPlot.Add.Signal(ScottPlot.Generate.Cos(51));

ScottPlot.Grids.DefaultGrid grid = myPlot.GetDefaultGrid();

grid.MajorLineStyle.Color = Colors.Green.WithOpacity(.5);
grid.MinorLineStyle.Color = Colors.Green.WithOpacity(.1);
grid.MinorLineStyle.Width = 1;

myPlot.SavePng("demo.png", 400, 300);

```

{{< /code-sp5 >}}

<hr class='my-5 invisible'>


<h2><a href='/cookbook/5.0/CustomizingGrids/GridAbove'>Grid Above Data</a></h2>

Grid lines are typically drawn beneath data, but grids can be configured to render on top of plottables too.

[![](/cookbook/5.0/images/GridAbove.png?240128210832)](/cookbook/5.0/images/GridAbove.png?240128210832)

{{< code-sp5 >}}

```cs
ScottPlot.Plot myPlot = new();

var sig = myPlot.Add.Signal(ScottPlot.Generate.Sin());
sig.LineWidth = 10;

ScottPlot.Grids.DefaultGrid grid = myPlot.GetDefaultGrid();
grid.MajorLineStyle.Width = 3;
grid.MajorLineStyle.Color = Colors.WhiteSmoke;
grid.IsBeneathPlottables = false;

myPlot.SavePng("demo.png", 400, 300);

```

{{< /code-sp5 >}}

<hr class='my-5 invisible'>

