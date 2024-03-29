---
Title: "Text - ScottPlot 4.1 Cookbook"
Description: "The Text plottable displays a string at an X/Y coordinate in unit space. Unlike the Annotation plottable, text moves when the axes are adjusted."
Date: 2024-01-21
Version: ScottPlot 4.1.71
URL: /cookbook/4.1/recipes/text_quickstart/
BreadcrumbNames: ["ScottPlot 4.1 Cookbook", "Text", "Text"]
BreadcrumbUrls: ["/cookbook/4.1/", "/cookbook/4.1/category/plottable-text", "/cookbook/4.1/recipes/text_quickstart/"]
SearchUrl: "/cookbook/4.1/search/"
OgImage: "/cookbook/4.1/images/text_quickstart.png"
---

<h2><a id='text' href='/cookbook/4.1/recipes/text_quickstart/'>Text</a></h2>

The Text plottable displays a string at an X/Y coordinate in unit space. Unlike the Annotation plottable, text moves when the axes are adjusted.

{{< code-sp4 >}}

```cs
ScottPlot.Version.ShouldBe(4, 1, 71);
var plt = new ScottPlot.Plot(600, 400);

int pointCount = 51;
double[] x = DataGen.Consecutive(pointCount);
double[] sin = DataGen.Sin(pointCount);
double[] cos = DataGen.Cos(pointCount);

plt.AddScatter(x, sin);
plt.AddScatter(x, cos);

plt.AddText("sample text", 10, .5, size: 16, color: Color.Blue);

plt.SaveFig("text_quickstart.png");
```

{{< /code-sp4 >}}

<img src='../../images/text_quickstart.png' class='d-block mx-auto my-5' />


