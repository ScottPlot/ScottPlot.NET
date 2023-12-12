---
Title: "Values Above Bars - ScottPlot 4.1 Cookbook"
Description: "The value of each bar can be displayed above it."
Date: 12/11/2023 8:04:06 PM
Version: ScottPlot 4.1.69
URL: /cookbook/4.1/recipes/bar_values/
BreadcrumbNames: ["ScottPlot 4.1 Cookbook", "Bar Graph", "Values Above Bars"]
BreadcrumbUrls: ["/cookbook/4.1/", "/cookbook/4.1/category/plottable-bar-graph", "/cookbook/4.1/recipes/bar_values/"]
SearchUrl: "/cookbook/4.1/search/"
OgImage: "/cookbook/4.1/images/bar_values.png"
---

<h2><a href='/cookbook/4.1/recipes/bar_values/'>Values Above Bars</a></h2>

The value of each bar can be displayed above it.

```cs
var plt = new ScottPlot.Plot(600, 400);

// create sample data
double[] values = { 27.3, 23.1, 21.2, 16.1, 6.4, 19.2, 18.7, 17.3, 20.3, 13.1 };

// add a bar graph to the plot and enable values to be displayed above each bar
var bar = plt.AddBar(values);
bar.ShowValuesAboveBars = true;

// adjust axis limits so there is no padding below the bar graph
plt.SetAxisLimits(yMin: 0);

plt.SaveFig("bar_values.png");
```

<img src='../../images/bar_values.png' class='d-block mx-auto my-5' />


