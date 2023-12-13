---
Title: "Image Stretching - ScottPlot 4.1 Cookbook"
Description: "By default image dimensions are in pixel units so they are not stretched as axes are manipulated. However, users have the option to define image dimensions in axis units. In this case, corners of images will remain fixed on the coordinate system and will get stretched as axes are stretched."
Date: 2023-12-13
Version: ScottPlot 4.1.69
URL: /cookbook/4.1/recipes/image_stretching/
BreadcrumbNames: ["ScottPlot 4.1 Cookbook", "Image", "Image Stretching"]
BreadcrumbUrls: ["/cookbook/4.1/", "/cookbook/4.1/category/plottable-image", "/cookbook/4.1/recipes/image_stretching/"]
SearchUrl: "/cookbook/4.1/search/"
OgImage: "/cookbook/4.1/images/image_stretching.png"
---

<h2><a id='image-stretching' href='/cookbook/4.1/recipes/image_stretching/'>Image Stretching</a></h2>

By default image dimensions are in pixel units so they are not stretched as axes are manipulated. However, users have the option to define image dimensions in axis units. In this case, corners of images will remain fixed on the coordinate system and will get stretched as axes are stretched.

```cs
var plt = new ScottPlot.Plot(600, 400);

// display some sample data
plt.AddSignal(DataGen.Sin(51));
plt.AddSignal(DataGen.Cos(51));

Bitmap monaLisa = DataGen.SampleImage();

var img = plt.AddImage(monaLisa, 10, .5);
img.HeightInAxisUnits = 1;
img.WidthInAxisUnits = 30;

// 4 corners of the image remain fixed in coordinate space
plt.AddPoint(10, .5, color: Color.Magenta, size: 20);
plt.AddPoint(40, .5, color: Color.Green, size: 20);
plt.AddPoint(10, -.5, color: Color.Green, size: 20);
plt.AddPoint(40, -.5, color: Color.Green, size: 20);

plt.SaveFig("image_stretching.png");
```

<img src='../../images/image_stretching.png' class='d-block mx-auto my-5' />


