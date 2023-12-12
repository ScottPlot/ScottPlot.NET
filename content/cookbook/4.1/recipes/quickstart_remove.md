---
Title: "Remove a Plottable - ScottPlot 4.1 Cookbook"
Description: "Call Remove() to remove a specific plottable."
Date: 12/11/2023 7:52:02 PM
Version: ScottPlot 4.1.69
URL: /cookbook/4.1/recipes/quickstart_remove/
BreadcrumbNames: ["ScottPlot 4.1 Cookbook", "Quickstart", "Remove a Plottable"]
BreadcrumbUrls: ["/cookbook/4.1/", "/cookbook/4.1/category/quickstart", "/cookbook/4.1/recipes/quickstart_remove/"]
SearchUrl: "/cookbook/4.1/search/"
OgImage: "/cookbook/4.1/images/quickstart_remove.png"
---

<h2><a href='/cookbook/4.1/recipes/quickstart_remove/'>Remove a Plottable</a></h2>

Call Remove() to remove a specific plottable.

```cs
var plt = new ScottPlot.Plot(600, 400);

double[] xs = DataGen.Consecutive(51);
double[] sin = DataGen.Sin(51);
double[] cos = DataGen.Cos(51);

var sinPlot = plt.AddScatter(xs, sin, color: Color.Red);
var cosPlot = plt.AddScatter(xs, cos, color: Color.Blue);

plt.Remove(sinPlot);

plt.SaveFig("quickstart_remove.png");
```

<img src='../../images/quickstart_remove.png' class='d-block mx-auto my-5' />


