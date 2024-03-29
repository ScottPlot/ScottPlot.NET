---
Title: "Legend Location - ScottPlot 4.1 Cookbook"
Description: "Legends can be placed at various locations within the plot area"
Date: 2024-01-21
Version: ScottPlot 4.1.71
URL: /cookbook/4.1/recipes/legend_location/
BreadcrumbNames: ["ScottPlot 4.1 Cookbook", "Legend", "Legend Location"]
BreadcrumbUrls: ["/cookbook/4.1/", "/cookbook/4.1/category/legend", "/cookbook/4.1/recipes/legend_location/"]
SearchUrl: "/cookbook/4.1/search/"
OgImage: "/cookbook/4.1/images/legend_location.png"
---

<h2><a id='legend-location' href='/cookbook/4.1/recipes/legend_location/'>Legend Location</a></h2>

Legends can be placed at various locations within the plot area

{{< code-sp4 >}}

```cs
ScottPlot.Version.ShouldBe(4, 1, 71);
var plt = new ScottPlot.Plot(600, 400);

plt.AddSignal(Generate.Sin(), label: "sin");
plt.AddSignal(Generate.Cos(), label: "cos");

var legend = plt.Legend();
legend.Location = Alignment.UpperCenter;

plt.SaveFig("legend_location.png");
```

{{< /code-sp4 >}}

<img src='../../images/legend_location.png' class='d-block mx-auto my-5' />


