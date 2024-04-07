---
Title: Radial gauge - ScottPlot 5.0 Cookbook
Description: A radial gauge chart displays scalar data as circular gauges.
URL: /cookbook/5.0/RadialGauge/
BreadcrumbNames: ["ScottPlot 5.0 Cookbook", "Radial gauge"]
BreadcrumbUrls: ["/cookbook/5.0/", "/cookbook/5.0/RadialGauge"]
Date: 2024-04-07
Version: ScottPlot 5.0.24
Version: ScottPlot 5.0.24
SearchUrl: "/cookbook/5.0/search/"
ShowEditLink: false
---

# Radial gauge


<h2><a href='/cookbook/5.0/RadialGauge/RadialGaugeQuickstart'>Radial gauge from values</a></h2>

A radial gauge chart can be created from a few values.

[![](/cookbook/5.0/images/RadialGaugeQuickstart.png?240407172904)](/cookbook/5.0/images/RadialGaugeQuickstart.png?240407172904)

{{< code-sp5 >}}

```cs
ScottPlot.Plot myPlot = new();

double[] values = { 100, 80, 65, 45, 20 };
myPlot.Add.RadialGaugePlot(values);

myPlot.SavePng("demo.png", 400, 300);

```

{{< /code-sp5 >}}

<hr class='my-5 invisible'>


<h2><a href='/cookbook/5.0/RadialGauge/RadialGaugeColormap'>Gauge Colors</a></h2>

Gauge colors can be customized by changing the default palette.

[![](/cookbook/5.0/images/RadialGaugeColormap.png?240407172904)](/cookbook/5.0/images/RadialGaugeColormap.png?240407172904)

{{< code-sp5 >}}

```cs
ScottPlot.Plot myPlot = new();

myPlot.Add.Palette = new ScottPlot.Palettes.Nord();
double[] values = { 100, 80, 65, 45, 20 };
myPlot.Add.RadialGaugePlot(values);

myPlot.SavePng("demo.png", 400, 300);

```

{{< /code-sp5 >}}

<hr class='my-5 invisible'>


<h2><a href='/cookbook/5.0/RadialGauge/RadialGaugeNegative'>Negative Values</a></h2>

Radial gauge plots support positive and negative values.

[![](/cookbook/5.0/images/RadialGaugeNegative.png?240407172904)](/cookbook/5.0/images/RadialGaugeNegative.png?240407172904)

{{< code-sp5 >}}

```cs
ScottPlot.Plot myPlot = new();

myPlot.Add.Palette = new ScottPlot.Palettes.Nord();
double[] values = { 100, 80, -65, 45, -20 };
myPlot.Add.RadialGaugePlot(values);

myPlot.SavePng("demo.png", 400, 300);

```

{{< /code-sp5 >}}

<hr class='my-5 invisible'>


<h2><a href='/cookbook/5.0/RadialGauge/RadialGaugeSequential'>Sequential Gauge Mode</a></h2>

Sequential gauge mode indicates that the base of each gauge starts at the tip of the previous gauge.

[![](/cookbook/5.0/images/RadialGaugeSequential.png?240407172904)](/cookbook/5.0/images/RadialGaugeSequential.png?240407172904)

{{< code-sp5 >}}

```cs
ScottPlot.Plot myPlot = new();

myPlot.Add.Palette = new ScottPlot.Palettes.Nord();
double[] values = { 100, 80, 65, 45, 50 };
var radialGaugePlot = myPlot.Add.RadialGaugePlot(values);
radialGaugePlot.GaugeMode = ScottPlot.RadialGaugeMode.Sequential;

myPlot.SavePng("demo.png", 400, 300);

```

{{< /code-sp5 >}}

<hr class='my-5 invisible'>


<h2><a href='/cookbook/5.0/RadialGauge/RadialGaugeReverse'>Reverse Order</a></h2>

