---
Title: Line Plot - ScottPlot 5.0 Cookbook
Description: Line plots can be placed on the plot in coordinate space using a Start, End, and an optional LineStyle.
URL: /cookbook/5.0/LinePlot/
BreadcrumbNames: ["ScottPlot 5.0 Cookbook", "Line Plot"]
BreadcrumbUrls: ["/cookbook/5.0/", "/cookbook/5.0/LinePlot"]
Date: 2024-11-09
Version: ScottPlot 5.0.44
Version: ScottPlot 5.0.44
SearchUrl: "/cookbook/5.0/search/"
ShowEditLink: false
---

<h1>Line Plot</h1>


<div class='d-flex align-items-center mt-5'>
<h1 class='me-2 text-dark my-0 border-0'>Line Plot Quickstart</h1>
<a href='/cookbook/5.0/LinePlot/LineQuickStart' target='_blank'>
<img src='/images/icons/new-window.svg' style='height: 2rem;' class='new-window-icon'>
</a>
</div>

Line plots are placed with a start and end location in coordinate space. Their styles can be customized.

[![](/cookbook/5.0/images/LineQuickStart.png?241109132219)](/cookbook/5.0/images/LineQuickStart.png?241109132219)

{{< recipe-sp5 sourceUrl="https://github.com/ScottPlot/ScottPlot/blob/main/src/ScottPlot5/ScottPlot5%20Cookbook/Recipes/PlotTypes/Line.cs" imageUrl="/cookbook/5.0/images/LineQuickStart.png?241109132219" >}}ScottPlot.Plot myPlot = new();

myPlot.Add.Line(1, 12, 12, 0);
myPlot.Add.Line(7, 9, 42, 9);
myPlot.Add.Line(30, 17, 30, 1);

myPlot.SavePng("demo.png", 400, 300);
{{< /recipe-sp5 >}}

<hr class='my-5 invisible'>



<div class='d-flex align-items-center mt-5'>
<h1 class='me-2 text-dark my-0 border-0'>Line Plot Shapes</h1>
<a href='/cookbook/5.0/LinePlot/LinePlotStyles' target='_blank'>
<img src='/images/icons/new-window.svg' style='height: 2rem;' class='new-window-icon'>
</a>
</div>

Line plots can be styled using a LineStyle.

[![](/cookbook/5.0/images/LinePlotStyles.png?241109132219)](/cookbook/5.0/images/LinePlotStyles.png?241109132219)

{{< recipe-sp5 sourceUrl="https://github.com/ScottPlot/ScottPlot/blob/main/src/ScottPlot5/ScottPlot5%20Cookbook/Recipes/PlotTypes/Line.cs" imageUrl="/cookbook/5.0/images/LinePlotStyles.png?241109132219" >}}ScottPlot.Plot myPlot = new();

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

<hr class='my-5 invisible'>



<div class='d-flex align-items-center mt-5'>
<h1 class='me-2 text-dark my-0 border-0'>Line Plot Legend</h1>
<a href='/cookbook/5.0/LinePlot/LinePlotLegendQWER' target='_blank'>
<img src='/images/icons/new-window.svg' style='height: 2rem;' class='new-window-icon'>
</a>
</div>

Line plots with labels appear in the legend.

[![](/cookbook/5.0/images/LinePlotLegendQWER.png?241109132219)](/cookbook/5.0/images/LinePlotLegendQWER.png?241109132219)

{{< recipe-sp5 sourceUrl="https://github.com/ScottPlot/ScottPlot/blob/main/src/ScottPlot5/ScottPlot5%20Cookbook/Recipes/PlotTypes/Line.cs" imageUrl="/cookbook/5.0/images/LinePlotLegendQWER.png?241109132219" >}}ScottPlot.Plot myPlot = new();

var sin = myPlot.Add.Signal(Generate.Sin());
sin.LegendText = "Sine";

var cos = myPlot.Add.Signal(Generate.Cos());
cos.LegendText = "Cosine";

var line = myPlot.Add.Line(1, 12, 12, 0);
line.LineWidth = 3;
line.MarkerSize = 10;
line.LegendText = "Line Plot";

myPlot.ShowLegend(Alignment.UpperRight);

myPlot.SavePng("demo.png", 400, 300);
{{< /recipe-sp5 >}}

<hr class='my-5 invisible'>


