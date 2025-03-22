---
Title: Line Only Markers - ScottPlot 5.0 Cookbook
Description: Markers composed of lines only do not have fill properties.
URL: /cookbook/5.0/Marker/MarkerLineOnly/
BreadcrumbNames: ["ScottPlot 5.0 Cookbook", "Marker", "Line Only Markers"]
BreadcrumbUrls: ["/cookbook/5.0/", "/cookbook/5.0/Marker", "/cookbook/5.0/Marker/MarkerLineOnly"]
Date: 2025-03-22
Version: ScottPlot 5.0.55
Version: ScottPlot 5.0.55
SearchUrl: "/cookbook/5.0/search/"
ShowEditLink: false
---


<div class='d-flex align-items-center mt-5'>
<h1 class='me-2 text-dark my-0 border-0'>Line Only Markers</h1>
</div>

Markers composed of lines only do not have fill properties.

[![](/cookbook/5.0/images/MarkerLineOnly.png?250322130304)](/cookbook/5.0/images/MarkerLineOnly.png?250322130304)

{{< recipe-sp5 sourceUrl="https://github.com/ScottPlot/ScottPlot/blob/main/src/ScottPlot5/ScottPlot5%20Cookbook/Recipes/PlotTypes/Marker.cs" imageUrl="/cookbook/5.0/images/MarkerLineOnly.png?250322130304" >}}ScottPlot.Plot myPlot = new();

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

<div class='my-5 text-center'>This recipe is one of many in the <a href='/cookbook/5.0/Marker'>Marker</a> category</div>


