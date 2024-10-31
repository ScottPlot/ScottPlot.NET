---
Title: Radar Plot - ScottPlot 5.0 Cookbook
Description: Radar charts (also called a spider charts or star charts) represent multi-axis data as a 2D shape on axes arranged circularly around a center point.
URL: /cookbook/5.0/Radar/
BreadcrumbNames: ["ScottPlot 5.0 Cookbook", "Radar Plot"]
BreadcrumbUrls: ["/cookbook/5.0/", "/cookbook/5.0/Radar"]
Date: 2024-10-31
Version: ScottPlot 5.0.42
Version: ScottPlot 5.0.42
SearchUrl: "/cookbook/5.0/search/"
ShowEditLink: false
---

<h1>Radar Plot</h1>


<h2 style='border-bottom: 0;'><a href='/cookbook/5.0/Radar/RadarQuickstart'>Radar Plot Quickstart</a></h2>

<div class="d-flex mb-2">
<a class="btn btn-sm btn-primary me-1" href="/cookbook/5.0/Radar/RadarQuickstart">Recipe Permalink</a>
<a class="btn btn-sm btn-success me-1" href="/cookbook/5.0/Radar">Category: Radar Plot</a>
</div>

A radar chart can be created from a single array of values.

[![](/cookbook/5.0/images/RadarQuickstart.png?241031194635)](/cookbook/5.0/images/RadarQuickstart.png?241031194635)

{{< recipe-sp5 >}}ScottPlot.Plot myPlot = new();

double[] values = { 78, 83, 84, 76, 43 };
myPlot.Add.Radar(values);

myPlot.SavePng("demo.png", 400, 300);
{{< /recipe-sp5 >}}

<hr class='my-5 invisible'>



<h2 style='border-bottom: 0;'><a href='/cookbook/5.0/Radar/RadarMultipleQuickstart'>Radar Plot with Multiple Series</a></h2>

<div class="d-flex mb-2">
<a class="btn btn-sm btn-primary me-1" href="/cookbook/5.0/Radar/RadarMultipleQuickstart">Recipe Permalink</a>
<a class="btn btn-sm btn-success me-1" href="/cookbook/5.0/Radar">Category: Radar Plot</a>
</div>

A single radar chart can be used to display values from multiple series using a 2D array

[![](/cookbook/5.0/images/RadarMultipleQuickstart.png?241031194635)](/cookbook/5.0/images/RadarMultipleQuickstart.png?241031194635)

{{< recipe-sp5 >}}ScottPlot.Plot myPlot = new();

double[,] values = {
    { 78,  83, 84, 76, 43 },
    { 100, 50, 70, 60, 90 }
};

myPlot.Add.Radar(values);

myPlot.SavePng("demo.png", 400, 300);
{{< /recipe-sp5 >}}

<hr class='my-5 invisible'>



<h2 style='border-bottom: 0;'><a href='/cookbook/5.0/Radar/RadarLegend'>Radar Legend</a></h2>

<div class="d-flex mb-2">
<a class="btn btn-sm btn-primary me-1" href="/cookbook/5.0/Radar/RadarLegend">Recipe Permalink</a>
<a class="btn btn-sm btn-success me-1" href="/cookbook/5.0/Radar">Category: Radar Plot</a>
</div>

Collections of radar values (radar series) can be labeled so they appear in the legend

[![](/cookbook/5.0/images/RadarLegend.png?241031194635)](/cookbook/5.0/images/RadarLegend.png?241031194635)

{{< recipe-sp5 >}}ScottPlot.Plot myPlot = new();

double[,] values = {
    { 78,  83, 84, 76, 43 },
    { 100, 50, 70, 60, 90 }
};

var radar = myPlot.Add.Radar(values);
radar.Series[0].LegendText = "Sebastian";
radar.Series[1].LegendText = "Fernando";

myPlot.SavePng("demo.png", 400, 300);
{{< /recipe-sp5 >}}

<hr class='my-5 invisible'>



<h2 style='border-bottom: 0;'><a href='/cookbook/5.0/Radar/RadarSeriesCustomization'>Radar Series Customization</a></h2>

<div class="d-flex mb-2">
<a class="btn btn-sm btn-primary me-1" href="/cookbook/5.0/Radar/RadarSeriesCustomization">Recipe Permalink</a>
<a class="btn btn-sm btn-success me-1" href="/cookbook/5.0/Radar">Category: Radar Plot</a>
</div>

Radar plots have a collection of RadarSeries objects which each describe a set of values and the styling information used to display it as a shape on the radar plot. Users may change properties of radar series objects to achieve a high level of customization over each shape.

