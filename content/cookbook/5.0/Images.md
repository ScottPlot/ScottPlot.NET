---
Title: Images - ScottPlot 5.0 Cookbook
Description: Images can be placed on plots in a variety of ways
URL: /cookbook/5.0/Images/
BreadcrumbNames: ["ScottPlot 5.0 Cookbook", "Images"]
BreadcrumbUrls: ["/cookbook/5.0/", "/cookbook/5.0/Images"]
Date: 2024-10-28
Version: ScottPlot 5.0.41
Version: ScottPlot 5.0.41
SearchUrl: "/cookbook/5.0/search/"
ShowEditLink: false
---

# Images


<h2><a href='/cookbook/5.0/Images/ImageRectQuickstart'>Image Rectangle</a></h2>

An image can be drawn inside a rectangle defined in coordinate units.

[![](/cookbook/5.0/images/ImageRectQuickstart.png?241027220842)](/cookbook/5.0/images/ImageRectQuickstart.png?241027220842)

{{< recipe-sp5 >}}

```cs
ScottPlot.Plot myPlot = new();

// Images may be loaded from files or created dynamically
ScottPlot.Image img = ScottPlot.SampleImages.MonaLisa();

CoordinateRect rect = new(left: 0, right: img.Width, bottom: 0, top: img.Height);

myPlot.Add.ImageRect(img, rect);

myPlot.SavePng("demo.png", 400, 300);

```

{{< /recipe-sp5 >}}

<hr class='my-5 invisible'>

