---
Title: "Data Background Image - ScottPlot 4.1 Cookbook"
Description: "A backgorund image can be drawn behind the data area. Users to do this may want to make grid lines semitransparent."
Date: 2023-12-28
Version: ScottPlot 4.1.70
URL: /cookbook/4.1/recipes/misc_background_image_data/
BreadcrumbNames: ["ScottPlot 4.1 Cookbook", "Style", "Data Background Image"]
BreadcrumbUrls: ["/cookbook/4.1/", "/cookbook/4.1/category/style", "/cookbook/4.1/recipes/misc_background_image_data/"]
SearchUrl: "/cookbook/4.1/search/"
OgImage: "/cookbook/4.1/images/misc_background_image_data.png"
---

<h2><a id='data-background-image' href='/cookbook/4.1/recipes/misc_background_image_data/'>Data Background Image</a></h2>

A backgorund image can be drawn behind the data area. Users to do this may want to make grid lines semitransparent.

```cs
var plt = new ScottPlot.Plot(600, 400);

plt.AddSignal(DataGen.Sin(51), 1, Color.Yellow);
plt.AddSignal(DataGen.Cos(51), 1, Color.Magenta);

Bitmap monaLisaBmp = ScottPlot.DataGen.SampleImage();

plt.Style(
    grid: Color.FromArgb(50, Color.White),
    dataBackgroundImage: monaLisaBmp);

plt.SaveFig("misc_background_image_data.png");
```

<img src='../../images/misc_background_image_data.png' class='d-block mx-auto my-5' />


