---
Title: "Disable Grid - ScottPlot 4.1 Cookbook"
Description: "Visibility of primary X and Y grids can be set using a single method."
Date: 2024-01-21
Version: ScottPlot 4.1.71
URL: /cookbook/4.1/recipes/axis_griddisableall/
BreadcrumbNames: ["ScottPlot 4.1 Cookbook", "Axis and Ticks", "Disable Grid"]
BreadcrumbUrls: ["/cookbook/4.1/", "/cookbook/4.1/category/axis-and-ticks", "/cookbook/4.1/recipes/axis_griddisableall/"]
SearchUrl: "/cookbook/4.1/search/"
OgImage: "/cookbook/4.1/images/axis_griddisableall.png"
---

<h2><a id='disable-grid' href='/cookbook/4.1/recipes/axis_griddisableall/'>Disable Grid</a></h2>

Visibility of primary X and Y grids can be set using a single method.

{{< code-sp4 >}}

```cs
ScottPlot.Version.ShouldBe(4, 1, 71);
var plt = new ScottPlot.Plot(600, 400);

// plot sample data
plt.AddSignal(DataGen.Sin(51));
plt.AddSignal(DataGen.Cos(51));

// hide grids
plt.Grid(false);

plt.SaveFig("axis_gridDisableAll.png");
```

{{< /code-sp4 >}}

<img src='../../images/axis_griddisableall.png' class='d-block mx-auto my-5' />


