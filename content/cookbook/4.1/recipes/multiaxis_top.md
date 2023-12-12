---
Title: "Top X Axis - ScottPlot 4.1 Cookbook"
Description: "This example demonstrates how to display an X axis above the figure. The horizontal axis above the figure is index 1, so plots must be updated to indicate they are to use a nonstandard axis index."
Date: 12/11/2023 8:13:09 PM
Version: ScottPlot 4.1.69
URL: /cookbook/4.1/recipes/multiaxis_top/
BreadcrumbNames: ["ScottPlot 4.1 Cookbook", "Multi-Axis", "Top X Axis"]
BreadcrumbUrls: ["/cookbook/4.1/", "/cookbook/4.1/category/multi-axis", "/cookbook/4.1/recipes/multiaxis_top/"]
SearchUrl: "/cookbook/4.1/search/"
OgImage: "/cookbook/4.1/images/multiaxis_top.png"
---

<h2><a id='top-x-axis' href='/cookbook/4.1/recipes/multiaxis_top/'>Top X Axis</a></h2>

This example demonstrates how to display an X axis above the figure. The horizontal axis above the figure is index 1, so plots must be updated to indicate they are to use a nonstandard axis index.

```cs
var plt = new ScottPlot.Plot(600, 400);

double[] values = DataGen.RandomWalk(100);
var sig = plt.AddSignal(values);
sig.XAxisIndex = plt.TopAxis.AxisIndex;

plt.BottomAxis.Ticks(false);
plt.BottomAxis.Grid(false);
plt.TopAxis.Ticks(true);
plt.TopAxis.Grid(true);
plt.TopAxis.Label("Sample Number");
plt.YAxis.Label("Value");

plt.SaveFig("multiAxis_top.png");
```

<img src='../../images/multiaxis_top.png' class='d-block mx-auto my-5' />


