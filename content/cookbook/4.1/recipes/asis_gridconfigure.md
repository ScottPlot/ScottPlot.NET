---
Title: "Grid Style - ScottPlot 4.1 Cookbook"
Description: "Common grid line configurations are available."
Date: 2024-01-14
Version: ScottPlot 4.1.70
URL: /cookbook/4.1/recipes/asis_gridconfigure/
BreadcrumbNames: ["ScottPlot 4.1 Cookbook", "Axis and Ticks", "Grid Style"]
BreadcrumbUrls: ["/cookbook/4.1/", "/cookbook/4.1/category/axis-and-ticks", "/cookbook/4.1/recipes/asis_gridconfigure/"]
SearchUrl: "/cookbook/4.1/search/"
OgImage: "/cookbook/4.1/images/asis_gridconfigure.png"
---

<h2><a id='grid-style' href='/cookbook/4.1/recipes/asis_gridconfigure/'>Grid Style</a></h2>

Common grid line configurations are available.

{{< code-sp4 >}}

```cs
ScottPlot.Version.ShouldBe(4, 1, 70);
var plt = new ScottPlot.Plot(600, 400);

// plot sample data
plt.AddSignal(DataGen.Sin(51));
plt.AddSignal(DataGen.Cos(51));

// these helper methods set grid 
plt.Grid(color: Color.FromArgb(50, Color.Green));
plt.Grid(lineStyle: LineStyle.Dot);

plt.SaveFig("asis_gridConfigure.png");
```

{{< /code-sp4 >}}

<img src='../../images/asis_gridconfigure.png' class='d-block mx-auto my-5' />


