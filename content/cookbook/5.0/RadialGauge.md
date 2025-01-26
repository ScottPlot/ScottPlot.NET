---
Title: Radial gauge - ScottPlot 5.0 Cookbook
Description: A radial gauge chart displays scalar data as circular gauges.
URL: /cookbook/5.0/RadialGauge/
BreadcrumbNames: ["ScottPlot 5.0 Cookbook", "Radial gauge"]
BreadcrumbUrls: ["/cookbook/5.0/", "/cookbook/5.0/RadialGauge"]
Date: 2025-01-26
Version: ScottPlot 5.0.55
Version: ScottPlot 5.0.55
SearchUrl: "/cookbook/5.0/search/"
ShowEditLink: false
---

<h1>Radial gauge</h1>


<div class='d-flex align-items-center mt-5'>
<h1 class='me-2 text-dark my-0 border-0'>Radial gauge from values</h1>
<a href='/cookbook/5.0/RadialGauge/RadialGaugeQuickstart' target='_blank'>
<img src='/images/icons/new-window.svg' style='height: 2rem;' class='new-window-icon'>
</a>
</div>

A radial gauge chart can be created from a few values.

[![](/cookbook/5.0/images/RadialGaugeQuickstart.png?250126165944)](/cookbook/5.0/images/RadialGaugeQuickstart.png?250126165944)

{{< recipe-sp5 sourceUrl="https://github.com/ScottPlot/ScottPlot/blob/main/src/ScottPlot5/ScottPlot5%20Cookbook/Recipes/PlotTypes/RadialGauge.cs" imageUrl="/cookbook/5.0/images/RadialGaugeQuickstart.png?250126165944" >}}ScottPlot.Plot myPlot = new();

double[] values = { 100, 80, 65, 45, 20 };
myPlot.Add.RadialGaugePlot(values);

myPlot.SavePng("demo.png", 400, 300);
{{< /recipe-sp5 >}}

<hr class='my-5 invisible'>



<div class='d-flex align-items-center mt-5'>
<h1 class='me-2 text-dark my-0 border-0'>Gauge Colors</h1>
<a href='/cookbook/5.0/RadialGauge/RadialGaugeColormap' target='_blank'>
<img src='/images/icons/new-window.svg' style='height: 2rem;' class='new-window-icon'>
</a>
</div>

Gauge colors can be customized by changing the default palette.

[![](/cookbook/5.0/images/RadialGaugeColormap.png?250126165944)](/cookbook/5.0/images/RadialGaugeColormap.png?250126165944)

{{< recipe-sp5 sourceUrl="https://github.com/ScottPlot/ScottPlot/blob/main/src/ScottPlot5/ScottPlot5%20Cookbook/Recipes/PlotTypes/RadialGauge.cs" imageUrl="/cookbook/5.0/images/RadialGaugeColormap.png?250126165944" >}}ScottPlot.Plot myPlot = new();

myPlot.Add.Palette = new ScottPlot.Palettes.Nord();
double[] values = { 100, 80, 65, 45, 20 };
myPlot.Add.RadialGaugePlot(values);

myPlot.SavePng("demo.png", 400, 300);
{{< /recipe-sp5 >}}

<hr class='my-5 invisible'>



<div class='d-flex align-items-center mt-5'>
<h1 class='me-2 text-dark my-0 border-0'>Negative Values</h1>
<a href='/cookbook/5.0/RadialGauge/RadialGaugeNegative' target='_blank'>
<img src='/images/icons/new-window.svg' style='height: 2rem;' class='new-window-icon'>
</a>
</div>

Radial gauge plots support positive and negative values.

[![](/cookbook/5.0/images/RadialGaugeNegative.png?250126165944)](/cookbook/5.0/images/RadialGaugeNegative.png?250126165944)

{{< recipe-sp5 sourceUrl="https://github.com/ScottPlot/ScottPlot/blob/main/src/ScottPlot5/ScottPlot5%20Cookbook/Recipes/PlotTypes/RadialGauge.cs" imageUrl="/cookbook/5.0/images/RadialGaugeNegative.png?250126165944" >}}ScottPlot.Plot myPlot = new();

