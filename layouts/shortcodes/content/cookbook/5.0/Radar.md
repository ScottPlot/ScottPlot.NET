---
Title: Radar Plot - ScottPlot 5.0 Cookbook
Description: Radar charts (also called a spider charts or star charts) represent multi-axis data as a 2D shape on axes arranged circularly around a center point.
URL: /cookbook/5.0/Radar/
BreadcrumbNames: ["ScottPlot 5.0 Cookbook", "Radar Plot"]
BreadcrumbUrls: ["/cookbook/5.0/", "/cookbook/5.0/Radar"]
Date: 2025-08-23
Version: ScottPlot 5.0.56
Version: ScottPlot 5.0.56
SearchUrl: "/cookbook/5.0/search/"
ShowEditLink: false
---

<h1>Radar Plot</h1>


<div class='d-flex align-items-center mt-5'>
<h1 class='me-2 text-dark my-0 border-0'>Radar Plot Quickstart</h1>
<a href='/cookbook/5.0/Radar/RadarQuickstart' target='_blank'>
<img src='/images/icons/new-window.svg' style='height: 2rem;' class='new-window-icon'>
</a>
</div>

A radar chart can be created from a single array of values.

[![](/cookbook/5.0/images/RadarQuickstart.png?250822231048)](/cookbook/5.0/images/RadarQuickstart.png?250822231048)

{{< recipe-sp5 sourceUrl="https://github.com/ScottPlot/ScottPlot/blob/main/src/ScottPlot5/ScottPlot5%20Cookbook/Recipes/PlotTypes/Radar.cs" imageUrl="/cookbook/5.0/images/RadarQuickstart.png?250822231048" >}}ScottPlot.Plot myPlot = new();

double[] values = { 78, 83, 84, 76, 43 };
myPlot.Add.Radar(values);

myPlot.SavePng("demo.png", 400, 300);
{{< /recipe-sp5 >}}

<hr class='my-5 invisible'>



<div class='d-flex align-items-center mt-5'>
<h1 class='me-2 text-dark my-0 border-0'>Radar Plot with Multiple Series</h1>
<a href='/cookbook/5.0/Radar/RadarMultipleQuickstart' target='_blank'>
<img src='/images/icons/new-window.svg' style='height: 2rem;' class='new-window-icon'>
</a>
</div>

A single radar chart can be used to display values from multiple series using a 2D array

[![](/cookbook/5.0/images/RadarMultipleQuickstart.png?250822231048)](/cookbook/5.0/images/RadarMultipleQuickstart.png?250822231048)

{{< recipe-sp5 sourceUrl="https://github.com/ScottPlot/ScottPlot/blob/main/src/ScottPlot5/ScottPlot5%20Cookbook/Recipes/PlotTypes/Radar.cs" imageUrl="/cookbook/5.0/images/RadarMultipleQuickstart.png?250822231048" >}}ScottPlot.Plot myPlot = new();

double[,] values = {
    { 78,  83, 84, 76, 43 },
    { 100, 50, 70, 60, 90 }
};

myPlot.Add.Radar(values);

myPlot.SavePng("demo.png", 400, 300);
{{< /recipe-sp5 >}}

<hr class='my-5 invisible'>



<div class='d-flex align-items-center mt-5'>
<h1 class='me-2 text-dark my-0 border-0'>Radar Legend</h1>
<a href='/cookbook/5.0/Radar/RadarLegend' target='_blank'>
<img src='/images/icons/new-window.svg' style='height: 2rem;' class='new-window-icon'>
</a>
</div>

Collections of radar values (radar series) can be labeled so they appear in the legend

[![](/cookbook/5.0/images/RadarLegend.png?250822231048)](/cookbook/5.0/images/RadarLegend.png?250822231048)

{{< recipe-sp5 sourceUrl="https://github.com/ScottPlot/ScottPlot/blob/main/src/ScottPlot5/ScottPlot5%20Cookbook/Recipes/PlotTypes/Radar.cs" imageUrl="/cookbook/5.0/images/RadarLegend.png?250822231048" >}}ScottPlot.Plot myPlot = new();

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



<div class='d-flex align-items-center mt-5'>
<h1 class='me-2 text-dark my-0 border-0'>Radar Series Customization</h1>
<a href='/cookbook/5.0/Radar/RadarSeriesCustomization' target='_blank'>
<img src='/images/icons/new-window.svg' style='height: 2rem;' class='new-window-icon'>
</a>
</div>

Radar plots have a collection of RadarSeries objects which each describe a set of values and the styling information used to display it as a shape on the radar plot. Users may change properties of radar series objects to achieve a high level of customization over each shape.

[![](/cookbook/5.0/images/RadarSeriesCustomization.png?250822231048)](/cookbook/5.0/images/RadarSeriesCustomization.png?250822231048)

{{< recipe-sp5 sourceUrl="https://github.com/ScottPlot/ScottPlot/blob/main/src/ScottPlot5/ScottPlot5%20Cookbook/Recipes/PlotTypes/Radar.cs" imageUrl="/cookbook/5.0/images/RadarSeriesCustomization.png?250822231048" >}}ScottPlot.Plot myPlot = new();

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



