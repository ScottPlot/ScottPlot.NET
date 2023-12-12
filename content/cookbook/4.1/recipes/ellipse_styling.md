---
Title: "Ellipse Styling - ScottPlot 4.1 Cookbook"
Description: "Ellipses styles can be extensively customized"
Date: 12/11/2023 8:13:10 PM
Version: ScottPlot 4.1.69
URL: /cookbook/4.1/recipes/ellipse_styling/
BreadcrumbNames: ["ScottPlot 4.1 Cookbook", "Ellipse", "Ellipse Styling"]
BreadcrumbUrls: ["/cookbook/4.1/", "/cookbook/4.1/category/plottable-ellipse", "/cookbook/4.1/recipes/ellipse_styling/"]
SearchUrl: "/cookbook/4.1/search/"
OgImage: "/cookbook/4.1/images/ellipse_styling.png"
---

<h2><a id='ellipse-styling' href='/cookbook/4.1/recipes/ellipse_styling/'>Ellipse Styling</a></h2>

Ellipses styles can be extensively customized

```cs
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

<img src='../../images/ellipse_styling.png' class='d-block mx-auto my-5' />


