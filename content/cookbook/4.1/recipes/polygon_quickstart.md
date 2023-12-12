---
Title: "Polygon Quickstart - ScottPlot 4.1 Cookbook"
Description: "Polygons are 2D shapes made from pairs of X/Y points. The last point connects back to the first point, forming a closed shape. Polygons can be optionally outlined and optionally filled. Colors with semitransparency are especially useful for polygons."
Date: 12/11/2023 8:13:10 PM
Version: ScottPlot 4.1.69
URL: /cookbook/4.1/recipes/polygon_quickstart/
BreadcrumbNames: ["ScottPlot 4.1 Cookbook", "Polygon", "Polygon Quickstart"]
BreadcrumbUrls: ["/cookbook/4.1/", "/cookbook/4.1/category/plottable-polygon", "/cookbook/4.1/recipes/polygon_quickstart/"]
SearchUrl: "/cookbook/4.1/search/"
OgImage: "/cookbook/4.1/images/polygon_quickstart.png"
---

<h2><a id='polygon-quickstart' href='/cookbook/4.1/recipes/polygon_quickstart/'>Polygon Quickstart</a></h2>

Polygons are 2D shapes made from pairs of X/Y points. The last point connects back to the first point, forming a closed shape. Polygons can be optionally outlined and optionally filled. Colors with semitransparency are especially useful for polygons.

```cs
var plt = new ScottPlot.Plot(600, 400);

double[] xs1 = { 2, 8, 6, 4 };
double[] ys1 = { 3, 4, 0.5, 1 };
plt.AddPolygon(xs1, ys1);

double[] xs2 = { 3, 2.5, 5 };
double[] ys2 = { 4.5, 1.5, 2.5 };
plt.AddPolygon(xs2, ys2, plt.GetNextColor(.5), lineWidth: 2);

plt.SaveFig("polygon_quickstart.png");
```

<img src='../../images/polygon_quickstart.png' class='d-block mx-auto my-5' />


