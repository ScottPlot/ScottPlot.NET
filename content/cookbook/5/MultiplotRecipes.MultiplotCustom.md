---
Title: Multiplot Custom Layout - ScottPlot 5 Cookbook
Description: The Multiplot's Layout property may be configured to achieve a fully custom layout.
URL: /cookbook/5/MultiplotRecipes/MultiplotCustom/
BreadcrumbNames: ["ScottPlot 5 Cookbook", "Multiplot", "Multiplot Custom Layout"]
BreadcrumbUrls: ["/cookbook/5/", "/cookbook/5/MultiplotRecipes", "/cookbook/5/MultiplotRecipes/MultiplotCustom"]
Date: 2026-03-29
Version: ScottPlot 5.1.58
Version: ScottPlot 5.1.58
SearchUrl: "/cookbook/5/search/"
ShowEditLink: false
---


<div class='d-flex align-items-center mt-5'>
<h1 class='me-2 text-dark my-0 border-0'>Multiplot Custom Layout</h1>
</div>

The Multiplot's Layout property may be configured to achieve a fully custom layout.

[![](/cookbook/5/images/MultiplotCustom.png?260329072039)](/cookbook/5/images/MultiplotCustom.png?260329072039)

{{< recipe-sp5 sourceUrl="https://github.com/ScottPlot/ScottPlot/blob/main/src/ScottPlot5/ScottPlot5%20Cookbook/Recipes/General/MultiplotRecipes.cs" imageUrl="/cookbook/5/images/MultiplotCustom.png?260329072039" >}}ScottPlot.Multiplot multiplot = new();

// configure the multiplot to have 3 subplots
multiplot.AddPlots(3);

// add sample data to each subplot
for (int i = 0; i &lt; multiplot.Subplots.Count; i++)
{
    Plot plot = multiplot.GetPlot(i);
    double[] ys = Generate.Sin(oscillations: i + 1);
    plot.Add.Signal(ys);
}

// create a custom grid layout and define the position of each subplot
ScottPlot.MultiplotLayouts.CustomGrid gridLayout = new();
gridLayout.Set(multiplot.GetPlot(0), new GridCell(0, 0, 2, 1)); // double wide
gridLayout.Set(multiplot.GetPlot(1), new GridCell(1, 0, 2, 2)); // bottom left
gridLayout.Set(multiplot.GetPlot(2), new GridCell(1, 1, 2, 2)); // bottom right

// user the custom layout in our multiplot
multiplot.Layout = gridLayout;

multiplot.SavePng("demo.png", 400, 400);
{{< /recipe-sp5 >}}

<div class='my-5 text-center'>This recipe is one of many in the <a href='/cookbook/5/MultiplotRecipes'>Multiplot</a> category</div>


