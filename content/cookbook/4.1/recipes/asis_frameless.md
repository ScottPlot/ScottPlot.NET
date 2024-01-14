---
Title: "Frameless Plots - ScottPlot 4.1 Cookbook"
Description: "Frameless plots can display data that appraoches the edge of the figure."
Date: 2024-01-14
Version: ScottPlot 4.1.70
URL: /cookbook/4.1/recipes/asis_frameless/
BreadcrumbNames: ["ScottPlot 4.1 Cookbook", "Axis and Ticks", "Frameless Plots"]
BreadcrumbUrls: ["/cookbook/4.1/", "/cookbook/4.1/category/axis-and-ticks", "/cookbook/4.1/recipes/asis_frameless/"]
SearchUrl: "/cookbook/4.1/search/"
OgImage: "/cookbook/4.1/images/asis_frameless.png"
---

<h2><a id='frameless-plots' href='/cookbook/4.1/recipes/asis_frameless/'>Frameless Plots</a></h2>

Frameless plots can display data that appraoches the edge of the figure.

{{< code-sp4 >}}

```cs
ScottPlot.Version.ShouldBe(4, 1, 70);
var plt = new ScottPlot.Plot(600, 400);

plt.AddSignal(DataGen.Sin(51));
plt.AddSignal(DataGen.Cos(51));
plt.AxisAuto(0, 0); // zero margin between data and edge of plot
plt.Frameless();

plt.SaveFig("asis_frameless.png");
```

{{< /code-sp4 >}}

<img src='../../images/asis_frameless.png' class='d-block mx-auto my-5' />


