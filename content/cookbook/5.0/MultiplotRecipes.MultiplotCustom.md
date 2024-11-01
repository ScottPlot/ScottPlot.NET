---
Title: Multiplot Custom Layout - ScottPlot 5.0 Cookbook
Description: The Multiplot's Layout property may be configured to achieve a fully custom layout.
URL: /cookbook/5.0/MultiplotRecipes/MultiplotCustom/
BreadcrumbNames: ["ScottPlot 5.0 Cookbook", "Multiplot", "Multiplot Custom Layout"]
BreadcrumbUrls: ["/cookbook/5.0/", "/cookbook/5.0/MultiplotRecipes", "/cookbook/5.0/MultiplotRecipes/MultiplotCustom"]
Date: 2024-11-01
Version: ScottPlot 5.0.42
Version: ScottPlot 5.0.42
SearchUrl: "/cookbook/5.0/search/"
ShowEditLink: false
---


<div class='d-flex align-items-center mt-5'>
<h1 class='me-2 text-dark my-0 border-0'>Multiplot Custom Layout</h1>
</div>

The Multiplot's Layout property may be configured to achieve a fully custom layout.

[![](/cookbook/5.0/images/MultiplotCustom.png?241101192719)](/cookbook/5.0/images/MultiplotCustom.png?241101192719)

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

<div class='my-5 text-center'>This recipe is one of many in the <a href='/cookbook/5.0/MultiplotRecipes'>Multiplot</a> category</div>


