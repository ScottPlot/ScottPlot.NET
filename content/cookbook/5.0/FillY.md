---
Title: FillY plot - ScottPlot 5.0 Cookbook
Description: FillY plots display the vertical range between two Y values at defined X positions
URL: /cookbook/5.0/FillY/
BreadcrumbNames: ["ScottPlot 5.0 Cookbook", "FillY plot"]
BreadcrumbUrls: ["/cookbook/5.0/", "/cookbook/5.0/FillY"]
Date: 2024-01-10
Version: ScottPlot 5.0.13-beta
Version: ScottPlot 5.0.13-beta
SearchUrl: "/cookbook/5.0/search/"
ShowEditLink: false
---

# FillY plot



<div class='alert alert-warning' role='alert'><h4 class='alert-heading py-0 my-0'>⚠️ ScottPlot 5.0.13-beta is a preview package</h4><hr /><p class='mb-0'><span class='fw-semibold'>This page describes a beta release of ScottPlot.</span> It is available on NuGet as a preview package, but its API is not stable and it is not recommended for production use. See the <a href='https://scottplot.net/versions/'>ScottPlot Versions</a> page for more information. </p></div>



<h2><a href='/cookbook/5.0/FillY/FillYFromArrays'>FillY From Array Data</a></h2>

FillY plots can be created from X, Y1, and Y2 arrays.

[![](/cookbook/5.0/images/FillYFromArrays.png)](/cookbook/5.0/images/FillYFromArrays.png)

```cs
ScottPlot.Version.ShouldBe(5, 0, 13);
ScottPlot.Plot myPlot = new();

RandomDataGenerator dataGen = new(0);

int count = 20;
double[] xs = ScottPlot.Generate.Consecutive(count);
double[] ys1 = dataGen.RandomWalk(count, offset: -5);
double[] ys2 = dataGen.RandomWalk(count, offset: 5);

var xyy = myPlot.Add.FillY(xs, ys1, ys2);
xyy.FillStyle.Color = Colors.Magenta.WithAlpha(100);

myPlot.SavePng("demo.png");

```

<hr class='my-5 invisible'>


<h2><a href='/cookbook/5.0/FillY/FillYFromScatters'>FillY From Scatter Plots</a></h2>

FillY plots can be created from two scatter plots that share the same X values.

[![](/cookbook/5.0/images/FillYFromScatters.png)](/cookbook/5.0/images/FillYFromScatters.png)

```cs
ScottPlot.Version.ShouldBe(5, 0, 13);
ScottPlot.Plot myPlot = new();

RandomDataGenerator dataGen = new(0);

int count = 20;
double[] xs = ScottPlot.Generate.Consecutive(count);
double[] ys1 = dataGen.RandomWalk(count, offset: -5);
double[] ys2 = dataGen.RandomWalk(count, offset: 5);

var scatter1 = myPlot.Add.Scatter(xs, ys1);
var scatter2 = myPlot.Add.Scatter(xs, ys2);

var xyy = myPlot.Add.FillY(scatter1, scatter2);
xyy.FillStyle.Color = Colors.Blue.WithAlpha(100);

myPlot.SavePng("demo.png");

```

<hr class='my-5 invisible'>


<h2><a href='/cookbook/5.0/FillY/Function'>FillY with Custom Type</a></h2>

FillY plots can be created from data of any type if a conversion function is supplied.

[![](/cookbook/5.0/images/Function.png)](/cookbook/5.0/images/Function.png)

```cs
ScottPlot.Version.ShouldBe(5, 0, 13);
ScottPlot.Plot myPlot = new();

// create source data in a nonstandard data type
List<(int, int, int)> data = new();
Random rand = new(0);
for (int i = 0; i < 10; i++)
{
    int x = i;
    int y1 = rand.Next(0, 10);
    int y2 = rand.Next(20, 30);
    data.Add((x, y1, y2));
}

// create a custom converter for the source data type
static (double, double, double) MyConverter((int, int, int) s) => (s.Item1, s.Item2, s.Item3);

// create a filled plot from source data using the custom converter
myPlot.Add.FillY(data, MyConverter);

myPlot.SavePng("demo.png");

```

<hr class='my-5 invisible'>


<h2><a href='/cookbook/5.0/FillY/Styling'>FillY Plot Styling</a></h2>

FillY plots can be customized using public properties.

[![](/cookbook/5.0/images/Styling.png)](/cookbook/5.0/images/Styling.png)

```cs
ScottPlot.Version.ShouldBe(5, 0, 13);
ScottPlot.Plot myPlot = new();

RandomDataGenerator dataGen = new(0);

int count = 20;
double[] xs = ScottPlot.Generate.Consecutive(count);
double[] ys1 = dataGen.RandomWalk(count, offset: -5);
double[] ys2 = dataGen.RandomWalk(count, offset: 5);

var xyy = myPlot.Add.FillY(xs, ys1, ys2);
xyy.FillStyle.Color = Colors.OrangeRed.WithAlpha(100);

xyy.MarkerStyle.IsVisible = true;
xyy.MarkerStyle.Shape = MarkerShape.OpenSquare;
xyy.MarkerStyle.Size = 8;

xyy.LineStyle.AntiAlias = true;
xyy.LineStyle.Color = Colors.DarkBlue;
xyy.LineStyle.Pattern = LinePattern.Dotted;
xyy.LineStyle.Width = 2;
xyy.Label = "xyy";

myPlot.Legend.IsVisible = true;

myPlot.SavePng("demo.png");

```

<hr class='my-5 invisible'>

