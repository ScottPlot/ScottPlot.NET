---
Title: Arrow - ScottPlot 5.0 Cookbook
Description: Arrows point to a location in coordinate space.
URL: /cookbook/5.0/ArrowCoordinated/
BreadcrumbNames: ["ScottPlot 5.0 Cookbook", "Arrow"]
BreadcrumbUrls: ["/cookbook/5.0/", "/cookbook/5.0/ArrowCoordinated"]
Date: 2024-04-07
Version: ScottPlot 5.0.24
Version: ScottPlot 5.0.24
SearchUrl: "/cookbook/5.0/search/"
ShowEditLink: false
---

# Arrow


<h2><a href='/cookbook/5.0/ArrowCoordinated/ArrowQuickstart'>Arrow Quickstart</a></h2>

Arrows can be placed on plots to point to a location in coordinate space and extensively customized.

[![](/cookbook/5.0/images/ArrowQuickstart.png?240407172904)](/cookbook/5.0/images/ArrowQuickstart.png?240407172904)

{{< code-sp5 >}}

```cs
ScottPlot.Plot myPlot = new();

// plot some sample data
double[] sin = Generate.Sin(51);
double[] cos = Generate.Cos(51);
myPlot.Add.Signal(sin);
myPlot.Add.Signal(cos);

// add arrows using coordinates
myPlot.Add.Arrow(27, .2, 25, 0);

// you can define a minimum length so the line persists even when zooming out
var arrow2 = myPlot.Add.Arrow(23, -.5, 27, -.25);
arrow2.Color = Colors.Red;
arrow2.MinimumLength = 100;

// the shape of the arrowhead can be adjusted
var skinny = myPlot.Add.Arrow(12, .5, 12, 1);
skinny.Color = Colors.Green;
skinny.ArrowheadLength = 24;
skinny.ArrowheadWidth = 8;

var fat = myPlot.Add.Arrow(20, 1, 20, .6);
fat.Color = Colors.Blue;
fat.ArrowheadLength = 24;
fat.ArrowheadWidth = 36;
fat.LineWidth = 8;

// offset backs the arrow away from the tip coordinate
myPlot.Add.Marker(40, 0.3);
var arrow4 = myPlot.Add.Arrow(35, 0.6, 40, 0.3);
arrow4.Color = Colors.Fuchsia;
arrow4.Offset = 10;
arrow4.MinimumLength = 50;

myPlot.SavePng("demo.png", 400, 300);

```

{{< /code-sp5 >}}

<hr class='my-5 invisible'>