myPlot.Add.Palette = new ScottPlot.Palettes.Nord();
double[] values = { 100, 80, -65, 45, -20 };
myPlot.Add.RadialGaugePlot(values);

myPlot.SavePng("demo.png", 400, 300);
{{< /recipe-sp5 >}}

<hr class='my-5 invisible'>



<div class='d-flex align-items-center mt-5'>
<h1 class='me-2 text-dark my-0 border-0'>Sequential Gauge Mode</h1>
<a href='/cookbook/5.0/RadialGauge/RadialGaugeSequential' target='_blank'>
<img src='/images/icons/new-window.svg' style='height: 2rem;' class='new-window-icon'>
</a>
</div>

Sequential gauge mode indicates that the base of each gauge starts at the tip of the previous gauge.

[![](/cookbook/5.0/images/RadialGaugeSequential.png?250126165944)](/cookbook/5.0/images/RadialGaugeSequential.png?250126165944)

{{< recipe-sp5 sourceUrl="https://github.com/ScottPlot/ScottPlot/blob/main/src/ScottPlot5/ScottPlot5%20Cookbook/Recipes/PlotTypes/RadialGauge.cs" imageUrl="/cookbook/5.0/images/RadialGaugeSequential.png?250126165944" >}}ScottPlot.Plot myPlot = new();

myPlot.Add.Palette = new ScottPlot.Palettes.Nord();
double[] values = { 100, 80, 65, 45, 50 };
var radialGaugePlot = myPlot.Add.RadialGaugePlot(values);
radialGaugePlot.GaugeMode = ScottPlot.RadialGaugeMode.Sequential;

myPlot.SavePng("demo.png", 400, 300);
{{< /recipe-sp5 >}}

<hr class='my-5 invisible'>



<div class='d-flex align-items-center mt-5'>
<h1 class='me-2 text-dark my-0 border-0'>Reverse Order</h1>
<a href='/cookbook/5.0/RadialGauge/RadialGaugeReverse' target='_blank'>
<img src='/images/icons/new-window.svg' style='height: 2rem;' class='new-window-icon'>
</a>
</div>

Gauges are displayed from the center outward by default but the order can be customized.

[![](/cookbook/5.0/images/RadialGaugeReverse.png?250126165944)](/cookbook/5.0/images/RadialGaugeReverse.png?250126165944)

{{< recipe-sp5 sourceUrl="https://github.com/ScottPlot/ScottPlot/blob/main/src/ScottPlot5/ScottPlot5%20Cookbook/Recipes/PlotTypes/RadialGauge.cs" imageUrl="/cookbook/5.0/images/RadialGaugeReverse.png?250126165944" >}}ScottPlot.Plot myPlot = new();

myPlot.Add.Palette = new ScottPlot.Palettes.Nord();
double[] values = { 100, 80, 65, 45, 50 };
var radialGaugePlot = myPlot.Add.RadialGaugePlot(values);
radialGaugePlot.GaugeMode = ScottPlot.RadialGaugeMode.Sequential;
radialGaugePlot.OrderInsideOut = false;

myPlot.SavePng("demo.png", 400, 300);
{{< /recipe-sp5 >}}

<hr class='my-5 invisible'>



<div class='d-flex align-items-center mt-5'>
<h1 class='me-2 text-dark my-0 border-0'>Single Gauge Mode</h1>
<a href='/cookbook/5.0/RadialGauge/RadialGaugeModeSingle' target='_blank'>
<img src='/images/icons/new-window.svg' style='height: 2rem;' class='new-window-icon'>
</a>
</div>

The SingleGauge mode draws all gauges stacked together as a single gauge. This is useful for showing a progress gauges composed of many individual smaller gauges.

[![](/cookbook/5.0/images/RadialGaugeModeSingle.png?250126165944)](/cookbook/5.0/images/RadialGaugeModeSingle.png?250126165944)

