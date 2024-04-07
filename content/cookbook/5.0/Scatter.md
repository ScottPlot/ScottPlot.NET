---
Title: Scatter Plot - ScottPlot 5.0 Cookbook
Description: Scatter plots display points at X/Y locations in coordinate space.
URL: /cookbook/5.0/Scatter/
BreadcrumbNames: ["ScottPlot 5.0 Cookbook", "Scatter Plot"]
BreadcrumbUrls: ["/cookbook/5.0/", "/cookbook/5.0/Scatter"]
Date: 2024-04-07
Version: ScottPlot 5.0.24
Version: ScottPlot 5.0.24
SearchUrl: "/cookbook/5.0/search/"
ShowEditLink: false
---

# Scatter Plot


<h2><a href='/cookbook/5.0/Scatter/ScatterQuickstart'>Scatter Plot Quickstart</a></h2>

Scatter plots can be created from two arrays containing X and Y values.

[![](/cookbook/5.0/images/ScatterQuickstart.png?240407170921)](/cookbook/5.0/images/ScatterQuickstart.png?240407170921)

{{< code-sp5 >}}

```cs
ScottPlot.Plot myPlot = new();

double[] xs = { 1, 2, 3, 4, 5 };
double[] ys = { 1, 4, 9, 16, 25 };

myPlot.Add.Scatter(xs, ys);

myPlot.SavePng("demo.png", 400, 300);

```

{{< /code-sp5 >}}

<hr class='my-5 invisible'>


<h2><a href='/cookbook/5.0/Scatter/ScatterCoordinates'>Scatter Plot Coordinates</a></h2>

Scatter plots can be created from a collection of Coordinates.

[![](/cookbook/5.0/images/ScatterCoordinates.png?240407170921)](/cookbook/5.0/images/ScatterCoordinates.png?240407170921)

{{< code-sp5 >}}

```cs
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

myPlot.SavePng("demo.png", 400, 300);

```

{{< /code-sp5 >}}

<hr class='my-5 invisible'>


<h2><a href='/cookbook/5.0/Scatter/ScatterDataType'>Scatter Plot Data Type</a></h2>

Scatter plots can be created from any numeric data type, not just double.

[![](/cookbook/5.0/images/ScatterDataType.png?240407170921)](/cookbook/5.0/images/ScatterDataType.png?240407170921)

{{< code-sp5 >}}

```cs
ScottPlot.Plot myPlot = new();

float[] xs = { 1, 2, 3, 4, 5 };
int[] ys = { 1, 4, 9, 16, 25 };

myPlot.Add.Scatter(xs, ys);

myPlot.SavePng("demo.png", 400, 300);

```

{{< /code-sp5 >}}

<hr class='my-5 invisible'>


<h2><a href='/cookbook/5.0/Scatter/ScatterList'>Scatter Plot of List Data</a></h2>

Scatter plots can be created from Lists, but be very cafeful not to add or remove items while a render is occurring or you may throw an index exception. See documentation about the Render Lock system for details.

[![](/cookbook/5.0/images/ScatterList.png?240407170921)](/cookbook/5.0/images/ScatterList.png?240407170921)

{{< code-sp5 >}}

```cs
ScottPlot.Plot myPlot = new();

List<double> xs = new() { 1, 2, 3, 4, 5 };
List<double> ys = new() { 1, 4, 9, 16, 25 };

myPlot.Add.Scatter(xs, ys);

myPlot.SavePng("demo.png", 400, 300);

```

{{< /code-sp5 >}}

<hr class='my-5 invisible'>


<h2><a href='/cookbook/5.0/Scatter/ScatterLine'>Scatter Plot with Lines Only</a></h2>

The `ScatterLine()` method can be used to create a scatter plot with a line only (marker size is set to 0).

[![](/cookbook/5.0/images/ScatterLine.png?240407170921)](/cookbook/5.0/images/ScatterLine.png?240407170921)

{{< code-sp5 >}}

```cs
ScottPlot.Plot myPlot = new();

double[] xs = Generate.Consecutive(51);
double[] sin = Generate.Sin(51);
double[] cos = Generate.Cos(51);

myPlot.Add.ScatterLine(xs, sin);
myPlot.Add.ScatterLine(xs, cos);

myPlot.SavePng("demo.png", 400, 300);

```

