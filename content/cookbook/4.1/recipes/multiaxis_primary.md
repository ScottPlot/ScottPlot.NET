---
Title: "Primary Axes - ScottPlot 4.1 Cookbook"
Description: "Plots always have 4 fundamental axes available to work with. By default primary axes are totally visible, and secondary axes have ticks hidden and no label. Sometimes the top axis is given a label to simulate a plot title."
Date: 2024-01-21
Version: ScottPlot 4.1.71
URL: /cookbook/4.1/recipes/multiaxis_primary/
BreadcrumbNames: ["ScottPlot 4.1 Cookbook", "Multi-Axis", "Primary Axes"]
BreadcrumbUrls: ["/cookbook/4.1/", "/cookbook/4.1/category/multi-axis", "/cookbook/4.1/recipes/multiaxis_primary/"]
SearchUrl: "/cookbook/4.1/search/"
OgImage: "/cookbook/4.1/images/multiaxis_primary.png"
---

<h2><a id='primary-axes' href='/cookbook/4.1/recipes/multiaxis_primary/'>Primary Axes</a></h2>

Plots always have 4 fundamental axes available to work with. By default primary axes are totally visible, and secondary axes have ticks hidden and no label. Sometimes the top axis is given a label to simulate a plot title.

{{< code-sp4 >}}

```cs
ScottPlot.Version.ShouldBe(4, 1, 71);
var plt = new ScottPlot.Plot(600, 400);

// plot one set of data using the primary Y axis
var sigSmall = plt.AddSignal(DataGen.Sin(51, mult: 1), sampleRate: 1);
sigSmall.YAxisIndex = plt.LeftAxis.AxisIndex;
sigSmall.XAxisIndex = plt.BottomAxis.AxisIndex;
plt.BottomAxis.Label("Primary X Axis");
plt.YAxis.Label("Primary Y Axis");
plt.BottomAxis.Color(sigSmall.Color);
plt.YAxis.Color(sigSmall.Color);

// plot another set of data using the secondary axes
var sigBig = plt.AddSignal(DataGen.Cos(51, mult: 100), sampleRate: 100);
sigBig.YAxisIndex = plt.RightAxis.AxisIndex;
sigBig.XAxisIndex = plt.TopAxis.AxisIndex;

// show ticks and labels for axes where they are hidden by default
plt.RightAxis.Ticks(true);
plt.RightAxis.Color(sigBig.Color);
plt.RightAxis.Label("Secondary Y Axis");
plt.TopAxis.Ticks(true);
plt.TopAxis.Color(sigBig.Color);
plt.TopAxis.Label("Secondary X Axis");

plt.SaveFig("multiAxis_primary.png");
```

{{< /code-sp4 >}}

<img src='../../images/multiaxis_primary.png' class='d-block mx-auto my-5' />