Gauges are displayed from the center outward by default but the order can be customized.

[![](/cookbook/5.0/images/RadialGaugeReverse.png?240407172904)](/cookbook/5.0/images/RadialGaugeReverse.png?240407172904)

{{< code-sp5 >}}

```cs
ScottPlot.Plot myPlot = new();

myPlot.Add.Palette = new ScottPlot.Palettes.Nord();
double[] values = { 100, 80, 65, 45, 50 };
var radialGaugePlot = myPlot.Add.RadialGaugePlot(values);
radialGaugePlot.GaugeMode = ScottPlot.RadialGaugeMode.Sequential;
radialGaugePlot.OrderInsideOut = false;

myPlot.SavePng("demo.png", 400, 300);

```

{{< /code-sp5 >}}

<hr class='my-5 invisible'>


<h2><a href='/cookbook/5.0/RadialGauge/RadialGaugeModeSingle'>Single Gauge Mode</a></h2>

The SingleGauge mode draws all gauges stacked together as a single gauge. This is useful for showing a progress gauges composed of many individual smaller gauges.

[![](/cookbook/5.0/images/RadialGaugeModeSingle.png?240407172904)](/cookbook/5.0/images/RadialGaugeModeSingle.png?240407172904)

{{< code-sp5 >}}

```cs
ScottPlot.Plot myPlot = new();

myPlot.Add.Palette = new ScottPlot.Palettes.Nord();
double[] values = { 100, 80, 65, 45 };

var radialGaugePlot = myPlot.Add.RadialGaugePlot(values);
radialGaugePlot.GaugeMode = ScottPlot.RadialGaugeMode.SingleGauge;
radialGaugePlot.MaximumAngle = 180;
radialGaugePlot.StartingAngle = 180;

myPlot.SavePng("demo.png", 400, 300);

```

{{< /code-sp5 >}}

<hr class='my-5 invisible'>


<h2><a href='/cookbook/5.0/RadialGauge/RadialGaugeDirection'>Gauge Direction</a></h2>

The direction of gauges can be customized. Clockwise is used by default.

[![](/cookbook/5.0/images/RadialGaugeDirection.png?240407172904)](/cookbook/5.0/images/RadialGaugeDirection.png?240407172904)

{{< code-sp5 >}}

```cs
ScottPlot.Plot myPlot = new();

myPlot.Add.Palette = new ScottPlot.Palettes.Nord();
double[] values = { 100, 80, 65, 45, 20 };

var radialGaugePlot = myPlot.Add.RadialGaugePlot(values);
radialGaugePlot.Clockwise = false;

myPlot.SavePng("demo.png", 400, 300);

```

{{< /code-sp5 >}}

<hr class='my-5 invisible'>


<h2><a href='/cookbook/5.0/RadialGauge/RadialGaugeSize'>Gauge Size</a></h2>

The empty space between gauges can be adjusted as a fraction of their width. 

[![](/cookbook/5.0/images/RadialGaugeSize.png?240407172904)](/cookbook/5.0/images/RadialGaugeSize.png?240407172904)

{{< code-sp5 >}}

```cs
ScottPlot.Plot myPlot = new();

myPlot.Add.Palette = new ScottPlot.Palettes.Nord();
double[] values = { 100, 80, 65, 45, 20 };
var radialGaugePlot = myPlot.Add.RadialGaugePlot(values);
radialGaugePlot.SpaceFraction = .05;

myPlot.SavePng("demo.png", 400, 300);

```

{{< /code-sp5 >}}

<hr class='my-5 invisible'>


<h2><a href='/cookbook/5.0/RadialGauge/RadialGaugeStart'>Gauge Starting Angle</a></h2>

The starting angle for gauges can be customized. 270 for North (default value), 0 for East, 90 for South, 180 for West, etc.

[![](/cookbook/5.0/images/RadialGaugeStart.png?240407172904)](/cookbook/5.0/images/RadialGaugeStart.png?240407172904)

