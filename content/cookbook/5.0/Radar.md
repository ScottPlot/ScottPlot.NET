---
Title: Radar Plot - ScottPlot 5.0 Cookbook
Description: Radar charts (also called a spider charts or star charts) represent multi-axis data as a 2D shape on axes arranged circularly around a center point.
URL: /cookbook/5.0/Radar/
BreadcrumbNames: ["ScottPlot 5.0 Cookbook", "Radar Plot"]
BreadcrumbUrls: ["/cookbook/5.0/", "/cookbook/5.0/Radar"]
Date: 2024-10-16
Version: ScottPlot 5.0.40
Version: ScottPlot 5.0.40
SearchUrl: "/cookbook/5.0/search/"
ShowEditLink: false
---

# Radar Plot


<h2><a href='/cookbook/5.0/Radar/RadarQuickstart'>Radar Plot Quickstart</a></h2>

A radar chart can be created from a single array of values.

[![](/cookbook/5.0/images/RadarQuickstart.png?241016194708)](/cookbook/5.0/images/RadarQuickstart.png?241016194708)

{{< code-sp5 >}}

```cs
ScottPlot.Plot myPlot = new();

double[] values = { 78, 83, 84, 76, 43 };
myPlot.Add.Radar(values);

myPlot.SavePng("demo.png", 400, 300);

```

{{< /code-sp5 >}}

<hr class='my-5 invisible'>


<h2><a href='/cookbook/5.0/Radar/RadarMultipleQuickstart'>Radar Plot with Multiple Series</a></h2>

A single radar chart can be used to display values from multiple series using a 2D array

[![](/cookbook/5.0/images/RadarMultipleQuickstart.png?241016194708)](/cookbook/5.0/images/RadarMultipleQuickstart.png?241016194708)

{{< code-sp5 >}}

```cs
ScottPlot.Plot myPlot = new();

double[,] values = {
    { 78,  83, 84, 76, 43 },
    { 100, 50, 70, 60, 90 }
};

myPlot.Add.Radar(values);

myPlot.SavePng("demo.png", 400, 300);

```

{{< /code-sp5 >}}

<hr class='my-5 invisible'>


<h2><a href='/cookbook/5.0/Radar/RadarLegend'>Radar Legend</a></h2>

Collections of radar values (radar series) can be labeled so they appear in the legend

[![](/cookbook/5.0/images/RadarLegend.png?241016194708)](/cookbook/5.0/images/RadarLegend.png?241016194708)

{{< code-sp5 >}}

```cs
ScottPlot.Plot myPlot = new();

double[,] values = {
    { 78,  83, 84, 76, 43 },
    { 100, 50, 70, 60, 90 }
};

var radar = myPlot.Add.Radar(values);
radar.Series[0].LegendText = "Sebastian";
radar.Series[1].LegendText = "Fernando";

myPlot.SavePng("demo.png", 400, 300);

```

{{< /code-sp5 >}}

<hr class='my-5 invisible'>


<h2><a href='/cookbook/5.0/Radar/RadarSeriesCustomization'>Radar Series Customization</a></h2>

Radar plots have a collection of RadarSeries objects which each describe a set of values and the styling information used to display it as a shape on the radar plot. Users may change properties of radar series objects to achieve a high level of customization over each shape.

[![](/cookbook/5.0/images/RadarSeriesCustomization.png?241016194708)](/cookbook/5.0/images/RadarSeriesCustomization.png?241016194708)

{{< code-sp5 >}}

```cs
ScottPlot.Plot myPlot = new();

double[,] values = {
    { 78,  83, 84, 76, 43 },
    { 100, 50, 70, 60, 90 }
};

var radar = myPlot.Add.Radar(values);

radar.Series[0].FillColor = Colors.Transparent;
radar.Series[0].LineColor = Colors.Blue;
radar.Series[0].LineWidth = 3;
radar.Series[0].LinePattern = LinePattern.DenselyDashed;

radar.Series[1].FillColor = Colors.Green.WithAlpha(.2);
radar.Series[1].LineColor = Colors.Green;
radar.Series[1].LineWidth = 2;

myPlot.SavePng("demo.png", 400, 300);

```

{{< /code-sp5 >}}

<hr class='my-5 invisible'>


<h2><a href='/cookbook/5.0/Radar/RadarSpokeLabels'>Radar Spoke Labels</a></h2>

Labels can be assigned to spokes to label values around the circumference of the radar plot

[![](/cookbook/5.0/images/RadarSpokeLabels.png?241016194708)](/cookbook/5.0/images/RadarSpokeLabels.png?241016194708)

{{< code-sp5 >}}

```cs
ScottPlot.Plot myPlot = new();

double[,] values = {
    { 78,  83, 84, 76, 43 },
    { 100, 50, 70, 60, 90 }
};

var radar = myPlot.Add.Radar(values);

string[] spokeLabels = { "Wins", "Poles", "Podiums", "Points", "DNFs" };
radar.PolarAxis.SetSpokes(spokeLabels, length: 110);

myPlot.SavePng("demo.png", 400, 300);

```

{{< /code-sp5 >}}

<hr class='my-5 invisible'>


<h2><a href='/cookbook/5.0/Radar/RadarRadialTicks'>Radar Radial Tick Labels</a></h2>

Radar radial tick positions and labels may be defined by the user

[![](/cookbook/5.0/images/RadarRadialTicks.png?241016194708)](/cookbook/5.0/images/RadarRadialTicks.png?241016194708)

{{< code-sp5 >}}

```cs
ScottPlot.Plot myPlot = new();

double[,] values = {
    { 78,  83, 84, 76, 43 },
    { 100, 50, 70, 60, 90 }
};

var radar = myPlot.Add.Radar(values);

double[] tickPositions = { 25, 50, 75, 100 };
string[] tickLabels = tickPositions.Select(x => x.ToString()).ToArray();
radar.PolarAxis.SetCircles(tickPositions, tickLabels);

myPlot.SavePng("demo.png", 400, 300);

```

{{< /code-sp5 >}}

<hr class='my-5 invisible'>


<h2><a href='/cookbook/5.0/Radar/RadarStraightLines'>Radar with Straight Lines</a></h2>

Radial ticks may be rendered using straight lines instead of circles

[![](/cookbook/5.0/images/RadarStraightLines.png?241016194708)](/cookbook/5.0/images/RadarStraightLines.png?241016194708)

{{< code-sp5 >}}

```cs
ScottPlot.Plot myPlot = new();

double[] values = { 78, 83, 100, 76, 43 };
var radar = myPlot.Add.Radar(values);
radar.PolarAxis.StraightLines = true;

myPlot.SavePng("demo.png", 400, 300);

```

{{< /code-sp5 >}}

<hr class='my-5 invisible'>

