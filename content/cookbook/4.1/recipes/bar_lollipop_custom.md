---
Title: "Lollipop Plot Customizations - ScottPlot 4.1 Cookbook"
Description: "Lollipop plots can be extensively customized."
Date: 12/11/2023 7:52:02 PM
Version: ScottPlot 4.1.69
URL: /cookbook/4.1/recipes/bar_lollipop_custom/
BreadcrumbNames: ["ScottPlot 4.1 Cookbook", "Bar Graph", "Lollipop Plot Customizations"]
BreadcrumbUrls: ["/cookbook/4.1/", "/cookbook/4.1/category/plottable-bar-graph", "/cookbook/4.1/recipes/bar_lollipop_custom/"]
SearchUrl: "/cookbook/4.1/search/"
OgImage: "/cookbook/4.1/images/bar_lollipop_custom.png"
---

<h2><a href='/cookbook/4.1/recipes/bar_lollipop_custom/'>Lollipop Plot Customizations</a></h2>

Lollipop plots can be extensively customized.

```cs
var plt = new ScottPlot.Plot(600, 400);

double[] values = { 26, 20, 23, 7, 16 };
var lollipop = plt.AddLollipop(values);
lollipop.Orientation = Orientation.Horizontal;
lollipop.LollipopRadius = 3;
lollipop.BorderColor = Color.Green;
lollipop.LollipopColor = Color.Blue;
lollipop.LollipopRadius = 10;

plt.SaveFig("bar_lollipop_custom.png");
```

<img src='../../images/bar_lollipop_custom.png' class='d-block mx-auto my-5' />

