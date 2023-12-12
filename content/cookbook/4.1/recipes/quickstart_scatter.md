---
Title: "Scatter Plot - ScottPlot 4.1 Cookbook"
Description: "Scatter plots have paired X/Y points."
Date: 12/11/2023 7:52:02 PM
Version: ScottPlot 4.1.69
URL: /cookbook/4.1/recipes/quickstart_scatter/
BreadcrumbNames: ["ScottPlot 4.1 Cookbook", "Quickstart", "Scatter Plot"]
BreadcrumbUrls: ["/cookbook/4.1/", "/cookbook/4.1/category/quickstart", "/cookbook/4.1/recipes/quickstart_scatter/"]
SearchUrl: "/cookbook/4.1/search/"
OgImage: "/cookbook/4.1/images/quickstart_scatter.png"
---

<h2><a href='/cookbook/4.1/recipes/quickstart_scatter/'>Scatter Plot</a></h2>

Scatter plots have paired X/Y points.

```cs
var plt = new ScottPlot.Plot(600, 400);

// sample data
double[] xs = DataGen.Consecutive(51);
double[] sin = DataGen.Sin(51);
double[] cos = DataGen.Cos(51);

// plot the data
plt.AddScatter(xs, sin);
plt.AddScatter(xs, cos);

// customize the axis labels
plt.Title("ScottPlot Quickstart");
plt.XLabel("Horizontal Axis");
plt.YLabel("Vertical Axis");

plt.SaveFig("quickstart_scatter.png");
```

<img src='../../images/quickstart_scatter.png' class='d-block mx-auto my-5' />


