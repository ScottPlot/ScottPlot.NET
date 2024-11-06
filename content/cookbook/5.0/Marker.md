---
Title: Marker - ScottPlot 5.0 Cookbook
Description: Markers can be placed on the plot in coordinate space.
URL: /cookbook/5.0/Marker/
BreadcrumbNames: ["ScottPlot 5.0 Cookbook", "Marker"]
BreadcrumbUrls: ["/cookbook/5.0/", "/cookbook/5.0/Marker"]
Date: 2024-11-06
Version: ScottPlot 5.0.43
Version: ScottPlot 5.0.43
SearchUrl: "/cookbook/5.0/search/"
ShowEditLink: false
---

<h1>Marker</h1>


<div class='d-flex align-items-center mt-5'>
<h1 class='me-2 text-dark my-0 border-0'>Marker Quickstart</h1>
<a href='/cookbook/5.0/Marker/MarkerQuickstart' target='_blank'>
<img src='/images/icons/new-window.svg' style='height: 2rem;' class='new-window-icon'>
</a>
</div>

Markers are symbols placed at a location in coordinate space. Their shape, size, and color can be customized.

[![](/cookbook/5.0/images/MarkerQuickstart.png?241105214550)](/cookbook/5.0/images/MarkerQuickstart.png?241105214550)

{{< recipe-sp5 sourceUrl="https://github.com/ScottPlot/ScottPlot/blob/main/src/ScottPlot5/ScottPlot5%20Cookbook/Recipes/PlotTypes/Marker.cs" imageUrl="/cookbook/5.0/images/MarkerQuickstart.png?241105214550" >}}ScottPlot.Plot myPlot = new();

myPlot.Add.Signal(Generate.Sin());
myPlot.Add.Signal(Generate.Cos());

myPlot.Add.Marker(25, .5);
myPlot.Add.Marker(35, .6);
myPlot.Add.Marker(45, .7);

myPlot.SavePng("demo.png", 400, 300);
{{< /recipe-sp5 >}}

<hr class='my-5 invisible'>



<div class='d-flex align-items-center mt-5'>
<h1 class='me-2 text-dark my-0 border-0'>Marker Shapes</h1>
<a href='/cookbook/5.0/Marker/MarkerShapes' target='_blank'>
<img src='/images/icons/new-window.svg' style='height: 2rem;' class='new-window-icon'>
</a>
</div>

Standard marker shapes are provided, but advanced users are able to create their own as well.

[![](/cookbook/5.0/images/MarkerShapes.png?241105214550)](/cookbook/5.0/images/MarkerShapes.png?241105214550)

{{< recipe-sp5 sourceUrl="https://github.com/ScottPlot/ScottPlot/blob/main/src/ScottPlot5/ScottPlot5%20Cookbook/Recipes/PlotTypes/Marker.cs" imageUrl="/cookbook/5.0/images/MarkerShapes.png?241105214550" >}}ScottPlot.Plot myPlot = new();

MarkerShape[] markerShapes = Enum.GetValues&lt;MarkerShape&gt;().ToArray();
ScottPlot.Palettes.Category20 palette = new();

for (int i = 0; i &lt; markerShapes.Length; i++)
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
{{< /recipe-sp5 >}}

<hr class='my-5 invisible'>



<div class='d-flex align-items-center mt-5'>
<h1 class='me-2 text-dark my-0 border-0'>Marker Legend</h1>
<a href='/cookbook/5.0/Marker/MarkerLegend' target='_blank'>
<img src='/images/icons/new-window.svg' style='height: 2rem;' class='new-window-icon'>
</a>
</div>

Markers with labels appear in the legend.

[![](/cookbook/5.0/images/MarkerLegend.png?241105214550)](/cookbook/5.0/images/MarkerLegend.png?241105214550)

{{< recipe-sp5 sourceUrl="https://github.com/ScottPlot/ScottPlot/blob/main/src/ScottPlot5/ScottPlot5%20Cookbook/Recipes/PlotTypes/Marker.cs" imageUrl="/cookbook/5.0/images/MarkerLegend.png?241105214550" >}}ScottPlot.Plot myPlot = new();

