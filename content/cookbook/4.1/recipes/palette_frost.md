---
Title: "Frost - ScottPlot 4.1 Cookbook"
Description: "Frost is a 4-color palette sourced from Nord."
Date: 2024-01-21
Version: ScottPlot 4.1.71
URL: /cookbook/4.1/recipes/palette_frost/
BreadcrumbNames: ["ScottPlot 4.1 Cookbook", "Palette", "Frost"]
BreadcrumbUrls: ["/cookbook/4.1/", "/cookbook/4.1/category/palette", "/cookbook/4.1/recipes/palette_frost/"]
SearchUrl: "/cookbook/4.1/search/"
OgImage: "/cookbook/4.1/images/palette_frost.png"
---

<h2><a id='frost' href='/cookbook/4.1/recipes/palette_frost/'>Frost</a></h2>

Frost is a 4-color palette sourced from Nord.

{{< code-sp4 >}}

```cs
ScottPlot.Version.ShouldBe(4, 1, 71);
var plt = new ScottPlot.Plot(600, 400);

plt.Palette = ScottPlot.Palette.Frost;

for (int i = 0; i < plt.Palette.Count(); i++)
{
    double[] xs = DataGen.Consecutive(100);
    double[] ys = DataGen.Sin(100, phase: -i * .5 / plt.Palette.Count());
    plt.AddScatterLines(xs, ys, lineWidth: 3);
}

plt.Title($"{plt.Palette}");
plt.AxisAuto(0, 0.1);

plt.SaveFig("palette_Frost.png");
```

{{< /code-sp4 >}}

<img src='../../images/palette_frost.png' class='d-block mx-auto my-5' />


