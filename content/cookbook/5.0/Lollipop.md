---
Title: Lollipop Plot - ScottPlot 5.0 Cookbook
Description: A lollipop chart is a variation of a bar chart that uses a line (stem) extending from a baseline to a marker (head) to represent data points. Lollipop highlight individual data points with less visual clutter than to traditional bar charts.
URL: /cookbook/5.0/Lollipop/
BreadcrumbNames: ["ScottPlot 5.0 Cookbook", "Lollipop Plot"]
BreadcrumbUrls: ["/cookbook/5.0/", "/cookbook/5.0/Lollipop"]
Date: 2024-09-09
Version: ScottPlot 5.0.39
Version: ScottPlot 5.0.39
SearchUrl: "/cookbook/5.0/search/"
ShowEditLink: false
---

# Lollipop Plot


<h2><a href='/cookbook/5.0/Lollipop/LollipopQuickStart'>Lollipop Plot Quickstart</a></h2>

Lollipop plots can be created from a sequence of values

[![](/cookbook/5.0/images/LollipopQuickStart.png?240908210824)](/cookbook/5.0/images/LollipopQuickStart.png?240908210824)

{{< code-sp5 >}}

```cs
ScottPlot.Plot myPlot = new();

double[] values = Generate.Sin(25);
myPlot.Add.Lollipop(values);

myPlot.SavePng("demo.png", 400, 300);

```

{{< /code-sp5 >}}

<hr class='my-5 invisible'>


<h2><a href='/cookbook/5.0/Lollipop/LollipopPositions'>Lollipop Positions</a></h2>

The position of each lollipop may be defined.

[![](/cookbook/5.0/images/LollipopPositions.png?240908210824)](/cookbook/5.0/images/LollipopPositions.png?240908210824)

{{< code-sp5 >}}

```cs
ScottPlot.Plot myPlot = new();

double[] xs = Generate.Range(0, 6.28, 0.314);
double[] ys = xs.Select(Math.Sin).ToArray();
var lollipop = myPlot.Add.Lollipop(ys, xs);

myPlot.SavePng("demo.png", 400, 300);

```

{{< /code-sp5 >}}

<hr class='my-5 invisible'>


<h2><a href='/cookbook/5.0/Lollipop/BarLollipopCustom'>Lollipop Plot Customizations</a></h2>

The stem line and head marker can be extensively customized.

[![](/cookbook/5.0/images/BarLollipopCustom.png?240908210824)](/cookbook/5.0/images/BarLollipopCustom.png?240908210824)

{{< code-sp5 >}}

```cs
ScottPlot.Plot myPlot = new();

double[] values = Generate.Sin(21);
var lollipop = myPlot.Add.Lollipop(values);

lollipop.MarkerColor = Colors.Red;
lollipop.MarkerSize = 15;
lollipop.MarkerShape = MarkerShape.FilledDiamond;

lollipop.LineColor = Colors.Green;
lollipop.LineWidth = 3;
lollipop.LinePattern = LinePattern.Dotted;

myPlot.SavePng("demo.png", 400, 300);

```

{{< /code-sp5 >}}

<hr class='my-5 invisible'>


<h2><a href='/cookbook/5.0/Lollipop/LollipopHorizontal'>Horizontal Lollipop Plot</a></h2>

Change the lollipop plot's Orientation to Horizontal to cause stems to be drawn horizontally instead of vertically.

[![](/cookbook/5.0/images/LollipopHorizontal.png?240908210824)](/cookbook/5.0/images/LollipopHorizontal.png?240908210824)

{{< code-sp5 >}}

```cs
ScottPlot.Plot myPlot = new();

double[] xs = Generate.Sin(21);
double[] ys = Generate.Consecutive(21);
Coordinates[] coordinates = Coordinates.Zip(xs, ys);

var lollipop = myPlot.Add.Lollipop(coordinates);
lollipop.Orientation = Orientation.Horizontal;

myPlot.SavePng("demo.png", 400, 300);

```

{{< /code-sp5 >}}

<hr class='my-5 invisible'>

