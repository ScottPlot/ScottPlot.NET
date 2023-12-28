---
Title: "Ellipse Quickstart - ScottPlot 4.1 Cookbook"
Description: "Ellipses can be added to plots"
Date: 2023-12-28
Version: ScottPlot 4.1.70
URL: /cookbook/4.1/recipes/ellipse_quickstart/
BreadcrumbNames: ["ScottPlot 4.1 Cookbook", "Ellipse", "Ellipse Quickstart"]
BreadcrumbUrls: ["/cookbook/4.1/", "/cookbook/4.1/category/plottable-ellipse", "/cookbook/4.1/recipes/ellipse_quickstart/"]
SearchUrl: "/cookbook/4.1/search/"
OgImage: "/cookbook/4.1/images/ellipse_quickstart.png"
---

<h2><a id='ellipse-quickstart' href='/cookbook/4.1/recipes/ellipse_quickstart/'>Ellipse Quickstart</a></h2>

Ellipses can be added to plots

```cs
var plt = new ScottPlot.Plot(600, 400);

Random rand = new(0);
for (int i = 0; i < 5; i++)
{
    plt.AddEllipse(
        x: rand.Next(-10, 10),
        y: rand.Next(-10, 10),
        xRadius: rand.Next(1, 7),
        yRadius: rand.Next(1, 7),
        lineWidth: rand.Next(1, 10));
}

plt.SaveFig("ellipse_quickstart.png");
```

<img src='../../images/ellipse_quickstart.png' class='d-block mx-auto my-5' />


