---
Title: Image - ScottPlot 5 Cookbook
Description: Images can be placed on plots in a variety of ways
URL: /cookbook/5/Image/
BreadcrumbNames: ["ScottPlot 5 Cookbook", "Image"]
BreadcrumbUrls: ["/cookbook/5/", "/cookbook/5/Image"]
Date: 2026-08-15
Version: ScottPlot 5.1.60
Version: ScottPlot 5.1.60
SearchUrl: "/cookbook/5/search/"
ShowEditLink: false
---

<h1>Image</h1>


<div class='d-flex align-items-center mt-5'>
<h1 class='me-2 text-dark my-0 border-0'>Image Rectangle</h1>
<a href='/cookbook/5/Image/ImageRectQuickstart' target='_blank'>
<img src='/images/icons/new-window.svg' style='height: 2rem;' class='new-window-icon'>
</a>
</div>

An image can be drawn inside a rectangle defined in coordinate units.

[![](/cookbook/5/images/ImageRectQuickstart.png?260815173246)](/cookbook/5/images/ImageRectQuickstart.png?260815173246)

{{< recipe-sp5 sourceUrl="https://github.com/ScottPlot/ScottPlot/blob/main/src/ScottPlot5/ScottPlot5%20Cookbook/Recipes/PlotTypes/Image.cs" imageUrl="/cookbook/5/images/ImageRectQuickstart.png?260815173246" >}}ScottPlot.Plot myPlot = new();

// Images may be loaded from files or created dynamically
ScottPlot.Image img = ScottPlot.SampleImages.MonaLisa();

CoordinateRect rect = new(left: 0, right: img.Width, bottom: 0, top: img.Height);

myPlot.Add.ImageRect(img, rect);

myPlot.SavePng("demo.png", 400, 300);
{{< /recipe-sp5 >}}

<hr class='my-5 invisible'>


