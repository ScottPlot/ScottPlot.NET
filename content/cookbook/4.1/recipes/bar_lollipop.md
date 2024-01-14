---
Title: "Lollipop Plot Quickstart - ScottPlot 4.1 Cookbook"
Description: "Lollipop plots convey the same information as Bar plots but have a different appearance."
Date: 2024-01-14
Version: ScottPlot 4.1.70
URL: /cookbook/4.1/recipes/bar_lollipop/
BreadcrumbNames: ["ScottPlot 4.1 Cookbook", "Bar Graph", "Lollipop Plot Quickstart"]
BreadcrumbUrls: ["/cookbook/4.1/", "/cookbook/4.1/category/plottable-bar-graph", "/cookbook/4.1/recipes/bar_lollipop/"]
SearchUrl: "/cookbook/4.1/search/"
OgImage: "/cookbook/4.1/images/bar_lollipop.png"
---

<h2><a id='lollipop-plot-quickstart' href='/cookbook/4.1/recipes/bar_lollipop/'>Lollipop Plot Quickstart</a></h2>

Lollipop plots convey the same information as Bar plots but have a different appearance.

{{< code-sp4 >}}

```cs
ScottPlot.Version.ShouldBe(4, 1, 70);
var plt = new ScottPlot.Plot(600, 400);

double[] values = { 26, 20, 23, 7, 16 };
plt.AddLollipop(values);

plt.SaveFig("bar_lollipop.png");
```

{{< /code-sp4 >}}

<img src='../../images/bar_lollipop.png' class='d-block mx-auto my-5' />


