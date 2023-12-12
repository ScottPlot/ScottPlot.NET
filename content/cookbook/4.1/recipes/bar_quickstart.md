---
Title: "Bar Graph - ScottPlot 4.1 Cookbook"
Description: "A simple bar graph can be created from a series of values. By default values are palced at X positions 0, 1, 2, etc."
Date: 12/11/2023 8:13:09 PM
Version: ScottPlot 4.1.69
URL: /cookbook/4.1/recipes/bar_quickstart/
BreadcrumbNames: ["ScottPlot 4.1 Cookbook", "Bar Graph", "Bar Graph"]
BreadcrumbUrls: ["/cookbook/4.1/", "/cookbook/4.1/category/plottable-bar-graph", "/cookbook/4.1/recipes/bar_quickstart/"]
SearchUrl: "/cookbook/4.1/search/"
OgImage: "/cookbook/4.1/images/bar_quickstart.png"
---

<h2><a id='bar-graph' href='/cookbook/4.1/recipes/bar_quickstart/'>Bar Graph</a></h2>

A simple bar graph can be created from a series of values. By default values are palced at X positions 0, 1, 2, etc.

```cs
var plt = new ScottPlot.Plot(600, 400);

// create sample data
double[] values = { 26, 20, 23, 7, 16 };

// add a bar graph to the plot
plt.AddBar(values);

// adjust axis limits so there is no padding below the bar graph
plt.SetAxisLimits(yMin: 0);

plt.SaveFig("bar_quickstart.png");
```

<img src='../../images/bar_quickstart.png' class='d-block mx-auto my-5' />


