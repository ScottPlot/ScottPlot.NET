---
Title: "Scatter List Generic - ScottPlot 4.1 Cookbook"
Description: "This plot type supports generics."
Date: 2023-12-13
Version: ScottPlot 4.1.69
URL: /cookbook/4.1/recipes/scatterlist_generic/
BreadcrumbNames: ["ScottPlot 4.1 Cookbook", "Scatter Plot", "Scatter List Generic"]
BreadcrumbUrls: ["/cookbook/4.1/", "/cookbook/4.1/category/plottable-scatter-plot", "/cookbook/4.1/recipes/scatterlist_generic/"]
SearchUrl: "/cookbook/4.1/search/"
OgImage: "/cookbook/4.1/images/scatterlist_generic.png"
---

<h2><a id='scatter-list-generic' href='/cookbook/4.1/recipes/scatterlist_generic/'>Scatter List Generic</a></h2>

This plot type supports generics.

```cs
var plt = new ScottPlot.Plot(600, 400);

int[] xs = { 1, 2, 3, 4 };
int[] ys = { 1, 4, 9, 16 };

var scatterList = plt.AddScatterList<int>();
scatterList.AddRange(xs, ys);
scatterList.Add(5, 25);

plt.SaveFig("scatterList_generic.png");
```

<img src='../../images/scatterlist_generic.png' class='d-block mx-auto my-5' />


