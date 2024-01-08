---
Title: "Negative Bar Colors - ScottPlot 4.1 Cookbook"
Description: "Bars with negative values can be colored differently than positive ones."
Date: 2024-01-07
Version: ScottPlot 4.1.70
URL: /cookbook/4.1/recipes/bar_ynegcolor/
BreadcrumbNames: ["ScottPlot 4.1 Cookbook", "Bar Graph", "Negative Bar Colors"]
BreadcrumbUrls: ["/cookbook/4.1/", "/cookbook/4.1/category/plottable-bar-graph", "/cookbook/4.1/recipes/bar_ynegcolor/"]
SearchUrl: "/cookbook/4.1/search/"
OgImage: "/cookbook/4.1/images/bar_ynegcolor.png"
---

<h2><a id='negative-bar-colors' href='/cookbook/4.1/recipes/bar_ynegcolor/'>Negative Bar Colors</a></h2>

Bars with negative values can be colored differently than positive ones.

```cs
ScottPlot.Version.ShouldBe(4, 1, 70);
var plt = new ScottPlot.Plot(600, 400);

double[] values = { 23, -17, 19, -24, 22 };

var bar = plt.AddBar(values);
bar.FillColor = Color.Green;
bar.FillColorNegative = Color.Red;

plt.SaveFig("bar_yNegColor.png");
```

<img src='../../images/bar_ynegcolor.png' class='d-block mx-auto my-5' />


