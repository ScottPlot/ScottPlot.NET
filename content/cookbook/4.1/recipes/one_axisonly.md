---
Title: "One Axis Only - ScottPlot 4.1 Cookbook"
Description: "Axis ticks and lines can be disabled. Note that hiding them in this way preserves their whitespace. Setting XAxis.IsVisible to false would collapse the axis entirely. "
Date: 2024-01-21
Version: ScottPlot 4.1.71
URL: /cookbook/4.1/recipes/one_axisonly/
BreadcrumbNames: ["ScottPlot 4.1 Cookbook", "Axis and Ticks", "One Axis Only"]
BreadcrumbUrls: ["/cookbook/4.1/", "/cookbook/4.1/category/axis-and-ticks", "/cookbook/4.1/recipes/one_axisonly/"]
SearchUrl: "/cookbook/4.1/search/"
OgImage: "/cookbook/4.1/images/one_axisonly.png"
---

<h2><a id='one-axis-only' href='/cookbook/4.1/recipes/one_axisonly/'>One Axis Only</a></h2>

Axis ticks and lines can be disabled. Note that hiding them in this way preserves their whitespace. Setting XAxis.IsVisible to false would collapse the axis entirely. 

{{< code-sp4 >}}

```cs
ScottPlot.Version.ShouldBe(4, 1, 71);
var plt = new ScottPlot.Plot(600, 400);

// plot sample data
plt.AddSignal(DataGen.Sin(51));
plt.AddSignal(DataGen.Cos(51));

// hide just the horizontal axis ticks
plt.XAxis.Ticks(false);

// hide the lines on the bottom, right, and top of the plot
plt.XAxis.Line(false);
plt.YAxis2.Line(false);
plt.XAxis2.Line(false);

plt.SaveFig("one_axisonly.png");
```

{{< /code-sp4 >}}

<img src='../../images/one_axisonly.png' class='d-block mx-auto my-5' />


