---
Title: Data Area Background Image - ScottPlot 5 Cookbook
Description: An image can be used for the background of the data area.
URL: /cookbook/5/Miscellaneous/DataBackgroundImage/
BreadcrumbNames: ["ScottPlot 5 Cookbook", "Miscellaneous", "Data Area Background Image"]
BreadcrumbUrls: ["/cookbook/5/", "/cookbook/5/Miscellaneous", "/cookbook/5/Miscellaneous/DataBackgroundImage"]
Date: 2026-03-29
Version: ScottPlot 5.1.58
Version: ScottPlot 5.1.58
SearchUrl: "/cookbook/5/search/"
ShowEditLink: false
---


<div class='d-flex align-items-center mt-5'>
<h1 class='me-2 text-dark my-0 border-0'>Data Area Background Image</h1>
</div>

An image can be used for the background of the data area.

[![](/cookbook/5/images/DataBackgroundImage.png?260329072039)](/cookbook/5/images/DataBackgroundImage.png?260329072039)

{{< recipe-sp5 sourceUrl="https://github.com/ScottPlot/ScottPlot/blob/main/src/ScottPlot5/ScottPlot5%20Cookbook/Recipes/General/Miscellaneous.cs" imageUrl="/cookbook/5/images/DataBackgroundImage.png?260329072039" >}}ScottPlot.Plot myPlot = new();

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

<div class='my-5 text-center'>This recipe is one of many in the <a href='/cookbook/5/Miscellaneous'>Miscellaneous</a> category</div>


