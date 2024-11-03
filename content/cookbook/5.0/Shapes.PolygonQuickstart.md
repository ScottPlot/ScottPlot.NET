---
Title: Polygon Plot Quickstart - ScottPlot 5.0 Cookbook
Description: Polygon plots can be added from a series of vertices, and must be in clockwise order.
URL: /cookbook/5.0/Shapes/PolygonQuickstart/
BreadcrumbNames: ["ScottPlot 5.0 Cookbook", "Shapes", "Polygon Plot Quickstart"]
BreadcrumbUrls: ["/cookbook/5.0/", "/cookbook/5.0/Shapes", "/cookbook/5.0/Shapes/PolygonQuickstart"]
Date: 2024-11-03
Version: ScottPlot 5.0.43
Version: ScottPlot 5.0.43
SearchUrl: "/cookbook/5.0/search/"
ShowEditLink: false
---


<div class='d-flex align-items-center mt-5'>
<h1 class='me-2 text-dark my-0 border-0'>Polygon Plot Quickstart</h1>
</div>

Polygon plots can be added from a series of vertices, and must be in clockwise order.

[![](/cookbook/5.0/images/PolygonQuickstart.png?241103171511)](/cookbook/5.0/images/PolygonQuickstart.png?241103171511)

{{< recipe-sp5 sourceUrl="https://github.com/ScottPlot/ScottPlot/blob/main/src/ScottPlot5/ScottPlot5%20Cookbook/Recipes/PlotTypes/Shapes.cs" imageUrl="/cookbook/5.0/images/PolygonQuickstart.png?241103171511" >}}ScottPlot.Plot myPlot = new();

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

<div class='my-5 text-center'>This recipe is one of many in the <a href='/cookbook/5.0/Shapes'>Shapes</a> category</div>