{{< recipe-sp5 sourceUrl="https://github.com/ScottPlot/ScottPlot/blob/main/src/ScottPlot5/ScottPlot5%20Cookbook/Recipes/PlotTypes/RadialGauge.cs" imageUrl="/cookbook/5.0/images/RadialGaugeModeSingle.png?250126165944" >}}ScottPlot.Plot myPlot = new();

myPlot.Add.Palette = new ScottPlot.Palettes.Nord();
double[] values = { 100, 80, 65, 45 };

var radialGaugePlot = myPlot.Add.RadialGaugePlot(values);
radialGaugePlot.GaugeMode = ScottPlot.RadialGaugeMode.SingleGauge;
radialGaugePlot.MaximumAngle = 180;
radialGaugePlot.StartingAngle = 180;

myPlot.SavePng("demo.png", 400, 300);
{{< /recipe-sp5 >}}

<hr class='my-5 invisible'>



<div class='d-flex align-items-center mt-5'>
<h1 class='me-2 text-dark my-0 border-0'>Gauge Direction</h1>
<a href='/cookbook/5.0/RadialGauge/RadialGaugeDirection' target='_blank'>
<img src='/images/icons/new-window.svg' style='height: 2rem;' class='new-window-icon'>
</a>
</div>

The direction of gauges can be customized. Clockwise is used by default.

[![](/cookbook/5.0/images/RadialGaugeDirection.png?250126165944)](/cookbook/5.0/images/RadialGaugeDirection.png?250126165944)

{{< recipe-sp5 sourceUrl="https://github.com/ScottPlot/ScottPlot/blob/main/src/ScottPlot5/ScottPlot5%20Cookbook/Recipes/PlotTypes/RadialGauge.cs" imageUrl="/cookbook/5.0/images/RadialGaugeDirection.png?250126165944" >}}ScottPlot.Plot myPlot = new();

myPlot.Add.Palette = new ScottPlot.Palettes.Nord();
double[] values = { 100, 80, 65, 45, 20 };

var radialGaugePlot = myPlot.Add.RadialGaugePlot(values);
radialGaugePlot.Clockwise = false;

myPlot.SavePng("demo.png", 400, 300);
{{< /recipe-sp5 >}}

<hr class='my-5 invisible'>



<div class='d-flex align-items-center mt-5'>
<h1 class='me-2 text-dark my-0 border-0'>Gauge Size</h1>
<a href='/cookbook/5.0/RadialGauge/RadialGaugeSize' target='_blank'>
<img src='/images/icons/new-window.svg' style='height: 2rem;' class='new-window-icon'>
</a>
</div>

The empty space between gauges can be adjusted as a fraction of their width. 

[![](/cookbook/5.0/images/RadialGaugeSize.png?250126165944)](/cookbook/5.0/images/RadialGaugeSize.png?250126165944)

{{< recipe-sp5 sourceUrl="https://github.com/ScottPlot/ScottPlot/blob/main/src/ScottPlot5/ScottPlot5%20Cookbook/Recipes/PlotTypes/RadialGauge.cs" imageUrl="/cookbook/5.0/images/RadialGaugeSize.png?250126165944" >}}ScottPlot.Plot myPlot = new();

myPlot.Add.Palette = new ScottPlot.Palettes.Nord();
double[] values = { 100, 80, 65, 45, 20 };
var radialGaugePlot = myPlot.Add.RadialGaugePlot(values);
radialGaugePlot.SpaceFraction = .05;

myPlot.SavePng("demo.png", 400, 300);
{{< /recipe-sp5 >}}

<hr class='my-5 invisible'>



<div class='d-flex align-items-center mt-5'>
<h1 class='me-2 text-dark my-0 border-0'>Gauge Starting Angle</h1>
<a href='/cookbook/5.0/RadialGauge/RadialGaugeStart' target='_blank'>
<img src='/images/icons/new-window.svg' style='height: 2rem;' class='new-window-icon'>
</a>
</div>

The starting angle for gauges can be customized. 270 for North (default value), 0 for East, 90 for South, 180 for West, etc.

[![](/cookbook/5.0/images/RadialGaugeStart.png?250126165944)](/cookbook/5.0/images/RadialGaugeStart.png?250126165944)

