---
Title: Pie Slice Labels - ScottPlot 5.0 Cookbook
Description: Slice labels can be displayed centered with the slice at a customizable distance from the center of the pie.
URL: /cookbook/5.0/Pie/PieSliceLabels/
BreadcrumbNames: ["ScottPlot 5.0 Cookbook", "Pie", "Pie Slice Labels"]
BreadcrumbUrls: ["/cookbook/5.0/", "/cookbook/5.0/Pie", "/cookbook/5.0/Pie/PieSliceLabels"]
Date: 2024-10-31
Version: ScottPlot 5.0.42
Version: ScottPlot 5.0.42
SearchUrl: "/cookbook/5.0/search/"
ShowEditLink: false
---


<h2 style='border-bottom: 0;'><a href='/cookbook/5.0/Pie/PieSliceLabels'>Pie Slice Labels</a></h2>

<div class="d-flex mb-2">
<a class="btn btn-sm btn-primary me-1" href="/cookbook/5.0/Pie/PieSliceLabels">Recipe Permalink</a>
<a class="btn btn-sm btn-success me-1" href="/cookbook/5.0/Pie">Category: Pie</a>
</div>

Slice labels can be displayed centered with the slice at a customizable distance from the center of the pie.

[![](/cookbook/5.0/images/PieSliceLabels.png?241031194635)](/cookbook/5.0/images/PieSliceLabels.png?241031194635)

{{< recipe-sp5 >}}ScottPlot.Plot myPlot = new();

PieSlice slice1 = new() { Value = 5, FillColor = Colors.Red, Label = "alpha" };
PieSlice slice2 = new() { Value = 2, FillColor = Colors.Orange, Label = "beta" };
PieSlice slice3 = new() { Value = 8, FillColor = Colors.Gold, Label = "gamma" };
PieSlice slice4 = new() { Value = 4, FillColor = Colors.Green, Label = "delta" };
PieSlice slice5 = new() { Value = 8, FillColor = Colors.Blue, Label = "epsilon" };

List<PieSlice> slices = new() { slice1, slice2, slice3, slice4, slice5 };

// setup the pie to display slice labels
var pie = myPlot.Add.Pie(slices);
pie.ExplodeFraction = .1;
pie.SliceLabelDistance = 1.3;

// color each label's text to match the slice
slices.ForEach(x => x.LabelFontColor = x.FillColor.Darken(.5));

// styling can be customized for individual slices
slice2.LabelStyle.FontSize = 18;
slice2.LabelStyle.Bold = true;
slice2.LabelStyle.Italic = true;

// hide unnecessary plot components
myPlot.Axes.Frameless();
myPlot.HideGrid();

myPlot.SavePng("demo.png", 400, 300);
{{< /recipe-sp5 >}}

<hr class='my-5 invisible'>


