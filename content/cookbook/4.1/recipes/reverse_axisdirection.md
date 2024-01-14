---
Title: "Reverse Axis Direction - ScottPlot 4.1 Cookbook"
Description: "Plot data on reversed axis. And all points plotted match the reverse coordinate axis."
Date: 2024-01-14
Version: ScottPlot 4.1.70
URL: /cookbook/4.1/recipes/reverse_axisdirection/
BreadcrumbNames: ["ScottPlot 4.1 Cookbook", "Advanced Axis Features", "Reverse Axis Direction"]
BreadcrumbUrls: ["/cookbook/4.1/", "/cookbook/4.1/category/advanced-axis-features", "/cookbook/4.1/recipes/reverse_axisdirection/"]
SearchUrl: "/cookbook/4.1/search/"
OgImage: "/cookbook/4.1/images/reverse_axisdirection.png"
---

<h2><a id='reverse-axis-direction' href='/cookbook/4.1/recipes/reverse_axisdirection/'>Reverse Axis Direction</a></h2>

Plot data on reversed axis. And all points plotted match the reverse coordinate axis.

{{< code-sp4 >}}

```cs
ScottPlot.Version.ShouldBe(4, 1, 70);
var plt = new ScottPlot.Plot(600, 400);

plt.AddSignal(DataGen.Sin(51), label: "sin");
plt.AddSignal(DataGen.Cos(51), label: "cos");
plt.Legend();

plt.XAxis.IsReverse = true;
plt.YAxis.IsReverse = true;

plt.SaveFig("reverse_axisDirection.png");
```

{{< /code-sp4 >}}

<img src='../../images/reverse_axisdirection.png' class='d-block mx-auto my-5' />


