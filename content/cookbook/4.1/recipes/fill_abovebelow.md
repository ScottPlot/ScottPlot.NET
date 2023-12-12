---
Title: "Fill Above and Below - ScottPlot 4.1 Cookbook"
Description: "Sometimes you want to share the area under a curve, but change its color depending on which side of the baseline value it is. There's a helper method to make this easier."
Date: 12/11/2023 8:13:10 PM
Version: ScottPlot 4.1.69
URL: /cookbook/4.1/recipes/fill_abovebelow/
BreadcrumbNames: ["ScottPlot 4.1 Cookbook", "Fill", "Fill Above and Below"]
BreadcrumbUrls: ["/cookbook/4.1/", "/cookbook/4.1/category/plottable-fill", "/cookbook/4.1/recipes/fill_abovebelow/"]
SearchUrl: "/cookbook/4.1/search/"
OgImage: "/cookbook/4.1/images/fill_abovebelow.png"
---

<h2><a id='fill-above-and-below' href='/cookbook/4.1/recipes/fill_abovebelow/'>Fill Above and Below</a></h2>

Sometimes you want to share the area under a curve, but change its color depending on which side of the baseline value it is. There's a helper method to make this easier.

```cs
var plt = new ScottPlot.Plot(600, 400);

// create sample data
Random rand = new Random(3);
double[] xs = DataGen.Consecutive(201);
double[] ys = DataGen.RandomWalk(rand, xs.Length);

// add filled polygons
plt.AddFillAboveAndBelow(xs, ys);

// tighten the axis limits so we don't see lines on the edges
plt.SetAxisLimits(xMin: 0, xMax: 200);

plt.SaveFig("fill_aboveBelow.png");
```

<img src='../../images/fill_abovebelow.png' class='d-block mx-auto my-5' />


