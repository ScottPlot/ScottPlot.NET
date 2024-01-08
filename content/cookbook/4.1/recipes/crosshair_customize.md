---
Title: "Crosshair Customization - ScottPlot 4.1 Cookbook"
Description: "Crosshair styling and label formatting can be customized by accessing public fields."
Date: 2024-01-07
Version: ScottPlot 4.1.70
URL: /cookbook/4.1/recipes/crosshair_customize/
BreadcrumbNames: ["ScottPlot 4.1 Cookbook", "Crosshair", "Crosshair Customization"]
BreadcrumbUrls: ["/cookbook/4.1/", "/cookbook/4.1/category/plottable-crosshair", "/cookbook/4.1/recipes/crosshair_customize/"]
SearchUrl: "/cookbook/4.1/search/"
OgImage: "/cookbook/4.1/images/crosshair_customize.png"
---

<h2><a id='crosshair-customization' href='/cookbook/4.1/recipes/crosshair_customize/'>Crosshair Customization</a></h2>

Crosshair styling and label formatting can be customized by accessing public fields.

```cs
ScottPlot.Version.ShouldBe(4, 1, 70);
var plt = new ScottPlot.Plot(600, 400);

plt.Title("Customized Crosshair");
plt.XLabel("Horizontal Axis");
plt.YLabel("Vertical Axis");

plt.AddSignal(ScottPlot.DataGen.Sin(51));
plt.AddSignal(ScottPlot.DataGen.Cos(51));

var ch = plt.AddCrosshair(42, 0.48);

// you can style both lines at the same time
ch.LineStyle = LineStyle.Dash;
ch.Color = System.Drawing.Color.Blue;
ch.LineWidth = 2;

// or reach in and style lines individually
ch.HorizontalLine.PositionLabelFont.Size = 16;
ch.VerticalLine.PositionLabelFont.Size = 8;
ch.VerticalLine.LineStyle = LineStyle.Dot;

plt.SaveFig("crosshair_customize.png");
```

<img src='../../images/crosshair_customize.png' class='d-block mx-auto my-5' />


