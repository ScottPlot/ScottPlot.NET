---
Title: "Ellipse Styling - ScottPlot 4.1 Cookbook"
Description: "Ellipses styles can be extensively customized"
Date: 2024-01-21
Version: ScottPlot 4.1.71
URL: /cookbook/4.1/recipes/ellipse_styling/
BreadcrumbNames: ["ScottPlot 4.1 Cookbook", "Ellipse", "Ellipse Styling"]
BreadcrumbUrls: ["/cookbook/4.1/", "/cookbook/4.1/category/plottable-ellipse", "/cookbook/4.1/recipes/ellipse_styling/"]
SearchUrl: "/cookbook/4.1/search/"
OgImage: "/cookbook/4.1/images/ellipse_styling.png"
---

<h2><a id='ellipse-styling' href='/cookbook/4.1/recipes/ellipse_styling/'>Ellipse Styling</a></h2>

Ellipses styles can be extensively customized

{{< code-sp4 >}}

```cs
ScottPlot.Version.ShouldBe(4, 1, 71);
var plt = new ScottPlot.Plot(600, 400);

var el = plt.AddCircle(0, 0, 5);
el.BorderLineWidth = 5;
el.BorderLineStyle = LineStyle.Dash;
el.BorderColor = Color.Green;
el.Color = Color.Navy;
el.HatchColor = Color.Red;
el.HatchStyle = Drawing.HatchStyle.StripedUpwardDiagonal;

plt.SetAxisLimits(-10, 10, -10, 10);

plt.SaveFig("ellipse_styling.png");
```

{{< /code-sp4 >}}

<img src='../../images/ellipse_styling.png' class='d-block mx-auto my-5' />


