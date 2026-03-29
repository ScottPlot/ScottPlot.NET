---
Title: Polygon Plot Quickstart - ScottPlot 5 Cookbook
Description: Polygon plots can be added from a series of vertices, and must be in clockwise order.
URL: /cookbook/5/Shapes/PolygonQuickstart/
BreadcrumbNames: ["ScottPlot 5 Cookbook", "Shapes", "Polygon Plot Quickstart"]
BreadcrumbUrls: ["/cookbook/5/", "/cookbook/5/Shapes", "/cookbook/5/Shapes/PolygonQuickstart"]
Date: 2026-03-29
Version: ScottPlot 5.1.58
Version: ScottPlot 5.1.58
SearchUrl: "/cookbook/5/search/"
ShowEditLink: false
---


<div class='d-flex align-items-center mt-5'>
<h1 class='me-2 text-dark my-0 border-0'>Polygon Plot Quickstart</h1>
</div>

Polygon plots can be added from a series of vertices, and must be in clockwise order.

[![](/cookbook/5/images/PolygonQuickstart.png?260329072039)](/cookbook/5/images/PolygonQuickstart.png?260329072039)

{{< recipe-sp5 sourceUrl="https://github.com/ScottPlot/ScottPlot/blob/main/src/ScottPlot5/ScottPlot5%20Cookbook/Recipes/PlotTypes/Shapes.cs" imageUrl="/cookbook/5/images/PolygonQuickstart.png?260329072039" >}}ScottPlot.Plot myPlot = new();

Coordinates[] points =
{
    new(0,   0.25),
    new(0.3, 0.75),
    new(1,   1),
    new(0.7, 0.5),
    new(1,   0)
};

myPlot.Add.Polygon(points);

myPlot.SavePng("demo.png", 400, 300);
{{< /recipe-sp5 >}}

<div class='my-5 text-center'>This recipe is one of many in the <a href='/cookbook/5/Shapes'>Shapes</a> category</div>


