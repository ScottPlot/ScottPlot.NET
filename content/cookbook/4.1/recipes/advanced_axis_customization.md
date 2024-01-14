---
Title: "Advanced Axis Customization - ScottPlot 4.1 Cookbook"
Description: "Axis labels, tick marks, and axis lines can all be extensively customized by interacting directly with axis configuration objects."
Date: 2024-01-14
Version: ScottPlot 4.1.70
URL: /cookbook/4.1/recipes/advanced_axis_customization/
BreadcrumbNames: ["ScottPlot 4.1 Cookbook", "Advanced Axis Features", "Advanced Axis Customization"]
BreadcrumbUrls: ["/cookbook/4.1/", "/cookbook/4.1/category/advanced-axis-features", "/cookbook/4.1/recipes/advanced_axis_customization/"]
SearchUrl: "/cookbook/4.1/search/"
OgImage: "/cookbook/4.1/images/advanced_axis_customization.png"
---

<h2><a id='advanced-axis-customization' href='/cookbook/4.1/recipes/advanced_axis_customization/'>Advanced Axis Customization</a></h2>

Axis labels, tick marks, and axis lines can all be extensively customized by interacting directly with axis configuration objects.

{{< code-sp4 >}}

```cs
ScottPlot.Version.ShouldBe(4, 1, 70);
var plt = new ScottPlot.Plot(600, 400);

plt.AddSignal(DataGen.Sin(51));
plt.AddSignal(DataGen.Cos(51));

plt.XAxis.AxisTicks.MajorTickLength = 10;
plt.XAxis.AxisTicks.MinorTickLength = 5;

plt.XAxis.AxisTicks.MajorTickColor = Color.Magenta;
plt.XAxis.AxisTicks.MinorTickColor = Color.LightSkyBlue;

plt.YAxis.AxisLine.Width = 3;

plt.SaveFig("advanced_axis_customization.png");
```

{{< /code-sp4 >}}

<img src='../../images/advanced_axis_customization.png' class='d-block mx-auto my-5' />


