---
Title: Image Rectangle - ScottPlot 5 Cookbook
Description: An image can be drawn inside a rectangle defined in coordinate units.
URL: /cookbook/5/Images/ImageRectQuickstart/
BreadcrumbNames: ["ScottPlot 5 Cookbook", "Images", "Image Rectangle"]
BreadcrumbUrls: ["/cookbook/5/", "/cookbook/5/Images", "/cookbook/5/Images/ImageRectQuickstart"]
Date: 2026-03-29
Version: ScottPlot 5.1.58
Version: ScottPlot 5.1.58
SearchUrl: "/cookbook/5/search/"
ShowEditLink: false
---


<div class='d-flex align-items-center mt-5'>
<h1 class='me-2 text-dark my-0 border-0'>Image Rectangle</h1>
</div>

An image can be drawn inside a rectangle defined in coordinate units.

[![](/cookbook/5/images/ImageRectQuickstart.png?260329072039)](/cookbook/5/images/ImageRectQuickstart.png?260329072039)

{{< recipe-sp5 sourceUrl="https://github.com/ScottPlot/ScottPlot/blob/main/src/ScottPlot5/ScottPlot5%20Cookbook/Recipes/PlotTypes/Images.cs" imageUrl="/cookbook/5/images/ImageRectQuickstart.png?260329072039" >}}ScottPlot.Plot myPlot = new();

// Images may be loaded from files or created dynamically
ScottPlot.Image img = ScottPlot.SampleImages.MonaLisa();

CoordinateRect rect = new(left: 0, right: img.Width, bottom: 0, top: img.Height);

myPlot.Add.ImageRect(img, rect);

myPlot.SavePng("demo.png", 400, 300);
{{< /recipe-sp5 >}}

<div class='my-5 text-center'>This recipe is one of many in the <a href='/cookbook/5/Images'>Images</a> category</div>


