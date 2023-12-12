---
Title: "Image Rotation - ScottPlot 4.1 Cookbook"
Description: "Images can be rotated around the position defined by their anchor."
Date: 12/11/2023 8:04:06 PM
Version: ScottPlot 4.1.69
URL: /cookbook/4.1/recipes/image_rotation/
BreadcrumbNames: ["ScottPlot 4.1 Cookbook", "Image", "Image Rotation"]
BreadcrumbUrls: ["/cookbook/4.1/", "/cookbook/4.1/category/plottable-image", "/cookbook/4.1/recipes/image_rotation/"]
SearchUrl: "/cookbook/4.1/search/"
OgImage: "/cookbook/4.1/images/image_rotation.png"
---

<h2><a href='/cookbook/4.1/recipes/image_rotation/'>Image Rotation</a></h2>

Images can be rotated around the position defined by their anchor.

```cs
var plt = new ScottPlot.Plot(600, 400);

plt.AddSignal(DataGen.Sin(51));
plt.AddSignal(DataGen.Cos(51));

Bitmap monaLisa = DataGen.SampleImage();

plt.AddImage(monaLisa, 10, .5, rotation: 30);
plt.AddPoint(10, .5, color: Color.Magenta, size: 20);

plt.AddImage(monaLisa, 25, 0, rotation: -30);
plt.AddPoint(25, 0, color: Color.Magenta, size: 20);

plt.AddImage(monaLisa, 45, 0, rotation: 30, anchor: Alignment.MiddleCenter);
plt.AddPoint(45, 0, color: Color.Magenta, size: 20);

plt.SaveFig("image_rotation.png");
```

<img src='../../images/image_rotation.png' class='d-block mx-auto my-5' />


