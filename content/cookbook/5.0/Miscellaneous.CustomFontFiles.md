---
Title: Custom Font Files - ScottPlot 5.0 Cookbook
Description: Users can apply custom typefaces by loaded from font files.
URL: /cookbook/5.0/Miscellaneous/CustomFontFiles/
BreadcrumbNames: ["ScottPlot 5.0 Cookbook", "Miscellaneous", "Custom Font Files"]
BreadcrumbUrls: ["/cookbook/5.0/", "/cookbook/5.0/Miscellaneous", "/cookbook/5.0/Miscellaneous/CustomFontFiles"]
Date: 2025-01-13
Version: ScottPlot 5.0.53
Version: ScottPlot 5.0.53
SearchUrl: "/cookbook/5.0/search/"
ShowEditLink: false
---


<div class='d-flex align-items-center mt-5'>
<h1 class='me-2 text-dark my-0 border-0'>Custom Font Files</h1>
</div>

Users can apply custom typefaces by loaded from font files.

[![](/cookbook/5.0/images/CustomFontFiles.png?250112204022)](/cookbook/5.0/images/CustomFontFiles.png?250112204022)

{{< recipe-sp5 sourceUrl="https://github.com/ScottPlot/ScottPlot/blob/main/src/ScottPlot5/ScottPlot5%20Cookbook/Recipes/General/Miscellaneous.cs" imageUrl="/cookbook/5.0/images/CustomFontFiles.png?250112204022" >}}ScottPlot.Plot myPlot = new();

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

<div class='my-5 text-center'>This recipe is one of many in the <a href='/cookbook/5.0/Miscellaneous'>Miscellaneous</a> category</div>


