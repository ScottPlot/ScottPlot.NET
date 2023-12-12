---
Title: "X Ticks Width - ScottPlot 4.1 Cookbook"
Description: "This example show how to change the width of the X axe ticks"
Date: 12/11/2023 7:52:02 PM
Version: ScottPlot 4.1.69
URL: /cookbook/4.1/recipes/ticks_width/
BreadcrumbNames: ["ScottPlot 4.1 Cookbook", "Axis and Ticks", "X Ticks Width"]
BreadcrumbUrls: ["/cookbook/4.1/", "/cookbook/4.1/category/axis-and-ticks", "/cookbook/4.1/recipes/ticks_width/"]
SearchUrl: "/cookbook/4.1/search/"
OgImage: "/cookbook/4.1/images/ticks_width.png"
---

<h2><a href='/cookbook/4.1/recipes/ticks_width/'>X Ticks Width</a></h2>

This example show how to change the width of the X axe ticks

```cs
var plt = new ScottPlot.Plot(600, 400);

//Plot sample data
plt.AddSignal(DataGen.Sin(51));

//Change the width of the ticks
plt.XAxis.AxisTicks.MajorLineWidth = 5;
plt.XAxis.AxisTicks.MinorLineWidth = 2;

plt.SaveFig("ticks_width.png");
```

<img src='../../images/ticks_width.png' class='d-block mx-auto my-5' />