var sin = myPlot.Add.Signal(Generate.Sin());
sin.LegendText = "Sine";

var cos = myPlot.Add.Signal(Generate.Cos());
cos.LegendText = "Cosine";

var marker = myPlot.Add.Marker(25, .5);
marker.LegendText = "Marker";
myPlot.ShowLegend();

myPlot.SavePng("demo.png", 400, 300);
{{< /recipe-sp5 >}}

<hr class='my-5 invisible'>



<div class='d-flex align-items-center mt-5'>
<h1 class='me-2 text-dark my-0 border-0'>Many Markers</h1>
<a href='/cookbook/5.0/Marker/MarkersPlot' target='_blank'>
<img src='/images/icons/new-window.svg' style='height: 2rem;' class='new-window-icon'>
</a>
</div>

Collections of markers that are all styled the same may be added to the plot

[![](/cookbook/5.0/images/MarkersPlot.png?241105214550)](/cookbook/5.0/images/MarkersPlot.png?241105214550)

{{< recipe-sp5 sourceUrl="https://github.com/ScottPlot/ScottPlot/blob/main/src/ScottPlot5/ScottPlot5%20Cookbook/Recipes/PlotTypes/Marker.cs" imageUrl="/cookbook/5.0/images/MarkersPlot.png?241105214550" >}}ScottPlot.Plot myPlot = new();

double[] xs = Generate.Consecutive(51);
double[] sin = Generate.Sin(51);
double[] cos = Generate.Cos(51);

myPlot.Add.Markers(xs, sin, MarkerShape.OpenCircle, 15, Colors.Green);
myPlot.Add.Markers(xs, cos, MarkerShape.FilledDiamond, 10, Colors.Magenta);

myPlot.SavePng("demo.png", 400, 300);
{{< /recipe-sp5 >}}

<hr class='my-5 invisible'>



<div class='d-flex align-items-center mt-5'>
<h1 class='me-2 text-dark my-0 border-0'>Marker with Colormap</h1>
<a href='/cookbook/5.0/Marker/MarkersColormap' target='_blank'>
<img src='/images/icons/new-window.svg' style='height: 2rem;' class='new-window-icon'>
</a>
</div>

A colormap may be used to style a collection of markers

[![](/cookbook/5.0/images/MarkersColormap.png?241105214550)](/cookbook/5.0/images/MarkersColormap.png?241105214550)

{{< recipe-sp5 sourceUrl="https://github.com/ScottPlot/ScottPlot/blob/main/src/ScottPlot5/ScottPlot5%20Cookbook/Recipes/PlotTypes/Marker.cs" imageUrl="/cookbook/5.0/images/MarkersColormap.png?241105214550" >}}ScottPlot.Plot myPlot = new();

double[] xs = Generate.Consecutive(51);
double[] ys = Generate.Sin(51);

var markers = myPlot.Add.Markers(xs, ys);
markers.Colormap = new ScottPlot.Colormaps.MellowRainbow();

myPlot.SavePng("demo.png", 400, 300);
{{< /recipe-sp5 >}}

<hr class='my-5 invisible'>



<div class='d-flex align-items-center mt-5'>
<h1 class='me-2 text-dark my-0 border-0'>Image Marker</h1>
<a href='/cookbook/5.0/Marker/ImageMarkerQuickstart' target='_blank'>
<img src='/images/icons/new-window.svg' style='height: 2rem;' class='new-window-icon'>
</a>
</div>

An ImageMarker can be placed on the plot to display an image centered at a location in coordinate space.

[![](/cookbook/5.0/images/ImageMarkerQuickstart.png?241105214550)](/cookbook/5.0/images/ImageMarkerQuickstart.png?241105214550)

{{< recipe-sp5 sourceUrl="https://github.com/ScottPlot/ScottPlot/blob/main/src/ScottPlot5/ScottPlot5%20Cookbook/Recipes/PlotTypes/Marker.cs" imageUrl="/cookbook/5.0/images/ImageMarkerQuickstart.png?241105214550" >}}ScottPlot.Plot myPlot = new();

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
{{< /recipe-sp5 >}}

<hr class='my-5 invisible'>


