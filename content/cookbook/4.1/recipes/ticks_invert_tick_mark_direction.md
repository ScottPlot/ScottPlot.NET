---
Title: "Invert tick mark direction - ScottPlot 4.1 Cookbook"
Description: "Tick marks can be outward (default) or inverted to appear as inward lines relative to the edge of the plot area."
Date: 2024-01-21
Version: ScottPlot 4.1.71
URL: /cookbook/4.1/recipes/ticks_invert_tick_mark_direction/
BreadcrumbNames: ["ScottPlot 4.1 Cookbook", "Advanced Axis Features", "Invert tick mark direction"]
BreadcrumbUrls: ["/cookbook/4.1/", "/cookbook/4.1/category/advanced-axis-features", "/cookbook/4.1/recipes/ticks_invert_tick_mark_direction/"]
SearchUrl: "/cookbook/4.1/search/"
OgImage: "/cookbook/4.1/images/ticks_invert_tick_mark_direction.png"
---

<h2><a id='invert-tick-mark-direction' href='/cookbook/4.1/recipes/ticks_invert_tick_mark_direction/'>Invert tick mark direction</a></h2>

Tick marks can be outward (default) or inverted to appear as inward lines relative to the edge of the plot area.

{{< code-sp4 >}}

```cs
ScottPlot.Version.ShouldBe(4, 1, 71);
var plt = new ScottPlot.Plot(600, 400);

plt.AddSignal(DataGen.Sin(51));
plt.AddSignal(DataGen.Cos(51));

plt.XAxis.TickMarkDirection(outward: false);
plt.YAxis.TickMarkDirection(outward: false);

plt.SaveFig("ticks_invert_tick_mark_direction.png");
```

{{< /code-sp4 >}}

<img src='../../images/ticks_invert_tick_mark_direction.png' class='d-block mx-auto my-5' />


