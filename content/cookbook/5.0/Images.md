---
Title: Images - ScottPlot 5.0 Cookbook
Description: Images can be placed on plots in a variety of ways
URL: /cookbook/5.0/Images/
BreadcrumbNames: ["ScottPlot 5.0 Cookbook", "Images"]
BreadcrumbUrls: ["/cookbook/5.0/", "/cookbook/5.0/Images"]
Date: 2024-10-31
Version: ScottPlot 5.0.42
Version: ScottPlot 5.0.42
SearchUrl: "/cookbook/5.0/search/"
ShowEditLink: false
---

<h1>Images</h1>


<h2 style='border-bottom: 0;'><a href='/cookbook/5.0/Images/ImageRectQuickstart'>Image Rectangle</a></h2>

<div class="d-flex mb-2">
<a class="btn btn-sm btn-primary me-1" href="/cookbook/5.0/Images/ImageRectQuickstart">Recipe Permalink</a>
<a class="btn btn-sm btn-success me-1" href="/cookbook/5.0/Images">Category: Images</a>
</div>

An image can be drawn inside a rectangle defined in coordinate units.

[![](/cookbook/5.0/images/ImageRectQuickstart.png?241031194635)](/cookbook/5.0/images/ImageRectQuickstart.png?241031194635)

{{< recipe-sp5 >}}ScottPlot.Plot myPlot = new();

// Images may be loaded from files or created dynamically
ScottPlot.Image img = ScottPlot.SampleImages.MonaLisa();

CoordinateRect rect = new(left: 0, right: img.Width, bottom: 0, top: img.Height);

myPlot.Add.ImageRect(img, rect);

myPlot.SavePng("demo.png", 400, 300);
{{< /recipe-sp5 >}}

<hr class='my-5 invisible'>


