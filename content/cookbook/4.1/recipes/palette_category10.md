---
Title: "Category10 - ScottPlot 4.1 Cookbook"
Description: "This 10-color palette is the default colorset used by ScottPlot. It is the same default colorset used by modern versions of Matplotlib (https://matplotlib.org/2.0.2/users/dflt_style_changes.html)"
Date: 2024-01-21
Version: ScottPlot 4.1.71
URL: /cookbook/4.1/recipes/palette_category10/
BreadcrumbNames: ["ScottPlot 4.1 Cookbook", "Palette", "Category10"]
BreadcrumbUrls: ["/cookbook/4.1/", "/cookbook/4.1/category/palette", "/cookbook/4.1/recipes/palette_category10/"]
SearchUrl: "/cookbook/4.1/search/"
OgImage: "/cookbook/4.1/images/palette_category10.png"
---

<h2><a id='category10' href='/cookbook/4.1/recipes/palette_category10/'>Category10</a></h2>

This 10-color palette is the default colorset used by ScottPlot. It is the same default colorset used by modern versions of Matplotlib (https://matplotlib.org/2.0.2/users/dflt_style_changes.html)

{{< code-sp4 >}}

```cs
ScottPlot.Version.ShouldBe(4, 1, 71);
var plt = new ScottPlot.Plot(600, 400);

plt.Palette = ScottPlot.Palette.Category10;

for (int i = 0; i < plt.Palette.Count(); i++)
{
    double[] xs = DataGen.Consecutive(100);
    double[] ys = DataGen.Sin(100, phase: -i * .5 / plt.Palette.Count());
    plt.AddScatterLines(xs, ys, lineWidth: 3);
}

plt.Title($"{plt.Palette}");
plt.AxisAuto(0, 0.1);

plt.SaveFig("palette_Category10.png");
```

{{< /code-sp4 >}}

<img src='../../images/palette_category10.png' class='d-block mx-auto my-5' />


