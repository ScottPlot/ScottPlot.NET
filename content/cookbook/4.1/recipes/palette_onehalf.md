---
Title: "OneHalf - ScottPlot 4.1 Cookbook"
Description: "OneHalf is a 7-color palette sourced from Sublime"
Date: 2024-01-21
Version: ScottPlot 4.1.71
URL: /cookbook/4.1/recipes/palette_onehalf/
BreadcrumbNames: ["ScottPlot 4.1 Cookbook", "Palette", "OneHalf"]
BreadcrumbUrls: ["/cookbook/4.1/", "/cookbook/4.1/category/palette", "/cookbook/4.1/recipes/palette_onehalf/"]
SearchUrl: "/cookbook/4.1/search/"
OgImage: "/cookbook/4.1/images/palette_onehalf.png"
---

<h2><a id='onehalf' href='/cookbook/4.1/recipes/palette_onehalf/'>OneHalf</a></h2>

OneHalf is a 7-color palette sourced from Sublime

{{< code-sp4 >}}

```cs
ScottPlot.Version.ShouldBe(4, 1, 71);
var plt = new ScottPlot.Plot(600, 400);

plt.Palette = ScottPlot.Palette.OneHalf;

for (int i = 0; i < plt.Palette.Count(); i++)
{
    double[] xs = DataGen.Consecutive(100);
    double[] ys = DataGen.Sin(100, phase: -i * .5 / plt.Palette.Count());
    plt.AddScatterLines(xs, ys, lineWidth: 3);
}

plt.Title($"{plt.Palette}");
plt.AxisAuto(0, 0.1);

plt.SaveFig("palette_OneHalf.png");
```

{{< /code-sp4 >}}

<img src='../../images/palette_onehalf.png' class='d-block mx-auto my-5' />


