---
Title: "Rectangle - ScottPlot 4.1 Cookbook"
Description: "Rectangles can be added to plots."
Date: 12/11/2023 8:04:06 PM
Version: ScottPlot 4.1.69
URL: /cookbook/4.1/recipes/misc_addrectangle/
BreadcrumbNames: ["ScottPlot 4.1 Cookbook", "Miscellaneous", "Rectangle"]
BreadcrumbUrls: ["/cookbook/4.1/", "/cookbook/4.1/category/misc", "/cookbook/4.1/recipes/misc_addrectangle/"]
SearchUrl: "/cookbook/4.1/search/"
OgImage: "/cookbook/4.1/images/misc_addrectangle.png"
---

<h2><a href='/cookbook/4.1/recipes/misc_addrectangle/'>Rectangle</a></h2>

Rectangles can be added to plots.

```cs
var plt = new ScottPlot.Plot(600, 400);

plt.AddSignal(DataGen.Sin(51));
plt.AddSignal(DataGen.Cos(51));

// add a rectangle to the plot
plt.AddRectangle(xMin: 5, xMax: 15, yMin: .1, yMax: .7);

// customize its appearance
var rp = plt.AddRectangle(xMin: 20, xMax: 30, yMin: -.5, yMax: .5);
rp.BorderColor = Color.Blue;
rp.BorderLineWidth = 3;
rp.BorderLineStyle = LineStyle.Dot;
rp.Color = Color.FromArgb(100, Color.Yellow);

plt.SaveFig("misc_addRectangle.png");
```

<img src='../../images/misc_addrectangle.png' class='d-block mx-auto my-5' />


