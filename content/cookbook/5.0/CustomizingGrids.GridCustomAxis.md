---
Title: Axis Specific Grid Customization - ScottPlot 5.0 Cookbook
Description: Axis-specific styling properties are available for extensive axis-specific customization of grid line styling.
URL: /cookbook/5.0/CustomizingGrids/GridCustomAxis/
BreadcrumbNames: ["ScottPlot 5.0 Cookbook", "Customizing Grids", "Axis Specific Grid Customization"]
BreadcrumbUrls: ["/cookbook/5.0/", "/cookbook/5.0/CustomizingGrids", "/cookbook/5.0/CustomizingGrids/GridCustomAxis"]
Date: 2024-11-06
Version: ScottPlot 5.0.43
Version: ScottPlot 5.0.43
SearchUrl: "/cookbook/5.0/search/"
ShowEditLink: false
---


<div class='d-flex align-items-center mt-5'>
<h1 class='me-2 text-dark my-0 border-0'>Axis Specific Grid Customization</h1>
</div>

Axis-specific styling properties are available for extensive axis-specific customization of grid line styling.

[![](/cookbook/5.0/images/GridCustomAxis.png?241105214550)](/cookbook/5.0/images/GridCustomAxis.png?241105214550)

{{< recipe-sp5 sourceUrl="https://github.com/ScottPlot/ScottPlot/blob/main/src/ScottPlot5/ScottPlot5%20Cookbook/Recipes/General/GridRecipes.cs" imageUrl="/cookbook/5.0/images/GridCustomAxis.png?241105214550" >}}ScottPlot.Plot myPlot = new();

myPlot.Add.Signal(Generate.Sin(51));
myPlot.Add.Signal(Generate.Cos(51));

myPlot.Grid.XAxisStyle.MajorLineStyle.Color = Colors.Magenta.WithAlpha(.1);
myPlot.Grid.XAxisStyle.MajorLineStyle.Width = 5;

myPlot.Grid.YAxisStyle.MajorLineStyle.Color = Colors.Green.WithAlpha(.3);
myPlot.Grid.YAxisStyle.MajorLineStyle.Width = 2;

myPlot.SavePng("demo.png", 400, 300);
{{< /recipe-sp5 >}}

<div class='my-5 text-center'>This recipe is one of many in the <a href='/cookbook/5.0/CustomizingGrids'>Customizing Grids</a> category</div>


