---
Title: "Bar Graph with Defined Positions - ScottPlot 4.1 Cookbook"
Description: "Horizontal positions for each bar can be defined manually. If you define bar positions, you will probably want to define the bar width as well."
Date: 12/11/2023 8:04:06 PM
Version: ScottPlot 4.1.69
URL: /cookbook/4.1/recipes/bar_positions/
BreadcrumbNames: ["ScottPlot 4.1 Cookbook", "Bar Graph", "Bar Graph with Defined Positions"]
BreadcrumbUrls: ["/cookbook/4.1/", "/cookbook/4.1/category/plottable-bar-graph", "/cookbook/4.1/recipes/bar_positions/"]
SearchUrl: "/cookbook/4.1/search/"
OgImage: "/cookbook/4.1/images/bar_positions.png"
---

<h2><a href='/cookbook/4.1/recipes/bar_positions/'>Bar Graph with Defined Positions</a></h2>

Horizontal positions for each bar can be defined manually. If you define bar positions, you will probably want to define the bar width as well.

```cs
var plt = new ScottPlot.Plot(600, 400);

// create sample data
double[] values = { 26, 20, 23, 7, 16 };
double[] positions = { 10, 20, 30, 40, 50 };

// add a bar graph to the plot
var bar = plt.AddBar(values, positions);

// customize the width of bars (80% of the inter-position distance looks good)
bar.BarWidth = (positions[1] - positions[0]) * .8;

// adjust axis limits so there is no padding below the bar graph
plt.SetAxisLimits(yMin: 0);

plt.SaveFig("bar_positions.png");
```

<img src='../../images/bar_positions.png' class='d-block mx-auto my-5' />


