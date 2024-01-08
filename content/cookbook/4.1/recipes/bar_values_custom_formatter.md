---
Title: "Custom Value Formatter - ScottPlot 4.1 Cookbook"
Description: "A custom formatter can be used to generate labels above each bar using the numeric value of the bar itself."
Date: 2024-01-07
Version: ScottPlot 4.1.70
URL: /cookbook/4.1/recipes/bar_values_custom_formatter/
BreadcrumbNames: ["ScottPlot 4.1 Cookbook", "Bar Graph", "Custom Value Formatter"]
BreadcrumbUrls: ["/cookbook/4.1/", "/cookbook/4.1/category/plottable-bar-graph", "/cookbook/4.1/recipes/bar_values_custom_formatter/"]
SearchUrl: "/cookbook/4.1/search/"
OgImage: "/cookbook/4.1/images/bar_values_custom_formatter.png"
---

<h2><a id='custom-value-formatter' href='/cookbook/4.1/recipes/bar_values_custom_formatter/'>Custom Value Formatter</a></h2>

A custom formatter can be used to generate labels above each bar using the numeric value of the bar itself.

```cs
ScottPlot.Version.ShouldBe(4, 1, 70);
var plt = new ScottPlot.Plot(600, 400);

Func<double, string> customFormatter = y => $"Y={y:N2}";

double[] values = { 27.3, 23.1, 21.2, 16.1, 6.4, 19.2, 18.7, 17.3, 20.3, 13.1 };
var bar = plt.AddBar(values);
bar.ShowValuesAboveBars = true;
bar.ValueFormatter = customFormatter;

plt.SetAxisLimits(yMin: 0);

plt.SaveFig("bar_values_custom_formatter.png");
```

<img src='../../images/bar_values_custom_formatter.png' class='d-block mx-auto my-5' />


