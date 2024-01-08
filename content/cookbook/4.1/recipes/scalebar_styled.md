---
Title: "Styled Scale Bar - ScottPlot 4.1 Cookbook"
Description: "An L-shaped scalebar can be added in the corner of any plot. Set the vertical or horizontal sizer to zero and the scale bar will only span one dimension."
Date: 2024-01-07
Version: ScottPlot 4.1.70
URL: /cookbook/4.1/recipes/scalebar_styled/
BreadcrumbNames: ["ScottPlot 4.1 Cookbook", "Scale Bar", "Styled Scale Bar"]
BreadcrumbUrls: ["/cookbook/4.1/", "/cookbook/4.1/category/plottable-scale-bar", "/cookbook/4.1/recipes/scalebar_styled/"]
SearchUrl: "/cookbook/4.1/search/"
OgImage: "/cookbook/4.1/images/scalebar_styled.png"
---

<h2><a id='styled-scale-bar' href='/cookbook/4.1/recipes/scalebar_styled/'>Styled Scale Bar</a></h2>

An L-shaped scalebar can be added in the corner of any plot. Set the vertical or horizontal sizer to zero and the scale bar will only span one dimension.

```cs
ScottPlot.Version.ShouldBe(4, 1, 70);
var plt = new ScottPlot.Plot(600, 400);

// plot sample data
plt.AddSignal(DataGen.Sin(51));
plt.AddSignal(DataGen.Cos(51));

// remove traditional scale indicators
plt.Grid(enable: false);
plt.Frameless();

// add an L-shaped scalebar
plt.AddScaleBar(5, .25, "100 ms", "250 mV");

// add style
plt.Style(Style.Black);

plt.SaveFig("scalebar_styled.png");
```

<img src='../../images/scalebar_styled.png' class='d-block mx-auto my-5' />


