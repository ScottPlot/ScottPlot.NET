---
Title: "Color Range - ScottPlot 4.1 Cookbook"
Description: "You can restrict a colorbar to only show a small range of a colormap. In this example we only use the middle of a rainbow colormap."
Date: 12/11/2023 8:13:10 PM
Version: ScottPlot 4.1.69
URL: /cookbook/4.1/recipes/colorbar_range/
BreadcrumbNames: ["ScottPlot 4.1 Cookbook", "Colorbar", "Color Range"]
BreadcrumbUrls: ["/cookbook/4.1/", "/cookbook/4.1/category/plottable-colorbar", "/cookbook/4.1/recipes/colorbar_range/"]
SearchUrl: "/cookbook/4.1/search/"
OgImage: "/cookbook/4.1/images/colorbar_range.png"
---

<h2><a id='color-range' href='/cookbook/4.1/recipes/colorbar_range/'>Color Range</a></h2>

You can restrict a colorbar to only show a small range of a colormap. In this example we only use the middle of a rainbow colormap.

```cs
var plt = new ScottPlot.Plot(600, 400);

var cb = plt.AddColorbar(Drawing.Colormap.Turbo);
cb.MinValue = -10;
cb.MaxValue = 10;
cb.MinColor = .25;
cb.MaxColor = .75;

// direct attention to the colorbar
var text = plt.AddText("Colorbar", 5, 0, 24, Color.Red);
text.Alignment = Alignment.MiddleRight;
plt.AddArrow(7, 0, 5, 0, color: Color.Red);
plt.SetAxisLimits(-10, 10, -10, 10);

plt.SaveFig("colorbar_Range.png");
```

<img src='../../images/colorbar_range.png' class='d-block mx-auto my-5' />


