---
Title: "Plot Layout - ScottPlot 4.1 Cookbook"
Description: "Call Layout() to manually define padding on all edges of the data area. This is the easiest way to make room for large custom tick labels. Under the hood, this method sets the minimum size of all 4 primary axes."
Date: 2024-01-14
Version: ScottPlot 4.1.70
URL: /cookbook/4.1/recipes/layout_plot/
BreadcrumbNames: ["ScottPlot 4.1 Cookbook", "Layout", "Plot Layout"]
BreadcrumbUrls: ["/cookbook/4.1/", "/cookbook/4.1/category/layout", "/cookbook/4.1/recipes/layout_plot/"]
SearchUrl: "/cookbook/4.1/search/"
OgImage: "/cookbook/4.1/images/layout_plot.png"
---

<h2><a id='plot-layout' href='/cookbook/4.1/recipes/layout_plot/'>Plot Layout</a></h2>

Call Layout() to manually define padding on all edges of the data area. This is the easiest way to make room for large custom tick labels. Under the hood, this method sets the minimum size of all 4 primary axes.

{{< code-sp4 >}}

```cs
ScottPlot.Version.ShouldBe(4, 1, 70);
var plt = new ScottPlot.Plot(600, 400);

plt.AddSignal(DataGen.Sin(51));
plt.AddSignal(DataGen.Cos(51));
plt.XLabel("Horizontal Axis");
plt.YLabel("Vertical Axis");
plt.Title("Plot Title");
plt.Style(figureBackground: Color.SkyBlue);

plt.Layout(left: 100, right: 100, bottom: 100, top: 50);

plt.SaveFig("layout_plot.png");
```

{{< /code-sp4 >}}

<img src='../../images/layout_plot.png' class='d-block mx-auto my-5' />


