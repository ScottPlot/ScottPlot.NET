---
Title: Rectangle - ScottPlot 5.0 Cookbook
Description: A rectangle can be added to the plot and styled as desired.
URL: /cookbook/5.0/Shapes/RectangleQuickstart/
BreadcrumbNames: ["ScottPlot 5.0 Cookbook", "Shapes", "Rectangle"]
BreadcrumbUrls: ["/cookbook/5.0/", "/cookbook/5.0/Shapes", "/cookbook/5.0/Shapes/RectangleQuickstart"]
Date: 2024-10-31
Version: ScottPlot 5.0.42
Version: ScottPlot 5.0.42
SearchUrl: "/cookbook/5.0/search/"
ShowEditLink: false
---


<h2 style='border-bottom: 0;'><a href='/cookbook/5.0/Shapes/RectangleQuickstart'>Rectangle</a></h2>

<div class="d-flex mb-2">
<a class="btn btn-sm btn-primary me-1" href="/cookbook/5.0/Shapes/RectangleQuickstart">Recipe Permalink</a>
<a class="btn btn-sm btn-success me-1" href="/cookbook/5.0/Shapes">Category: Shapes</a>
</div>

A rectangle can be added to the plot and styled as desired.

[![](/cookbook/5.0/images/RectangleQuickstart.png?241031194635)](/cookbook/5.0/images/RectangleQuickstart.png?241031194635)

{{< recipe-sp5 >}}ScottPlot.Plot myPlot = new();

// add a rectangle by specifying points
myPlot.Add.Rectangle(0, 1, 0, 1);

// add a rectangle using more expressive shapes
Coordinates location = new(2, 0);
CoordinateSize size = new(1, 1);
CoordinateRect rect = new(location, size);
myPlot.Add.Rectangle(rect);

// style rectangles after they are added to the plot
var rp = myPlot.Add.Rectangle(4, 5, 0, 1);
rp.FillStyle.Color = Colors.Magenta.WithAlpha(.2);
rp.LineStyle.Color = Colors.Green;
rp.LineStyle.Width = 3;
rp.LineStyle.Pattern = LinePattern.Dashed;

myPlot.SavePng("demo.png", 400, 300);
{{< /recipe-sp5 >}}

<hr class='my-5 invisible'>


