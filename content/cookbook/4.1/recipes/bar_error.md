---
Title: "Bar Graph with Error Bars - ScottPlot 4.1 Cookbook"
Description: "Errorbars can be added to any bar graph."
Date: 2024-01-21
Version: ScottPlot 4.1.71
URL: /cookbook/4.1/recipes/bar_error/
BreadcrumbNames: ["ScottPlot 4.1 Cookbook", "Bar Graph", "Bar Graph with Error Bars"]
BreadcrumbUrls: ["/cookbook/4.1/", "/cookbook/4.1/category/plottable-bar-graph", "/cookbook/4.1/recipes/bar_error/"]
SearchUrl: "/cookbook/4.1/search/"
OgImage: "/cookbook/4.1/images/bar_error.png"
---

<h2><a id='bar-graph-with-error-bars' href='/cookbook/4.1/recipes/bar_error/'>Bar Graph with Error Bars</a></h2>

Errorbars can be added to any bar graph.

{{< code-sp4 >}}

```cs
ScottPlot.Version.ShouldBe(4, 1, 71);
var plt = new ScottPlot.Plot(600, 400);

// add a bar graph to the plot
double[] values = { 26, 20, 23, 7, 16 };
var bar = plt.AddBar(values);

// add errorbars to the bar graph and customize styling as desired
double[] errors = { 3, 2, 5, 1, 3 };
bar.ValueErrors = errors;
bar.ErrorCapSize = .1;

// adjust axis limits so there is no padding below the bar graph
plt.SetAxisLimits(yMin: 0);

plt.SaveFig("bar_error.png");
```

{{< /code-sp4 >}}

<img src='../../images/bar_error.png' class='d-block mx-auto my-5' />


