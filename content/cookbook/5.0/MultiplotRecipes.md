---
Title: Multiplot - ScottPlot 5.0 Cookbook
Description: Use Multiplot to create figures with multiple subplots
URL: /cookbook/5.0/MultiplotRecipes/
BreadcrumbNames: ["ScottPlot 5.0 Cookbook", "Multiplot"]
BreadcrumbUrls: ["/cookbook/5.0/", "/cookbook/5.0/MultiplotRecipes"]
Date: 2024-10-28
Version: ScottPlot 5.0.41
Version: ScottPlot 5.0.41
SearchUrl: "/cookbook/5.0/search/"
ShowEditLink: false
---

# Multiplot


<h2><a href='/cookbook/5.0/MultiplotRecipes/MultiplotQuickstart'>Multiplot Quickstart</a></h2>

Use the Multiplot class to create figures with multiple subplots.

[![](/cookbook/5.0/images/MultiplotQuickstart.png?241027221943)](/cookbook/5.0/images/MultiplotQuickstart.png?241027221943)

{{< recipe-sp5 >}}ScottPlot.Multiplot multiplot = new();

ScottPlot.Plot plot1 = new();
plot1.Add.Signal(Generate.Sin());

ScottPlot.Plot plot2 = new();
plot2.Add.Signal(Generate.Cos());

multiplot.AddPlot(plot1);
multiplot.AddPlot(plot2);

multiplot.SavePng("demo.png", 400, 400);
{{< /recipe-sp5 >}}

<hr class='my-5 invisible'>


<h2><a href='/cookbook/5.0/MultiplotRecipes/MultiplotColumns'>Multiplot Columns</a></h2>

The Multiplot's Layout property may be customized to achieve a column layout.

[![](/cookbook/5.0/images/MultiplotColumns.png?241027221943)](/cookbook/5.0/images/MultiplotColumns.png?241027221943)

{{< recipe-sp5 >}}ScottPlot.Multiplot multiplot = new();

ScottPlot.Plot plot1 = new();
plot1.Add.Signal(Generate.Sin());

ScottPlot.Plot plot2 = new();
plot2.Add.Signal(Generate.Cos());

multiplot.AddPlot(plot1);
multiplot.AddPlot(plot2);
multiplot.Layout = new ScottPlot.MultiplotLayouts.Columns();

multiplot.SavePng("demo.png", 400, 400);
{{< /recipe-sp5 >}}

<hr class='my-5 invisible'>


<h2><a href='/cookbook/5.0/MultiplotRecipes/MultiplotGrid'>Multiplot Grid</a></h2>

The Multiplot's Layout property may be customized to achieve a grid layout.

[![](/cookbook/5.0/images/MultiplotGrid.png?241027221943)](/cookbook/5.0/images/MultiplotGrid.png?241027221943)

{{< recipe-sp5 >}}ScottPlot.Multiplot multiplot = new();

for (int i = 0; i < 6; i++)
{
    ScottPlot.Plot plot = new();
    double[] ys = Generate.Sin(oscillations: i + 1);
    plot.Add.Signal(ys);
    multiplot.AddPlot(plot);
}

multiplot.Layout = new ScottPlot.MultiplotLayouts.Grid(2);

multiplot.SavePng("demo.png", 400, 400);
{{< /recipe-sp5 >}}

<hr class='my-5 invisible'>


<h2><a href='/cookbook/5.0/MultiplotRecipes/MultiplotCustom'>Multiplot Custom Layout</a></h2>

The Multiplot's Layout property may be configured to achieve a fully custom layout.

[![](/cookbook/5.0/images/MultiplotCustom.png?241027221943)](/cookbook/5.0/images/MultiplotCustom.png?241027221943)

{{< recipe-sp5 >}}ScottPlot.Multiplot multiplot = new();

// create 3 plots
for (int i = 0; i < 3; i++)
{
    ScottPlot.Plot plot = new();
    double[] ys = Generate.Sin(oscillations: i + 1);
    plot.Add.Signal(ys);
    multiplot.AddPlot(plot);
}

// create 3 rectangles (one per plot)
FractionRect[] rectangles = [
    FractionRect.GridCell(0, 0, 2, 2), // top left
    FractionRect.GridCell(1, 0, 2, 2), // top right
    FractionRect.GridCell(0, 1, 1, 2), // full bottom
];

multiplot.Layout = new ScottPlot.MultiplotLayouts.Custom(rectangles);

multiplot.SavePng("demo.png", 400, 400);
{{< /recipe-sp5 >}}

<hr class='my-5 invisible'>

