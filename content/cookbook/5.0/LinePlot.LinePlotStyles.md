---
Title: Line Plot Shapes - ScottPlot 5.0 Cookbook
Description: Line plots can be styled using a LineStyle.
URL: /cookbook/5.0/LinePlot/LinePlotStyles/
BreadcrumbNames: ["ScottPlot 5.0 Cookbook", "Line Plot", "Line Plot Shapes"]
BreadcrumbUrls: ["/cookbook/5.0/", "/cookbook/5.0/LinePlot", "/cookbook/5.0/LinePlot/LinePlotStyles"]
Date: 2024-11-17
Version: ScottPlot 5.0.46
Version: ScottPlot 5.0.46
SearchUrl: "/cookbook/5.0/search/"
ShowEditLink: false
---


<div class='d-flex align-items-center mt-5'>
<h1 class='me-2 text-dark my-0 border-0'>Line Plot Shapes</h1>
</div>

Line plots can be styled using a LineStyle.

[![](/cookbook/5.0/images/LinePlotStyles.png?241117162641)](/cookbook/5.0/images/LinePlotStyles.png?241117162641)

{{< recipe-sp5 sourceUrl="https://github.com/ScottPlot/ScottPlot/blob/main/src/ScottPlot5/ScottPlot5%20Cookbook/Recipes/PlotTypes/Line.cs" imageUrl="/cookbook/5.0/images/LinePlotStyles.png?241117162641" >}}ScottPlot.Plot myPlot = new();

ScottPlot.Colormaps.Viridis colormap = new();

for (int i = 0; i &lt; 10; i++)
{
    // add a line
    Coordinates start = Generate.RandomCoordinates();
    Coordinates end = Generate.RandomCoordinates();
    var line = myPlot.Add.Line(start, end);

    // customize the line
    line.LineColor = Generate.RandomColor(colormap);
    line.LineWidth = Generate.RandomInteger(1, 4);
    line.LinePattern = Generate.RandomLinePattern();

    // customize markers
    line.MarkerLineColor = line.LineStyle.Color;
    line.MarkerShape = Generate.RandomMarkerShape();
    line.MarkerSize = Generate.RandomInteger(5, 15);
}

myPlot.SavePng("demo.png", 400, 300);
{{< /recipe-sp5 >}}

<div class='my-5 text-center'>This recipe is one of many in the <a href='/cookbook/5.0/LinePlot'>Line Plot</a> category</div>


