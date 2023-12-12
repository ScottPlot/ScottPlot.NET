---
Title: "Disable Vertical Grid - ScottPlot 4.1 Cookbook"
Description: "Grid line visibility can be controlled for each axis individually. Use this to selectively enable grid lines only for the axes of interest. Keep in mind that vertical grid lines are controlled by horizontal axes."
Date: 12/11/2023 7:52:02 PM
Version: ScottPlot 4.1.69
URL: /cookbook/4.1/recipes/axis_griddisableone/
BreadcrumbNames: ["ScottPlot 4.1 Cookbook", "Axis and Ticks", "Disable Vertical Grid"]
BreadcrumbUrls: ["/cookbook/4.1/", "/cookbook/4.1/category/axis-and-ticks", "/cookbook/4.1/recipes/axis_griddisableone/"]
SearchUrl: "/cookbook/4.1/search/"
OgImage: "/cookbook/4.1/images/axis_griddisableone.png"
---

<h2><a href='/cookbook/4.1/recipes/axis_griddisableone/'>Disable Vertical Grid</a></h2>

Grid line visibility can be controlled for each axis individually. Use this to selectively enable grid lines only for the axes of interest. Keep in mind that vertical grid lines are controlled by horizontal axes.

```cs
var plt = new ScottPlot.Plot(600, 400);

// plot sample data
plt.AddSignal(DataGen.Sin(51));
plt.AddSignal(DataGen.Cos(51));

// each axis has its own visibility controls
plt.XAxis.Grid(false);

plt.SaveFig("axis_gridDisableOne.png");
```

<img src='../../images/axis_griddisableone.png' class='d-block mx-auto my-5' />


