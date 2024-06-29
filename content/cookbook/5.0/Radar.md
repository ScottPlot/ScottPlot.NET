---
Title: Radar Plot - ScottPlot 5.0 Cookbook
Description: Radar charts (also called a spider charts or star charts) represent multi-axis data as a 2D shape on axes arranged circularly around a center point.
URL: /cookbook/5.0/Radar/
BreadcrumbNames: ["ScottPlot 5.0 Cookbook", "Radar Plot"]
BreadcrumbUrls: ["/cookbook/5.0/", "/cookbook/5.0/Radar"]
Date: 2024-06-29
Version: ScottPlot 5.0.36
Version: ScottPlot 5.0.36
SearchUrl: "/cookbook/5.0/search/"
ShowEditLink: false
---

# Radar Plot


<h2><a href='/cookbook/5.0/Radar/RadarQuickstart'>Radar Plot Quickstart</a></h2>

Radar charts (also called a spider charts or star charts) represent multi-axis data as a 2D shape on axes arranged circularly around a center point.

[![](/cookbook/5.0/images/RadarQuickstart.png?240629072232)](/cookbook/5.0/images/RadarQuickstart.png?240629072232)

{{< code-sp5 >}}

```cs
ScottPlot.Plot myPlot = new();

// create a collection of objects to describe the data being displayed (each has 5 values)
List<RadarSeries> radarSeries = new()
{
    new() { Values = new double[] { 5, 4, 5, 2, 3 }, Label = "Green", FillColor = Colors.Green.WithAlpha(.5) },
    new() { Values = new double[] { 2, 3, 2, 4, 2 }, Label = "Blue", FillColor = Colors.Blue.WithAlpha(.5) },
};

// add radar data to the plot
var radar = myPlot.Add.Radar(radarSeries);

// customize radar axis labels (5 axes because each RadarSeries has 5 values)
radar.Labels = new string[] { "Axis 1", "Axis 2", "Axis 3", "Axis 4", "Axis 5" }
    .Select(s => new Label() { Text = s, Alignment = Alignment.MiddleCenter })
    .ToArray();

myPlot.Axes.Frameless();
myPlot.Axes.Margins(0.5, 0.5);
myPlot.ShowLegend();
myPlot.HideGrid();

myPlot.SavePng("demo.png", 400, 300);

```

{{< /code-sp5 >}}

<hr class='my-5 invisible'>