{{< recipe-sp5 sourceUrl="https://github.com/ScottPlot/ScottPlot/blob/main/src/ScottPlot5/ScottPlot5%20Cookbook/Recipes/PlotTypes/RadialGauge.cs" imageUrl="/cookbook/5.0/images/RadialGaugeStart.png?250126165944" >}}ScottPlot.Plot myPlot = new();

myPlot.Add.Palette = new ScottPlot.Palettes.Nord();
double[] values = { 100, 80, 65, 45, 20 };

var radialGaugePlot = myPlot.Add.RadialGaugePlot(values);
radialGaugePlot.StartingAngle = 180;

myPlot.SavePng("demo.png", 400, 300);
{{< /recipe-sp5 >}}

<hr class='my-5 invisible'>



<div class='d-flex align-items-center mt-5'>
<h1 class='me-2 text-dark my-0 border-0'>Gauge Angular Range</h1>
<a href='/cookbook/5.0/RadialGauge/RadialGaugeRange' target='_blank'>
<img src='/images/icons/new-window.svg' style='height: 2rem;' class='new-window-icon'>
</a>
</div>

By default gauges are full circles (360 degrees) but smaller gauges can be created by customizing the gauge size.

[![](/cookbook/5.0/images/RadialGaugeRange.png?250126165944)](/cookbook/5.0/images/RadialGaugeRange.png?250126165944)

{{< recipe-sp5 sourceUrl="https://github.com/ScottPlot/ScottPlot/blob/main/src/ScottPlot5/ScottPlot5%20Cookbook/Recipes/PlotTypes/RadialGauge.cs" imageUrl="/cookbook/5.0/images/RadialGaugeRange.png?250126165944" >}}ScottPlot.Plot myPlot = new();

myPlot.Add.Palette = new ScottPlot.Palettes.Nord();
double[] values = { 100, 80, 65, 45, 20 };

var radialGaugePlot = myPlot.Add.RadialGaugePlot(values);
radialGaugePlot.MaximumAngle = 180;

myPlot.SavePng("demo.png", 400, 300);
{{< /recipe-sp5 >}}

<hr class='my-5 invisible'>



<div class='d-flex align-items-center mt-5'>
<h1 class='me-2 text-dark my-0 border-0'>Show Levels</h1>
<a href='/cookbook/5.0/RadialGauge/RadialGaugeLabels' target='_blank'>
<img src='/images/icons/new-window.svg' style='height: 2rem;' class='new-window-icon'>
</a>
</div>

The value of each gauge is displayed as text by default but this behavior can be overridden. Note that this is different than the labels fiels which is what appears in the legened.

[![](/cookbook/5.0/images/RadialGaugeLabels.png?250126165944)](/cookbook/5.0/images/RadialGaugeLabels.png?250126165944)

{{< recipe-sp5 sourceUrl="https://github.com/ScottPlot/ScottPlot/blob/main/src/ScottPlot5/ScottPlot5%20Cookbook/Recipes/PlotTypes/RadialGauge.cs" imageUrl="/cookbook/5.0/images/RadialGaugeLabels.png?250126165944" >}}ScottPlot.Plot myPlot = new();

myPlot.Add.Palette = new ScottPlot.Palettes.Nord();
double[] values = { 100, 80, 65, 45, 20 };

var radialGaugePlot = myPlot.Add.RadialGaugePlot(values);
radialGaugePlot.ShowLevels = false;

myPlot.SavePng("demo.png", 400, 300);
{{< /recipe-sp5 >}}

<hr class='my-5 invisible'>



<div class='d-flex align-items-center mt-5'>
<h1 class='me-2 text-dark my-0 border-0'>Gauge Label Position</h1>
<a href='/cookbook/5.0/RadialGauge/RadialGaugeLabelPos' target='_blank'>
<img src='/images/icons/new-window.svg' style='height: 2rem;' class='new-window-icon'>
</a>
</div>

Gauge level text is positioned at the tip of each gauge by default, but this position can be adjusted by the user.

