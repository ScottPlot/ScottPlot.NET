---
Title: "Multiplier Notation - ScottPlot 4.1 Cookbook"
Description: "Multiplier notation keeps tick labels small when plotting large data values. This style is also called engineering notation or scientific notation."
Date: 2024-01-14
Version: ScottPlot 4.1.70
URL: /cookbook/4.1/recipes/ticks_multiplier/
BreadcrumbNames: ["ScottPlot 4.1 Cookbook", "Advanced Axis Features", "Multiplier Notation"]
BreadcrumbUrls: ["/cookbook/4.1/", "/cookbook/4.1/category/advanced-axis-features", "/cookbook/4.1/recipes/ticks_multiplier/"]
SearchUrl: "/cookbook/4.1/search/"
OgImage: "/cookbook/4.1/images/ticks_multiplier.png"
---

<h2><a id='multiplier-notation' href='/cookbook/4.1/recipes/ticks_multiplier/'>Multiplier Notation</a></h2>

Multiplier notation keeps tick labels small when plotting large data values. This style is also called engineering notation or scientific notation.

{{< code-sp4 >}}

```cs
ScottPlot.Version.ShouldBe(4, 1, 70);
var plt = new ScottPlot.Plot(600, 400);

plt.AddLine(-1e5, -1e10, 1e5, 1e10);

plt.XAxis.TickLabelNotation(multiplier: true);
plt.YAxis.TickLabelNotation(multiplier: true);

plt.SaveFig("ticks_multiplier.png");
```

{{< /code-sp4 >}}

<img src='../../images/ticks_multiplier.png' class='d-block mx-auto my-5' />


