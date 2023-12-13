---
Title: "Heatmap Rotation - ScottPlot 4.1 Cookbook"
Description: "A Heatmap can be rotated clockwise around around a user-specified center of rotation. Locking axis scales to enforce square pixels is recommended. Rotation occurs after any flipping operations."
Date: 2023-12-13
Version: ScottPlot 4.1.69
URL: /cookbook/4.1/recipes/heatmap_rotation/
BreadcrumbNames: ["ScottPlot 4.1 Cookbook", "Heatmap", "Heatmap Rotation"]
BreadcrumbUrls: ["/cookbook/4.1/", "/cookbook/4.1/category/plottable-heatmap", "/cookbook/4.1/recipes/heatmap_rotation/"]
SearchUrl: "/cookbook/4.1/search/"
OgImage: "/cookbook/4.1/images/heatmap_rotation.png"
---

<h2><a id='heatmap-rotation' href='/cookbook/4.1/recipes/heatmap_rotation/'>Heatmap Rotation</a></h2>

A Heatmap can be rotated clockwise around around a user-specified center of rotation. Locking axis scales to enforce square pixels is recommended. Rotation occurs after any flipping operations.

```cs
var plt = new ScottPlot.Plot(600, 400);

double[,] imageData = DataGen.SampleImageData();

for (int i = 0; i < 5; i++)
{
    var hm = plt.AddHeatmap(imageData, lockScales: true);
    hm.XMin = 0;
    hm.XMax = 1;
    hm.YMin = 0;
    hm.YMax = 1;
    hm.Rotation = i * 10;
}

for (int i = 0; i < 5; i++)
{
    var hm = plt.AddHeatmap(imageData, lockScales: true);
    hm.XMin = 2;
    hm.XMax = 3;
    hm.YMin = 0;
    hm.YMax = 1;

    hm.CenterOfRotation = Alignment.MiddleCenter;

    hm.Rotation = i * 10;
}

plt.SetAxisLimits(-1, 4, -1, 2);

plt.SaveFig("heatmap_rotation.png");
```

<img src='../../images/heatmap_rotation.png' class='d-block mx-auto my-5' />


