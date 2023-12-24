---
Title: "Bars with Y Offsets - ScottPlot 4.1 Cookbook"
Description: "By default bar graphs start at 0, but this does not have to be the case. Y offsets can be defined for each bar. When Y offsets are used, values represent the height of the bars (relative to their offsets)."
Date: 2023-12-24
Version: ScottPlot 4.1.69
URL: /cookbook/4.1/recipes/bar_yoffset/
BreadcrumbNames: ["ScottPlot 4.1 Cookbook", "Bar Graph", "Bars with Y Offsets"]
BreadcrumbUrls: ["/cookbook/4.1/", "/cookbook/4.1/category/plottable-bar-graph", "/cookbook/4.1/recipes/bar_yoffset/"]
SearchUrl: "/cookbook/4.1/search/"
OgImage: "/cookbook/4.1/images/bar_yoffset.png"
---

<h2><a id='bars-with-y-offsets' href='/cookbook/4.1/recipes/bar_yoffset/'>Bars with Y Offsets</a></h2>

By default bar graphs start at 0, but this does not have to be the case. Y offsets can be defined for each bar. When Y offsets are used, values represent the height of the bars (relative to their offsets).

```cs
var plt = new ScottPlot.Plot(600, 400);

double[] values = { 23, 17, 19, 24, 22 };
double[] yOffsets = { -100, -100, -100, -100, -100 };

var bar = plt.AddBar(values);
bar.ValueOffsets = yOffsets;

// adjust axis limits so there is no padding below the bar graph
plt.SetAxisLimits(yMin: -100);

plt.SaveFig("bar_yoffset.png");
```

<img src='../../images/bar_yoffset.png' class='d-block mx-auto my-5' />


