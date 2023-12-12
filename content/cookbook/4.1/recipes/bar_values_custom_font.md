---
Title: "Customizing Value Label Font - ScottPlot 4.1 Cookbook"
Description: "Font styling for bar value labels can be customized."
Date: 12/11/2023 7:52:02 PM
Version: ScottPlot 4.1.69
URL: /cookbook/4.1/recipes/bar_values_custom_font/
BreadcrumbNames: ["ScottPlot 4.1 Cookbook", "Bar Graph", "Customizing Value Label Font"]
BreadcrumbUrls: ["/cookbook/4.1/", "/cookbook/4.1/category/plottable-bar-graph", "/cookbook/4.1/recipes/bar_values_custom_font/"]
SearchUrl: "/cookbook/4.1/search/"
OgImage: "/cookbook/4.1/images/bar_values_custom_font.png"
---

<h2><a href='/cookbook/4.1/recipes/bar_values_custom_font/'>Customizing Value Label Font</a></h2>

Font styling for bar value labels can be customized.

```cs
var plt = new ScottPlot.Plot(600, 400);

double[] values = { 27.3, 23.1, 21.2, 16.1, 6.4, 19.2, 18.7, 17.3, 20.3, 13.1 };

var bar = plt.AddBar(values);
bar.ShowValuesAboveBars = true;
bar.Font.Color = Color.Green;
bar.Font.Size = 18;
bar.Font.Bold = true;

plt.SetAxisLimits(yMin: 0);

plt.SaveFig("bar_values_custom_font.png");
```

<img src='../../images/bar_values_custom_font.png' class='d-block mx-auto my-5' />


