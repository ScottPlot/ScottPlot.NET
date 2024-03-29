---
Title: "Manually add a Plottable - ScottPlot 4.1 Cookbook"
Description: "You can create a plot manually, then add it to the plot with Add(). This allows you to create custom plot types and add them to the plot."
Date: 2024-01-21
Version: ScottPlot 4.1.71
URL: /cookbook/4.1/recipes/quickstart_add/
BreadcrumbNames: ["ScottPlot 4.1 Cookbook", "Quickstart", "Manually add a Plottable"]
BreadcrumbUrls: ["/cookbook/4.1/", "/cookbook/4.1/category/quickstart", "/cookbook/4.1/recipes/quickstart_add/"]
SearchUrl: "/cookbook/4.1/search/"
OgImage: "/cookbook/4.1/images/quickstart_add.png"
---

<h2><a id='manually-add-a-plottable' href='/cookbook/4.1/recipes/quickstart_add/'>Manually add a Plottable</a></h2>

You can create a plot manually, then add it to the plot with Add(). This allows you to create custom plot types and add them to the plot.

{{< code-sp4 >}}

```cs
ScottPlot.Version.ShouldBe(4, 1, 71);
var plt = new ScottPlot.Plot(600, 400);

double[] xs = DataGen.Consecutive(51);
double[] sin = DataGen.Sin(51);

// instantiate a plottable
var splt = new ScottPlot.Plottable.ScatterPlot(xs, sin);

// customize its style or change its data as desired
splt.Color = Color.Navy;
splt.MarkerSize = 10;
splt.MarkerShape = MarkerShape.filledDiamond;

// add it to the plot
plt.Add(splt);

plt.SaveFig("quickstart_add.png");
```

{{< /code-sp4 >}}

<img src='../../images/quickstart_add.png' class='d-block mx-auto my-5' />


