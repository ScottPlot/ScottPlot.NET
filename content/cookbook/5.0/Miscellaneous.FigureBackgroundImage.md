---
Title: Figure Background Image - ScottPlot 5.0 Cookbook
Description: An image can be used for the background of a figure.
URL: /cookbook/5.0/Miscellaneous/FigureBackgroundImage/
BreadcrumbNames: ["ScottPlot 5.0 Cookbook", "Miscellaneous", "Figure Background Image"]
BreadcrumbUrls: ["/cookbook/5.0/", "/cookbook/5.0/Miscellaneous", "/cookbook/5.0/Miscellaneous/FigureBackgroundImage"]
Date: 2024-11-06
Version: ScottPlot 5.0.43
Version: ScottPlot 5.0.43
SearchUrl: "/cookbook/5.0/search/"
ShowEditLink: false
---


<div class='d-flex align-items-center mt-5'>
<h1 class='me-2 text-dark my-0 border-0'>Figure Background Image</h1>
</div>

An image can be used for the background of a figure.

[![](/cookbook/5.0/images/FigureBackgroundImage.png?241105214550)](/cookbook/5.0/images/FigureBackgroundImage.png?241105214550)

{{< recipe-sp5 sourceUrl="https://github.com/ScottPlot/ScottPlot/blob/main/src/ScottPlot5/ScottPlot5%20Cookbook/Recipes/General/Miscellaneous.cs" imageUrl="/cookbook/5.0/images/FigureBackgroundImage.png?241105214550" >}}ScottPlot.Plot myPlot = new();

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

<div class='my-5 text-center'>This recipe is one of many in the <a href='/cookbook/5.0/Miscellaneous'>Miscellaneous</a> category</div>


