---
Title: "Axis Customizations - ScottPlot 4.1 Cookbook"
Description: "Axes can be customized different ways. Axis labels and colors are the most common types of customizations."
Date: 2024-01-14
Version: ScottPlot 4.1.70
URL: /cookbook/4.1/recipes/axis_label/
BreadcrumbNames: ["ScottPlot 4.1 Cookbook", "Axis and Ticks", "Axis Customizations"]
BreadcrumbUrls: ["/cookbook/4.1/", "/cookbook/4.1/category/axis-and-ticks", "/cookbook/4.1/recipes/axis_label/"]
SearchUrl: "/cookbook/4.1/search/"
OgImage: "/cookbook/4.1/images/axis_label.png"
---

<h2><a id='axis-customizations' href='/cookbook/4.1/recipes/axis_label/'>Axis Customizations</a></h2>

Axes can be customized different ways. Axis labels and colors are the most common types of customizations.

{{< code-sp4 >}}

```cs
ScottPlot.Version.ShouldBe(4, 1, 70);
var plt = new ScottPlot.Plot(600, 400);

// plot sample data
plt.AddSignal(DataGen.Sin(51));
plt.AddSignal(DataGen.Cos(51));

// These shortcuts are the easiest way to set axis labels
plt.XLabel("Horizontal Axis");
plt.YLabel("Vertical Axis");
plt.Title("Axis Customization");

// Axes labels can be further customized for any axis
plt.YAxis.Label("Vertical Axis", Color.Magenta, size: 24, fontName: "Comic Sans MS");

// This method will set the color of axis labels, lines, ticks, and tick labels
plt.XAxis.Color(Color.Green);

plt.SaveFig("Axis_label.png");
```

{{< /code-sp4 >}}

<img src='../../images/axis_label.png' class='d-block mx-auto my-5' />