[![](/cookbook/5.0/images/RadialGaugeLabelPos.png?250126165944)](/cookbook/5.0/images/RadialGaugeLabelPos.png?250126165944)

{{< recipe-sp5 sourceUrl="https://github.com/ScottPlot/ScottPlot/blob/main/src/ScottPlot5/ScottPlot5%20Cookbook/Recipes/PlotTypes/RadialGauge.cs" imageUrl="/cookbook/5.0/images/RadialGaugeLabelPos.png?250126165944" >}}ScottPlot.Plot myPlot = new();

myPlot.Add.Palette = new ScottPlot.Palettes.Nord();
double[] values = { 100, 80, 65, 45, 20 };

var radialGaugePlot = myPlot.Add.RadialGaugePlot(values);
radialGaugePlot.LabelPositionFraction = 0.5;

myPlot.SavePng("demo.png", 400, 300);
{{< /recipe-sp5 >}}

<hr class='my-5 invisible'>



<div class='d-flex align-items-center mt-5'>
<h1 class='me-2 text-dark my-0 border-0'>Gauge Label Font Percentage</h1>
<a href='/cookbook/5.0/RadialGauge/RadialGaugeLabelFontPct' target='_blank'>
<img src='/images/icons/new-window.svg' style='height: 2rem;' class='new-window-icon'>
</a>
</div>

Size of the gauge level text as a fraction of the gauge width.

[![](/cookbook/5.0/images/RadialGaugeLabelFontPct.png?250126165944)](/cookbook/5.0/images/RadialGaugeLabelFontPct.png?250126165944)

{{< recipe-sp5 sourceUrl="https://github.com/ScottPlot/ScottPlot/blob/main/src/ScottPlot5/ScottPlot5%20Cookbook/Recipes/PlotTypes/RadialGauge.cs" imageUrl="/cookbook/5.0/images/RadialGaugeLabelFontPct.png?250126165944" >}}ScottPlot.Plot myPlot = new();

myPlot.Add.Palette = new ScottPlot.Palettes.Nord();
double[] values = { 100, 80, 65, 45, 20 };

var radialGaugePlot = myPlot.Add.RadialGaugePlot(values);
radialGaugePlot.FontSizeFraction = .4;

myPlot.SavePng("demo.png", 400, 300);
{{< /recipe-sp5 >}}

<hr class='my-5 invisible'>



<div class='d-flex align-items-center mt-5'>
<h1 class='me-2 text-dark my-0 border-0'>Gauge Label Color</h1>
<a href='/cookbook/5.0/RadialGauge/RadialGaugeLabelColor' target='_blank'>
<img src='/images/icons/new-window.svg' style='height: 2rem;' class='new-window-icon'>
</a>
</div>

Level text fonts may be customized.

[![](/cookbook/5.0/images/RadialGaugeLabelColor.png?250126165944)](/cookbook/5.0/images/RadialGaugeLabelColor.png?250126165944)

{{< recipe-sp5 sourceUrl="https://github.com/ScottPlot/ScottPlot/blob/main/src/ScottPlot5/ScottPlot5%20Cookbook/Recipes/PlotTypes/RadialGauge.cs" imageUrl="/cookbook/5.0/images/RadialGaugeLabelColor.png?250126165944" >}}ScottPlot.Plot myPlot = new();

myPlot.Add.Palette = new ScottPlot.Palettes.Nord();
double[] values = { 100, 80, 65, 45, 20 };

var radialGaugePlot = myPlot.Add.RadialGaugePlot(values);
radialGaugePlot.Font.Color = Colors.Black;

myPlot.SavePng("demo.png", 400, 300);
{{< /recipe-sp5 >}}

<hr class='my-5 invisible'>



<div class='d-flex align-items-center mt-5'>
<h1 class='me-2 text-dark my-0 border-0'>Gauge Labels in Legend</h1>
<a href='/cookbook/5.0/RadialGauge/RadialGaugeLegend' target='_blank'>
<img src='/images/icons/new-window.svg' style='height: 2rem;' class='new-window-icon'>
</a>
</div>

