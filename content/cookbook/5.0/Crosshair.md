---
Title: Crosshair - ScottPlot 5.0 Cookbook
Description: A Crosshair combines a horizontal axis line and vertical axis line to mark a location in coordinate space.
URL: /cookbook/5.0/Crosshair/
BreadcrumbNames: ["ScottPlot 5.0 Cookbook", "Crosshair"]
BreadcrumbUrls: ["/cookbook/5.0/", "/cookbook/5.0/Crosshair"]
Date: 2024-07-30
Version: ScottPlot 5.0.37
Version: ScottPlot 5.0.37
SearchUrl: "/cookbook/5.0/search/"
ShowEditLink: false
---

# Crosshair


<h2><a href='/cookbook/5.0/Crosshair/CrosshairQuickstart'>Crosshair Quickstart</a></h2>

A Crosshair combines a horizontal axis line and vertical axis line to mark a location in coordinate space.

[![](/cookbook/5.0/images/CrosshairQuickstart.png?240729212327)](/cookbook/5.0/images/CrosshairQuickstart.png?240729212327)

{{< code-sp5 >}}

```cs
ScottPlot.Plot myPlot = new();

myPlot.Add.Signal(Generate.Sin());
myPlot.Add.Signal(Generate.Cos());

myPlot.Add.Crosshair(13, .25);

myPlot.SavePng("demo.png", 400, 300);

```

{{< /code-sp5 >}}

<hr class='my-5 invisible'>


<h2><a href='/cookbook/5.0/Crosshair/CrosshairCustomization'>Crosshair Customization</a></h2>

Crosshairs can be extensively customized.

[![](/cookbook/5.0/images/CrosshairCustomization.png?240729212327)](/cookbook/5.0/images/CrosshairCustomization.png?240729212327)

{{< code-sp5 >}}

```cs
ScottPlot.Plot myPlot = new();

myPlot.Add.Signal(Generate.Sin());
myPlot.Add.Signal(Generate.Cos());

var cross = myPlot.Add.Crosshair(13, .25);

// properties set style for both lines
cross.LineWidth = 2;
cross.LineColor = Colors.Magenta;

// each line's styles can be individually accessed as well
cross.HorizontalLine.LinePattern = LinePattern.Dotted;

myPlot.SavePng("demo.png", 400, 300);

```

{{< /code-sp5 >}}

<hr class='my-5 invisible'>