{{< /code-sp5 >}}

<hr class='my-5 invisible'>


<h2><a href='/cookbook/5.0/Scatter/ScatterPoints'>Scatter Plot with Points Only</a></h2>

The `ScatterPoints()` method can be used to create a scatter plot with markers only (line width is set to 0).

[![](/cookbook/5.0/images/ScatterPoints.png?240407170921)](/cookbook/5.0/images/ScatterPoints.png?240407170921)

{{< code-sp5 >}}

```cs
ScottPlot.Plot myPlot = new();

double[] xs = Generate.Consecutive(51);
double[] sin = Generate.Sin(51);
double[] cos = Generate.Cos(51);

myPlot.Add.ScatterPoints(xs, sin);
myPlot.Add.ScatterPoints(xs, cos);

myPlot.SavePng("demo.png", 400, 300);

```

{{< /code-sp5 >}}

<hr class='my-5 invisible'>


<h2><a href='/cookbook/5.0/Scatter/ScatterStyling'>Scatter Plot Styling</a></h2>

Scatter plots can be extensively styled by interacting with the object that is returned after a scatter plot is added. Assign text to a scatter plot's Label property to allow it to appear in the legend.

[![](/cookbook/5.0/images/ScatterStyling.png?240407170921)](/cookbook/5.0/images/ScatterStyling.png?240407170921)

{{< code-sp5 >}}

```cs
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

myPlot.SavePng("demo.png", 400, 300);

```

{{< /code-sp5 >}}

<hr class='my-5 invisible'>


<h2><a href='/cookbook/5.0/Scatter/ScatterLinePatterns'>Scatter Line Patterns</a></h2>

Several line patterns are available

[![](/cookbook/5.0/images/ScatterLinePatterns.png?240407170921)](/cookbook/5.0/images/ScatterLinePatterns.png?240407170921)

{{< code-sp5 >}}

```cs
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
    sp.LinePattern = patterns[i];
    sp.Color = palette.GetColor(i);

    var txt = myPlot.Add.Text(patterns[i].ToString(), 51, yOffset);
    txt.Label.ForeColor = sp.Color;
    txt.Label.FontSize = 22;
    txt.Label.Bold = true;
    txt.Label.Alignment = Alignment.MiddleLeft;
}

myPlot.Axes.Margins(.05, .5, .05, .05);

myPlot.SavePng("demo.png", 400, 300);

```

{{< /code-sp5 >}}

<hr class='my-5 invisible'>


<h2><a href='/cookbook/5.0/Scatter/ScatterGeneric'>Scatter Generic</a></h2>

Scatter plots support generic data types, although double is typically the most performant.

[![](/cookbook/5.0/images/ScatterGeneric.png?240407170921)](/cookbook/5.0/images/ScatterGeneric.png?240407170921)

{{< code-sp5 >}}

```cs
ScottPlot.Plot myPlot = new();

int[] xs = { 1, 2, 3, 4, 5 };
float[] ys = { 1, 4, 9, 16, 25 };

myPlot.Add.Scatter(xs, ys);

myPlot.SavePng("demo.png", 400, 300);

```

{{< /code-sp5 >}}

<hr class='my-5 invisible'>


<h2><a href='/cookbook/5.0/Scatter/ScatterDateTime'>Scatter DateTime</a></h2>

A scatter plot may use DateTime units but be sure to setup the respective axis to display using DateTime format.

[![](/cookbook/5.0/images/ScatterDateTime.png?240407170921)](/cookbook/5.0/images/ScatterDateTime.png?240407170921)

{{< code-sp5 >}}

```cs
ScottPlot.Plot myPlot = new();

DateTime[] xs = Generate.DateTime.Days(100);
double[] ys = Generate.RandomWalk(xs.Length);

myPlot.Add.Scatter(xs, ys);
myPlot.Axes.DateTimeTicksBottom();

myPlot.SavePng("demo.png", 400, 300);

```

{{< /code-sp5 >}}

<hr class='my-5 invisible'>


<h2><a href='/cookbook/5.0/Scatter/ScatterStep'>Step Plot</a></h2>

