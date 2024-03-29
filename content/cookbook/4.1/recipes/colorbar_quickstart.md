---
Title: "Colorbar - ScottPlot 4.1 Cookbook"
Description: "A colorbar displays a colormap beside the data area. Colorbars are typically added to plots containing heatmaps."
Date: 2024-01-21
Version: ScottPlot 4.1.71
URL: /cookbook/4.1/recipes/colorbar_quickstart/
BreadcrumbNames: ["ScottPlot 4.1 Cookbook", "Colorbar", "Colorbar"]
BreadcrumbUrls: ["/cookbook/4.1/", "/cookbook/4.1/category/plottable-colorbar", "/cookbook/4.1/recipes/colorbar_quickstart/"]
SearchUrl: "/cookbook/4.1/search/"
OgImage: "/cookbook/4.1/images/colorbar_quickstart.png"
---

<h2><a id='colorbar' href='/cookbook/4.1/recipes/colorbar_quickstart/'>Colorbar</a></h2>

A colorbar displays a colormap beside the data area. Colorbars are typically added to plots containing heatmaps.

{{< code-sp4 >}}

```cs
ScottPlot.Version.ShouldBe(4, 1, 71);
var plt = new ScottPlot.Plot(600, 400);

plt.AddColorbar();

// direct attention to the colorbar
var text = plt.AddText("Colorbar", 5, 0, 24, Color.Red);
text.Alignment = Alignment.MiddleRight;
plt.AddArrow(7, 0, 5, 0, color: Color.Red);
plt.SetAxisLimits(-10, 10, -10, 10);

plt.SaveFig("colorbar_quickstart.png");
```

{{< /code-sp4 >}}

<img src='../../images/colorbar_quickstart.png' class='d-block mx-auto my-5' />


