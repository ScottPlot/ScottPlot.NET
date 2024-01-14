---
Title: "Custom Line Style - ScottPlot 4.1 Cookbook"
Description: "A customizable line style exists which allows users to define any pattern."
Date: 2024-01-14
Version: ScottPlot 4.1.70
URL: /cookbook/4.1/recipes/misc_custom_line_style/
BreadcrumbNames: ["ScottPlot 4.1 Cookbook", "Style", "Custom Line Style"]
BreadcrumbUrls: ["/cookbook/4.1/", "/cookbook/4.1/category/style", "/cookbook/4.1/recipes/misc_custom_line_style/"]
SearchUrl: "/cookbook/4.1/search/"
OgImage: "/cookbook/4.1/images/misc_custom_line_style.png"
---

<h2><a id='custom-line-style' href='/cookbook/4.1/recipes/misc_custom_line_style/'>Custom Line Style</a></h2>

A customizable line style exists which allows users to define any pattern.

{{< code-sp4 >}}

```cs
ScottPlot.Version.ShouldBe(4, 1, 70);
var plt = new ScottPlot.Plot(600, 400);

// All default line style patterns can be customized.
// Numbers are the length of lines and spaces.
ScottPlot.LineStylePatterns.Custom = new float[] { 1, 1, 2, 1, 3, 1, 4, 1 };

// Use line style patterns anywhere
double[] xs = ScottPlot.DataGen.Consecutive(51);
double[] ys = ScottPlot.DataGen.Sin(51);
plt.AddScatter(xs, ys, markerSize: 0, lineStyle: LineStyle.Custom, lineWidth: 5);

plt.SaveFig("misc_custom_line_style.png");
```

{{< /code-sp4 >}}

<img src='../../images/misc_custom_line_style.png' class='d-block mx-auto my-5' />


