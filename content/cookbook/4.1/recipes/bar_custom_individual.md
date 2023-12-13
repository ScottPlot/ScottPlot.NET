---
Title: "Custom Individual Bars - ScottPlot 4.1 Cookbook"
Description: "Extreme customization can be achieved by placing each bar manually and adjusting its styling properties individually."
Date: 2023-12-13
Version: ScottPlot 4.1.69
URL: /cookbook/4.1/recipes/bar_custom_individual/
BreadcrumbNames: ["ScottPlot 4.1 Cookbook", "Bar Graph", "Custom Individual Bars"]
BreadcrumbUrls: ["/cookbook/4.1/", "/cookbook/4.1/category/plottable-bar-graph", "/cookbook/4.1/recipes/bar_custom_individual/"]
SearchUrl: "/cookbook/4.1/search/"
OgImage: "/cookbook/4.1/images/bar_custom_individual.png"
---

<h2><a id='custom-individual-bars' href='/cookbook/4.1/recipes/bar_custom_individual/'>Custom Individual Bars</a></h2>

Extreme customization can be achieved by placing each bar manually and adjusting its styling properties individually.

```cs
var plt = new ScottPlot.Plot(600, 400);

// place bars simulating groups with manually defined colors
plt.AddBar(-1, 15, 3, Color.Red);
plt.AddBar(0, 17, 4, Color.Orange);
plt.AddBar(1, 13, 5, Color.Yellow);

plt.AddBar(3, 14, 3, Color.Green);
plt.AddBar(4, 15, 4, Color.Blue);
var lastBar = plt.AddBar(5, 16, 5, Color.Violet);

// bars can be further customized individually
lastBar.HatchStyle = Drawing.HatchStyle.LargeCheckerBoard;
lastBar.BorderLineWidth = 3;
lastBar.ErrorCapSize = 0.2;
lastBar.ErrorLineWidth = 2;
lastBar.BarWidth = 0.5;

// use manaual tick labels to name groups
double[] tickPositions = { 0, 4 };
string[] tickLabels = { "Group 1", "Group 2" };
plt.BottomAxis.ManualTickPositions(tickPositions, tickLabels);

// adjust axis limits so the view starts at zero
plt.SetAxisLimits(yMin: 0);

plt.SaveFig("bar_custom_individual.png");
```

<img src='../../images/bar_custom_individual.png' class='d-block mx-auto my-5' />


