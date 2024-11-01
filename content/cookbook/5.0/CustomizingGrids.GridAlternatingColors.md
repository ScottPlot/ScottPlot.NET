---
Title: Grid Fill Colors - ScottPlot 5.0 Cookbook
Description: Regions between alternating pairs of major grid lines may be filled with a color specified by the user
URL: /cookbook/5.0/CustomizingGrids/GridAlternatingColors/
BreadcrumbNames: ["ScottPlot 5.0 Cookbook", "Customizing Grids", "Grid Fill Colors"]
BreadcrumbUrls: ["/cookbook/5.0/", "/cookbook/5.0/CustomizingGrids", "/cookbook/5.0/CustomizingGrids/GridAlternatingColors"]
Date: 2024-11-01
Version: ScottPlot 5.0.42
Version: ScottPlot 5.0.42
SearchUrl: "/cookbook/5.0/search/"
ShowEditLink: false
---


<div class='d-flex align-items-center mt-5'>
<h1 class='me-2 text-dark my-0 border-0'>Grid Fill Colors</h1>
</div>

Regions between alternating pairs of major grid lines may be filled with a color specified by the user

[![](/cookbook/5.0/images/GridAlternatingColors.png?241101192719)](/cookbook/5.0/images/GridAlternatingColors.png?241101192719)

{{< recipe-sp5 >}}ScottPlot.Plot myPlot = new();

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
{{< /recipe-sp5 >}}

<div class='my-5 text-center'>This recipe is one of many in the <a href='/cookbook/5.0/CustomizingGrids'>Customizing Grids</a> category</div>


