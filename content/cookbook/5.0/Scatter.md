---
Title: Scatter Plot - ScottPlot 5.0 Cookbook
Description: Scatter plots display points at X/Y locations in coordinate space.
URL: /cookbook/5.0/Scatter/
BreadcrumbNames: ["ScottPlot 5.0 Cookbook", "Scatter Plot"]
BreadcrumbUrls: ["/cookbook/5.0/", "/cookbook/5.0/Scatter"]
Date: 2024-01-09
Version: ScottPlot 5.0.12-beta
Version: ScottPlot 5.0.12-beta
SearchUrl: "/cookbook/5.0/search/"
ShowEditLink: false
---

# Scatter Plot



<div class='alert alert-warning' role='alert'><h4 class='alert-heading py-0 my-0'>⚠️ ScottPlot 5.0.12-beta is a preview package</h4><hr /><p class='mb-0'><span class='fw-semibold'>This page describes a beta release of ScottPlot.</span> It is available on NuGet as a preview package, but its API is not stable and it is not recommended for production use. See the <a href='https://scottplot.net/versions/'>ScottPlot Versions</a> page for more information. </p></div>



<h2><a href='/cookbook/5.0/Scatter/ScatterQuickstart'>Scatter Plot Quickstart</a></h2>

Scatter plots can be created from two arrays containing X and Y values.

[![](/cookbook/5.0/images/ScatterQuickstart.png)](/cookbook/5.0/images/ScatterQuickstart.png)

```cs
ScottPlot.Version.ShouldBe(5, 0, 12);
ScottPlot.Plot myPlot = new();

double[] xs = { 1, 2, 3, 4, 5 };
double[] ys = { 1, 4, 9, 16, 25 };

myPlot.Add.Scatter(xs, ys);

myPlot.SavePng("demo.png");

```

<hr class='my-5 invisible'>


<h2><a href='/cookbook/5.0/Scatter/ScatterCoordinates'>Scatter Plot Coordinates</a></h2>

Scatter plots can be created from a collection of Coordinates.

[![](/cookbook/5.0/images/ScatterCoordinates.png)](/cookbook/5.0/images/ScatterCoordinates.png)

```cs
ScottPlot.Version.ShouldBe(5, 0, 12);
ScottPlot.Plot myPlot = new();

Coordinates[] coordinates =
{
    new(1, 1),
    new(2, 4),
    new(3, 9),
    new(4, 16),
    new(5, 25),
};

myPlot.Add.Scatter(coordinates);

myPlot.SavePng("demo.png");

```

<hr class='my-5 invisible'>


<h2><a href='/cookbook/5.0/Scatter/ScatterDataType'>Scatter Plot Data Type</a></h2>

Scatter plots can be created from any numeric data type, not just double.

[![](/cookbook/5.0/images/ScatterDataType.png)](/cookbook/5.0/images/ScatterDataType.png)

```cs
ScottPlot.Version.ShouldBe(5, 0, 12);
ScottPlot.Plot myPlot = new();

float[] xs = { 1, 2, 3, 4, 5 };
int[] ys = { 1, 4, 9, 16, 25 };

myPlot.Add.Scatter(xs, ys);

myPlot.SavePng("demo.png");

```

<hr class='my-5 invisible'>


<h2><a href='/cookbook/5.0/Scatter/ScatterList'>Scatter Plot of List Data</a></h2>

Scatter plots can be created from Lists, but be very cafeful not to add or remove items while a render is occurring or you may throw an index exception. See documentation about the Render Lock system for details.

[![](/cookbook/5.0/images/ScatterList.png)](/cookbook/5.0/images/ScatterList.png)

```cs
ScottPlot.Version.ShouldBe(5, 0, 12);
ScottPlot.Plot myPlot = new();

List<double> xs = new() { 1, 2, 3, 4, 5 };
List<double> ys = new() { 1, 4, 9, 16, 25 };

myPlot.Add.Scatter(xs, ys);

myPlot.SavePng("demo.png");

```

<hr class='my-5 invisible'>


<h2><a href='/cookbook/5.0/Scatter/ScatterStyling'>Scatter Plot Styling</a></h2>

Scatter plots can be extensively styled by interacting with the object that is returned after a scatter plot is added. Assign text to a scatter plot's Label property to allow it to appear in the legend.

[![](/cookbook/5.0/images/ScatterStyling.png)](/cookbook/5.0/images/ScatterStyling.png)

```cs
ScottPlot.Version.ShouldBe(5, 0, 12);
ScottPlot.Plot myPlot = new();

double[] xs = Generate.Consecutive(51);
double[] ys1 = Generate.Sin(51);
double[] ys2 = Generate.Cos(51);

var sp1 = myPlot.Add.Scatter(xs, ys1);
sp1.Label = "Sine";
sp1.LineWidth = 3;
sp1.Color = Colors.Magenta;
sp1.MarkerSize = 15;

var sp2 = myPlot.Add.Scatter(xs, ys2);
sp2.Label = "Cosine";
sp2.LineWidth = 2;
sp2.Color = Colors.Green;
sp2.MarkerSize = 10;

myPlot.ShowLegend();

myPlot.SavePng("demo.png");

```

<hr class='my-5 invisible'>


<h2><a href='/cookbook/5.0/Scatter/ScatterLinePatterns'>Scatter Line Patterns</a></h2>

Several line patterns are available

[![](/cookbook/5.0/images/ScatterLinePatterns.png)](/cookbook/5.0/images/ScatterLinePatterns.png)

```cs
ScottPlot.Version.ShouldBe(5, 0, 12);
ScottPlot.Plot myPlot = new();

LinePattern[] patterns = Enum.GetValues<LinePattern>();
ScottPlot.Palettes.ColorblindFriendly palette = new();

for (int i = 0; i < patterns.Length; i++)
{
    double yOffset = patterns.Length - i;
    double[] xs = Generate.Consecutive(51);
    double[] ys = Generate.Sin(51, offset: yOffset);

    var sp = myPlot.Add.Scatter(xs, ys);
    sp.LineWidth = 2;
    sp.MarkerSize = 0;
    sp.LineStyle.Pattern = patterns[i];
    sp.Color = palette.GetColor(i);

    var txt = myPlot.Add.Text(patterns[i].ToString(), 51, yOffset);
    txt.Label.ForeColor = sp.Color;
    txt.Label.FontSize = 22;
    txt.Label.Bold = true;
    txt.Label.Alignment = Alignment.MiddleLeft;
}

myPlot.Axes.Margins(.05, .5, .05, .05);

myPlot.SavePng("demo.png");

```

<hr class='my-5 invisible'>

