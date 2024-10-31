---
Title: Custom Font Files - ScottPlot 5.0 Cookbook
Description: Users can apply custom typefaces by loaded from font files.
URL: /cookbook/5.0/Miscellaneous/CustomFontFiles/
BreadcrumbNames: ["ScottPlot 5.0 Cookbook", "Miscellaneous", "Custom Font Files"]
BreadcrumbUrls: ["/cookbook/5.0/", "/cookbook/5.0/Miscellaneous", "/cookbook/5.0/Miscellaneous/CustomFontFiles"]
Date: 2024-10-31
Version: ScottPlot 5.0.42
Version: ScottPlot 5.0.42
SearchUrl: "/cookbook/5.0/search/"
ShowEditLink: false
---


<h2 style='border-bottom: 0;'><a href='/cookbook/5.0/Miscellaneous/CustomFontFiles'>Custom Font Files</a></h2>

<div class="d-flex mb-2">
<a class="btn btn-sm btn-primary me-1" href="/cookbook/5.0/Miscellaneous/CustomFontFiles">Recipe Permalink</a>
<a class="btn btn-sm btn-success me-1" href="/cookbook/5.0/Miscellaneous">Category: Miscellaneous</a>
</div>

Users can apply custom typefaces by loaded from font files.

[![](/cookbook/5.0/images/CustomFontFiles.png?241031194635)](/cookbook/5.0/images/CustomFontFiles.png?241031194635)

{{< recipe-sp5 >}}ScottPlot.Plot myPlot = new();

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