{{< code-sp5 >}}

```cs
ScottPlot.Plot myPlot = new();

myPlot.Add.Palette = new ScottPlot.Palettes.Nord();
double[] values = { 100, 80, 65, 45, 20 };

var radialGaugePlot = myPlot.Add.RadialGaugePlot(values);
radialGaugePlot.StartingAngle = 180;

myPlot.SavePng("demo.png", 400, 300);

```

{{< /code-sp5 >}}

<hr class='my-5 invisible'>


<h2><a href='/cookbook/5.0/RadialGauge/RadialGaugeRange'>Gauge Angular Range</a></h2>

By default gauges are full circles (360 degrees) but smaller gauges can be created by customizing the gauge size.

[![](/cookbook/5.0/images/RadialGaugeRange.png?240407172904)](/cookbook/5.0/images/RadialGaugeRange.png?240407172904)

{{< code-sp5 >}}

```cs
ScottPlot.Plot myPlot = new();

myPlot.Add.Palette = new ScottPlot.Palettes.Nord();
double[] values = { 100, 80, 65, 45, 20 };

var radialGaugePlot = myPlot.Add.RadialGaugePlot(values);
radialGaugePlot.MaximumAngle = 180;

myPlot.SavePng("demo.png", 400, 300);

```

{{< /code-sp5 >}}

<hr class='my-5 invisible'>


<h2><a href='/cookbook/5.0/RadialGauge/RadialGaugeLabels'>Show Levels</a></h2>

The value of each gauge is displayed as text by default but this behavior can be overridden. Note that this is different than the labels fiels which is what appears in the legened.

[![](/cookbook/5.0/images/RadialGaugeLabels.png?240407172904)](/cookbook/5.0/images/RadialGaugeLabels.png?240407172904)

{{< code-sp5 >}}

```cs
ScottPlot.Plot myPlot = new();

myPlot.Add.Palette = new ScottPlot.Palettes.Nord();
double[] values = { 100, 80, 65, 45, 20 };

var radialGaugePlot = myPlot.Add.RadialGaugePlot(values);
radialGaugePlot.ShowLevels = false;

myPlot.SavePng("demo.png", 400, 300);

```

{{< /code-sp5 >}}

<hr class='my-5 invisible'>


<h2><a href='/cookbook/5.0/RadialGauge/RadialGaugeLabelPos'>Gauge Label Position</a></h2>

Gauge level text is positioned at the tip of each gauge by default, but this position can be adjusted by the user.

[![](/cookbook/5.0/images/RadialGaugeLabelPos.png?240407172904)](/cookbook/5.0/images/RadialGaugeLabelPos.png?240407172904)

{{< code-sp5 >}}

```cs
ScottPlot.Plot myPlot = new();

myPlot.Add.Palette = new ScottPlot.Palettes.Nord();
double[] values = { 100, 80, 65, 45, 20 };

var radialGaugePlot = myPlot.Add.RadialGaugePlot(values);
radialGaugePlot.LabelPositionFraction = 0.5;

myPlot.SavePng("demo.png", 400, 300);

```

{{< /code-sp5 >}}

<hr class='my-5 invisible'>


<h2><a href='/cookbook/5.0/RadialGauge/RadialGaugeLabelFontPct'>Gauge Label Font Percentage</a></h2>

Size of the gauge level text as a fraction of the gauge width.

[![](/cookbook/5.0/images/RadialGaugeLabelFontPct.png?240407172904)](/cookbook/5.0/images/RadialGaugeLabelFontPct.png?240407172904)

{{< code-sp5 >}}

```cs
ScottPlot.Plot myPlot = new();

myPlot.Add.Palette = new ScottPlot.Palettes.Nord();
double[] values = { 100, 80, 65, 45, 20 };

var radialGaugePlot = myPlot.Add.RadialGaugePlot(values);
radialGaugePlot.FontSizeFraction = .4;

myPlot.SavePng("demo.png", 400, 300);

```

