---
Title: "Marker Line Width - ScottPlot 4.1 Cookbook"
Description: "Markers have options that can be customized, such as line width."
Date: 2023-12-28
Version: ScottPlot 4.1.70
URL: /cookbook/4.1/recipes/marker_linewidth/
BreadcrumbNames: ["ScottPlot 4.1 Cookbook", "Marker", "Marker Line Width"]
BreadcrumbUrls: ["/cookbook/4.1/", "/cookbook/4.1/category/plottable-marker", "/cookbook/4.1/recipes/marker_linewidth/"]
SearchUrl: "/cookbook/4.1/search/"
OgImage: "/cookbook/4.1/images/marker_linewidth.png"
---

<h2><a id='marker-line-width' href='/cookbook/4.1/recipes/marker_linewidth/'>Marker Line Width</a></h2>

Markers have options that can be customized, such as line width.

```cs
var plt = new ScottPlot.Plot(600, 400);

double[] ys1 = DataGen.Sin(30);
var cmap1 = ScottPlot.Drawing.Colormap.Viridis;

double[] ys2 = DataGen.Cos(30);
var cmap2 = ScottPlot.Drawing.Colormap.Turbo;

for (int i = 0; i < ys1.Length; i++)
{
    double frac = i / (ys1.Length - 1f);

    var circle = plt.AddMarker(i, ys1[i]);
    circle.MarkerShape = MarkerShape.openCircle;
    circle.MarkerSize = i + 5;
    circle.MarkerLineWidth = 1 + i / 2;
    circle.MarkerColor = cmap1.GetColor(1 - frac, .8);

    var triangle = plt.AddMarker(i, ys2[i]);
    triangle.MarkerShape = MarkerShape.openTriangleUp;
    triangle.MarkerSize = i + 5;
    triangle.MarkerLineWidth = 1 + i / 4;
    triangle.MarkerColor = cmap2.GetColor(frac, .8);
}

plt.Margins(.2, .2);

plt.SaveFig("marker_linewidth.png");
```

<img src='../../images/marker_linewidth.png' class='d-block mx-auto my-5' />


