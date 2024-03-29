---
Title: "Horizontal Bar Graph - ScottPlot 4.1 Cookbook"
Description: "Bar graphs are typically displayed as columns, but it's possible to show bars as rows."
Date: 2024-01-21
Version: ScottPlot 4.1.71
URL: /cookbook/4.1/recipes/bar_horizontal/
BreadcrumbNames: ["ScottPlot 4.1 Cookbook", "Bar Graph", "Horizontal Bar Graph"]
BreadcrumbUrls: ["/cookbook/4.1/", "/cookbook/4.1/category/plottable-bar-graph", "/cookbook/4.1/recipes/bar_horizontal/"]
SearchUrl: "/cookbook/4.1/search/"
OgImage: "/cookbook/4.1/images/bar_horizontal.png"
---

<h2><a id='horizontal-bar-graph' href='/cookbook/4.1/recipes/bar_horizontal/'>Horizontal Bar Graph</a></h2>

Bar graphs are typically displayed as columns, but it's possible to show bars as rows.

{{< code-sp4 >}}

```cs
ScottPlot.Version.ShouldBe(4, 1, 71);
var plt = new ScottPlot.Plot(600, 400);

// create sample data
double[] values = { 26, 20, 23, 7, 16 };
double[] errors = { 3, 2, 5, 1, 3 };
double[] positions = { 1, 2, 3, 4, 5 };

// add a bar graph to the plot and customize it to render horizontally
var bar = plt.AddBar(values, errors, positions);
bar.Orientation = Orientation.Horizontal;

// adjust axis limits so there is no padding to the left of the bar graph
plt.SetAxisLimits(xMin: 0);

plt.SaveFig("bar_horizontal.png");
```

{{< /code-sp4 >}}

<img src='../../images/bar_horizontal.png' class='d-block mx-auto my-5' />


