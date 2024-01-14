---
Title: "Minimum Tick Spacing - ScottPlot 4.1 Cookbook"
Description: "Minimum tick spacing can be defined such that zooming in does not produce more grid lines, ticks, and tick labels beyond the defined limit."
Date: 2024-01-14
Version: ScottPlot 4.1.70
URL: /cookbook/4.1/recipes/asis_minimumtickspacing/
BreadcrumbNames: ["ScottPlot 4.1 Cookbook", "Advanced Axis Features", "Minimum Tick Spacing"]
BreadcrumbUrls: ["/cookbook/4.1/", "/cookbook/4.1/category/advanced-axis-features", "/cookbook/4.1/recipes/asis_minimumtickspacing/"]
SearchUrl: "/cookbook/4.1/search/"
OgImage: "/cookbook/4.1/images/asis_minimumtickspacing.png"
---

<h2><a id='minimum-tick-spacing' href='/cookbook/4.1/recipes/asis_minimumtickspacing/'>Minimum Tick Spacing</a></h2>

Minimum tick spacing can be defined such that zooming in does not produce more grid lines, ticks, and tick labels beyond the defined limit.

{{< code-sp4 >}}

```cs
ScottPlot.Version.ShouldBe(4, 1, 70);
var plt = new ScottPlot.Plot(600, 400);

plt.AddSignal(DataGen.Sin(51));
plt.AddSignal(DataGen.Cos(51));

plt.YAxis.MinimumTickSpacing(1);
plt.XAxis.MinimumTickSpacing(25);

plt.SaveFig("asis_minimumTickSpacing.png");
```

{{< /code-sp4 >}}

<img src='../../images/asis_minimumtickspacing.png' class='d-block mx-auto my-5' />


