---
Title: "Frameless Plots - ScottPlot 4.1 Cookbook"
Description: "Frameless plots can display data that appraoches the edge of the figure."
Date: 12/11/2023 7:52:02 PM
Version: ScottPlot 4.1.69
URL: /cookbook/4.1/recipes/asis_frameless/
BreadcrumbNames: ["ScottPlot 4.1 Cookbook", "Axis and Ticks", "Frameless Plots"]
BreadcrumbUrls: ["/cookbook/4.1/", "/cookbook/4.1/category/axis-and-ticks", "/cookbook/4.1/recipes/asis_frameless/"]
SearchUrl: "/cookbook/4.1/search/"
OgImage: "/cookbook/4.1/images/asis_frameless.png"
---

<h2><a href='/cookbook/4.1/recipes/asis_frameless/'>Frameless Plots</a></h2>

Frameless plots can display data that appraoches the edge of the figure.

```cs
var plt = new ScottPlot.Plot(600, 400);

plt.AddSignal(DataGen.Sin(51));
plt.AddSignal(DataGen.Cos(51));
plt.AxisAuto(0, 0); // zero margin between data and edge of plot
plt.Frameless();

plt.SaveFig("asis_frameless.png");
```

<img src='../../images/asis_frameless.png' class='d-block mx-auto my-5' />