{{< /code-sp5 >}}

<hr class='my-5 invisible'>


<h2><a href='/cookbook/5.0/RadialGauge/RadialGaugeLabelColor'>Gauge Label Color</a></h2>

Level text fonts may be customized.

[![](/cookbook/5.0/images/RadialGaugeLabelColor.png?240407172904)](/cookbook/5.0/images/RadialGaugeLabelColor.png?240407172904)

{{< code-sp5 >}}

```cs
ScottPlot.Plot myPlot = new();

myPlot.Add.Palette = new ScottPlot.Palettes.Nord();
double[] values = { 100, 80, 65, 45, 20 };

var radialGaugePlot = myPlot.Add.RadialGaugePlot(values);
radialGaugePlot.Font.Color = Colors.Black;

myPlot.SavePng("demo.png", 400, 300);

```

{{< /code-sp5 >}}

<hr class='my-5 invisible'>


<h2><a href='/cookbook/5.0/RadialGauge/RadialGaugeLegend'>Gauge Labels in Legend</a></h2>

Radial gauge labels will appear in the legend if they are assigned. 

[![](/cookbook/5.0/images/RadialGaugeLegend.png?240407172904)](/cookbook/5.0/images/RadialGaugeLegend.png?240407172904)

{{< code-sp5 >}}

```cs
ScottPlot.Plot myPlot = new();

myPlot.Add.Palette = new ScottPlot.Palettes.Nord();
double[] values = { 100, 80, 65, 45, 20 };

var radialGaugePlot = myPlot.Add.RadialGaugePlot(values);
radialGaugePlot.Labels = new string[] { "alpha", "beta", "gamma", "delta", "epsilon" };
myPlot.ShowLegend();

myPlot.SavePng("demo.png", 400, 300);

```

{{< /code-sp5 >}}

<hr class='my-5 invisible'>


<h2><a href='/cookbook/5.0/RadialGauge/RadialGaugeBackDim'>Background Gauges Dim</a></h2>

By default the full range of each gauge is drawn as a semitransparent ring. The amount of transparency can be adjusted as desired.

[![](/cookbook/5.0/images/RadialGaugeBackDim.png?240407172904)](/cookbook/5.0/images/RadialGaugeBackDim.png?240407172904)

{{< code-sp5 >}}

```cs
ScottPlot.Plot myPlot = new();

myPlot.Add.Palette = new ScottPlot.Palettes.Nord();
double[] values = { 100, 80, 65, 45, 20 };

var radialGaugePlot = myPlot.Add.RadialGaugePlot(values);
radialGaugePlot.BackgroundTransparencyFraction = .5;

myPlot.SavePng("demo.png", 400, 300);

```

{{< /code-sp5 >}}

<hr class='my-5 invisible'>


<h2><a href='/cookbook/5.0/RadialGauge/RadialGaugeBackNorm'>Background Gauges Normalization</a></h2>

Gauge backgrounds are drawn as full circles by default. This behavior can be disabled to draw partial backgrounds for non-circular gauges.

[![](/cookbook/5.0/images/RadialGaugeBackNorm.png?240407172904)](/cookbook/5.0/images/RadialGaugeBackNorm.png?240407172904)

{{< code-sp5 >}}

```cs
ScottPlot.Plot myPlot = new();

myPlot.Add.Palette = new ScottPlot.Palettes.Nord();
double[] values = { 100, 80, 65, 45, 20 };

var radialGaugePlot = myPlot.Add.RadialGaugePlot(values);
radialGaugePlot.CircularBackground = false;
radialGaugePlot.MaximumAngle = 180;
radialGaugePlot.StartingAngle = 180;

myPlot.SavePng("demo.png", 400, 300);

```

{{< /code-sp5 >}}

<hr class='my-5 invisible'>