Radial gauge labels will appear in the legend if they are assigned. 

[![](/cookbook/5.0/images/RadialGaugeLegend.png?250126165944)](/cookbook/5.0/images/RadialGaugeLegend.png?250126165944)

{{< recipe-sp5 sourceUrl="https://github.com/ScottPlot/ScottPlot/blob/main/src/ScottPlot5/ScottPlot5%20Cookbook/Recipes/PlotTypes/RadialGauge.cs" imageUrl="/cookbook/5.0/images/RadialGaugeLegend.png?250126165944" >}}ScottPlot.Plot myPlot = new();

myPlot.Add.Palette = new ScottPlot.Palettes.Nord();
double[] values = { 100, 80, 65, 45, 20 };

var radialGaugePlot = myPlot.Add.RadialGaugePlot(values);
radialGaugePlot.Labels = new string[] { "alpha", "beta", "gamma", "delta", "epsilon" };
myPlot.ShowLegend();

myPlot.SavePng("demo.png", 400, 300);
{{< /recipe-sp5 >}}

<hr class='my-5 invisible'>



<div class='d-flex align-items-center mt-5'>
<h1 class='me-2 text-dark my-0 border-0'>Background Gauges Dim</h1>
<a href='/cookbook/5.0/RadialGauge/RadialGaugeBackDim' target='_blank'>
<img src='/images/icons/new-window.svg' style='height: 2rem;' class='new-window-icon'>
</a>
</div>

By default the full range of each gauge is drawn as a semitransparent ring. The amount of transparency can be adjusted as desired.

[![](/cookbook/5.0/images/RadialGaugeBackDim.png?250126165944)](/cookbook/5.0/images/RadialGaugeBackDim.png?250126165944)

{{< recipe-sp5 sourceUrl="https://github.com/ScottPlot/ScottPlot/blob/main/src/ScottPlot5/ScottPlot5%20Cookbook/Recipes/PlotTypes/RadialGauge.cs" imageUrl="/cookbook/5.0/images/RadialGaugeBackDim.png?250126165944" >}}ScottPlot.Plot myPlot = new();

myPlot.Add.Palette = new ScottPlot.Palettes.Nord();
double[] values = { 100, 80, 65, 45, 20 };

var radialGaugePlot = myPlot.Add.RadialGaugePlot(values);
radialGaugePlot.BackgroundTransparencyFraction = .5;

myPlot.SavePng("demo.png", 400, 300);
{{< /recipe-sp5 >}}

<hr class='my-5 invisible'>



<div class='d-flex align-items-center mt-5'>
<h1 class='me-2 text-dark my-0 border-0'>Background Gauges Normalization</h1>
<a href='/cookbook/5.0/RadialGauge/RadialGaugeBackNorm' target='_blank'>
<img src='/images/icons/new-window.svg' style='height: 2rem;' class='new-window-icon'>
</a>
</div>

Gauge backgrounds are drawn as full circles by default. This behavior can be disabled to draw partial backgrounds for non-circular gauges.

[![](/cookbook/5.0/images/RadialGaugeBackNorm.png?250126165944)](/cookbook/5.0/images/RadialGaugeBackNorm.png?250126165944)

{{< recipe-sp5 sourceUrl="https://github.com/ScottPlot/ScottPlot/blob/main/src/ScottPlot5/ScottPlot5%20Cookbook/Recipes/PlotTypes/RadialGauge.cs" imageUrl="/cookbook/5.0/images/RadialGaugeBackNorm.png?250126165944" >}}ScottPlot.Plot myPlot = new();

myPlot.Add.Palette = new ScottPlot.Palettes.Nord();
double[] values = { 100, 80, 65, 45, 20 };

var radialGaugePlot = myPlot.Add.RadialGaugePlot(values);
radialGaugePlot.CircularBackground = false;
radialGaugePlot.MaximumAngle = 180;
radialGaugePlot.StartingAngle = 180;

myPlot.SavePng("demo.png", 400, 300);
{{< /recipe-sp5 >}}

<hr class='my-5 invisible'>


