---
Title: "Tooltip Quickstart - ScottPlot 4.1 Cookbook"
Description: "Tooltips are annotations that point to an X/Y coordinate on the plot"
Date: 2024-01-21
Version: ScottPlot 4.1.71
URL: /cookbook/4.1/recipes/tooltip_quickstart/
BreadcrumbNames: ["ScottPlot 4.1 Cookbook", "Tooltip", "Tooltip Quickstart"]
BreadcrumbUrls: ["/cookbook/4.1/", "/cookbook/4.1/category/plottable-tooltip", "/cookbook/4.1/recipes/tooltip_quickstart/"]
SearchUrl: "/cookbook/4.1/search/"
OgImage: "/cookbook/4.1/images/tooltip_quickstart.png"
---

<h2><a id='tooltip-quickstart' href='/cookbook/4.1/recipes/tooltip_quickstart/'>Tooltip Quickstart</a></h2>

Tooltips are annotations that point to an X/Y coordinate on the plot

{{< code-sp4 >}}

```cs
ScottPlot.Version.ShouldBe(4, 1, 71);
var plt = new ScottPlot.Plot(600, 400);

double[] ys = DataGen.Sin(50);
plt.AddSignal(ys);

plt.AddTooltip(label: "Special Point", x: 17, y: ys[17]);

plt.SaveFig("tooltip_quickstart.png");
```

{{< /code-sp4 >}}

<img src='../../images/tooltip_quickstart.png' class='d-block mx-auto my-5' />


