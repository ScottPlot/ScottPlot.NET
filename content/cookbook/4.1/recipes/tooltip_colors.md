---
Title: "Tooltip Colors - ScottPlot 4.1 Cookbook"
Description: "Tooltips border and fill styles can be customized"
Date: 12/11/2023 8:13:10 PM
Version: ScottPlot 4.1.69
URL: /cookbook/4.1/recipes/tooltip_colors/
BreadcrumbNames: ["ScottPlot 4.1 Cookbook", "Tooltip", "Tooltip Colors"]
BreadcrumbUrls: ["/cookbook/4.1/", "/cookbook/4.1/category/plottable-tooltip", "/cookbook/4.1/recipes/tooltip_colors/"]
SearchUrl: "/cookbook/4.1/search/"
OgImage: "/cookbook/4.1/images/tooltip_colors.png"
---

<h2><a id='tooltip-colors' href='/cookbook/4.1/recipes/tooltip_colors/'>Tooltip Colors</a></h2>

Tooltips border and fill styles can be customized

```cs
var plt = new ScottPlot.Plot(600, 400);

double[] ys = DataGen.Sin(50);
plt.AddSignal(ys);

var tt = plt.AddTooltip("This point has\na negative slope", 25, ys[25]);
tt.Font.Size = 24;
tt.Font.Color = System.Drawing.Color.White;
tt.FillColor = System.Drawing.Color.Blue;
tt.BorderWidth = 5;
tt.BorderColor = System.Drawing.Color.Navy;
tt.ArrowSize = 15;

plt.SaveFig("tooltip_colors.png");
```

<img src='../../images/tooltip_colors.png' class='d-block mx-auto my-5' />


