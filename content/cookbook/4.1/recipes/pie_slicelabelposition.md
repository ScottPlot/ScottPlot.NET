---
Title: "Slice Label Position - ScottPlot 4.1 Cookbook"
Description: "Slice label position can be customized to place labels outside the pie. If labels are placed outside the pie, the pie size should be reduced to make room for them."
Date: 2023-12-24
Version: ScottPlot 4.1.69
URL: /cookbook/4.1/recipes/pie_slicelabelposition/
BreadcrumbNames: ["ScottPlot 4.1 Cookbook", "Pie Chart", "Slice Label Position"]
BreadcrumbUrls: ["/cookbook/4.1/", "/cookbook/4.1/category/plottable-pie", "/cookbook/4.1/recipes/pie_slicelabelposition/"]
SearchUrl: "/cookbook/4.1/search/"
OgImage: "/cookbook/4.1/images/pie_slicelabelposition.png"
---

<h2><a id='slice-label-position' href='/cookbook/4.1/recipes/pie_slicelabelposition/'>Slice Label Position</a></h2>

Slice label position can be customized to place labels outside the pie. If labels are placed outside the pie, the pie size should be reduced to make room for them.

```cs
var plt = new ScottPlot.Plot(600, 400);

double[] values = { 778, 43, 283, 76, 184 };
var pie = plt.AddPie(values);
pie.ShowValues = true;
pie.SliceLabelPosition = 0.6;
pie.Size = .7;
pie.SliceLabelColors = pie.SliceFillColors;

plt.SaveFig("pie_sliceLabelPosition.png");
```

<img src='../../images/pie_slicelabelposition.png' class='d-block mx-auto my-5' />


