---
Title: Markers with Fills - ScottPlot 5.0 Cookbook
Description: Markers with fills support customization.
URL: /cookbook/5.0/Marker/MarkerWithFill/
BreadcrumbNames: ["ScottPlot 5.0 Cookbook", "Marker", "Markers with Fills"]
BreadcrumbUrls: ["/cookbook/5.0/", "/cookbook/5.0/Marker", "/cookbook/5.0/Marker/MarkerWithFill"]
Date: 2025-03-22
Version: ScottPlot 5.0.55
Version: ScottPlot 5.0.55
SearchUrl: "/cookbook/5.0/search/"
ShowEditLink: false
---


<div class='d-flex align-items-center mt-5'>
<h1 class='me-2 text-dark my-0 border-0'>Markers with Fills</h1>
</div>

Markers with fills support customization.

[![](/cookbook/5.0/images/MarkerWithFill.png?250322130304)](/cookbook/5.0/images/MarkerWithFill.png?250322130304)

{{< recipe-sp5 sourceUrl="https://github.com/ScottPlot/ScottPlot/blob/main/src/ScottPlot5/ScottPlot5%20Cookbook/Recipes/PlotTypes/Marker.cs" imageUrl="/cookbook/5.0/images/MarkerWithFill.png?250322130304" >}}ScottPlot.Plot myPlot = new();

MarkerShape[] filledMarkerShapes = [
    MarkerShape.FilledCircle,
    MarkerShape.FilledSquare,
    MarkerShape.FilledTriangleUp,
    MarkerShape.FilledTriangleDown,
    MarkerShape.FilledDiamond,
];

for (int i = 0; i &lt; filledMarkerShapes.Length; i++)
{
    var markerFill = myPlot.Add.Marker(i, 1, filledMarkerShapes[i]);
    markerFill.MarkerSize = 20;

    var markerFillAndOutline = myPlot.Add.Marker(i, -1, filledMarkerShapes[i]);
    markerFillAndOutline.MarkerSize = 20;

    // filled markers have a customizable fill color
    markerFill.MarkerFillColor = Colors.Green.WithAlpha(.5);
    markerFillAndOutline.MarkerFillColor = Colors.Green.WithAlpha(.5);

    // filled markers can be given an outline
    markerFillAndOutline.MarkerLineColor = Colors.Blue;
    markerFillAndOutline.LineWidth = 2;
}

myPlot.Layout.Frameless();
myPlot.HideGrid();
myPlot.Axes.SetLimitsY(-5, 5);

myPlot.SavePng("demo.png", 400, 300);
{{< /recipe-sp5 >}}

<div class='my-5 text-center'>This recipe is one of many in the <a href='/cookbook/5.0/Marker'>Marker</a> category</div>


