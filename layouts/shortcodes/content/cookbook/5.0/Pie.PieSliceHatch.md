---
Title: Pie Slice with Hatch - ScottPlot 5.0 Cookbook
Description: Individual slices may be given a custom hatch style
URL: /cookbook/5.0/Pie/PieSliceHatch/
BreadcrumbNames: ["ScottPlot 5.0 Cookbook", "Pie", "Pie Slice with Hatch"]
BreadcrumbUrls: ["/cookbook/5.0/", "/cookbook/5.0/Pie", "/cookbook/5.0/Pie/PieSliceHatch"]
Date: 2025-03-22
Version: ScottPlot 5.0.55
Version: ScottPlot 5.0.55
SearchUrl: "/cookbook/5.0/search/"
ShowEditLink: false
---


<div class='d-flex align-items-center mt-5'>
<h1 class='me-2 text-dark my-0 border-0'>Pie Slice with Hatch</h1>
</div>

Individual slices may be given a custom hatch style

[![](/cookbook/5.0/images/PieSliceHatch.png?250322130304)](/cookbook/5.0/images/PieSliceHatch.png?250322130304)

{{< recipe-sp5 sourceUrl="https://github.com/ScottPlot/ScottPlot/blob/main/src/ScottPlot5/ScottPlot5%20Cookbook/Recipes/PlotTypes/Pie.cs" imageUrl="/cookbook/5.0/images/PieSliceHatch.png?250322130304" >}}ScottPlot.Plot myPlot = new();

var pie = myPlot.Add.Pie([5, 4, 6]);

// customize the hatch style for a single slice
pie.Slices[0].Fill.Hatch = new ScottPlot.Hatches.Striped();
pie.Slices[0].Fill.HatchColor = pie.Slices[0].Fill.Color.Lighten(.2);

// hide unnecessary plot components
myPlot.Axes.Frameless();
myPlot.HideGrid();

myPlot.SavePng("demo.png", 400, 300);
{{< /recipe-sp5 >}}

<div class='my-5 text-center'>This recipe is one of many in the <a href='/cookbook/5.0/Pie'>Pie</a> category</div>


