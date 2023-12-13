---
Title: "Custom - ScottPlot 4.1 Cookbook"
Description: "A custom palette can be created from an array of HTML color values. These colors will be used as the default colors for new plottables added to the plot."
Date: 2023-12-13
Version: ScottPlot 4.1.69
URL: /cookbook/4.1/recipes/palette_custom/
BreadcrumbNames: ["ScottPlot 4.1 Cookbook", "Palette", "Custom"]
BreadcrumbUrls: ["/cookbook/4.1/", "/cookbook/4.1/category/palette", "/cookbook/4.1/recipes/palette_custom/"]
SearchUrl: "/cookbook/4.1/search/"
OgImage: "/cookbook/4.1/images/palette_custom.png"
---

<h2><a id='custom' href='/cookbook/4.1/recipes/palette_custom/'>Custom</a></h2>

A custom palette can be created from an array of HTML color values. These colors will be used as the default colors for new plottables added to the plot.

```cs
var plt = new ScottPlot.Plot(600, 400);

// custom colors generated using "i want hue" http://medialab.github.io/iwanthue/
string[] customColors = { "#019d9f", "#7d3091", "#57e075", "#e5b5fa", "#009118" };

// create a custom palette and set it in the plot module
plt.Palette = ScottPlot.Palette.FromHtmlColors(customColors);

for (int i = 0; i < plt.Palette.Count(); i++)
{
    double[] xs = DataGen.Consecutive(100);
    double[] ys = DataGen.Sin(100, phase: -i * .5 / plt.Palette.Count());
    plt.AddScatterLines(xs, ys, lineWidth: 3);
}

plt.Title($"{plt.Palette}");
plt.AxisAuto(0, 0.1);

plt.SaveFig("palette_Custom.png");
```

<img src='../../images/palette_custom.png' class='d-block mx-auto my-5' />


