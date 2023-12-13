---
Title: "Right Y Axis - ScottPlot 4.1 Cookbook"
Description: "This example demonstrates how to display a Y axis on the right side of the figure. The vertical axis to the right of the figure is index 1, so plots must be updated to indicate they are to use a nonstandard axis index."
Date: 2023-12-13
Version: ScottPlot 4.1.69
URL: /cookbook/4.1/recipes/multiaxis_right/
BreadcrumbNames: ["ScottPlot 4.1 Cookbook", "Multi-Axis", "Right Y Axis"]
BreadcrumbUrls: ["/cookbook/4.1/", "/cookbook/4.1/category/multi-axis", "/cookbook/4.1/recipes/multiaxis_right/"]
SearchUrl: "/cookbook/4.1/search/"
OgImage: "/cookbook/4.1/images/multiaxis_right.png"
---

<h2><a id='right-y-axis' href='/cookbook/4.1/recipes/multiaxis_right/'>Right Y Axis</a></h2>

This example demonstrates how to display a Y axis on the right side of the figure. The vertical axis to the right of the figure is index 1, so plots must be updated to indicate they are to use a nonstandard axis index.

```cs
var plt = new ScottPlot.Plot(600, 400);

double[] values = DataGen.RandomWalk(100);
var sig = plt.AddSignal(values);
sig.YAxisIndex = plt.RightAxis.AxisIndex;

plt.YAxis.Ticks(false);
plt.YAxis.Grid(false);
plt.RightAxis.Ticks(true);
plt.RightAxis.Grid(true);
plt.RightAxis.Label("Value");
plt.BottomAxis.Label("Sample Number");

plt.SaveFig("multiAxis_right.png");
```

<img src='../../images/multiaxis_right.png' class='d-block mx-auto my-5' />


