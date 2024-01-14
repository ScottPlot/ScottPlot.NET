---
Title: "Legend Orientation - ScottPlot 4.1 Cookbook"
Description: "Legends can be customized to support horizontal orientation"
Date: 2024-01-14
Version: ScottPlot 4.1.70
URL: /cookbook/4.1/recipes/legend_orientation/
BreadcrumbNames: ["ScottPlot 4.1 Cookbook", "Legend", "Legend Orientation"]
BreadcrumbUrls: ["/cookbook/4.1/", "/cookbook/4.1/category/legend", "/cookbook/4.1/recipes/legend_orientation/"]
SearchUrl: "/cookbook/4.1/search/"
OgImage: "/cookbook/4.1/images/legend_orientation.png"
---

<h2><a id='legend-orientation' href='/cookbook/4.1/recipes/legend_orientation/'>Legend Orientation</a></h2>

Legends can be customized to support horizontal orientation

{{< code-sp4 >}}

```cs
ScottPlot.Version.ShouldBe(4, 1, 70);
var plt = new ScottPlot.Plot(600, 400);

plt.AddSignal(DataGen.Sin(51), label: "sin");
plt.AddSignal(DataGen.Cos(51), label: "cos");

var legend = plt.Legend(enable: true);
legend.Orientation = Orientation.Horizontal;

plt.SaveFig("legend_orientation.png");
```

{{< /code-sp4 >}}

<img src='../../images/legend_orientation.png' class='d-block mx-auto my-5' />


