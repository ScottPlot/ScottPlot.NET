---
Title: Image Marker - ScottPlot 5.0 Cookbook
Description: An ImageMarker can be placed on the plot to display an image centered at a location in coordinate space.
URL: /cookbook/5.0/Marker/ImageMarkerQuickstart/
BreadcrumbNames: ["ScottPlot 5.0 Cookbook", "Marker", "Image Marker"]
BreadcrumbUrls: ["/cookbook/5.0/", "/cookbook/5.0/Marker", "/cookbook/5.0/Marker/ImageMarkerQuickstart"]
Date: 2025-01-26
Version: ScottPlot 5.0.55
Version: ScottPlot 5.0.55
SearchUrl: "/cookbook/5.0/search/"
ShowEditLink: false
---


<div class='d-flex align-items-center mt-5'>
<h1 class='me-2 text-dark my-0 border-0'>Image Marker</h1>
</div>

An ImageMarker can be placed on the plot to display an image centered at a location in coordinate space.

[![](/cookbook/5.0/images/ImageMarkerQuickstart.png?250126165944)](/cookbook/5.0/images/ImageMarkerQuickstart.png?250126165944)

{{< recipe-sp5 sourceUrl="https://github.com/ScottPlot/ScottPlot/blob/main/src/ScottPlot5/ScottPlot5%20Cookbook/Recipes/PlotTypes/Marker.cs" imageUrl="/cookbook/5.0/images/ImageMarkerQuickstart.png?250126165944" >}}ScottPlot.Plot myPlot = new();

myPlot.Add.Signal(Generate.Sin());
myPlot.Add.Signal(Generate.Cos());

// An image can be loaded from a file or created dynamically
ScottPlot.Image image = SampleImages.ScottPlotLogo(48, 48);

Coordinates location1 = new(5, .5);
Coordinates location2 = new(25, .5);

myPlot.Add.ImageMarker(location1, image);
myPlot.Add.ImageMarker(location2, image, scale: 2);

var m1 = myPlot.Add.Marker(location1);
var m2 = myPlot.Add.Marker(location2);
m1.Color = Colors.Orange;
m2.Color = Colors.Orange;

myPlot.SavePng("demo.png", 400, 300);
{{< /recipe-sp5 >}}

<div class='my-5 text-center'>This recipe is one of many in the <a href='/cookbook/5.0/Marker'>Marker</a> category</div>


