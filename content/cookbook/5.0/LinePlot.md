---
Title: Line Plot - ScottPlot 5.0 Cookbook
Description: Line plots can be placed on the plot in coordinate space using a Start, End, and an optional LineStyle.
URL: /cookbook/5.0/LinePlot/
BreadcrumbNames: ["ScottPlot 5.0 Cookbook", "Line Plot"]
BreadcrumbUrls: ["/cookbook/5.0/", "/cookbook/5.0/LinePlot"]
Date: 2024-01-18
Version: ScottPlot 5.0.18
Version: ScottPlot 5.0.18
SearchUrl: "/cookbook/5.0/search/"
ShowEditLink: false
---

# Line Plot


<h2><a href='/cookbook/5.0/LinePlot/LineQuickStart'>Line Plot Quickstart</a></h2>

Line plots are placed with a start and end location in coordinate space. Their styles can be customized.

[![](/cookbook/5.0/images/LineQuickStart.png)](/cookbook/5.0/images/LineQuickStart.png)

{{< code-sp5 >}}

```cs
ScottPlot.Plot myPlot = new();

myPlot.Add.Line(1, 12, 12, 0);
myPlot.Add.Line(7, 9, 42, 9);
myPlot.Add.Line(30, 17, 30, 1);

myPlot.SavePng("demo.png", 400, 300);

```

{{< /code-sp5 >}}

<hr class='my-5 invisible'>


<h2><a href='/cookbook/5.0/LinePlot/LinePlotStyles'>Line Plot Shapes</a></h2>

Line plots can be styled using a LineStyle.

[![](/cookbook/5.0/images/LinePlotStyles.png)](/cookbook/5.0/images/LinePlotStyles.png)

{{< code-sp5 >}}

```cs
ScottPlot.Plot myPlot = new();

ScottPlot.Colormaps.Viridis colormap = new();

for (int i = 0; i < 10; i++)
{
    // add a line
    Coordinates start = Generate.RandomCoordinates();
    Coordinates end = Generate.RandomCoordinates();
    var line = myPlot.Add.Line(start, end);

    // customize the line
    line.LineStyle.Color = Generate.RandomColor(colormap);
    line.LineStyle.Width = Generate.RandomInteger(1, 4);
    line.LineStyle.Pattern = Generate.RandomLinePattern();

    // customize markers
    line.MarkerStyle.Fill.Color = line.LineStyle.Color;
    line.MarkerStyle.Shape = Generate.RandomMarkerShape();
    line.MarkerStyle.Size = Generate.RandomInteger(5, 15);
}

myPlot.SavePng("demo.png", 400, 300);

```

{{< /code-sp5 >}}

<hr class='my-5 invisible'>


<h2><a href='/cookbook/5.0/LinePlot/LinePlotLegendQWER'>Line Plot Legend</a></h2>

Line plots with labels appear in the legend.

[![](/cookbook/5.0/images/LinePlotLegendQWER.png)](/cookbook/5.0/images/LinePlotLegendQWER.png)

{{< code-sp5 >}}

```cs
ScottPlot.Plot myPlot = new();

var sin = myPlot.Add.Signal(Generate.Sin());
var cos = myPlot.Add.Signal(Generate.Cos());

var line = myPlot.Add.Line(1, 12, 12, 0);
line.LineStyle.Width = 3;
line.MarkerStyle.Size = 10;

sin.Label = "Sine";
cos.Label = "Cosine";
line.Label = "Line Plot";

myPlot.ShowLegend(Alignment.UpperRight);

myPlot.SavePng("demo.png", 400, 300);

```

{{< /code-sp5 >}}

<hr class='my-5 invisible'>

