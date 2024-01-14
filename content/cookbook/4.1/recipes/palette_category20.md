---
Title: "Category20 - ScottPlot 4.1 Cookbook"
Description: "This 20-color palette is similar to the default, but optimized for situations where more than 10 plottables are required. Every second color is a lighter version of the color before it. This palette was sourced from Matplotlib."
Date: 2024-01-14
Version: ScottPlot 4.1.70
URL: /cookbook/4.1/recipes/palette_category20/
BreadcrumbNames: ["ScottPlot 4.1 Cookbook", "Palette", "Category20"]
BreadcrumbUrls: ["/cookbook/4.1/", "/cookbook/4.1/category/palette", "/cookbook/4.1/recipes/palette_category20/"]
SearchUrl: "/cookbook/4.1/search/"
OgImage: "/cookbook/4.1/images/palette_category20.png"
---

<h2><a id='category20' href='/cookbook/4.1/recipes/palette_category20/'>Category20</a></h2>

This 20-color palette is similar to the default, but optimized for situations where more than 10 plottables are required. Every second color is a lighter version of the color before it. This palette was sourced from Matplotlib.

{{< code-sp4 >}}

```cs
ScottPlot.Version.ShouldBe(4, 1, 70);
var plt = new ScottPlot.Plot(600, 400);

plt.Palette = ScottPlot.Palette.Category20;

for (int i = 0; i < plt.Palette.Count(); i++)
{
    double[] xs = DataGen.Consecutive(100);
    double[] ys = DataGen.Sin(100, phase: -i * .5 / plt.Palette.Count());
    plt.AddScatterLines(xs, ys, lineWidth: 3);
}

plt.Title($"{plt.Palette}");
plt.AxisAuto(0, 0.1);

plt.SaveFig("palette_Category20.png");
```

{{< /code-sp4 >}}

<img src='../../images/palette_category20.png' class='d-block mx-auto my-5' />


