---
Title: "Ellipse Rotation - ScottPlot 4.1 Cookbook"
Description: "Ellipses can also be rotated"
Date: 2023-12-13
Version: ScottPlot 4.1.69
URL: /cookbook/4.1/recipes/ellipse_rotation/
BreadcrumbNames: ["ScottPlot 4.1 Cookbook", "Ellipse", "Ellipse Rotation"]
BreadcrumbUrls: ["/cookbook/4.1/", "/cookbook/4.1/category/plottable-ellipse", "/cookbook/4.1/recipes/ellipse_rotation/"]
SearchUrl: "/cookbook/4.1/search/"
OgImage: "/cookbook/4.1/images/ellipse_rotation.png"
---

<h2><a id='ellipse-rotation' href='/cookbook/4.1/recipes/ellipse_rotation/'>Ellipse Rotation</a></h2>

Ellipses can also be rotated

```cs
var plt = new ScottPlot.Plot(600, 400);

for (int i = 0; i < 5; i++)
{
    var el = plt.AddEllipse(x: 0, y: 0, xRadius: 1, yRadius: 5);
    el.Rotation = i * 15;
}

plt.AxisScaleLock(true);

plt.SaveFig("ellipse_rotation.png");
```

<img src='../../images/ellipse_rotation.png' class='d-block mx-auto my-5' />


