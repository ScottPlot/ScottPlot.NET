---
Title: "Colorbar on Left - ScottPlot 4.1 Cookbook"
Description: "A colorbar may be added to the left side of the chart"
Date: 2023-12-28
Version: ScottPlot 4.1.70
URL: /cookbook/4.1/recipes/colorbar_left/
BreadcrumbNames: ["ScottPlot 4.1 Cookbook", "Colorbar", "Colorbar on Left"]
BreadcrumbUrls: ["/cookbook/4.1/", "/cookbook/4.1/category/plottable-colorbar", "/cookbook/4.1/recipes/colorbar_left/"]
SearchUrl: "/cookbook/4.1/search/"
OgImage: "/cookbook/4.1/images/colorbar_left.png"
---

<h2><a id='colorbar-on-left' href='/cookbook/4.1/recipes/colorbar_left/'>Colorbar on Left</a></h2>

A colorbar may be added to the left side of the chart

```cs
var plt = new ScottPlot.Plot(600, 400);

plt.AddColorbar(rightSide: false);

plt.SaveFig("colorbar_left.png");
```

<img src='../../images/colorbar_left.png' class='d-block mx-auto my-5' />


