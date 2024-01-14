---
Title: "Axis Line - ScottPlot 4.1 Cookbook"
Description: "An axis line marks a position on an axis. Axis lines extend to positive and negative infinity on the other axis."
Date: 2024-01-14
Version: ScottPlot 4.1.70
URL: /cookbook/4.1/recipes/axisline_basics/
BreadcrumbNames: ["ScottPlot 4.1 Cookbook", "Axis Line and Span", "Axis Line"]
BreadcrumbUrls: ["/cookbook/4.1/", "/cookbook/4.1/category/plottable-axis-line-and-span", "/cookbook/4.1/recipes/axisline_basics/"]
SearchUrl: "/cookbook/4.1/search/"
OgImage: "/cookbook/4.1/images/axisline_basics.png"
---

<h2><a id='axis-line' href='/cookbook/4.1/recipes/axisline_basics/'>Axis Line</a></h2>

An axis line marks a position on an axis. Axis lines extend to positive and negative infinity on the other axis.

{{< code-sp4 >}}

```cs
ScottPlot.Version.ShouldBe(4, 1, 70);
var plt = new ScottPlot.Plot(600, 400);

// plot sample data
plt.AddSignal(DataGen.Sin(51));
plt.AddSignal(DataGen.Cos(51));

// add axis lines
plt.AddHorizontalLine(.85);
plt.AddVerticalLine(23);

// customize axis lines with optional arguments
plt.AddVerticalLine(x: 33, color: Color.Magenta, width: 3, style: LineStyle.Dot);

plt.SaveFig("axisLine_basics.png");
```

{{< /code-sp4 >}}

<img src='../../images/axisline_basics.png' class='d-block mx-auto my-5' />


