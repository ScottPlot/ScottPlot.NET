---
Title: "Clipped value range - ScottPlot 4.1 Cookbook"
Description: "If data values extend beyond the min/max range displayed by a colorbar you can indicate the colormap is clipping the data values and inequality symbols will be displayed in the tick labeles at the edge of the colorbar."
Date: 2023-12-28
Version: ScottPlot 4.1.70
URL: /cookbook/4.1/recipes/colorbar_clip/
BreadcrumbNames: ["ScottPlot 4.1 Cookbook", "Colorbar", "Clipped value range"]
BreadcrumbUrls: ["/cookbook/4.1/", "/cookbook/4.1/category/plottable-colorbar", "/cookbook/4.1/recipes/colorbar_clip/"]
SearchUrl: "/cookbook/4.1/search/"
OgImage: "/cookbook/4.1/images/colorbar_clip.png"
---

<h2><a id='clipped-value-range' href='/cookbook/4.1/recipes/colorbar_clip/'>Clipped value range</a></h2>

If data values extend beyond the min/max range displayed by a colorbar you can indicate the colormap is clipping the data values and inequality symbols will be displayed in the tick labeles at the edge of the colorbar.

```cs
var plt = new ScottPlot.Plot(600, 400);

var cb = plt.AddColorbar(Drawing.Colormap.Turbo);
cb.MinValue = -10;
cb.MaxValue = 10;
cb.MinIsClipped = true;
cb.MaxIsClipped = true;

// direct attention to the colorbar
var text = plt.AddText("Colorbar", 5, 0, 24, Color.Red);
text.Alignment = Alignment.MiddleRight;
plt.AddArrow(7, 0, 5, 0, color: Color.Red);
plt.SetAxisLimits(-10, 10, -10, 10);

plt.SaveFig("colorbar_clip.png");
```

<img src='../../images/colorbar_clip.png' class='d-block mx-auto my-5' />


