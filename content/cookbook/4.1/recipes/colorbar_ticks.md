---
Title: "Colorbar Ticks - ScottPlot 4.1 Cookbook"
Description: "Tick marks can be added to colorbars. Each tick is described by a position (a fraction of the distance from the bottom to the top) and a string (the tick label)."
Date: 12/11/2023 8:13:10 PM
Version: ScottPlot 4.1.69
URL: /cookbook/4.1/recipes/colorbar_ticks/
BreadcrumbNames: ["ScottPlot 4.1 Cookbook", "Colorbar", "Colorbar Ticks"]
BreadcrumbUrls: ["/cookbook/4.1/", "/cookbook/4.1/category/plottable-colorbar", "/cookbook/4.1/recipes/colorbar_ticks/"]
SearchUrl: "/cookbook/4.1/search/"
OgImage: "/cookbook/4.1/images/colorbar_ticks.png"
---

<h2><a id='colorbar-ticks' href='/cookbook/4.1/recipes/colorbar_ticks/'>Colorbar Ticks</a></h2>

Tick marks can be added to colorbars. Each tick is described by a position (a fraction of the distance from the bottom to the top) and a string (the tick label).

```cs
var plt = new ScottPlot.Plot(600, 400);

var cb = plt.AddColorbar(Drawing.Colormap.Turbo);

// Add manual ticks (disabling automatic ticks)
cb.AddTick(0, "-123");
cb.AddTick(1, "+123");
cb.AddTick(.5, "0");
cb.AddTick(.25, "-61.5");
cb.AddTick(.75, "+61.5");

// To re-enable automatic ticks call cb.AutomaticTicks(true)

// direct attention to the colorbar
var text = plt.AddText("Colorbar", 5, 0, 24, Color.Red);
text.Alignment = Alignment.MiddleRight;
plt.AddArrow(7, 0, 5, 0, color: Color.Red);
plt.SetAxisLimits(-10, 10, -10, 10);

plt.SaveFig("colorbar_ticks.png");
```

<img src='../../images/colorbar_ticks.png' class='d-block mx-auto my-5' />


