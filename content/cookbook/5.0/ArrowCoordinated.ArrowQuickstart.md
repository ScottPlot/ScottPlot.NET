---
Title: Arrow Quickstart - ScottPlot 5.0 Cookbook
Description: Arrows can be placed on plots to point to a location in coordinate space and extensively customized.
URL: /cookbook/5.0/ArrowCoordinated/ArrowQuickstart/
BreadcrumbNames: ["ScottPlot 5.0 Cookbook", "Arrow", "Arrow Quickstart"]
BreadcrumbUrls: ["/cookbook/5.0/", "/cookbook/5.0/ArrowCoordinated", "/cookbook/5.0/ArrowCoordinated/ArrowQuickstart"]
Date: 2024-04-23
Version: ScottPlot 5.0.27
Version: ScottPlot 5.0.27
SearchUrl: "/cookbook/5.0/search/"
ShowEditLink: false
---

# Arrow Quickstart


Arrows can be placed on plots to point to a location in coordinate space and extensively customized.

[![](/cookbook/5.0/images/ArrowQuickstart.png?240423091821)](/cookbook/5.0/images/ArrowQuickstart.png?240423091821)

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

<a href='https://github.com/ScottPlot/ScottPlot/blob/main/src/ScottPlot5/ScottPlot5%20Cookbook/Recipes/PlotTypes/Arrow.cs'><svg xmlns="http://www.w3.org/2000/svg" width="16" height="16" fill="currentColor" class="mb-1 bi bi-github" viewBox="0 0 16 16">
  <path d="M8 0C3.58 0 0 3.58 0 8c0 3.54 2.29 6.53 5.47 7.59.4.07.55-.17.55-.38 0-.19-.01-.82-.01-1.49-2.01.37-2.53-.49-2.69-.94-.09-.23-.48-.94-.82-1.13-.28-.15-.68-.52-.01-.53.63-.01 1.08.58 1.23.82.72 1.21 1.87.87 2.33.66.07-.52.28-.87.51-1.07-1.78-.2-3.64-.89-3.64-3.95 0-.87.31-1.59.82-2.15-.08-.2-.36-1.02.08-2.12 0 0 .67-.21 2.2.82.64-.18 1.32-.27 2-.27s1.36.09 2 .27c1.53-1.04 2.2-.82 2.2-.82.44 1.1.16 1.92.08 2.12.51.56.82 1.27.82 2.15 0 3.07-1.87 3.75-3.65 3.95.29.25.54.73.54 1.48 0 1.07-.01 1.93-.01 2.2 0 .21.15.46.55.38A8.01 8.01 0 0 0 16 8c0-4.42-3.58-8-8-8"/>
</svg> Edit on GitHub</a>

