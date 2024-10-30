---
Title: Line Plot Shapes - ScottPlot 5.0 Cookbook
Description: Line plots can be styled using a LineStyle.
URL: /cookbook/5.0/LinePlot/LinePlotStyles/
BreadcrumbNames: ["ScottPlot 5.0 Cookbook", "Line Plot", "Line Plot Shapes"]
BreadcrumbUrls: ["/cookbook/5.0/", "/cookbook/5.0/LinePlot", "/cookbook/5.0/LinePlot/LinePlotStyles"]
Date: 2024-10-30
Version: ScottPlot 5.0.42
Version: ScottPlot 5.0.42
SearchUrl: "/cookbook/5.0/search/"
ShowEditLink: false
---


<h2 style='border-bottom: 0;'><a href='/cookbook/5.0/LinePlot/LinePlotStyles'>Line Plot Shapes</a></h2>

<div class="d-flex mb-2">
<a class="btn btn-sm btn-primary me-1" href="/cookbook/5.0/LinePlot/LinePlotStyles">Recipe Permalink</a>
<a class="btn btn-sm btn-success me-1" href="/cookbook/5.0/LinePlot">Category: Line Plot</a>
</div>

Line plots can be styled using a LineStyle.

[![](/cookbook/5.0/images/LinePlotStyles.png?241029205813)](/cookbook/5.0/images/LinePlotStyles.png?241029205813)

{{< recipe-sp5 >}}ScottPlot.Plot myPlot = new();

ScottPlot.Colormaps.Viridis colormap = new();

for (int i = 0; i < 10; i++)
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

<hr class='my-5 invisible'>


