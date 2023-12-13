---
Title: "Advanced Grid Customization - ScottPlot 4.1 Cookbook"
Description: "Grid lines can be extensively customized using various configuration methods."
Date: 2023-12-13
Version: ScottPlot 4.1.69
URL: /cookbook/4.1/recipes/asis_gridadvanced/
BreadcrumbNames: ["ScottPlot 4.1 Cookbook", "Advanced Axis Features", "Advanced Grid Customization"]
BreadcrumbUrls: ["/cookbook/4.1/", "/cookbook/4.1/category/advanced-axis-features", "/cookbook/4.1/recipes/asis_gridadvanced/"]
SearchUrl: "/cookbook/4.1/search/"
OgImage: "/cookbook/4.1/images/asis_gridadvanced.png"
---

<h2><a id='advanced-grid-customization' href='/cookbook/4.1/recipes/asis_gridadvanced/'>Advanced Grid Customization</a></h2>

Grid lines can be extensively customized using various configuration methods.

```cs
var plt = new ScottPlot.Plot(600, 400);

// plot sample data
plt.AddSignal(DataGen.Sin(51));
plt.AddSignal(DataGen.Cos(51));

// advanced grid customizations are available by accessing Axes directly
plt.XAxis.MajorGrid(color: Color.FromArgb(100, Color.Black));
plt.XAxis.MinorGrid(enable: true, color: Color.FromArgb(20, Color.Black));
plt.YAxis.MajorGrid(lineWidth: 2, lineStyle: LineStyle.Dash, color: Color.Magenta);

plt.SaveFig("asis_gridAdvanced.png");
```

<img src='../../images/asis_gridadvanced.png' class='d-block mx-auto my-5' />


