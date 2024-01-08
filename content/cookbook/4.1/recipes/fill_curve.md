---
Title: "Fill Under Curve - ScottPlot 4.1 Cookbook"
Description: "Fill methods help to create semitransparent polygons to fill the area under a curve. This can be used to give the appearance of shading under a scatter plot, even though the plottable created here is a polygon with optional edge color and fill color."
Date: 2024-01-07
Version: ScottPlot 4.1.70
URL: /cookbook/4.1/recipes/fill_curve/
BreadcrumbNames: ["ScottPlot 4.1 Cookbook", "Fill", "Fill Under Curve"]
BreadcrumbUrls: ["/cookbook/4.1/", "/cookbook/4.1/category/plottable-fill", "/cookbook/4.1/recipes/fill_curve/"]
SearchUrl: "/cookbook/4.1/search/"
OgImage: "/cookbook/4.1/images/fill_curve.png"
---

<h2><a id='fill-under-curve' href='/cookbook/4.1/recipes/fill_curve/'>Fill Under Curve</a></h2>

Fill methods help to create semitransparent polygons to fill the area under a curve. This can be used to give the appearance of shading under a scatter plot, even though the plottable created here is a polygon with optional edge color and fill color.

```cs
ScottPlot.Version.ShouldBe(4, 1, 70);
var plt = new ScottPlot.Plot(600, 400);

// create sample data
double[] xs = DataGen.Range(0, 10, .1, true);
double[] ys1 = DataGen.Sin(xs);
double[] ys2 = DataGen.Cos(xs);

// add filled polygons
plt.AddFill(xs, ys1);
plt.AddFill(xs, ys2, baseline: -.25);

// tighten the axis limits so we don't see lines on the edges
plt.SetAxisLimits(xMin: 0, xMax: 10);

plt.SaveFig("fill_curve.png");
```

<img src='../../images/fill_curve.png' class='d-block mx-auto my-5' />


