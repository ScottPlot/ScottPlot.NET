---
Title: Image Axis Label - ScottPlot 5.0 Cookbook
Description: For cases where axis label font styling does not provide the desired level of customization, a bitmap image may be displayed as an axis label. This strategy allows rich text to be realized using any third party tool that can render that text as a bitmap. It also enables users to place icons or images in their axis labels.
URL: /cookbook/5.0/AxisAndTicks/ImageAxisLabel/
BreadcrumbNames: ["ScottPlot 5.0 Cookbook", "Axis and Ticks", "Image Axis Label"]
BreadcrumbUrls: ["/cookbook/5.0/", "/cookbook/5.0/AxisAndTicks", "/cookbook/5.0/AxisAndTicks/ImageAxisLabel"]
Date: 2025-03-22
Version: ScottPlot 5.0.55
Version: ScottPlot 5.0.55
SearchUrl: "/cookbook/5.0/search/"
ShowEditLink: false
---


<div class='d-flex align-items-center mt-5'>
<h1 class='me-2 text-dark my-0 border-0'>Image Axis Label</h1>
</div>

For cases where axis label font styling does not provide the desired level of customization, a bitmap image may be displayed as an axis label. This strategy allows rich text to be realized using any third party tool that can render that text as a bitmap. It also enables users to place icons or images in their axis labels.

[![](/cookbook/5.0/images/ImageAxisLabel.png?250322130304)](/cookbook/5.0/images/ImageAxisLabel.png?250322130304)

{{< recipe-sp5 sourceUrl="https://github.com/ScottPlot/ScottPlot/blob/main/src/ScottPlot5/ScottPlot5%20Cookbook/Recipes/General/AxisRecipes.cs" imageUrl="/cookbook/5.0/images/ImageAxisLabel.png?250322130304" >}}ScottPlot.Plot myPlot = new();

myPlot.Add.Signal(Generate.Sin(51));
myPlot.Add.Signal(Generate.Cos(51));

// This array holds the bytes of a bitmap. Here it's generated,
// but it could be a byte array read from a bitmap file on disk.
byte[] bytes1 = SampleImages.NoisyText("Horiz", 150, 50).GetImageBytes();
byte[] bytes2 = SampleImages.NoisyText("Vert", 150, 50).GetImageBytes();

// Create a ScottPlot.Image from the bitmap bytes
ScottPlot.Image img1 = new(bytes1);
ScottPlot.Image img2 = new(bytes2);

// Display the image for the bottom axis label
myPlot.Axes.Bottom.Label.Image = img1;
myPlot.Axes.Left.Label.Image = img2;

myPlot.SavePng("demo.png", 400, 300);
{{< /recipe-sp5 >}}

<div class='my-5 text-center'>This recipe is one of many in the <a href='/cookbook/5.0/AxisAndTicks'>Axis and Ticks</a> category</div>


