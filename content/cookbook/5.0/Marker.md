---
Title: Marker - ScottPlot 5.0 Cookbook
Description: Markers can be placed on the plot in coordinate space.
URL: /cookbook/5.0/Marker/
BreadcrumbNames: ["ScottPlot 5.0 Cookbook", "Marker"]
BreadcrumbUrls: ["/cookbook/5.0/", "/cookbook/5.0/Marker"]
Date: 2024-07-30
Version: ScottPlot 5.0.37
Version: ScottPlot 5.0.37
SearchUrl: "/cookbook/5.0/search/"
ShowEditLink: false
---

# Marker


<h2><a href='/cookbook/5.0/Marker/MarkerQuickstart'>Marker Quickstart</a></h2>

Markers are symbols placed at a location in coordinate space. Their shape, size, and color can be customized.

[![](/cookbook/5.0/images/MarkerQuickstart.png?240729212327)](/cookbook/5.0/images/MarkerQuickstart.png?240729212327)

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

Standard marker shapes are provided, but advanced users are able to create their own as well.

[![](/cookbook/5.0/images/MarkerShapes.png?240729212327)](/cookbook/5.0/images/MarkerShapes.png?240729212327)

{{< code-sp5 >}}

```cs
ScottPlot.Plot myPlot = new();

MarkerShape[] markerShapes = Enum.GetValues<MarkerShape>().ToArray();
ScottPlot.Palettes.Category20 palette = new();

for (int i = 0; i < markerShapes.Length; i++)
{
    var mp = myPlot.Add.Marker(x: i, y: 0);
    mp.MarkerStyle.Shape = markerShapes[i];
    mp.MarkerStyle.Size = 10;

    // markers made from filled shapes have can be customized
    mp.MarkerStyle.FillColor = palette.GetColor(i).WithAlpha(.5);

    // markers made from filled shapes have optional outlines
    mp.MarkerStyle.OutlineColor = palette.GetColor(i);
    mp.MarkerStyle.OutlineWidth = 2;

    // markers created from lines can be customized
    mp.MarkerStyle.LineWidth = 2f;
    mp.MarkerStyle.LineColor = palette.GetColor(i);

    var txt = myPlot.Add.Text(markerShapes[i].ToString(), i, 0.15);
    txt.LabelRotation = -90;
    txt.LabelAlignment = Alignment.MiddleLeft;
    txt.LabelFontColor = Colors.Black;
}

myPlot.Title("Marker Names");
myPlot.Axes.SetLimits(-1, markerShapes.Length, -1, 4);
myPlot.HideGrid();

myPlot.SavePng("demo.png", 400, 300);

```

{{< /code-sp5 >}}

<hr class='my-5 invisible'>


<h2><a href='/cookbook/5.0/Marker/MarkerLegend'>Marker Legend</a></h2>

Markers with labels appear in the legend.

[![](/cookbook/5.0/images/MarkerLegend.png?240729212327)](/cookbook/5.0/images/MarkerLegend.png?240729212327)

{{< code-sp5 >}}

```cs
ScottPlot.Plot myPlot = new();

var sin = myPlot.Add.Signal(Generate.Sin());
sin.LegendText = "Sine";

var cos = myPlot.Add.Signal(Generate.Cos());
cos.LegendText = "Cosine";

var marker = myPlot.Add.Marker(25, .5);
marker.LegendText = "Marker";
myPlot.ShowLegend();

myPlot.SavePng("demo.png", 400, 300);

```

{{< /code-sp5 >}}

<hr class='my-5 invisible'>


<h2><a href='/cookbook/5.0/Marker/MarkersPlot'>Many Markers</a></h2>

Collections of markers that are all styled the same may be added to the plot

[![](/cookbook/5.0/images/MarkersPlot.png?240729212327)](/cookbook/5.0/images/MarkersPlot.png?240729212327)

{{< code-sp5 >}}

```cs
ScottPlot.Plot myPlot = new();

double[] xs = Generate.Consecutive(51);
double[] sin = Generate.Sin(51);
double[] cos = Generate.Cos(51);

myPlot.Add.Markers(xs, sin, MarkerShape.OpenCircle, 15, Colors.Green);
myPlot.Add.Markers(xs, cos, MarkerShape.FilledDiamond, 10, Colors.Magenta);

myPlot.SavePng("demo.png", 400, 300);

```

{{< /code-sp5 >}}

<hr class='my-5 invisible'>


<h2><a href='/cookbook/5.0/Marker/ImageMarkerQuickstart'>Image Marker</a></h2>

An ImageMarker can be placed on the plot to display an image centered at a location in coordinate space.

[![](/cookbook/5.0/images/ImageMarkerQuickstart.png?240729212327)](/cookbook/5.0/images/ImageMarkerQuickstart.png?240729212327)

{{< code-sp5 >}}

```cs
ScottPlot.Plot myPlot = new();

myPlot.Add.Signal(Generate.Sin());
myPlot.Add.Signal(Generate.Cos());

// An image can be loaded from a file or created dynamically
ScottPlot.Image image = SampleImages.ScottPlotLogo(48, 48);

Coordinates location1 = new(5, .5);
Coordinates location2 = new(25, .5);

myPlot.Add.ImageMarker(location1, image);
myPlot.Add.ImageMarker(location2, image, scale: 2);

var m1 = myPlot.Add.Marker(location1);
var m2 = myPlot.Add.Marker(location2);
m1.Color = Colors.Orange;
m2.Color = Colors.Orange;

myPlot.SavePng("demo.png", 400, 300);

```

{{< /code-sp5 >}}

<hr class='my-5 invisible'>

