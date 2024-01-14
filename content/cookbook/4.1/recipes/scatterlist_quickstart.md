---
Title: "Scatter List Quickstart - ScottPlot 4.1 Cookbook"
Description: "This plot type has add/remove/clear methods like typical lists."
Date: 2024-01-14
Version: ScottPlot 4.1.70
URL: /cookbook/4.1/recipes/scatterlist_quickstart/
BreadcrumbNames: ["ScottPlot 4.1 Cookbook", "Scatter Plot", "Scatter List Quickstart"]
BreadcrumbUrls: ["/cookbook/4.1/", "/cookbook/4.1/category/plottable-scatter-plot", "/cookbook/4.1/recipes/scatterlist_quickstart/"]
SearchUrl: "/cookbook/4.1/search/"
OgImage: "/cookbook/4.1/images/scatterlist_quickstart.png"
---

<h2><a id='scatter-list-quickstart' href='/cookbook/4.1/recipes/scatterlist_quickstart/'>Scatter List Quickstart</a></h2>

This plot type has add/remove/clear methods like typical lists.

{{< code-sp4 >}}

```cs
ScottPlot.Version.ShouldBe(4, 1, 70);
var plt = new ScottPlot.Plot(600, 400);

double[] xs = { 1, 2, 3, 4 };
double[] ys = { 1, 4, 9, 16 };

var scatterList = plt.AddScatterList();
scatterList.AddRange(xs, ys);
scatterList.Add(5, 25);

plt.SaveFig("scatterList_quickstart.png");
```

{{< /code-sp4 >}}

<img src='../../images/scatterlist_quickstart.png' class='d-block mx-auto my-5' />


