---
Title: "Axis Visibility - ScottPlot 4.1 Cookbook"
Description: "Visibility of axes can be toggled. In this example an additional Y axis is added but the primary Y axis is hidden. The result is a plot that appears to only have one Y axis."
Date: 2024-01-21
Version: ScottPlot 4.1.71
URL: /cookbook/4.1/recipes/multiaxis_invisible/
BreadcrumbNames: ["ScottPlot 4.1 Cookbook", "Multi-Axis", "Axis Visibility"]
BreadcrumbUrls: ["/cookbook/4.1/", "/cookbook/4.1/category/multi-axis", "/cookbook/4.1/recipes/multiaxis_invisible/"]
SearchUrl: "/cookbook/4.1/search/"
OgImage: "/cookbook/4.1/images/multiaxis_invisible.png"
---

<h2><a id='axis-visibility' href='/cookbook/4.1/recipes/multiaxis_invisible/'>Axis Visibility</a></h2>

Visibility of axes can be toggled. In this example an additional Y axis is added but the primary Y axis is hidden. The result is a plot that appears to only have one Y axis.

{{< code-sp4 >}}

```cs
ScottPlot.Version.ShouldBe(4, 1, 71);
var plt = new ScottPlot.Plot(600, 400);

// plot one set of data using the primary Y axis
var sigSmall = plt.AddSignal(DataGen.Sin(51, mult: 1));
sigSmall.YAxisIndex = plt.LeftAxis.AxisIndex;
plt.YAxis.Label("Primary Axis");
plt.YAxis.Color(sigSmall.Color);

// plot another set of data using an additional axis
var sigBig = plt.AddSignal(DataGen.Cos(51, mult: 100));
var yAxis3 = plt.AddAxis(Renderable.Edge.Left);
sigBig.YAxisIndex = yAxis3.AxisIndex;
yAxis3.Label("Additional Axis");
yAxis3.Color(sigBig.Color);

// hide the primary Y axis
plt.YAxis.IsVisible = false;

plt.SaveFig("multiAxis_invisible.png");
```

{{< /code-sp4 >}}

<img src='../../images/multiaxis_invisible.png' class='d-block mx-auto my-5' />


