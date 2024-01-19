---
Title: Polygon Plot - ScottPlot 5.0 Cookbook
Description: Polygon plots draws a polygon
URL: /cookbook/5.0/Polygon/
BreadcrumbNames: ["ScottPlot 5.0 Cookbook", "Polygon Plot"]
BreadcrumbUrls: ["/cookbook/5.0/", "/cookbook/5.0/Polygon"]
Date: 2024-01-19
Version: ScottPlot 5.0.19
Version: ScottPlot 5.0.19
SearchUrl: "/cookbook/5.0/search/"
ShowEditLink: false
---

# Polygon Plot


<h2><a href='/cookbook/5.0/Polygon/PolygonQuickstart'>Polygon Plot Quickstart</a></h2>

Polygon plots can be added from a series of vertices, and must be in clockwise order.

[![](/cookbook/5.0/images/PolygonQuickstart.png)](/cookbook/5.0/images/PolygonQuickstart.png)

{{< code-sp5 >}}

```cs
ScottPlot.Plot myPlot = new();

Coordinates[] vertices = new Coordinates[]
{
    new Coordinates(0,   0.25),
    new Coordinates(0.3, 0.75),
    new Coordinates(1,   1),
    new Coordinates(0.7, 0.5),
    new Coordinates(1,   0)
};
myPlot.Add.Polygon(vertices);
myPlot.Axes.AutoScale();

myPlot.SavePng("demo.png", 400, 300);

```

{{< /code-sp5 >}}

<hr class='my-5 invisible'>


<h2><a href='/cookbook/5.0/Polygon/PolygonStyling'>Polygon Plot Styling</a></h2>

Polygon plots can be fully customized.

[![](/cookbook/5.0/images/PolygonStyling.png)](/cookbook/5.0/images/PolygonStyling.png)

{{< code-sp5 >}}

```cs
ScottPlot.Plot myPlot = new();

Coordinates[] vertices = new Coordinates[]
{
    new Coordinates(0,   0.25),
    new Coordinates(0.3, 0.75),
    new Coordinates(1,   1),
    new Coordinates(0.7, 0.5),
    new Coordinates(1,   0)
};
var poly = myPlot.Add.Polygon(vertices);
poly.FillStyle = new FillStyle
{
    Color = Colors.IndianRed
};
poly.LineStyle = new LineStyle
{
    AntiAlias = true,
    Color = Colors.Black,
    Pattern = LinePattern.Dashed,
    Width = 2
};
poly.MarkerStyle = new MarkerStyle(MarkerShape.OpenCircle, 8);
poly.MarkerStyle.Fill.Color = Colors.Gold;
poly.MarkerStyle.Outline.Color = Colors.Brown;
myPlot.Axes.AutoScale();

myPlot.SavePng("demo.png", 400, 300);

```

{{< /code-sp5 >}}

<hr class='my-5 invisible'>

