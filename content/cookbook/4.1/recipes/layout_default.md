---
Title: "Default Layout - ScottPlot 4.1 Cookbook"
Description: "ScottPlot has many ways to customize the layout. This example demonstrates the default layout, where padding around the data area is automatically determined by measuring the text in the axis labels and tick labels to ensure there is appropriate padding on all sides."
Date: 2024-01-21
Version: ScottPlot 4.1.71
URL: /cookbook/4.1/recipes/layout_default/
BreadcrumbNames: ["ScottPlot 4.1 Cookbook", "Layout", "Default Layout"]
BreadcrumbUrls: ["/cookbook/4.1/", "/cookbook/4.1/category/layout", "/cookbook/4.1/recipes/layout_default/"]
SearchUrl: "/cookbook/4.1/search/"
OgImage: "/cookbook/4.1/images/layout_default.png"
---

<h2><a id='default-layout' href='/cookbook/4.1/recipes/layout_default/'>Default Layout</a></h2>

ScottPlot has many ways to customize the layout. This example demonstrates the default layout, where padding around the data area is automatically determined by measuring the text in the axis labels and tick labels to ensure there is appropriate padding on all sides.

{{< code-sp4 >}}

```cs
ScottPlot.Version.ShouldBe(4, 1, 71);
var plt = new ScottPlot.Plot(600, 400);

plt.AddSignal(DataGen.Sin(51));
plt.AddSignal(DataGen.Cos(51));
plt.XLabel("Horizontal Axis");
plt.YLabel("Vertical Axis");
plt.Title("Plot Title");

plt.SaveFig("layout_default.png");
```

{{< /code-sp4 >}}

<img src='../../images/layout_default.png' class='d-block mx-auto my-5' />