Scatter plots can be created using a step plot display where points are connected with right angles instead of diagnal lines. The direction of the steps can be customized.

[![](/cookbook/5.0/images/ScatterStep.png?240407170921)](/cookbook/5.0/images/ScatterStep.png?240407170921)

{{< code-sp5 >}}

```cs
ScottPlot.Plot myPlot = new();

double[] xs = Generate.Consecutive(20);
double[] ys1 = Generate.Consecutive(20, first: 10);
double[] ys2 = Generate.Consecutive(20, first: 5);
double[] ys3 = Generate.Consecutive(20, first: 0);

var sp1 = myPlot.Add.Scatter(xs, ys1);
sp1.ConnectStyle = ConnectStyle.Straight;
sp1.Label = "Straight";

var sp2 = myPlot.Add.Scatter(xs, ys2);
sp2.ConnectStyle = ConnectStyle.StepHorizontal;
sp2.Label = "StepHorizontal";

var sp3 = myPlot.Add.Scatter(xs, ys3);
sp3.ConnectStyle = ConnectStyle.StepVertical;
sp3.Label = "StepVertical";

myPlot.ShowLegend();

myPlot.SavePng("demo.png", 400, 300);

```

{{< /code-sp5 >}}

<hr class='my-5 invisible'>


<h2><a href='/cookbook/5.0/Scatter/ScatterWithGaps'>Scatter with Gaps</a></h2>

NaN values in a scatter plot's data will appear as gaps in the line.

[![](/cookbook/5.0/images/ScatterWithGaps.png?240407170921)](/cookbook/5.0/images/ScatterWithGaps.png?240407170921)

{{< code-sp5 >}}

```cs
ScottPlot.Plot myPlot = new();

double[] xs = Generate.Consecutive(51);
double[] ys = Generate.Sin(51);

// long stretch of empty data
for (int i = 10; i < 20; i++)
    ys[i] = double.NaN;

// single missing data point
ys[30] = double.NaN;

// single floating data point
for (int i = 35; i < 40; i++)
    ys[i] = double.NaN;
for (int i = 40; i < 45; i++)
    ys[i] = double.NaN;

myPlot.Add.Scatter(xs, ys);

myPlot.SavePng("demo.png", 400, 300);

```

{{< /code-sp5 >}}

<hr class='my-5 invisible'>


<h2><a href='/cookbook/5.0/Scatter/ScatterSmooth'>Scatter Plot with Smooth Lines</a></h2>

Scatter plots draw straight lines between points by default, but setting the Smooth property allows the scatter plot to connect points with smooth lines.

[![](/cookbook/5.0/images/ScatterSmooth.png?240407170921)](/cookbook/5.0/images/ScatterSmooth.png?240407170921)

{{< code-sp5 >}}

```cs
ScottPlot.Plot myPlot = new();

double[] xs = Generate.Consecutive(10);
double[] ys = Generate.RandomSample(10, 5, 15);

var sp = myPlot.Add.Scatter(xs, ys);
sp.Smooth = true;
sp.Label = "Smooth";
sp.LineWidth = 2;
sp.MarkerSize = 7;

myPlot.SavePng("demo.png", 400, 300);

```

{{< /code-sp5 >}}

<hr class='my-5 invisible'>


<h2><a href='/cookbook/5.0/Scatter/ScatterLimitIndex'>Limiting Display with Render Indexes</a></h2>

Although a scatter plot may contain a very large amount of data, much of it may be unpopulated. The user can define min and max render indexes, and only values within that range will be displayed when the scatter plot is rendered.

[![](/cookbook/5.0/images/ScatterLimitIndex.png?240407170921)](/cookbook/5.0/images/ScatterLimitIndex.png?240407170921)

{{< code-sp5 >}}

```cs
ScottPlot.Plot myPlot = new();

double[] xs = Generate.Consecutive(51);
double[] ys = Generate.Sin(51);

var sp = myPlot.Add.Scatter(xs, ys);
sp.MinRenderIndex = 10;
sp.MaxRenderIndex = 40;

myPlot.SavePng("demo.png", 400, 300);

```

{{< /code-sp5 >}}

<hr class='my-5 invisible'>

