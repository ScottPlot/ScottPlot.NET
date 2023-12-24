---
Title: "Colorbar Label - ScottPlot 4.1 Cookbook"
Description: "Colorbars have a Label property similar to X and Y axes."
Date: 2023-12-24
Version: ScottPlot 4.1.69
URL: /cookbook/4.1/recipes/colorbar_label/
BreadcrumbNames: ["ScottPlot 4.1 Cookbook", "Colorbar", "Colorbar Label"]
BreadcrumbUrls: ["/cookbook/4.1/", "/cookbook/4.1/category/plottable-colorbar", "/cookbook/4.1/recipes/colorbar_label/"]
SearchUrl: "/cookbook/4.1/search/"
OgImage: "/cookbook/4.1/images/colorbar_label.png"
---

<h2><a id='colorbar-label' href='/cookbook/4.1/recipes/colorbar_label/'>Colorbar Label</a></h2>

Colorbars have a Label property similar to X and Y axes.

```cs
var plt = new ScottPlot.Plot(600, 400);

plt.AddColorbar();

plt.XLabel("Horizontal Axis");
plt.YLabel("Vertical Axis");

var cmap = ScottPlot.Drawing.Colormap.Turbo;
var cb = plt.AddColorbar(cmap);
cb.Label = "Custom Colorbar Label";

plt.SaveFig("colorbar_label.png");
```

<img src='../../images/colorbar_label.png' class='d-block mx-auto my-5' />


