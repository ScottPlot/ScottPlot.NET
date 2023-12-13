---
Title: "Nord - ScottPlot 4.1 Cookbook"
Description: "Nord is a 7-color palette derived from Aurora source from NordConEmu."
Date: 2023-12-13
Version: ScottPlot 4.1.69
URL: /cookbook/4.1/recipes/palette_nord/
BreadcrumbNames: ["ScottPlot 4.1 Cookbook", "Palette", "Nord"]
BreadcrumbUrls: ["/cookbook/4.1/", "/cookbook/4.1/category/palette", "/cookbook/4.1/recipes/palette_nord/"]
SearchUrl: "/cookbook/4.1/search/"
OgImage: "/cookbook/4.1/images/palette_nord.png"
---

<h2><a id='nord' href='/cookbook/4.1/recipes/palette_nord/'>Nord</a></h2>

Nord is a 7-color palette derived from Aurora source from NordConEmu.

```cs
var plt = new ScottPlot.Plot(600, 400);

plt.Palette = ScottPlot.Palette.Nord;

for (int i = 0; i < plt.Palette.Count(); i++)
{
    double[] xs = DataGen.Consecutive(100);
    double[] ys = DataGen.Sin(100, phase: -i * .5 / plt.Palette.Count());
    plt.AddScatterLines(xs, ys, lineWidth: 3);
}

plt.Title($"{plt.Palette}");
plt.AxisAuto(0, 0.1);

plt.SaveFig("palette_Nord.png");
```

<img src='../../images/palette_nord.png' class='d-block mx-auto my-5' />


