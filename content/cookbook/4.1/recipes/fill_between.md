---
Title: "Fill Between Curves - ScottPlot 4.1 Cookbook"
Description: "Given two curves, a polygon can be created to give the appearance of shading between them. Here we will display two scatter plots, then create a polygon to fill the region between them."
Date: 12/11/2023 8:13:10 PM
Version: ScottPlot 4.1.69
URL: /cookbook/4.1/recipes/fill_between/
BreadcrumbNames: ["ScottPlot 4.1 Cookbook", "Fill", "Fill Between Curves"]
BreadcrumbUrls: ["/cookbook/4.1/", "/cookbook/4.1/category/plottable-fill", "/cookbook/4.1/recipes/fill_between/"]
SearchUrl: "/cookbook/4.1/search/"
OgImage: "/cookbook/4.1/images/fill_between.png"
---

<h2><a id='fill-between-curves' href='/cookbook/4.1/recipes/fill_between/'>Fill Between Curves</a></h2>

Given two curves, a polygon can be created to give the appearance of shading between them. Here we will display two scatter plots, then create a polygon to fill the region between them.

```cs
var plt = new ScottPlot.Plot(600, 400);

// create sample data
double[] xs = DataGen.Range(0, 10, .1, true);
double[] ys1 = DataGen.Sin(xs);
double[] ys2 = DataGen.Cos(xs);

// add a polygon to fill the region between the two curves
plt.AddFill(xs, ys1, xs, ys2);

// add two scatter plots the traditional way
plt.AddScatter(xs, ys1, color: Color.Black);
plt.AddScatter(xs, ys2, color: Color.Black);

// tighten the axis limits so we don't see lines on the edges
plt.SetAxisLimits(xMin: 0, xMax: 10);

plt.SaveFig("fill_between.png");
```

<img src='../../images/fill_between.png' class='d-block mx-auto my-5' />