<div class='d-flex align-items-center mt-5'>
<h1 class='me-2 text-dark my-0 border-0'>Radar Spoke Labels</h1>
<a href='/cookbook/5.0/Radar/RadarSpokeLabels' target='_blank'>
<img src='/images/icons/new-window.svg' style='height: 2rem;' class='new-window-icon'>
</a>
</div>

Labels can be assigned to spokes to label values around the circumference of the radar plot

[![](/cookbook/5.0/images/RadarSpokeLabels.png?250822231048)](/cookbook/5.0/images/RadarSpokeLabels.png?250822231048)

{{< recipe-sp5 sourceUrl="https://github.com/ScottPlot/ScottPlot/blob/main/src/ScottPlot5/ScottPlot5%20Cookbook/Recipes/PlotTypes/Radar.cs" imageUrl="/cookbook/5.0/images/RadarSpokeLabels.png?250822231048" >}}ScottPlot.Plot myPlot = new();

double[,] values = {
    { 78,  83, 84, 76, 43 },
    { 100, 50, 70, 60, 90 }
};

var radar = myPlot.Add.Radar(values);
radar.Series[0].LegendText = "A";
radar.Series[1].LegendText = "B";

string[] spokeLabels = { "Wins", "Poles", "Podiums", "Points", "DNFs" };
radar.PolarAxis.SetSpokes(spokeLabels, length: 110);

myPlot.SavePng("demo.png", 400, 300);
{{< /recipe-sp5 >}}

<hr class='my-5 invisible'>



<div class='d-flex align-items-center mt-5'>
<h1 class='me-2 text-dark my-0 border-0'>Radar Radial Tick Labels</h1>
<a href='/cookbook/5.0/Radar/RadarRadialTicks' target='_blank'>
<img src='/images/icons/new-window.svg' style='height: 2rem;' class='new-window-icon'>
</a>
</div>

Radar radial tick positions and labels may be defined by the user

[![](/cookbook/5.0/images/RadarRadialTicks.png?250822231048)](/cookbook/5.0/images/RadarRadialTicks.png?250822231048)

{{< recipe-sp5 sourceUrl="https://github.com/ScottPlot/ScottPlot/blob/main/src/ScottPlot5/ScottPlot5%20Cookbook/Recipes/PlotTypes/Radar.cs" imageUrl="/cookbook/5.0/images/RadarRadialTicks.png?250822231048" >}}ScottPlot.Plot myPlot = new();

double[,] values = {
    { 78,  83, 84, 76, 43 },
    { 100, 50, 70, 60, 90 }
};

var radar = myPlot.Add.Radar(values);

double[] tickPositions = { 25, 50, 75, 100 };
string[] tickLabels = tickPositions.Select(x =&gt; x.ToString()).ToArray();
radar.PolarAxis.SetCircles(tickPositions, tickLabels);

myPlot.SavePng("demo.png", 400, 300);
{{< /recipe-sp5 >}}

<hr class='my-5 invisible'>



<div class='d-flex align-items-center mt-5'>
<h1 class='me-2 text-dark my-0 border-0'>Radar with Straight Lines</h1>
<a href='/cookbook/5.0/Radar/RadarStraightLines' target='_blank'>
<img src='/images/icons/new-window.svg' style='height: 2rem;' class='new-window-icon'>
</a>
</div>

Radial ticks may be rendered using straight lines instead of circles

[![](/cookbook/5.0/images/RadarStraightLines.png?250822231048)](/cookbook/5.0/images/RadarStraightLines.png?250822231048)

{{< recipe-sp5 sourceUrl="https://github.com/ScottPlot/ScottPlot/blob/main/src/ScottPlot5/ScottPlot5%20Cookbook/Recipes/PlotTypes/Radar.cs" imageUrl="/cookbook/5.0/images/RadarStraightLines.png?250822231048" >}}ScottPlot.Plot myPlot = new();

double[] values = { 78, 83, 100, 76, 43 };
var radar = myPlot.Add.Radar(values);
radar.PolarAxis.StraightLines = true;

myPlot.SavePng("demo.png", 400, 300);
{{< /recipe-sp5 >}}

<hr class='my-5 invisible'>



<div class='d-flex align-items-center mt-5'>
<h1 class='me-2 text-dark my-0 border-0'>Axis on Top of Data</h1>
<a href='/cookbook/5.0/Radar/AxisOnTop' target='_blank'>
<img src='/images/icons/new-window.svg' style='height: 2rem;' class='new-window-icon'>
</a>
</div>

Radar charts can be customized so the axis is rendered on top of the data

[![](/cookbook/5.0/images/AxisOnTop.png?250822231048)](/cookbook/5.0/images/AxisOnTop.png?250822231048)

{{< recipe-sp5 sourceUrl="https://github.com/ScottPlot/ScottPlot/blob/main/src/ScottPlot5/ScottPlot5%20Cookbook/Recipes/PlotTypes/Radar.cs" imageUrl="/cookbook/5.0/images/AxisOnTop.png?250822231048" >}}ScottPlot.Plot myPlot = new();

double[] values = { 78, 83, 100, 76, 43 };
var radar = myPlot.Add.Radar(values);

// make the shape opaque
radar.Series[0].FillColor = Colors.RebeccaPurple;

// render the axis above the data
radar.IsAxisAboveData = true;

myPlot.SavePng("demo.png", 400, 300);
{{< /recipe-sp5 >}}

<hr class='my-5 invisible'>


