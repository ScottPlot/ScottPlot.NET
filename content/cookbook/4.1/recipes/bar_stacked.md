---
Title: "Stacked Bar Graphs - ScottPlot 4.1 Cookbook"
Description: "Bars can be overlapped to give the appearance of stacking."
Date: 2024-01-21
Version: ScottPlot 4.1.71
URL: /cookbook/4.1/recipes/bar_stacked/
BreadcrumbNames: ["ScottPlot 4.1 Cookbook", "Bar Graph", "Stacked Bar Graphs"]
BreadcrumbUrls: ["/cookbook/4.1/", "/cookbook/4.1/category/plottable-bar-graph", "/cookbook/4.1/recipes/bar_stacked/"]
SearchUrl: "/cookbook/4.1/search/"
OgImage: "/cookbook/4.1/images/bar_stacked.png"
---

<h2><a id='stacked-bar-graphs' href='/cookbook/4.1/recipes/bar_stacked/'>Stacked Bar Graphs</a></h2>

Bars can be overlapped to give the appearance of stacking.

{{< code-sp4 >}}

```cs
ScottPlot.Version.ShouldBe(4, 1, 71);
var plt = new ScottPlot.Plot(600, 400);

// create sample data
double[] valuesA = { 1, 2, 3, 2, 1, 2, 1 };
double[] valuesB = { 3, 3, 2, 1, 3, 2, 1 };

// to simulate stacking B on A, shift B up by A
double[] valuesB2 = new double[valuesB.Length];
for (int i = 0; i < valuesB.Length; i++)
    valuesB2[i] = valuesA[i] + valuesB[i];

// plot the bar charts in reverse order (highest first)
plt.AddBar(valuesB2);
plt.AddBar(valuesA);

// adjust axis limits so there is no padding below the bar graph
plt.SetAxisLimits(yMin: 0);

plt.SaveFig("bar_stacked.png");
```

{{< /code-sp4 >}}

<img src='../../images/bar_stacked.png' class='d-block mx-auto my-5' />


