---
Title: "PolarNight - ScottPlot 4.1 Cookbook"
Description: "PolarNight is a 4-color palette sourced from Nord. This palette is optimized for a dark background."
Date: 12/11/2023 7:52:02 PM
Version: ScottPlot 4.1.69
URL: /cookbook/4.1/recipes/palette_polarnight/
BreadcrumbNames: ["ScottPlot 4.1 Cookbook", "Palette", "PolarNight"]
BreadcrumbUrls: ["/cookbook/4.1/", "/cookbook/4.1/category/palette", "/cookbook/4.1/recipes/palette_polarnight/"]
SearchUrl: "/cookbook/4.1/search/"
OgImage: "/cookbook/4.1/images/palette_polarnight.png"
---

<h2><a href='/cookbook/4.1/recipes/palette_polarnight/'>PolarNight</a></h2>

PolarNight is a 4-color palette sourced from Nord. This palette is optimized for a dark background.

```cs
var plt = new ScottPlot.Plot(600, 400);

plt.Palette = ScottPlot.Palette.PolarNight;

for (int i = 0; i < plt.Palette.Count(); i++)
{
    double[] xs = DataGen.Consecutive(100);
    double[] ys = DataGen.Sin(100, phase: -i * .5 / plt.Palette.Count());
    plt.AddScatterLines(xs, ys, lineWidth: 3);
}

plt.Title($"{plt.Palette}");
plt.AxisAuto(0, 0.1);
plt.Style(ScottPlot.Style.Blue2);

plt.SaveFig("palette_PolarNight.png");
```

<img src='../../images/palette_polarnight.png' class='d-block mx-auto my-5' />


