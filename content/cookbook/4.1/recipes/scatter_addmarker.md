---
Title: "Add markers - ScottPlot 4.1 Cookbook"
Description: "Want to place a marker at a position in X/Y space? AddMarker() will create a scatter plot with a single point."
Date: 12/11/2023 8:13:10 PM
Version: ScottPlot 4.1.69
URL: /cookbook/4.1/recipes/scatter_addmarker/
BreadcrumbNames: ["ScottPlot 4.1 Cookbook", "Scatter Plot", "Add markers"]
BreadcrumbUrls: ["/cookbook/4.1/", "/cookbook/4.1/category/plottable-scatter-plot", "/cookbook/4.1/recipes/scatter_addmarker/"]
SearchUrl: "/cookbook/4.1/search/"
OgImage: "/cookbook/4.1/images/scatter_addmarker.png"
---

<h2><a id='add-markers' href='/cookbook/4.1/recipes/scatter_addmarker/'>Add markers</a></h2>

Want to place a marker at a position in X/Y space? AddMarker() will create a scatter plot with a single point.

```cs
var plt = new ScottPlot.Plot(600, 400);

Random rand = new(0);
for (int i = 0; i < 100; i++)
{
    double x = rand.Next(100);
    double y = rand.Next(100);
    double fraction = rand.NextDouble();
    double size = (fraction + .1) * 30;
    var color = Drawing.Colormap.Turbo.GetColor(fraction, alpha: .8);
    var shape = Marker.Random(rand);
    plt.AddMarker(x, y, shape, size, color);
}

plt.SaveFig("scatter_AddMarker.png");
```

<img src='../../images/scatter_addmarker.png' class='d-block mx-auto my-5' />


