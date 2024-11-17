---
Title: Image Rectangle - ScottPlot 5.0 Cookbook
Description: An image can be drawn inside a rectangle defined in coordinate units.
URL: /cookbook/5.0/Images/ImageRectQuickstart/
BreadcrumbNames: ["ScottPlot 5.0 Cookbook", "Images", "Image Rectangle"]
BreadcrumbUrls: ["/cookbook/5.0/", "/cookbook/5.0/Images", "/cookbook/5.0/Images/ImageRectQuickstart"]
Date: 2024-11-17
Version: ScottPlot 5.0.46
Version: ScottPlot 5.0.46
SearchUrl: "/cookbook/5.0/search/"
ShowEditLink: false
---


<div class='d-flex align-items-center mt-5'>
<h1 class='me-2 text-dark my-0 border-0'>Image Rectangle</h1>
</div>

An image can be drawn inside a rectangle defined in coordinate units.

[![](/cookbook/5.0/images/ImageRectQuickstart.png?241117162641)](/cookbook/5.0/images/ImageRectQuickstart.png?241117162641)

{{< recipe-sp5 sourceUrl="https://github.com/ScottPlot/ScottPlot/blob/main/src/ScottPlot5/ScottPlot5%20Cookbook/Recipes/PlotTypes/Images.cs" imageUrl="/cookbook/5.0/images/ImageRectQuickstart.png?241117162641" >}}ScottPlot.Plot myPlot = new();

// Images may be loaded from files or created dynamically
ScottPlot.Image img = ScottPlot.SampleImages.MonaLisa();

CoordinateRect rect = new(left: 0, right: img.Width, bottom: 0, top: img.Height);

myPlot.Add.ImageRect(img, rect);

myPlot.SavePng("demo.png", 400, 300);
{{< /recipe-sp5 >}}

<div class='my-5 text-center'>This recipe is one of many in the <a href='/cookbook/5.0/Images'>Images</a> category</div>


