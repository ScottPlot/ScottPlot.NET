---
Title: Data Area Background Image - ScottPlot 5.0 Cookbook
Description: An image can be used for the background of the data area.
URL: /cookbook/5.0/Miscellaneous/DataBackgroundImage/
BreadcrumbNames: ["ScottPlot 5.0 Cookbook", "Miscellaneous", "Data Area Background Image"]
BreadcrumbUrls: ["/cookbook/5.0/", "/cookbook/5.0/Miscellaneous", "/cookbook/5.0/Miscellaneous/DataBackgroundImage"]
Date: 2024-11-06
Version: ScottPlot 5.0.43
Version: ScottPlot 5.0.43
SearchUrl: "/cookbook/5.0/search/"
ShowEditLink: false
---


<div class='d-flex align-items-center mt-5'>
<h1 class='me-2 text-dark my-0 border-0'>Data Area Background Image</h1>
</div>

An image can be used for the background of the data area.

[![](/cookbook/5.0/images/DataBackgroundImage.png?241105214550)](/cookbook/5.0/images/DataBackgroundImage.png?241105214550)

{{< recipe-sp5 sourceUrl="https://github.com/ScottPlot/ScottPlot/blob/main/src/ScottPlot5/ScottPlot5%20Cookbook/Recipes/General/Miscellaneous.cs" imageUrl="/cookbook/5.0/images/DataBackgroundImage.png?241105214550" >}}ScottPlot.Plot myPlot = new();

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

<div class='my-5 text-center'>This recipe is one of many in the <a href='/cookbook/5.0/Miscellaneous'>Miscellaneous</a> category</div>


