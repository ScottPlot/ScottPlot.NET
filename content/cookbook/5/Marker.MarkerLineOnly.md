---
Title: Line Only Markers - ScottPlot 5 Cookbook
Description: Markers composed of lines only do not have fill properties.
URL: /cookbook/5/Marker/MarkerLineOnly/
BreadcrumbNames: ["ScottPlot 5 Cookbook", "Marker", "Line Only Markers"]
BreadcrumbUrls: ["/cookbook/5/", "/cookbook/5/Marker", "/cookbook/5/Marker/MarkerLineOnly"]
Date: 2026-03-29
Version: ScottPlot 5.1.58
Version: ScottPlot 5.1.58
SearchUrl: "/cookbook/5/search/"
ShowEditLink: false
---


<div class='d-flex align-items-center mt-5'>
<h1 class='me-2 text-dark my-0 border-0'>Line Only Markers</h1>
</div>

Markers composed of lines only do not have fill properties.

[![](/cookbook/5/images/MarkerLineOnly.png?260329072039)](/cookbook/5/images/MarkerLineOnly.png?260329072039)

{{< recipe-sp5 sourceUrl="https://github.com/ScottPlot/ScottPlot/blob/main/src/ScottPlot5/ScottPlot5%20Cookbook/Recipes/PlotTypes/Marker.cs" imageUrl="/cookbook/5/images/MarkerLineOnly.png?260329072039" >}}ScottPlot.Plot myPlot = new();

MarkerShape[] lineOnlyMarkerShapes = [
    MarkerShape.OpenCircle,
    MarkerShape.OpenSquare,
    MarkerShape.OpenTriangleUp,
    MarkerShape.Eks,
    MarkerShape.Cross,
    MarkerShape.Asterisk,
    MarkerShape.HashTag,
];

for (int i = 0; i &lt; lineOnlyMarkerShapes.Length; i++)
{
    var marker = myPlot.Add.Marker(i, 0, lineOnlyMarkerShapes[i]);

    // line only markers have line customization options
    marker.MarkerLineColor = Colors.Blue;
    marker.LineWidth = 2;
    marker.MarkerSize = 20;

    // line only markers are unaffected by changes in fill properties
    marker.MarkerFillColor = Colors.Green;
}

myPlot.Layout.Frameless();
myPlot.HideGrid();

myPlot.SavePng("demo.png", 400, 300);
{{< /recipe-sp5 >}}

<div class='my-5 text-center'>This recipe is one of many in the <a href='/cookbook/5/Marker'>Marker</a> category</div>


