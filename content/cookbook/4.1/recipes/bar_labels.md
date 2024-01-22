---
Title: "Bar Labels - ScottPlot 4.1 Cookbook"
Description: "Bars placed at specific positions can be labeled by setting tick labels for those positions."
Date: 2024-01-21
Version: ScottPlot 4.1.71
URL: /cookbook/4.1/recipes/bar_labels/
BreadcrumbNames: ["ScottPlot 4.1 Cookbook", "Bar Graph", "Bar Labels"]
BreadcrumbUrls: ["/cookbook/4.1/", "/cookbook/4.1/category/plottable-bar-graph", "/cookbook/4.1/recipes/bar_labels/"]
SearchUrl: "/cookbook/4.1/search/"
OgImage: "/cookbook/4.1/images/bar_labels.png"
---

<h2><a id='bar-labels' href='/cookbook/4.1/recipes/bar_labels/'>Bar Labels</a></h2>

Bars placed at specific positions can be labeled by setting tick labels for those positions.

{{< code-sp4 >}}

```cs
ScottPlot.Version.ShouldBe(4, 1, 71);
var plt = new ScottPlot.Plot(600, 400);

double[] values = { 26, 20, 23, 7, 16 };
double[] positions = { 0, 1, 2, 3, 4 };
string[] labels = { "PHP", "JS", "C++", "GO", "VB" };
plt.AddBar(values, positions);
plt.XTicks(positions, labels);
plt.SetAxisLimits(yMin: 0);

plt.SaveFig("bar_labels.png");
```

{{< /code-sp4 >}}

<img src='../../images/bar_labels.png' class='d-block mx-auto my-5' />


