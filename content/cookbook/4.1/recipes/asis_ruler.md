---
Title: "Ruler mode - ScottPlot 4.1 Cookbook"
Description: "Ruler mode is an alternative way to display axis ticks. It draws long ticks and offsets the tick labels to give the appearance of a ruler."
Date: 2024-01-21
Version: ScottPlot 4.1.71
URL: /cookbook/4.1/recipes/asis_ruler/
BreadcrumbNames: ["ScottPlot 4.1 Cookbook", "Advanced Axis Features", "Ruler mode"]
BreadcrumbUrls: ["/cookbook/4.1/", "/cookbook/4.1/category/advanced-axis-features", "/cookbook/4.1/recipes/asis_ruler/"]
SearchUrl: "/cookbook/4.1/search/"
OgImage: "/cookbook/4.1/images/asis_ruler.png"
---

<h2><a id='ruler-mode' href='/cookbook/4.1/recipes/asis_ruler/'>Ruler mode</a></h2>

Ruler mode is an alternative way to display axis ticks. It draws long ticks and offsets the tick labels to give the appearance of a ruler.

{{< code-sp4 >}}

```cs
ScottPlot.Version.ShouldBe(4, 1, 71);
var plt = new ScottPlot.Plot(600, 400);

plt.AddSignal(DataGen.Sin(51));
plt.AddSignal(DataGen.Cos(51));

plt.XAxis.RulerMode(true);
plt.YAxis.RulerMode(true);

plt.SaveFig("asis_ruler.png");
```

{{< /code-sp4 >}}

<img src='../../images/asis_ruler.png' class='d-block mx-auto my-5' />


