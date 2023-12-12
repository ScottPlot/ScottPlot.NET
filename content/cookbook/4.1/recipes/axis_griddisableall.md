---
Title: "Disable Grid - ScottPlot 4.1 Cookbook"
Description: "Visibility of primary X and Y grids can be set using a single method."
Date: 12/11/2023 7:52:02 PM
Version: ScottPlot 4.1.69
URL: /cookbook/4.1/recipes/axis_griddisableall/
BreadcrumbNames: ["ScottPlot 4.1 Cookbook", "Axis and Ticks", "Disable Grid"]
BreadcrumbUrls: ["/cookbook/4.1/", "/cookbook/4.1/category/axis-and-ticks", "/cookbook/4.1/recipes/axis_griddisableall/"]
SearchUrl: "/cookbook/4.1/search/"
OgImage: "/cookbook/4.1/images/axis_griddisableall.png"
---

<h2><a href='/cookbook/4.1/recipes/axis_griddisableall/'>Disable Grid</a></h2>

Visibility of primary X and Y grids can be set using a single method.

```cs
var plt = new ScottPlot.Plot(600, 400);

// plot sample data
plt.AddSignal(DataGen.Sin(51));
plt.AddSignal(DataGen.Cos(51));

// hide grids
plt.Grid(false);

plt.SaveFig("axis_gridDisableAll.png");
```

<img src='../../images/axis_griddisableall.png' class='d-block mx-auto my-5' />


