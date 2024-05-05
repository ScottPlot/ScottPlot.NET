---
Title: Advanced Styling - ScottPlot 5.0 Cookbook
Description: Features for users seeking extensive customization options.
URL: /cookbook/5.0/AdvancedStyling/
BreadcrumbNames: ["ScottPlot 5.0 Cookbook", "Advanced Styling"]
BreadcrumbUrls: ["/cookbook/5.0/", "/cookbook/5.0/AdvancedStyling"]
Date: 2024-05-05
Version: ScottPlot 5.0.34
Version: ScottPlot 5.0.34
SearchUrl: "/cookbook/5.0/search/"
ShowEditLink: false
---

# Advanced Styling


<h2><a href='/cookbook/5.0/AdvancedStyling/AdvancedStylingDataBackground'>Data Area Background Image</a></h2>

An image can be used for the background of the data area.

[![](/cookbook/5.0/images/AdvancedStylingDataBackground.png?240505131914)](/cookbook/5.0/images/AdvancedStylingDataBackground.png?240505131914)

{{< code-sp5 >}}

```cs
ScottPlot.Plot myPlot = new();

// plot sample data
var sig1 = myPlot.Add.Signal(Generate.Sin());
var sig2 = myPlot.Add.Signal(Generate.Cos());
sig1.LineWidth = 3;
sig2.LineWidth = 3;

// One could load an image from a file...
// Image bgImage = new("background.png");

// But in this example we will use a sample image:
Image bgImage = SampleImages.ScottPlotLogo();
myPlot.DataBackground.Image = bgImage;

myPlot.SavePng("demo.png", 400, 300);

```

{{< /code-sp5 >}}

<hr class='my-5 invisible'>


<h2><a href='/cookbook/5.0/AdvancedStyling/AdvancedStylingFigureBackground'>Figure Background Image</a></h2>

An image can be used for the background of a figure.

[![](/cookbook/5.0/images/AdvancedStylingFigureBackground.png?240505131914)](/cookbook/5.0/images/AdvancedStylingFigureBackground.png?240505131914)

{{< code-sp5 >}}

```cs
ScottPlot.Plot myPlot = new();

// plot sample data
var sig1 = myPlot.Add.Signal(Generate.Sin());
var sig2 = myPlot.Add.Signal(Generate.Cos());

// One could load an image from a file...
// Image bgImage = new("background.png");

// But in this example we will use a sample image:
Image bgImage = SampleImages.MonaLisa();
myPlot.FigureBackground.Image = bgImage;

// Color the axes and data so they stand out against the dark background
myPlot.Axes.Color(Colors.White);
sig1.Color = sig1.Color.Lighten(.2);
sig2.Color = sig2.Color.Lighten(.2);
sig1.LineWidth = 3;
sig2.LineWidth = 3;

// Shade the data area to make it stand out
myPlot.DataBackground.Color = Colors.Black.WithAlpha(.5);

myPlot.SavePng("demo.png", 400, 300);

```

{{< /code-sp5 >}}

<hr class='my-5 invisible'>


<h2><a href='/cookbook/5.0/AdvancedStyling/ColorInterpolation'>Color Interpolation</a></h2>

Colors can be mixed to createa range of colors. This strategy uses linear RGB interpolation.

[![](/cookbook/5.0/images/ColorInterpolation.png?240505131914)](/cookbook/5.0/images/ColorInterpolation.png?240505131914)

{{< code-sp5 >}}

```cs
ScottPlot.Plot myPlot = new();

for (int i = 0; i <= 10; i++)
{
    double fraction = (double)i / 10;
    double x = i;
    double y = Math.Sin(Math.PI * 2 * fraction);
    var circle = myPlot.Add.Circle(x, y, 2);
    circle.FillColor = Colors.Blue.MixedWith(Colors.Green, fraction);
    circle.LineColor = Colors.Black.WithAlpha(.5);
}

myPlot.SavePng("demo.png", 400, 300);

```

{{< /code-sp5 >}}

<hr class='my-5 invisible'>

