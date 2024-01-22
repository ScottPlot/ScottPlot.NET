---
Title: Marker - ScottPlot 5.0 Cookbook
Description: Markers can be placed on the plot in coordinate space.
URL: /cookbook/5.0/Marker/
BreadcrumbNames: ["ScottPlot 5.0 Cookbook", "Marker"]
BreadcrumbUrls: ["/cookbook/5.0/", "/cookbook/5.0/Marker"]
Date: 2024-01-22
Version: ScottPlot 5.0.20
Version: ScottPlot 5.0.20
SearchUrl: "/cookbook/5.0/search/"
ShowEditLink: false
---

# Marker


<h2><a href='/cookbook/5.0/Marker/MarkerQuickstart'>Marker Quickstart</a></h2>

Markers are symbols placed at a location in coordinate space. Their shape, size, and color can be customized.

[![](/cookbook/5.0/images/MarkerQuickstart.png)](/cookbook/5.0/images/MarkerQuickstart.png)

{{< code-sp5 >}}

```cs
ScottPlot.Plot myPlot = new();

myPlot.Add.Signal(Generate.Sin());
myPlot.Add.Signal(Generate.Cos());

myPlot.Add.Marker(25, .5);
myPlot.Add.Marker(35, .6);
myPlot.Add.Marker(45, .7);

myPlot.SavePng("demo.png", 400, 300);

```

{{< /code-sp5 >}}

<hr class='my-5 invisible'>


<h2><a href='/cookbook/5.0/Marker/MarkerShapes'>Marker Shapes</a></h2>

Many marker shapes are available.

[![](/cookbook/5.0/images/MarkerShapes.png)](/cookbook/5.0/images/MarkerShapes.png)

{{< code-sp5 >}}

```cs
ScottPlot.Plot myPlot = new();

ScottPlot.Colormaps.Turbo colormap = new();

for (int i = 0; i < 100; i++)
{
    MarkerShape shape = Generate.RandomMarkerShape();
    Coordinates location = Generate.RandomCoordinates();
    float size = Generate.RandomInteger(5, 10);
    Color color = Generate.RandomColor(colormap);

    myPlot.Add.Marker(location, shape, size, color);
}

myPlot.SavePng("demo.png", 400, 300);

```

{{< /code-sp5 >}}

<hr class='my-5 invisible'>


<h2><a href='/cookbook/5.0/Marker/MarkerLegend'>Marker Legend</a></h2>

Markers with labels appear in the legend.

[![](/cookbook/5.0/images/MarkerLegend.png)](/cookbook/5.0/images/MarkerLegend.png)

{{< code-sp5 >}}

```cs
ScottPlot.Plot myPlot = new();

var sin = myPlot.Add.Signal(Generate.Sin());
sin.Label = "Sine";

var cos = myPlot.Add.Signal(Generate.Cos());
cos.Label = "Cosine";

var marker = myPlot.Add.Marker(25, .5);
marker.Label = "Marker";
myPlot.ShowLegend();

myPlot.SavePng("demo.png", 400, 300);

```

{{< /code-sp5 >}}

<hr class='my-5 invisible'>

