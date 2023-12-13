---
Title: "Figure Background Image - ScottPlot 4.1 Cookbook"
Description: "A backgorund image can be drawn behind the entire figure. If you do this you likely want to make your data background transparent."
Date: 2023-12-13
Version: ScottPlot 4.1.69
URL: /cookbook/4.1/recipes/misc_background_image_figure/
BreadcrumbNames: ["ScottPlot 4.1 Cookbook", "Style", "Figure Background Image"]
BreadcrumbUrls: ["/cookbook/4.1/", "/cookbook/4.1/category/style", "/cookbook/4.1/recipes/misc_background_image_figure/"]
SearchUrl: "/cookbook/4.1/search/"
OgImage: "/cookbook/4.1/images/misc_background_image_figure.png"
---

<h2><a id='figure-background-image' href='/cookbook/4.1/recipes/misc_background_image_figure/'>Figure Background Image</a></h2>

A backgorund image can be drawn behind the entire figure. If you do this you likely want to make your data background transparent.

```cs
var plt = new ScottPlot.Plot(600, 400);

plt.AddSignal(DataGen.Sin(51), 1, Color.Yellow);
plt.AddSignal(DataGen.Cos(51), 1, Color.Magenta);

Bitmap monaLisaBmp = ScottPlot.DataGen.SampleImage();

plt.Style(
    grid: Color.FromArgb(50, Color.White),
    tick: Color.White,
    dataBackground: Color.FromArgb(50, Color.White),
    figureBackgroundImage: monaLisaBmp);

plt.SaveFig("misc_background_image_figure.png");
```

<img src='../../images/misc_background_image_figure.png' class='d-block mx-auto my-5' />


