---
Title: "Forest Plot - ScottPlot 4.1 Cookbook"
Description: "Scatter plots can be used to create forest plots, which are useful for showing the agreement between multiple estimates."
Date: 2023-12-24
Version: ScottPlot 4.1.69
URL: /cookbook/4.1/recipes/scatter_forest/
BreadcrumbNames: ["ScottPlot 4.1 Cookbook", "Scatter Plot", "Forest Plot"]
BreadcrumbUrls: ["/cookbook/4.1/", "/cookbook/4.1/category/plottable-scatter-plot", "/cookbook/4.1/recipes/scatter_forest/"]
SearchUrl: "/cookbook/4.1/search/"
OgImage: "/cookbook/4.1/images/scatter_forest.png"
---

<h2><a id='forest-plot' href='/cookbook/4.1/recipes/scatter_forest/'>Forest Plot</a></h2>

Scatter plots can be used to create forest plots, which are useful for showing the agreement between multiple estimates.

```cs
var plt = new ScottPlot.Plot(600, 400);

var plot1 = plt.AddScatter(new double[] { 2.5 }, new double[] { 5 }, label: "John Doe et al.");
plot1.XError = new double[] { 0.2 };

var plot2 = plt.AddScatter(new double[] { 2.7 }, new double[] { 4 }, label: "Jane Doe et al.");
plot2.XError = new double[] { 0.3 };

var plot3 = plt.AddScatter(new double[] { 2.3 }, new double[] { 3 }, label: "Jim Doe et al.");
plot3.XError = new double[] { 0.6 };

var plot4 = plt.AddScatter(new double[] { 2.8 }, new double[] { 2 }, label: "Joel Doe et al.");
plot4.XError = new double[] { 0.3 };

var plot5 = plt.AddScatter(new double[] { 2.5 }, new double[] { 1 }, label: "Jacqueline Doe et al.");
plot5.XError = new double[] { 0.2 };

plt.AddVerticalLine(2.6, style: LineStyle.Dash);

plt.SetAxisLimits(0, 5, 0, 6);
plt.Legend();

plt.SaveFig("scatter_forest.png");
```

<img src='../../images/scatter_forest.png' class='d-block mx-auto my-5' />


