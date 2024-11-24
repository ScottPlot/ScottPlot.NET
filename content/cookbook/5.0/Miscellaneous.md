---
Title: Miscellaneous - ScottPlot 5.0 Cookbook
Description: Miscellaneous features and customization options
URL: /cookbook/5.0/Miscellaneous/
BreadcrumbNames: ["ScottPlot 5.0 Cookbook", "Miscellaneous"]
BreadcrumbUrls: ["/cookbook/5.0/", "/cookbook/5.0/Miscellaneous"]
Date: 2024-11-24
Version: ScottPlot 5.0.47
Version: ScottPlot 5.0.47
SearchUrl: "/cookbook/5.0/search/"
ShowEditLink: false
---

<h1>Miscellaneous</h1>


<div class='d-flex align-items-center mt-5'>
<h1 class='me-2 text-dark my-0 border-0'>Data Area Background Image</h1>
<a href='/cookbook/5.0/Miscellaneous/DataBackgroundImage' target='_blank'>
<img src='/images/icons/new-window.svg' style='height: 2rem;' class='new-window-icon'>
</a>
</div>

An image can be used for the background of the data area.

[![](/cookbook/5.0/images/DataBackgroundImage.png?241124170640)](/cookbook/5.0/images/DataBackgroundImage.png?241124170640)

{{< recipe-sp5 sourceUrl="https://github.com/ScottPlot/ScottPlot/blob/main/src/ScottPlot5/ScottPlot5%20Cookbook/Recipes/General/Miscellaneous.cs" imageUrl="/cookbook/5.0/images/DataBackgroundImage.png?241124170640" >}}ScottPlot.Plot myPlot = new();

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
{{< /recipe-sp5 >}}

<hr class='my-5 invisible'>



<div class='d-flex align-items-center mt-5'>
<h1 class='me-2 text-dark my-0 border-0'>Figure Background Image</h1>
<a href='/cookbook/5.0/Miscellaneous/FigureBackgroundImage' target='_blank'>
<img src='/images/icons/new-window.svg' style='height: 2rem;' class='new-window-icon'>
</a>
</div>

An image can be used for the background of a figure.

[![](/cookbook/5.0/images/FigureBackgroundImage.png?241124170640)](/cookbook/5.0/images/FigureBackgroundImage.png?241124170640)

{{< recipe-sp5 sourceUrl="https://github.com/ScottPlot/ScottPlot/blob/main/src/ScottPlot5/ScottPlot5%20Cookbook/Recipes/General/Miscellaneous.cs" imageUrl="/cookbook/5.0/images/FigureBackgroundImage.png?241124170640" >}}ScottPlot.Plot myPlot = new();

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
{{< /recipe-sp5 >}}

<hr class='my-5 invisible'>



<div class='d-flex align-items-center mt-5'>
<h1 class='me-2 text-dark my-0 border-0'>Color Interpolation</h1>
<a href='/cookbook/5.0/Miscellaneous/ColorInterpolation' target='_blank'>
<img src='/images/icons/new-window.svg' style='height: 2rem;' class='new-window-icon'>
</a>
</div>

Colors can be mixed to createa range of colors. This strategy uses linear RGB interpolation.

[![](/cookbook/5.0/images/ColorInterpolation.png?241124170640)](/cookbook/5.0/images/ColorInterpolation.png?241124170640)

{{< recipe-sp5 sourceUrl="https://github.com/ScottPlot/ScottPlot/blob/main/src/ScottPlot5/ScottPlot5%20Cookbook/Recipes/General/Miscellaneous.cs" imageUrl="/cookbook/5.0/images/ColorInterpolation.png?241124170640" >}}ScottPlot.Plot myPlot = new();

for (int i = 0; i &lt;= 10; i++)
{
    double fraction = (double)i / 10;
    double x = i;
    double y = Math.Sin(Math.PI * 2 * fraction);
    var circle = myPlot.Add.Circle(x, y, 2);
    circle.FillColor = Colors.Blue.MixedWith(Colors.Green, fraction);
    circle.LineColor = Colors.Black.WithAlpha(.5);
}

myPlot.SavePng("demo.png", 400, 300);
{{< /recipe-sp5 >}}

<hr class='my-5 invisible'>



<div class='d-flex align-items-center mt-5'>
<h1 class='me-2 text-dark my-0 border-0'>Custom Font Files</h1>
<a href='/cookbook/5.0/Miscellaneous/CustomFontFiles' target='_blank'>
<img src='/images/icons/new-window.svg' style='height: 2rem;' class='new-window-icon'>
</a>
</div>

Users can apply custom typefaces by loaded from font files.

[![](/cookbook/5.0/images/CustomFontFiles.png?241124170640)](/cookbook/5.0/images/CustomFontFiles.png?241124170640)

{{< recipe-sp5 sourceUrl="https://github.com/ScottPlot/ScottPlot/blob/main/src/ScottPlot5/ScottPlot5%20Cookbook/Recipes/General/Miscellaneous.cs" imageUrl="/cookbook/5.0/images/CustomFontFiles.png?241124170640" >}}ScottPlot.Plot myPlot = new();

// Add a font file to use its typeface for fonts with a given name
Fonts.AddFontFile(
    name: "Alumni Sans",
    path: Path.Combine(Paths.FontFolder, @"AlumniSans/AlumniSans-Regular.ttf"));

// plot sample data
var sig1 = myPlot.Add.Signal(Generate.Sin(51));
sig1.LegendText = "Sin";
var sig2 = myPlot.Add.Signal(Generate.Cos(51));
sig2.LegendText = "Cos";

// custom fonts may be used in legends
myPlot.Legend.FontName = "Alumni Sans";
myPlot.Legend.FontSize = 24;

// custom fonts may be used in plottables that contain text
var text = myPlot.Add.Text("Hello", 25, 0.5);
text.LabelStyle.FontName = "Alumni Sans";
text.LabelStyle.FontSize = 24;

// Custom fonts may be used for axis labels.
// Note that bold is disabled because support for
// bold would require loading an additional font file.
myPlot.Title("Custom Font Demo");
myPlot.Axes.Title.Label.FontName = "Alumni Sans";
myPlot.Axes.Title.Label.FontSize = 36;
myPlot.Axes.Title.Label.Bold = false;

myPlot.XLabel("Horizontal Axis");
myPlot.Axes.Bottom.Label.FontName = "Alumni Sans";
myPlot.Axes.Bottom.Label.FontSize = 24;
myPlot.Axes.Bottom.Label.Bold = false;

myPlot.YLabel("Vertical Axis");
myPlot.Axes.Left.Label.FontName = "Alumni Sans";
myPlot.Axes.Left.Label.FontSize = 24;
myPlot.Axes.Left.Label.Bold = false;

myPlot.SavePng("demo.png", 400, 300);
{{< /recipe-sp5 >}}

<hr class='my-5 invisible'>


