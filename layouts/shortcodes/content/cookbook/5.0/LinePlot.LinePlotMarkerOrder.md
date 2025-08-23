---
Title: Line and Marker Order - ScottPlot 5.0 Cookbook
Description: Markers may be displayed at the ends of lines, and a flag controls whether the markers are drawn above or below the line.
URL: /cookbook/5.0/LinePlot/LinePlotMarkerOrder/
BreadcrumbNames: ["ScottPlot 5.0 Cookbook", "Line Plot", "Line and Marker Order"]
BreadcrumbUrls: ["/cookbook/5.0/", "/cookbook/5.0/LinePlot", "/cookbook/5.0/LinePlot/LinePlotMarkerOrder"]
Date: 2025-08-23
Version: ScottPlot 5.0.56
Version: ScottPlot 5.0.56
SearchUrl: "/cookbook/5.0/search/"
ShowEditLink: false
---


<div class='d-flex align-items-center mt-5'>
<h1 class='me-2 text-dark my-0 border-0'>Line and Marker Order</h1>
</div>

Markers may be displayed at the ends of lines, and a flag controls whether the markers are drawn above or below the line.

[![](/cookbook/5.0/images/LinePlotMarkerOrder.png?250822231048)](/cookbook/5.0/images/LinePlotMarkerOrder.png?250822231048)

{{< recipe-sp5 sourceUrl="https://github.com/ScottPlot/ScottPlot/blob/main/src/ScottPlot5/ScottPlot5%20Cookbook/Recipes/PlotTypes/Line.cs" imageUrl="/cookbook/5.0/images/LinePlotMarkerOrder.png?250822231048" >}}ScottPlot.Plot myPlot = new();

var line1 = myPlot.Add.Line(0, 0, 1, 1);
line1.LineColor = Colors.Orange;
line1.LineWidth = 5;
line1.MarkerColor = Colors.Red;
line1.MarkerSize = 20;
line1.MarkerShape = MarkerShape.FilledCircle;
line1.LineOnTop = true; // render order is controlled here

var line2 = myPlot.Add.Line(1, 0, 2, 1);
line2.LineColor = Colors.Orange;
line2.LineWidth = 5;
line2.MarkerColor = Colors.Red;
line2.MarkerSize = 20;
line2.MarkerShape = MarkerShape.FilledCircle;
line2.MarkersOnTop = true; // render order is controlled here

myPlot.SavePng("demo.png", 400, 300);
{{< /recipe-sp5 >}}

<div class='my-5 text-center'>This recipe is one of many in the <a href='/cookbook/5.0/LinePlot'>Line Plot</a> category</div>


