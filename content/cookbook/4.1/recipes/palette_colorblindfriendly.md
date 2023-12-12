---
Title: "Colorblind Friendly - ScottPlot 4.1 Cookbook"
Description: "8-color palette that has good overall variability and can be differentiated by individuals with red-green color blindness. Colors originated from Wong 2011, https://www.nature.com/articles/nmeth.1618.pdf"
Date: 12/11/2023 7:52:02 PM
Version: ScottPlot 4.1.69
URL: /cookbook/4.1/recipes/palette_colorblindfriendly/
BreadcrumbNames: ["ScottPlot 4.1 Cookbook", "Palette", "Colorblind Friendly"]
BreadcrumbUrls: ["/cookbook/4.1/", "/cookbook/4.1/category/palette", "/cookbook/4.1/recipes/palette_colorblindfriendly/"]
SearchUrl: "/cookbook/4.1/search/"
OgImage: "/cookbook/4.1/images/palette_colorblindfriendly.png"
---

<h2><a href='/cookbook/4.1/recipes/palette_colorblindfriendly/'>Colorblind Friendly</a></h2>

8-color palette that has good overall variability and can be differentiated by individuals with red-green color blindness. Colors originated from Wong 2011, https://www.nature.com/articles/nmeth.1618.pdf

```cs
var plt = new ScottPlot.Plot(600, 400);

plt.Palette = ScottPlot.Palette.ColorblindFriendly;

for (int i = 0; i < plt.Palette.Count(); i++)
{
    double[] xs = DataGen.Consecutive(100);
    double[] ys = DataGen.Sin(100, phase: -i * .5 / plt.Palette.Count());
    plt.AddScatterLines(xs, ys, lineWidth: 3);
}

plt.Title($"{plt.Palette}");
plt.AxisAuto(0, 0.1);

plt.SaveFig("palette_ColorblindFriendly.png");
```

<img src='../../images/palette_colorblindfriendly.png' class='d-block mx-auto my-5' />


