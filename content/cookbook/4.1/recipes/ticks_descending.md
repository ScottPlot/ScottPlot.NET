---
Title: "Descending Ticks - ScottPlot 4.1 Cookbook"
Description: "Axis tick labels can be inverted in sign to give the apperance of a reversed axis."
Date: 12/11/2023 8:13:09 PM
Version: ScottPlot 4.1.69
URL: /cookbook/4.1/recipes/ticks_descending/
BreadcrumbNames: ["ScottPlot 4.1 Cookbook", "Advanced Axis Features", "Descending Ticks"]
BreadcrumbUrls: ["/cookbook/4.1/", "/cookbook/4.1/category/advanced-axis-features", "/cookbook/4.1/recipes/ticks_descending/"]
SearchUrl: "/cookbook/4.1/search/"
OgImage: "/cookbook/4.1/images/ticks_descending.png"
---

<h2><a id='descending-ticks' href='/cookbook/4.1/recipes/ticks_descending/'>Descending Ticks</a></h2>

Axis tick labels can be inverted in sign to give the apperance of a reversed axis.

```cs
var plt = new ScottPlot.Plot(600, 400);

plt.AddSignal(DataGen.Sin(51), label: "sin");
plt.AddSignal(DataGen.Cos(51), label: "cos");
plt.Legend();

plt.XAxis.TickLabelNotation(invertSign: true);
plt.YAxis.TickLabelNotation(invertSign: true);

plt.SaveFig("ticks_descending.png");
```

<img src='../../images/ticks_descending.png' class='d-block mx-auto my-5' />


