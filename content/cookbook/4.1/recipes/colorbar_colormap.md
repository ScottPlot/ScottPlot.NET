---
Title: "Colorbar for Colormap - ScottPlot 4.1 Cookbook"
Description: "By default colorbars use the Viridis colormap, but this behavior can be customized and many colormaps are available."
Date: 2024-01-21
Version: ScottPlot 4.1.71
URL: /cookbook/4.1/recipes/colorbar_colormap/
BreadcrumbNames: ["ScottPlot 4.1 Cookbook", "Colorbar", "Colorbar for Colormap"]
BreadcrumbUrls: ["/cookbook/4.1/", "/cookbook/4.1/category/plottable-colorbar", "/cookbook/4.1/recipes/colorbar_colormap/"]
SearchUrl: "/cookbook/4.1/search/"
OgImage: "/cookbook/4.1/images/colorbar_colormap.png"
---

<h2><a id='colorbar-for-colormap' href='/cookbook/4.1/recipes/colorbar_colormap/'>Colorbar for Colormap</a></h2>

By default colorbars use the Viridis colormap, but this behavior can be customized and many colormaps are available.

{{< code-sp4 >}}

```cs
ScottPlot.Version.ShouldBe(4, 1, 71);
var plt = new ScottPlot.Plot(600, 400);

plt.AddColorbar(Drawing.Colormap.Turbo);

// direct attention to the colorbar
var text = plt.AddText("Colorbar", 5, 0, 24, Color.Red);
text.Alignment = Alignment.MiddleRight;
plt.AddArrow(7, 0, 5, 0, color: Color.Red);
plt.SetAxisLimits(-10, 10, -10, 10);

plt.SaveFig("colorbar_colormap.png");
```

{{< /code-sp4 >}}

<img src='../../images/colorbar_colormap.png' class='d-block mx-auto my-5' />