[![](/cookbook/5.0/images/RadarSeriesCustomization.png?241031194635)](/cookbook/5.0/images/RadarSeriesCustomization.png?241031194635)

{{< recipe-sp5 >}}ScottPlot.Plot myPlot = new();

double[,] values = {
    { 78,  83, 84, 76, 43 },
    { 100, 50, 70, 60, 90 }
};

var radar = myPlot.Add.Radar(values);

radar.Series[0].FillColor = Colors.Transparent;
radar.Series[0].LineColor = Colors.Blue;
radar.Series[0].LineWidth = 3;
radar.Series[0].LinePattern = LinePattern.DenselyDashed;

radar.Series[1].FillColor = Colors.Green.WithAlpha(.2);
radar.Series[1].LineColor = Colors.Green;
radar.Series[1].LineWidth = 2;

myPlot.SavePng("demo.png", 400, 300);
{{< /recipe-sp5 >}}

<hr class='my-5 invisible'>



<h2 style='border-bottom: 0;'><a href='/cookbook/5.0/Radar/RadarSpokeLabels'>Radar Spoke Labels</a></h2>

<div class="d-flex mb-2">
<a class="btn btn-sm btn-primary me-1" href="/cookbook/5.0/Radar/RadarSpokeLabels">Recipe Permalink</a>
<a class="btn btn-sm btn-success me-1" href="/cookbook/5.0/Radar">Category: Radar Plot</a>
</div>

Labels can be assigned to spokes to label values around the circumference of the radar plot

[![](/cookbook/5.0/images/RadarSpokeLabels.png?241031194635)](/cookbook/5.0/images/RadarSpokeLabels.png?241031194635)

{{< recipe-sp5 >}}ScottPlot.Plot myPlot = new();

double[,] values = {
    { 78,  83, 84, 76, 43 },
    { 100, 50, 70, 60, 90 }
};

var radar = myPlot.Add.Radar(values);

string[] spokeLabels = { "Wins", "Poles", "Podiums", "Points", "DNFs" };
radar.PolarAxis.SetSpokes(spokeLabels, length: 110);

myPlot.SavePng("demo.png", 400, 300);
{{< /recipe-sp5 >}}

<hr class='my-5 invisible'>



<h2 style='border-bottom: 0;'><a href='/cookbook/5.0/Radar/RadarRadialTicks'>Radar Radial Tick Labels</a></h2>

<div class="d-flex mb-2">
<a class="btn btn-sm btn-primary me-1" href="/cookbook/5.0/Radar/RadarRadialTicks">Recipe Permalink</a>
<a class="btn btn-sm btn-success me-1" href="/cookbook/5.0/Radar">Category: Radar Plot</a>
</div>

Radar radial tick positions and labels may be defined by the user

[![](/cookbook/5.0/images/RadarRadialTicks.png?241031194635)](/cookbook/5.0/images/RadarRadialTicks.png?241031194635)

{{< recipe-sp5 >}}ScottPlot.Plot myPlot = new();

double[,] values = {
    { 78,  83, 84, 76, 43 },
    { 100, 50, 70, 60, 90 }
};

var radar = myPlot.Add.Radar(values);

double[] tickPositions = { 25, 50, 75, 100 };
string[] tickLabels = tickPositions.Select(x => x.ToString()).ToArray();
radar.PolarAxis.SetCircles(tickPositions, tickLabels);

myPlot.SavePng("demo.png", 400, 300);
{{< /recipe-sp5 >}}

<hr class='my-5 invisible'>



<h2 style='border-bottom: 0;'><a href='/cookbook/5.0/Radar/RadarStraightLines'>Radar with Straight Lines</a></h2>

<div class="d-flex mb-2">
<a class="btn btn-sm btn-primary me-1" href="/cookbook/5.0/Radar/RadarStraightLines">Recipe Permalink</a>
<a class="btn btn-sm btn-success me-1" href="/cookbook/5.0/Radar">Category: Radar Plot</a>
</div>

Radial ticks may be rendered using straight lines instead of circles

[![](/cookbook/5.0/images/RadarStraightLines.png?241031194635)](/cookbook/5.0/images/RadarStraightLines.png?241031194635)

{{< recipe-sp5 >}}ScottPlot.Plot myPlot = new();

double[] values = { 78, 83, 100, 76, 43 };
var radar = myPlot.Add.Radar(values);
radar.PolarAxis.StraightLines = true;

myPlot.SavePng("demo.png", 400, 300);
{{< /recipe-sp5 >}}

<hr class='my-5 invisible'>


