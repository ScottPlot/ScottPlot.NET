---
Title: "Blue2 Style - ScottPlot 4.1 Cookbook"
Description: "Customize many plot features using style presets"
Date: 2024-01-21
Version: ScottPlot 4.1.71
URL: /cookbook/4.1/recipes/style_blue2/
BreadcrumbNames: ["ScottPlot 4.1 Cookbook", "Style", "Blue2 Style"]
BreadcrumbUrls: ["/cookbook/4.1/", "/cookbook/4.1/category/style", "/cookbook/4.1/recipes/style_blue2/"]
SearchUrl: "/cookbook/4.1/search/"
OgImage: "/cookbook/4.1/images/style_blue2.png"
---

<h2><a id='blue2-style' href='/cookbook/4.1/recipes/style_blue2/'>Blue2 Style</a></h2>

Customize many plot features using style presets

{{< code-sp4 >}}

```cs
ScottPlot.Version.ShouldBe(4, 1, 71);
var plt = new ScottPlot.Plot(600, 400);

plt.AddSignal(DataGen.Sin(51));
plt.AddSignal(DataGen.Cos(51));

plt.Style(Style.Blue2);
plt.Title("Style.Blue2");
plt.XLabel("Horizontal Axis");
plt.YLabel("Vertical Axis");

plt.SaveFig("style_blue2.png");
```

{{< /code-sp4 >}}

<img src='../../images/style_blue2.png' class='d-block mx-auto my-5' />


