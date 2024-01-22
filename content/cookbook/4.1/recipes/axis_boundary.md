---
Title: "Axis Boundary - ScottPlot 4.1 Cookbook"
Description: "Axes can be given boundaries which prevent the user from panning outside a given range."
Date: 2024-01-21
Version: ScottPlot 4.1.71
URL: /cookbook/4.1/recipes/axis_boundary/
BreadcrumbNames: ["ScottPlot 4.1 Cookbook", "Axis and Ticks", "Axis Boundary"]
BreadcrumbUrls: ["/cookbook/4.1/", "/cookbook/4.1/category/axis-and-ticks", "/cookbook/4.1/recipes/axis_boundary/"]
SearchUrl: "/cookbook/4.1/search/"
OgImage: "/cookbook/4.1/images/axis_boundary.png"
---

<h2><a id='axis-boundary' href='/cookbook/4.1/recipes/axis_boundary/'>Axis Boundary</a></h2>

Axes can be given boundaries which prevent the user from panning outside a given range.

{{< code-sp4 >}}

```cs
ScottPlot.Version.ShouldBe(4, 1, 71);
var plt = new ScottPlot.Plot(600, 400);

plt.AddSignal(DataGen.Sin(51));
plt.AddSignal(DataGen.Cos(51));

plt.YAxis.SetBoundary(-2, 2);
plt.XAxis.SetBoundary(-10, 60);

plt.SaveFig("Axis_boundary.png");
```

{{< /code-sp4 >}}

<img src='../../images/axis_boundary.png' class='d-block mx-auto my-5' />


