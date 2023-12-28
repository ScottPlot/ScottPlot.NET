---
Title: "Image Clipping - ScottPlot 4.1 Cookbook"
Description: "Images can be clipped to an arbitrary polygon"
Date: 2023-12-28
Version: ScottPlot 4.1.70
URL: /cookbook/4.1/recipes/image_clipping/
BreadcrumbNames: ["ScottPlot 4.1 Cookbook", "Image", "Image Clipping"]
BreadcrumbUrls: ["/cookbook/4.1/", "/cookbook/4.1/category/plottable-image", "/cookbook/4.1/recipes/image_clipping/"]
SearchUrl: "/cookbook/4.1/search/"
OgImage: "/cookbook/4.1/images/image_clipping.png"
---

<h2><a id='image-clipping' href='/cookbook/4.1/recipes/image_clipping/'>Image Clipping</a></h2>

Images can be clipped to an arbitrary polygon

```cs
var plt = new ScottPlot.Plot(600, 400);

Bitmap bmp = DataGen.SampleImage();
var img = plt.AddImage(bmp, 0, bmp.Height);
img.HeightInAxisUnits = bmp.Height;
img.WidthInAxisUnits = bmp.Width;
img.ClippingPoints = new Coordinate[]
{
    new Coordinate(30, 15),
    new Coordinate(55, 40),
    new Coordinate(60, 45),
    new Coordinate(80, 60),
    new Coordinate(40, 95),
    new Coordinate(15, 90),
    new Coordinate(5, 50),
};

plt.SaveFig("image_clipping.png");
```

<img src='../../images/image_clipping.png' class='d-block mx-auto my-5' />


