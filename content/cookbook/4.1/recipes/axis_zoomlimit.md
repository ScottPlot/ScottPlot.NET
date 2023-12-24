---
Title: "Axis Zoom Limit - ScottPlot 4.1 Cookbook"
Description: "Axes can be given a zoom limit which allows the user to pan everywhere but never zoom in beyond a given span"
Date: 2023-12-24
Version: ScottPlot 4.1.69
URL: /cookbook/4.1/recipes/axis_zoomlimit/
BreadcrumbNames: ["ScottPlot 4.1 Cookbook", "Axis and Ticks", "Axis Zoom Limit"]
BreadcrumbUrls: ["/cookbook/4.1/", "/cookbook/4.1/category/axis-and-ticks", "/cookbook/4.1/recipes/axis_zoomlimit/"]
SearchUrl: "/cookbook/4.1/search/"
OgImage: "/cookbook/4.1/images/axis_zoomlimit.png"
---

<h2><a id='axis-zoom-limit' href='/cookbook/4.1/recipes/axis_zoomlimit/'>Axis Zoom Limit</a></h2>

Axes can be given a zoom limit which allows the user to pan everywhere but never zoom in beyond a given span

```cs
var plt = new ScottPlot.Plot(600, 400);

plt.AddSignal(DataGen.Sin(51));
plt.AddSignal(DataGen.Cos(51));

plt.YAxis.SetZoomInLimit(2);
plt.XAxis.SetZoomInLimit(50);

plt.SaveFig("Axis_zoomLimit.png");
```

<img src='../../images/axis_zoomlimit.png' class='d-block mx-auto my-5' />


