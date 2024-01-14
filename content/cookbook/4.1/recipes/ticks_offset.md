---
Title: "Offset Notation - ScottPlot 4.1 Cookbook"
Description: "Offset notation keeps tick labels small when plotting large data values that are close together."
Date: 2024-01-14
Version: ScottPlot 4.1.70
URL: /cookbook/4.1/recipes/ticks_offset/
BreadcrumbNames: ["ScottPlot 4.1 Cookbook", "Advanced Axis Features", "Offset Notation"]
BreadcrumbUrls: ["/cookbook/4.1/", "/cookbook/4.1/category/advanced-axis-features", "/cookbook/4.1/recipes/ticks_offset/"]
SearchUrl: "/cookbook/4.1/search/"
OgImage: "/cookbook/4.1/images/ticks_offset.png"
---

<h2><a id='offset-notation' href='/cookbook/4.1/recipes/ticks_offset/'>Offset Notation</a></h2>

Offset notation keeps tick labels small when plotting large data values that are close together.

{{< code-sp4 >}}

```cs
ScottPlot.Version.ShouldBe(4, 1, 70);
var plt = new ScottPlot.Plot(600, 400);

plt.AddLine(1e5 + 111, 1e10 + 111, 1e5 + 222, 1e10 + 222);

plt.XAxis.TickLabelNotation(offset: true);
plt.YAxis.TickLabelNotation(offset: true);

plt.SaveFig("ticks_offset.png");
```

{{< /code-sp4 >}}

<img src='../../images/ticks_offset.png' class='d-block mx-auto my-5' />


