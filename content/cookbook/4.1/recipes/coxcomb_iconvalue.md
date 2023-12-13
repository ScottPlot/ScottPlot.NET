---
Title: "Coxcomb Chart with icons - ScottPlot 4.1 Cookbook"
Description: "A Pie chart where the angle of slices is constant but the radii are not, icons are used for quick reference."
Date: 2023-12-13
Version: ScottPlot 4.1.69
URL: /cookbook/4.1/recipes/coxcomb_iconvalue/
BreadcrumbNames: ["ScottPlot 4.1 Cookbook", "Coxcomb Chart", "Coxcomb Chart with icons"]
BreadcrumbUrls: ["/cookbook/4.1/", "/cookbook/4.1/category/plottable-coxcomb", "/cookbook/4.1/recipes/coxcomb_iconvalue/"]
SearchUrl: "/cookbook/4.1/search/"
OgImage: "/cookbook/4.1/images/coxcomb_iconvalue.png"
---

<h2><a id='coxcomb-chart-with-icons' href='/cookbook/4.1/recipes/coxcomb_iconvalue/'>Coxcomb Chart with icons</a></h2>

A Pie chart where the angle of slices is constant but the radii are not, icons are used for quick reference.

```cs
var plt = new ScottPlot.Plot(600, 400);

double[] values = { 11, 16, 7, 3, 14 };
var coxcomb = plt.AddCoxcomb(values);
coxcomb.CategoryImages = CategoryImages;
coxcomb.FillColors = plt.Palette.GetColors(5, 0, .5);
plt.Legend();

plt.SaveFig("coxcomb_iconValue.png");
```

<img src='../../images/coxcomb_iconvalue.png' class='d-block mx-auto my-5' />


